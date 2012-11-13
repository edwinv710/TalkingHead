using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using AIMLbot;

namespace TKTest
{
    public partial class Form2 : Form
    {
         private Bot myBot;
        private User myUser;
        private Request lastRequest = null;
        private Result lastResult = null;

        public Form2()
        {
            InitializeComponent();
            this.inputTextBox.Focus();
            myBot = new Bot();
            myBot.loadSettings();
            myUser = new User("DefaultUser", this.myBot);
            myBot.WrittenToLog += new Bot.LogMessageDelegate(myBot_WrittenToLog);

            try
            {
                AIMLbot.Utils.AIMLLoader loader = new AIMLbot.Utils.AIMLLoader(this.myBot);
                this.myBot.isAcceptingUserInput = false;
                loader.loadAIML(this.myBot.PathToAIML);
                this.myBot.isAcceptingUserInput = true;
            }
            catch (Exception ex)
            {
                this.outputRichTextBox.AppendText(ex.Message + Environment.NewLine);
            }
        }

        void myBot_WrittenToLog()
        {
            this.outputRichTextBox.Text += this.myBot.LastLogMessage + Environment.NewLine + Environment.NewLine;
            this.outputRichTextBox.ScrollToCaret();
        }

        private void sendButton_Click(object sender, EventArgs e)
        {
            this.processInputFromUser();
        }

        private void processInputFromUser()
        {
            if (this.myBot.isAcceptingUserInput)
            {
                string rawInput = this.inputTextBox.Text;
                this.inputTextBox.Text = string.Empty;
                this.outputRichTextBox.AppendText("You: " + rawInput + Environment.NewLine);
                Request myRequest = new Request(rawInput, this.myUser, this.myBot);
                Result myResult = this.myBot.Chat(myRequest);
                this.lastRequest = myRequest;
                this.lastResult = myResult;
                this.outputRichTextBox.AppendText("Bot: " + myResult.Output + Environment.NewLine + Environment.NewLine);
            }
            else
            {
                this.inputTextBox.Text = string.Empty;
                this.outputRichTextBox.AppendText("Bot not accepting user input." + Environment.NewLine);
            }
        }

        private void outputRichTextBox_TextChanged(object sender, EventArgs e)
        {
            this.outputRichTextBox.ScrollToCaret();
        }

        private void inputTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
                this.processInputFromUser();
        }
    }
}
