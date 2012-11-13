using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Google.Voice;

namespace msgCenter.Operators
{
    class GoogleVoiceOperator
    {
        public static GoogleVoiceClient GoogleVoice=new GoogleVoiceClient();
        private string email = "nteamtalkinghead@gmail.com";
        private string password = "temp123456";
        private string toPhoneNum= "7168030343";
        private string forwardingNum = "17165741848";

        public string Email {
            get { return email; }
            set { email = value; }
        }

        public string Password {
            get { return password; }
            set { password = value; }
        }

        public string ToPhoneNum
        {
            get { return toPhoneNum; }
            set { toPhoneNum = value; }
        }

        public string ForwardingNum
        {
            get { return forwardingNum; }
            set { forwardingNum = value; }
        }

        public GoogleVoiceOperator(string _email, string _password, string _toPhoneNum,string _forwardingNum) {
            Email = _email;
            Password = _password;
            ToPhoneNum = _toPhoneNum;
            ForwardingNum = _forwardingNum;
            
            GoogleVoiceOperator.GoogleVoice.Login(email, password);
        }

        public void PlaceCall() {
            if (GoogleVoiceOperator.GoogleVoice.LoggedIn)
            {
                Cache.SetVariable("Email", CryptorEngine.Encrypt(email, true));
                Cache.SetVariable("Password", CryptorEngine.Encrypt(password, true));
                GoogleVoiceOperator.GoogleVoice.InitiateCall(toPhoneNum, forwardingNum);
            }
        }


    }
}
