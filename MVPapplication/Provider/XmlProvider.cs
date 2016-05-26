using System;
using System.Windows.Forms;
using System.Xml.Linq;

namespace MVPapplication
{
    class XmlProvider : IProvider
    {
        public Script Load()
        {
            Script script = new Script(); // АТД для сценария
            Question question = null; // АТД для вопроса

            OpenFileDialog openFileDialog = new OpenFileDialog() { Filter = "eXtensible Markup Language files (*.xml)|*.xml" };
            openFileDialog.ShowDialog();
            XDocument xDocument = XDocument.Load(openFileDialog.FileName);

            foreach (XElement questionElement in xDocument.Element("root").Elements("question"))
            {
                question = new Question(int.Parse(questionElement.Attribute("number").Value), questionElement.Element("text").Value);

                foreach (XElement answer in questionElement.Element("answers").Elements("answer"))
                {
                    question.AddAnswer(answer.Value, int.Parse(answer.Attribute("nextQuestion").Value));
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