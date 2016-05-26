using System;
using System.Data;
using System.Data.OleDb;
using System.Windows.Forms;

namespace MVPapplication
{
    class OleDbProvider : IProvider
    {
        public Script Load()
        {
            Script script = new Script(); // АТД для сценария
            Question question = null; // АТД для вопроса

            OpenFileDialog openFileDialog = new OpenFileDialog() { Filter = "Microsoft Excel 97-2003 files (*.xls)|*.xls" };
            openFileDialog.ShowDialog();

            var conStr = new OleDbConnectionStringBuilder();
            conStr["Provider"] = "Microsoft.Jet.OLEDB.4.0";
            conStr["Data Source"] = openFileDialog.FileName;
            conStr["Extended Properties"] = "Excel 8.0";

            DataSet dataSet = new DataSet(); // для хранения двух таблиц и задания отношения между ними

            DataTable questionsTable = new DataTable("Questions");
            using (OleDbDataAdapter adapter = new OleDbDataAdapter("SELECT * FROM [Questions$]", conStr.ConnectionString))
                adapter.Fill(questionsTable);

            DataTable answersTable = new DataTable("Answers");
            using (OleDbDataAdapter adapter = new OleDbDataAdapter("SELECT * FROM [Answers$]", conStr.ConnectionString))
                adapter.Fill(answersTable);

            dataSet.Tables.AddRange(new DataTable[] { questionsTable, answersTable });
            dataSet.Relations.Add("Questions_Answers", dataSet.Tables["Questions"].Columns["QuestionNumber"], dataSet.Tables["Answers"].Columns["QuestionNumber_REF"], true);
            dataSet.Tables["Questions"].PrimaryKey = new DataColumn[] { dataSet.Tables["Questions"].Columns["QuestionNumber"] };

            foreach (DataRow questionRow in dataSet.Tables["Questions"].Rows)
            {
                question = new Question(Convert.ToInt32(questionRow["QuestionNumber"]), questionRow["QuestionText"].ToString());

                foreach (DataRow answerRow in questionRow.GetChildRows("Questions_Answers"))
                {
                    question.AddAnswer(answerRow["AnswerText"].ToString(), Convert.ToInt32(answerRow["NextQuestion"]));
                }

                script.AddQuestion(question);
            }

            return script;
        }

        public void Save(object @object)
        {
            throw new Exception("There is no implementation");
        }
    }
}