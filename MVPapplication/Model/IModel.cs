using System;

namespace MVPapplication
{
    interface IModel
    {
        Question GetNextQuestion(string textQuestion, string textAnswer, Script script);
    }
}