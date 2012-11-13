using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Runtime.Serialization.Formatters.Binary;
using System.Runtime.Serialization;
using System.Security.Permissions;
using System.IO;
using System.Collections; 

namespace msgCenter.Objects
{
    [Serializable] 
    public class MsgObject
    {
        public static int MSG_TYPE_TESTRING = 0;
        public static int MSG_TYPE_TEXT = 1;
        public static int MSG_TYPE_CRITICAL = 2;
        
        private DateTime msgTime;
        private int msgType;
        private string fromUID;
        private string toUID;
        private string fromName;
        private object msgContent;

        


        public string MsgTime {
            get { return msgTime.ToString(); }
            set { msgTime = DateTime.Parse(value); }
        }

        public int MsgType {
            get { return msgType; }
            set { msgType = value; }
        }

        public string FromUID
        {
            get { return fromUID; }
            set { fromUID = value; }
        }

        public string ToUID
        {
            get { return toUID; }
            set { toUID = value; }
        }

        public string FromName
        {
            get { return fromName; }
            set { fromName = value; }
        }
        public object MsgContent
        {
            get { return msgContent; }
            set { msgContent = value; }
        }

        public MsgObject() { }

        public MsgObject(string _msgTime, int _msgType, string _fromUID, string _toUID, object _msgContent)
        {
            MsgTime = _msgTime;
            MsgType = _msgType;
            FromUID = _fromUID;
            ToUID = _toUID;
            MsgContent = _msgContent;
        }

        public void SentMsg() {
            Operators.NetOperator netOpt = new msgCenter.Operators.NetOperator();
            netOpt.Content = serialize();
            netOpt.Send();
        }

        private byte[] serialize() {
            MemoryStream ms = new MemoryStream();
            BinaryFormatter formatter = new BinaryFormatter();
            formatter.Serialize(ms, this);
            byte[] bytes = ms.ToArray();
            ms.Position = 0;
            return bytes;
        }

        public void saveTextMessage() {
            string sqltext = "insert into tb_Msg (FromUID,ToUID,Content,[Time],[Read]) values ("+FromUID+","+ToUID+",'"+(string)MsgContent+"','" +MsgTime+ "','0')";
            Operators.DBOperator.Acc_ExcuteNon(sqltext);
        }

    }
}
