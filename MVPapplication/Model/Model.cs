using System;
using System.Data;

namespace MVPapplication
{
    class Model : IModel
    {
        public Question GetNextQuestion(string textQuestion, string textAnswer, Script script)
        {
            foreach (Question question in script.GetQuestions())
            {
                if (question.QuestionText == textQuestion) // если true, то question - текущая вершина графа
                {
                    foreach (var answer in question.GetAnswers())
                    {
                        if (answer.Key == textAnswer)
                        {
                            return script.GetQuestions().Find(x => x.QuestionNumber == answer.Value); // получаем искомую вершину графа
                        }
                    }
                }
            }

            return null; // если вершина не найдена, то возвращаем null
        }
    }
}