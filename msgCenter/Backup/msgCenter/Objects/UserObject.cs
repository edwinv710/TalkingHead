using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Runtime.Serialization.Formatters.Binary;
using System.Runtime.Serialization;
using System.Security.Permissions;
using System.IO;
namespace msgCenter.Objects
{
    [Serializable] 
    public class UserObject
    {
        public static int UserType_Doctor = 1;
        public static int UserType_Patient = 2;


        private string userID;
        private string firstName;
        private string lastName;
        private string midName;
        private string suffx;
        private string state;
        private int userType;
        private string gender;
        private float height;
        private float weight;
        private string birthday;
        private string address;
        private string homePhone;
        private string otherInf;


        public string UserID {
            get { return userID; }
            set { userID = value; }
        }

        public string FirstName
        {
            get { return firstName ; }
              set { firstName = value; }
        }

         public string LastName
        {
            get { return lastName ; }
              set { lastName = value; }
        }

        public string MidName
        {
            get { return midName ; }
              set { midName = value; }
        }

        public string Suffx
        {
            get { return suffx ; }
              set { suffx = value; }
        }

        public string Gender
        {
            get { return gender; }
            set { gender = value; }
        }

        public float Height
        {
            get { return height; }
            set { height = value; }
        }

        public float Weight
        {
            get { return weight; }
            set { weight = value; }
        }

        public string Birthday
        {
            get { return birthday; }
            set { birthday = value; }
        }

        public string HomePhone
        {
            get { return homePhone; }
            set { homePhone = value; }
        }

        public string Address
        {
            get { return address; }
            set { address =value; }
        }

        public string OtherInf
        {
            get { return otherInf; }
            set { otherInf = value; }
        }

        public bool State
        {
            get
            {
                if (state.Equals("1"))
                {
                    return true;
                }
                else {
                    return false;
                }
            }
            set
            {
                if (value)
                {
                    state = "1";
                }
                else
                {
                    state = "0";
                }
            }
        }

        public string UserType
        {
            get { return userType.ToString() ; }
              set { userType = int.Parse(value); }
        }


        public static UserObject GetLocalUser() {
            string sqltext = "select * from tb_User;";
            DataSet ds = Operators.DBOperator.Acc_GetDataSet(sqltext);
            UserObject c = new UserObject();
            c.UserID = ds.Tables[0].Rows[0]["ID"].ToString();
            c.firstName = ds.Tables[0].Rows[0]["firstName"].ToString();
            c.midName = ds.Tables[0].Rows[0]["midName"].ToString();
            c.lastName = ds.Tables[0].Rows[0]["lastName"].ToString();
            c.suffx = ds.Tables[0].Rows[0]["suffx"].ToString();
            c.gender = ds.Tables[0].Rows[0]["gender"].ToString();
            c.address = ds.Tables[0].Rows[0]["address"].ToString();
            c.height = float.Parse(ds.Tables[0].Rows[0]["height"].ToString());
            c.weight = float.Parse(ds.Tables[0].Rows[0]["weight"].ToString());
            c.homePhone = ds.Tables[0].Rows[0]["homePhone"].ToString();
            c.otherInf = ds.Tables[0].Rows[0]["otherInf"].ToString();
            c.birthday = ds.Tables[0].Rows[0]["birthday"].ToString();
            c.state = ds.Tables[0].Rows[0]["State"].ToString();
            c.userType = int.Parse(ds.Tables[0].Rows[0]["UserType"].ToString());
            return c;
        }

        public List<UserObject> contacts;

        public bool update() {
            string sqltext = "update tb_User set firstName='"+firstName+"',midName='"+midName+"', lastName='"+lastName
                +"',suffx='"+suffx+"',gender='"+gender+"', birthday='"+birthday+"', height='"+height
                +"',weight='"+weight+"',address='"+address+"',homephone='"+homePhone
                +"',otherInf='"+otherInf+"',State='"+state+"',Type="+userType+" where id="+userID;
            Operators.DBOperator.Acc_ExcuteNon(sqltext);
            return true;
        }

        public bool SyncUserState()
        {
            string sqltext = "update tb_User set State='" + state + "' where id=" + userID;
            Operators.DBOperator.Acc_ExcuteNon(sqltext);
            return true;
        }

