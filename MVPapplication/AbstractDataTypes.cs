using System;
using System.Data;
using System.Collections.Generic;

namespace MVPapplication
{
    class Script
    {
        List<Question> questions = new List<Question>();

        public List<Question> GetQuestions() // аналогично свойству
        {
            return questions;
        }

        public void AddQuestion(Question question)
        {
            this.questions.Add(question);
        }
    }

    class Question
    {
        public int QuestionNumber { get; private set; }
        public string QuestionText { get; private set; }

        DataTable answersTable; // таблица для ответов и номеров следующих вопросов
        DataRow answerRow; // строка для ответа и номера следующего вопроса       

        public Question(int questionNumber, string questionText)
        {
            this.QuestionNumber = questionNumber;
            this.QuestionText = questionText;
            
            this.answersTable = new DataTable();
            this.answersTable.Columns.AddRange(new[] { new DataColumn("AnswerText"), new DataColumn("NextQuestion", typeof(int)) });
        }

        public Dictionary<string, int> GetAnswers()
        {
            Dictionary<string, int> answers = new Dictionary<string, int>();

            foreach (DataRow answerRow in this.answersTable.Rows)
            {
                answers.Add(answerRow["AnswerText"].ToString(), Convert.ToInt32(answerRow["NextQuestion"]));
            }

            return answers;
        }
                        
        public void AddAnswer(string answerText, int nextQuestion)
        {
            this.answerRow = this.answersTable.NewRow();

            this.answerRow["AnswerText"] = answerText;
            this.answerRow["NextQuestion"] = nextQuestion;

            this.answersTable.Rows.Add(answerRow);
        }
    }
}