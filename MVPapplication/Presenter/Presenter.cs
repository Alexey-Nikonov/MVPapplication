using System;
using System.Data;
using System.Windows.Forms;
using System.Collections;

namespace MVPapplication
{
    partial class Presenter
    {
        // Model-View-Presenter
        View view = null; // view
        Model model = null; // модель с бизнес-логикой

        ArrayList providers = new ArrayList() {new OleDbProvider(), new TxtProvider(), new XmlProvider()}; // список провайдеров
        IProvider provider = null; // интерфейс для провайдеров

        // Abstract data types
        Script script = null; // АТД для хранения сценария
        Question question = null; // АТД для хранения вопроса

        public Presenter(View view)
        {
            this.view = view;
            this.model = new Model();
            SubscribeHandlers();
        }
    }

    // в этом partial-классе происходит подписка и обработка событий view
    partial class Presenter
    {
        void SubscribeHandlers()
        {
            this.view.sendButtonPressing += view_sendButtonPressing;

            this.view.xmlMenuItemPressing += view_openScriptPressing<XmlProvider>;

            this.view.oleDbMenuItemPressing += view_openScriptPressing<OleDbProvider>;

            this.view.txtMenuItemPressing += view_saveScriptPressing<TxtProvider>;

            this.view.exitMenuItemPressing += view_exitMenuItemPressing;
        }

        void view_sendButtonPressing(object sender, EventArgs e)
        {
            if (this.IsCorrectAnswer())
            {
                this.RefreshView(this.view.QuestionBox.Text, this.view.AnswerBox.Text);
            }
        }

        void view_openScriptPressing<ProviderType>(object sender, EventArgs e)
        {
            foreach (var provider in this.providers)
            {
                if (provider.GetType() == typeof(ProviderType))
                {
                     this.provider = provider as IProvider;
                }
            }

            this.script = this.provider.Load();
            this.RefreshView("Завершить работу?", "Нет"); // заглушка для первого запуска
        }

        void view_saveScriptPressing<ProviderType>(object sender, EventArgs e)
        {
            foreach (var provider in this.providers)
            {
                if (provider.GetType() == typeof(ProviderType))
                {
                    this.provider = provider as IProvider;
                }
            }
            
            this.provider.Save(this.view.DialogueList.Items);
        }

        void view_exitMenuItemPressing(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }

    // в этом partial-классе реализуются вспомогательные методы view
    partial class Presenter
    {
        void ClearView()
        {
            this.view.QuestionBox.Clear();
            this.view.AnswerBox.Clear();
            this.view.AnswersList.Items.Clear();
        }

        void RefreshView(string textQuestion, string textAnswer)
        {
            this.question = this.model.GetNextQuestion(textQuestion, textAnswer, this.script); // получаем следующий вопрос

            this.ClearView(); // очищаем некоторые поля view перед обновлением

            this.view.QuestionBox.Text = this.question.QuestionText; // обновляем поле вопроса

            this.view.DialogueList.Items.Add(this.question.QuestionText); // добавляем вопрос в поле диалога

            foreach (var answer in this.question.GetAnswers()) // обновляем поле ответов
            {
                this.view.AnswersList.Items.Add(answer.Key);
            }
        }

        bool IsCorrectAnswer()
        {
            if (this.view.AnswersList.Items.Contains(this.view.AnswerBox.Text))
            {
                this.view.DialogueList.Items.Add(this.view.AnswerBox.Text); // добавляем ответ в поле диалога
                return true;
            }
            else
            {
                this.view.ErrorsList.Items.Add("Wrong answer: " + this.view.AnswerBox.Text); // добавляем ответ в поле ошибок
                return false;
            }
        }
    }
}