        public int CheckUserState()
        {
            string sqltext = "select state from tb_User where id=" + userID;
            DataSet ds = Operators.DBOperator.Acc_GetDataSet(sqltext);
            return int.Parse(ds.Tables[0].Rows[0][0].ToString());
        }

        public void getContacts() {
            contacts = new List<UserObject>();
            string sqltext = "select * from tb_User where ID in (select contactID from tb_Contacts where UID="+userID+")";
            DataSet ds = Operators.DBOperator.Acc_GetDataSet(sqltext);
            for (int i = 0; i < ds.Tables[0].Rows.Count; i++) {
                UserObject c = new UserObject();
                c.UserID = ds.Tables[0].Rows[i]["ID"].ToString();
                c.firstName = ds.Tables[0].Rows[i]["firstName"].ToString();
                c.midName = ds.Tables[0].Rows[i]["midName"].ToString();
                c.lastName = ds.Tables[0].Rows[i]["lastName"].ToString();
                c.suffx = ds.Tables[0].Rows[i]["suffx"].ToString();
                c.gender = ds.Tables[0].Rows[i]["gender"].ToString();
                c.address = ds.Tables[0].Rows[i]["address"].ToString();
                c.height =float.Parse(ds.Tables[0].Rows[i]["height"].ToString());
                c.weight =float.Parse(ds.Tables[0].Rows[i]["weight"].ToString());
                c.homePhone = ds.Tables[0].Rows[i]["homePhone"].ToString();
                c.otherInf = ds.Tables[0].Rows[i]["otherInf"].ToString();
                c.birthday = ds.Tables[0].Rows[i]["birthday"].ToString();
                c.state =ds.Tables[0].Rows[i]["State"].ToString();
                c.userType =int.Parse(ds.Tables[0].Rows[i]["UserType"].ToString());
                contacts.Add(c);
            }
        }

        public byte[] serialize()
        {
            MemoryStream ms = new MemoryStream();
            BinaryFormatter formatter = new BinaryFormatter();
            formatter.Serialize(ms, this);
            byte[] bytes = ms.ToArray();
            ms.Position = 0;
            return bytes;
        }

        public static UserObject deserialize(byte[] byteMessage)
        {
            MemoryStream ms = new MemoryStream(byteMessage);
            BinaryFormatter formatter = new BinaryFormatter();
            object obj = formatter.Deserialize(ms);
            return (UserObject)obj;
        }

        private static int test(string checkTime) {
            string sqltext = "select tb_Msg.*,tb_User.firstName,tb_User.lastName from  tb_Msg,tb_User where toUID=1 and [read]='0' and time<#" + checkTime + "# and fromUID=tb_User.ID; ";
            DataSet ds = Operators.DBOperator.Acc_GetDataSet(sqltext);
            return ds.Tables[0].Rows.Count;
        }

        public List<MsgObject> checkMsg(string checkTime) {
            List<MsgObject> msgs = new List<MsgObject>();
            string sqltext = "select tb_Msg.*,tb_User.firstName,tb_User.lastName from  tb_Msg,tb_User where toUID=" + UserID + " and [read]='0' and time<#" + checkTime + "# and fromUID=tb_User.ID; ";
            DataSet ds = Operators.DBOperator.Acc_GetDataSet(sqltext);
            for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
            {
                MsgObject m= new MsgObject();
                m.FromName = ds.Tables[0].Rows[i]["firstName"].ToString()+" "+ds.Tables[0].Rows[i]["lastName"].ToString();
                m.FromUID = ds.Tables[0].Rows[i]["FromUID"].ToString();
                m.ToUID = ds.Tables[0].Rows[i]["ToUID"].ToString();
                m.MsgTime = ds.Tables[0].Rows[i]["Time"].ToString();
                m.MsgContent = ds.Tables[0].Rows[i]["Content"].ToString();
                msgs.Add(m);
            }
            sqltext = "update tb_Msg set [read]=1 where toUID=" + UserID + " and [read]='0' and [Time]<=#" + checkTime + "#";
           Operators.DBOperator.Acc_ExcuteNon(sqltext);
            return msgs;
        }

    }
}
