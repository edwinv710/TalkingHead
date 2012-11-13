using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using msgCenter;

namespace TKTest
{
    public partial class Form1 : Form
    {

        private List<msgCenter.Objects.MsgObject> _globalMsgList=new List<msgCenter.Objects.MsgObject>();
        private mainProcess mp;
        private List<msgCenter.Objects.UserObject> contacts;
        public Form1()
        {
            InitializeComponent();
            Control.CheckForIllegalCrossThreadCalls = false;
            msgCenter.Objects.UserObject user = msgCenter.Objects.UserObject.GetLocalUser();
            user.UserID = "1";
            //user.FirstName = "xxx";
            //user.State = true;
            //user.UserType = "2";

            mp = new mainProcess(user, ref _globalMsgList);
        }

        private void bt_sent_Click(object sender, EventArgs e)
        {
            
            msgCenter.Objects.TestResultObject.TestResult result = new msgCenter.Objects.TestResultObject.TestResult();
            result.maxValue = 110;
            result.minValue = 85;
            result.stateFlag = msgCenter.Objects.TestResultObject.STATE_FLAG_CRITICAL;
            result.testTime = DateTime.Now;
            result.testType = "Blood Presure";
  
            //mp.newTest(result);

            //mp.newDialog("test msg", "001");
            //int x= msgCenter.Objects.UserObject.test(DateTime.Now.ToString());
            //mp.ContactUpdatingEvent += updateContacts;
            //mp.getContacts();
           
            //mp.MSGUpdatingEvent += updateMSG;
           // mp.StartSync();
            //MessageBox.Show(x.ToString());


            //mp.newDialog(mp.Chat("hello"));
            mp.CallPhone();
        }

        public void updateContacts(List<msgCenter.Objects.UserObject> contacts) {
            bt_sent.Text += contacts.Count.ToString();
            foreach (msgCenter.Objects.UserObject u in contacts) {
                if (u.UserType.Equals("1")) {
                    checkBox1.Checked = u.State;
                    break;
                }
            }
        }

        public void updateMSG(List<msgCenter.Objects.MsgObject> msgs)
        {
            bt_sent.Text += msgs.Count.ToString();
        }
    }
}
