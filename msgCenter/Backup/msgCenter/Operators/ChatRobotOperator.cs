using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using AIMLbot;

namespace msgCenter.Operators
{
    class ChatRobotOperator
    {
        private Bot bot;
        private User user;
        private Request lastRequest = null;
        private Result lastResult = null;


        public ChatRobotOperator(string userName) {
            bot = new Bot();
            bot.loadSettings();
            user = new User(userName, bot);
            //try
            //{
                AIMLbot.Utils.AIMLLoader loader = new AIMLbot.Utils.AIMLLoader(bot);
                bot.isAcceptingUserInput = false;
                loader.loadAIML(bot.PathToAIML);
                bot.isAcceptingUserInput = true;
            //}
            //catch (Exception ex)
            //{
            //    //this.outputRichTextBox.AppendText(ex.Message + Environment.NewLine);
            //}
        }

        public string Chat(string userInput)
        {
            if (bot.isAcceptingUserInput)
            {
                Request newRequest = new Request(userInput, user, bot);
                Result result = bot.Chat(newRequest);
                lastRequest = newRequest;
                lastResult = result;
                return result.Output;
            }
            else {
                return "I don't understand.";
            }
        }

      

    }
}
