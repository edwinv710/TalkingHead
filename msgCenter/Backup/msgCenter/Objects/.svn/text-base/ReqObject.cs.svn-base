using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Runtime.Serialization.Formatters.Binary;
using System.Runtime.Serialization;
using System.Security.Permissions;
using System.IO;

namespace msgCenter.Objects
{
    [Serializable] 
    public class ReqObject
    {
        public static int REQ_TYPE_NEWMSG = 0;
        public static int REQ_TYPE_CONTACTS = 1;
        //public static int REQ_TYPE_TEXT = 1;
        //public static int REQ_TYPE_CRITICAL = 2;

        private int reqType;

        public int ReqType {
            get { return reqType; }
            set { reqType = value; }
        }

        private string reqTime;

        public DateTime ReqTime {
            get { return DateTime.Parse(reqTime); }
            set { reqTime = value.ToString(); }
        }


        private object reqContent;

        public object ReqContent {
            get { return reqContent; }
            set { reqContent = value; }
        }

        public void SentReq()
        {
            Operators.NetOperator netOpt = new msgCenter.Operators.NetOperator();
            netOpt.Content = Operators.SerializeOperator.Serialize(this);
            netOpt.Send();
        }

        public byte[] GetResponse() {
            Operators.NetOperator netOpt = new msgCenter.Operators.NetOperator();
            netOpt.Content = Operators.SerializeOperator.Serialize(this);
            return netOpt.GetResponse();
        }
    }
}
