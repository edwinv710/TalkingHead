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
        private string status;
        private int userType;
        private string gender;
        private string height;
        private string weight;
        private string birthday;
        private string address_street;
        private string address_city;
        private string address_state;
        private string address_zipcode;
        private string homePhone;
        private string otherInf;
        private bool useInsulin;
        private string emgName;
        private string emgPhone;
     

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
            get
            {
                if (gender.Equals("1"))
                {
                    return "True";
                }
                else
                {
                    return "False";
                }
            }
            set
            {
                if (bool.Parse(value))
                {
                    gender = "1";
                }
                else {
                    gender = "0";
                }
            }
        }

        public float Height
        {
            get {
                try
                {
                    return float.Parse(height);
                }
                catch {
                    return 0;
                }
            }
            set { height = value.ToString(); }
        }

        public float Weight
        {
            get
            {
                try
                {
                    return float.Parse(weight);
                }
                catch
                {
                    return 0;
                }
            }
            set { weight = value.ToString(); }
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

        public string Address_Street
        {
            get { return address_street; }
            set { address_street = value; }
        }

        public string Address_City
        {
            get { return address_city; }
            set { address_city = value; }
        }

        public string Address_State
        {
            get { return address_state; }
            set { address_state = value; }
        }
        public string Address_Zipcode
        {
            get { return address_zipcode; }
            set { address_zipcode = value; }
        }

        public string OtherInf
        {
            get { return otherInf; }
            set { otherInf = value; }
        }

        public bool Status
        {
            get
            {
                if (status.Equals("1"))
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
                    status = "1";
                }
                else
                {
                    status = "0";
                }
            }
        }

        public string UserType
        {
            get { return userType.ToString() ; }
            set { userType = int.Parse(value); }
        }

        public bool UseInsulin
        {
            get { return useInsulin; }
            set { useInsulin = value; }
        }
        public string EmgName
        {
            get { return emgName; }
            set { emgName = value;}
        }

        public string EmgPhone
        {
            get { return emgPhone; }
            set { emgPhone =value; }
        }


        public static UserObject GetUser() {
            string sqltext = "select * from tb_User;";
            DataSet ds = Operators.DBOperator.Acc_GetDataSet(sqltext);
            UserObject c = new UserObject();
            c.UserID = ds.Tables[0].Rows[0]["ID"].ToString();
            c.firstName = ds.Tables[0].Rows[0]["firstName"].ToString();
            c.midName = ds.Tables[0].Rows[0]["midName"].ToString();
            c.lastName = ds.Tables[0].Rows[0]["lastName"].ToString();
            c.suffx = ds.Tables[0].Rows[0]["suffx"].ToString();
            c.gender = ds.Tables[0].Rows[0]["gender"].ToString();
            c.address_street = ds.Tables[0].Rows[0]["street"].ToString();
            c.address_city = ds.Tables[0].Rows[0]["city"].ToString();
            c.address_state = ds.Tables[0].Rows[0]["state"].ToString();
            c.address_zipcode = ds.Tables[0].Rows[0]["zipcode"].ToString();
            c.height = ds.Tables[0].Rows[0]["height"].ToString();
            c.weight = ds.Tables[0].Rows[0]["weight"].ToString();
            c.homePhone = ds.Tables[0].Rows[0]["homePhone"].ToString();
            c.otherInf = ds.Tables[0].Rows[0]["otherInf"].ToString();
            c.birthday = ds.Tables[0].Rows[0]["birthday"].ToString();
            c.status = ds.Tables[0].Rows[0]["status"].ToString();
            c.userType = int.Parse(ds.Tables[0].Rows[0]["UserType"].ToString());
            c.emgName = ds.Tables[0].Rows[0]["EmgName"].ToString();
            c.emgPhone = ds.Tables[0].Rows[0]["EmgPhone"].ToString();
            c.useInsulin = bool.Parse(ds.Tables[0].Rows[0]["useInsulin"].ToString());
            return c;
        }

        public List<UserObject> contacts;

        public bool update() {
            string sqltext = "update tb_User set firstName='"+firstName+"',midName='"+midName+"', lastName='"+lastName
                +"',suffx='"+suffx+"',gender='"+gender+"', birthday='"+birthday+"', height='"+height
                +"',weight='"+weight+"',street='"+address_street+"',city='"+address_city+"',state='"+address_state+"',zipcode='"+address_zipcode+"',homephone='"+homePhone
                + "',otherInf='" + otherInf + "',useInsulin='"+useInsulin+"',emgName='"+emgName+"',emgPhone='"+emgPhone
                +"',status=1, userType=1 where id=1";
            Operators.DBOperator.Acc_ExcuteNon(sqltext);
            return true;
        }

        public bool SyncUserState()
        {
            string sqltext = "update tb_User set status='" + status + "' where id=" + userID;
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
                c.address_street = ds.Tables[0].Rows[0]["street"].ToString();
                c.address_city = ds.Tables[0].Rows[0]["city"].ToString();
                c.address_state = ds.Tables[0].Rows[0]["state"].ToString();
                c.address_zipcode = ds.Tables[0].Rows[0]["zipcode"].ToString();
                c.height =ds.Tables[0].Rows[i]["height"].ToString();
                c.weight =ds.Tables[0].Rows[i]["weight"].ToString();
                c.homePhone = ds.Tables[0].Rows[i]["homePhone"].ToString();
                c.otherInf = ds.Tables[0].Rows[i]["otherInf"].ToString();
                c.birthday = ds.Tables[0].Rows[i]["birthday"].ToString();
                c.status = ds.Tables[0].Rows[i]["status"].ToString();
                c.userType =int.Parse(ds.Tables[0].Rows[i]["UserType"].ToString());
                c.emgName = ds.Tables[0].Rows[0]["EmgName"].ToString();
                c.emgPhone = ds.Tables[0].Rows[0]["EmgPhone"].ToString();
                c.useInsulin = bool.Parse(ds.Tables[0].Rows[0]["useInsulin"].ToString());
                contacts.Add(c);
            }
        }
        public string getEmgPhoneNumber() {
            string sqltext = "select emgPhone from tb_User;";
            DataSet ds = Operators.DBOperator.Acc_GetDataSet(sqltext);
            return ds.Tables[0].Rows[0]["EmgPhone"].ToString();
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
