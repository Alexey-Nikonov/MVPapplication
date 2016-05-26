namespace MVPapplication
{
    partial class View
    {
        /// <summary>
        /// Требуется переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Обязательный метод для поддержки конструктора - не изменяйте
        /// содержимое данного метода при помощи редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.questionBox = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.answersList = new System.Windows.Forms.ListBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.sendButton = new System.Windows.Forms.Button();
            this.answerBox = new System.Windows.Forms.TextBox();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.dialogueList = new System.Windows.Forms.ListBox();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.errorsList = new System.Windows.Forms.ListBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.openToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.xmlScriptToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.oleDbScriptToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.txtDialogueToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.groupBox6.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.questionBox);
            this.groupBox1.Location = new System.Drawing.Point(12, 27);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(456, 50);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Question text:";
            // 
            // questionBox
            // 
            this.questionBox.Location = new System.Drawing.Point(6, 19);
            this.questionBox.Name = "questionBox";
            this.questionBox.Size = new System.Drawing.Size(444, 20);
            this.questionBox.TabIndex = 1;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.answersList);
            this.groupBox2.Location = new System.Drawing.Point(12, 83);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(243, 176);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "List of possible answers:";
            // 
            // answersList
            // 
            this.answersList.FormattingEnabled = true;
            this.answersList.Location = new System.Drawing.Point(6, 19);
            this.answersList.Name = "answersList";
            this.answersList.Size = new System.Drawing.Size(231, 147);
            this.answersList.TabIndex = 2;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.sendButton);
            this.groupBox3.Controls.Add(this.answerBox);
            this.groupBox3.Location = new System.Drawing.Point(261, 83);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(207, 80);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "For input of the text:";
            // 
            // sendButton
            // 
            this.sendButton.Location = new System.Drawing.Point(126, 45);
            this.sendButton.Name = "sendButton";
            this.sendButton.Size = new System.Drawing.Size(75, 23);
            this.sendButton.TabIndex = 1;
            this.sendButton.Text = "Send";
            this.sendButton.UseVisualStyleBackColor = true;
            this.sendButton.Click += new System.EventHandler(this.OnSendButtonPressing);
            // 
            // answerBox
            // 
            this.answerBox.Location = new System.Drawing.Point(6, 19);
            this.answerBox.Name = "answerBox";
            this.answerBox.Size = new System.Drawing.Size(195, 20);
            this.answerBox.TabIndex = 0;
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.dialogueList);
            this.groupBox5.Location = new System.Drawing.Point(12, 265);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(456, 129);
            this.groupBox5.TabIndex = 4;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Dialogue process:";
            // 
            // dialogueList
            // 
            this.dialogueList.FormattingEnabled = true;
            this.dialogueList.Location = new System.Drawing.Point(6, 19);
            this.dialogueList.Name = "dialogueList";
            this.dialogueList.Size = new System.Drawing.Size(444, 95);
            this.dialogueList.TabIndex = 0;
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.errorsList);
            this.groupBox6.Location = new System.Drawing.Point(261, 169);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(207, 90);
            this.groupBox6.TabIndex = 5;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "Errors:";
            // 
            // errorsList
            // 
            this.errorsList.FormattingEnabled = true;
            this.errorsList.Location = new System.Drawing.Point(6, 19);
            this.errorsList.Name = "errorsList";
            this.errorsList.Size = new System.Drawing.Size(195, 56);
            this.errorsList.TabIndex = 0;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.openToolStripMenuItem,
            this.saveToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(482, 24);
            this.menuStrip1.TabIndex = 6;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // openToolStripMenuItem
            // 
            this.openToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.xmlScriptToolStripMenuItem,
            this.oleDbScriptToolStripMenuItem});
            this.openToolStripMenuItem.Name = "openToolStripMenuItem";
            this.openToolStripMenuItem.Size = new System.Drawing.Size(48, 20);
            this.openToolStripMenuItem.Text = "Open";
            // 
            // xmlScriptToolStripMenuItem
            // 
            this.xmlScriptToolStripMenuItem.Name = "xmlScriptToolStripMenuItem";
            this.xmlScriptToolStripMenuItem.Size = new System.Drawing.Size(178, 22);
            this.xmlScriptToolStripMenuItem.Text = "Script XML (.xml)";
            this.xmlScriptToolStripMenuItem.Click += new System.EventHandler(this.OnXmlMenuItemPressing);
            // 
            // oleDbScriptToolStripMenuItem
            // 
            this.oleDbScriptToolStripMenuItem.Name = "oleDbScriptToolStripMenuItem";
            this.oleDbScriptToolStripMenuItem.Size = new System.Drawing.Size(178, 22);
            this.oleDbScriptToolStripMenuItem.Text = "Script Excel 8.0 (.xls)";
            this.oleDbScriptToolStripMenuItem.Click += new System.EventHandler(this.OnOleDbMenuItemPressing);
            // 
            // saveToolStripMenuItem
            // 
            this.saveToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.txtDialogueToolStripMenuItem});
            this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            this.saveToolStripMenuItem.Size = new System.Drawing.Size(43, 20);
            this.saveToolStripMenuItem.Text = "Save";
            // 
            // txtDialogueToolStripMenuItem
            // 
            this.txtDialogueToolStripMenuItem.Name = "txtDialogueToolStripMenuItem";
            this.txtDialogueToolStripMenuItem.Size = new System.Drawing.Size(167, 22);
            this.txtDialogueToolStripMenuItem.Text = "Dialogue file (.txt)";
            this.txtDialogueToolStripMenuItem.Click += new System.EventHandler(this.OnTxtMenuItemPressing);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.OnExitMenuItemPressing);
            // 
            // View
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(482, 401);
            this.Controls.Add(this.groupBox6);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "View";
            this.Text = "Main window";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            this.groupBox6.ResumeLayout(false);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        // для вывода
        private System.Windows.Forms.TextBox questionBox;
        private System.Windows.Forms.TextBox answerBox;
        private System.Windows.Forms.ListBox answersList;
        private System.Windows.Forms.ListBox dialogueList;
        private System.Windows.Forms.ListBox errorsList;

        public System.Windows.Forms.TextBox QuestionBox
        {
            get { return questionBox; }
            set { questionBox = value; }
        }

        public System.Windows.Forms.TextBox AnswerBox
        {
            get { return answerBox; }
        }

        public System.Windows.Forms.ListBox AnswersList
        {
            set { answersList = value; }
            get { return answersList; }
        }

        public System.Windows.Forms.ListBox DialogueList
        {
            set { dialogueList = value; }
            get { return dialogueList; }
        }

        public System.Windows.Forms.ListBox ErrorsList
        {
            set { errorsList = value; }
            get { return errorsList; }
        }

        // для действий        
        private System.Windows.Forms.ToolStripMenuItem openToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem xmlScriptToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem oleDbScriptToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.Button sendButton;

        // полностью закрытые
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem txtDialogueToolStripMenuItem;
    }
}

