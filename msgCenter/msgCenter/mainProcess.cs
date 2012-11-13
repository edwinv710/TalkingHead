﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using ttsEngine;
using System.Timers;
using System.Threading;
using RSSEngine;

namespace msgCenter
{
    public class mainProcess
    {
        private Objects.UserObject currentUser;
        public static List<Objects.MsgObject> _globalMsgList;

        public delegate void ContactUpdatingHandler(List<msgCenter.Objects.UserObject> contacts);
        public event ContactUpdatingHandler ContactUpdatingEvent;

        public delegate void MSGUpdatingHandler(List<msgCenter.Objects.MsgObject> msgs);
        public event MSGUpdatingHandler MSGUpdatingEvent;

        //public event ttsEngine.ttsEngine.SpeakCompleted SpeakingCompletedEvent;

        public delegate void SpeakingCompletedHandler();
        public event SpeakingCompletedHandler SpeakingCompletedEvent;

        public delegate void GetingNewsHandler(List<string[,]> news);
        public event GetingNewsHandler GettingNewsEvent;


        public void AddContactUpdatingEvent(ContactUpdatingHandler e) {
            ContactUpdatingEvent += e;
        }
        public void AddMSGUpdatingEvent(MSGUpdatingHandler e)
        {
            MSGUpdatingEvent += e;
        }

        public void AddGetingNewsEvent(GetingNewsHandler e)
        {
            GettingNewsEvent += e;
        }
        public void AddSpeakingCompletedEvent(SpeakingCompletedHandler e)
        {
            SpeakingCompletedEvent += e;
        }

        private Operators.ChatRobotOperator chatRobot;


        private string email = "nteamtalkinghead@gmail.com";
        private string password = "temp123456";
        private string toPhoneNum = "7168030343";
        private string forwardingNum = "17165741848";


        public void setEmePhoneNum(string cellNum) {
            toPhoneNum = cellNum;
        }
        private void SpeakingCompleteFunc() {
            if (SpeakingCompletedEvent != null)
            {
                SpeakingCompletedEvent();
            }
        }


        public mainProcess() { }
    
        public mainProcess(Objects.UserObject cUser,ref  List<Objects.MsgObject> list) {
            currentUser = cUser;
            mainProcess._globalMsgList = list;
            string userName = currentUser.FirstName + " " + currentUser.LastName;
            chatRobot = new msgCenter.Operators.ChatRobotOperator(userName);
        }

        public void updateServerAddress(string ip,int port) {
            Operators.NetOperator.serverIP = ip;
            Operators.NetOperator.serverPort = port;
        }

        public void newTest(Objects.TestResultObject.TestResult result) {
            Objects.TestResultObject newTR = new Objects.TestResultObject();
            
            if (newTR.IsCritical) {
                Objects.MsgObject msg = new msgCenter.Objects.MsgObject(DateTime.Now.ToString(), Objects.MsgObject.MSG_TYPE_CRITICAL, "0", "1", newTR.Result);
                msg.SentMsg();
            }
        }

        public void getNews(string url)
        {
            List<RSSEngine.rssItem> rss=RSSEngine.RSSEngine.getRSSData(url);
            List<string[,]> news=new List<string[,]>();
            foreach (rssItem item in rss) { 
                string[,] temp=new string[1,2];
                temp[0, 0] = item.title;
                temp[0, 1] = item.description;
                news.Add(temp);
            }
            GettingNewsEvent(news);
        }


        public void newDialog(string text,string targetUID) { 
            //sent msg to doctor
            Objects.MsgObject msg = new msgCenter.Objects.MsgObject(DateTime.Now.ToString(), Objects.MsgObject.MSG_TYPE_TEXT, currentUser.UserID, targetUID, (object)text);
            msg.SentMsg();
        }

        public void newDialog(string Input)
        {
            //ttsEngine.ttsEngine.SpeakCompleted+=
            //Call the text to speech module
            ttsEngine.ttsEngine.SpeakCompletedFuncs = SpeakingCompleteFunc;
            ttsEngine.ttsEngine.speak(Input);
        }

        #region ttsEngine Setting
        public void SetRate(int rate) {
            ttsEngine.ttsEngine.setRate(rate);
        }

        public void PauseSpeaking() {
            ttsEngine.ttsEngine.pause();
        }

        public void ContinueSpeaking()
        {
            ttsEngine.ttsEngine.resume();
        }
        public void StopSpeaking() {
            ttsEngine.ttsEngine.stop();
        }
        public void Mute(){
            ttsEngine.ttsEngine.pause();
            ttsEngine.ttsEngine.setMuteChecked();
            ttsEngine.ttsEngine.resume();
        }

        public void Demute(){
            ttsEngine.ttsEngine.pause();
            ttsEngine.ttsEngine.setMuteUnchecked();
            ttsEngine.ttsEngine.resume();
        }

        public List<string> GetVoices() {
            return ttsEngine.ttsEngine.getVoices();
        }

        public void SetVoice(string voiceName) {
            ttsEngine.ttsEngine.setVoice(voiceName);
        }

        public void SetVolum(int volum) {
            ttsEngine.ttsEngine.setVolume(volum);
        }
        #endregion

        public void StartSync() {
            Thread syncThread = new Thread(new ThreadStart(Sync_process));
            syncThread.Start();
        }

        private void Sync_process()
        {
            System.Timers.Timer syncTimer = new System.Timers.Timer();
            syncTimer.Interval = 5000;
            syncTimer.AutoReset = true;
            syncTimer.Elapsed += new ElapsedEventHandler(msgCheck);
            syncTimer.Elapsed += new ElapsedEventHandler(getContacts_process);
            syncTimer.Enabled = true;
            //msgCheck();

        }

        private void msgCheck(object source, System.Timers.ElapsedEventArgs e)
        //private void msgCheck()
        {
            try
            {
                Objects.ReqObject req = new msgCenter.Objects.ReqObject();
                req.ReqTime = DateTime.Now;
                req.ReqType = Objects.ReqObject.REQ_TYPE_NEWMSG;
                req.ReqContent = (object)currentUser.UserID;
                byte[] result = req.GetResponse();
                List<Objects.MsgObject> msgs = (List<Objects.MsgObject>)Operators.SerializeOperator.DeSerialize(result);
                if (msgs.Count > 0)
                {
                    MSGUpdatingEvent(msgs);
                }
            }
            catch (Exception ex)
            {
                //newDialog("Connection Error.");
            }
        }


        public void getContacts()
        {
            Thread gc = new Thread(new ThreadStart(getContacts_process));
            gc.Start();
        }
        private void getContacts_process()
        {
            try
            {
                Objects.ReqObject req = new msgCenter.Objects.ReqObject();
                req.ReqType = Objects.ReqObject.REQ_TYPE_CONTACTS;
                req.ReqTime = DateTime.Now;
                req.ReqContent = (object)currentUser.UserID;
                byte[] result = req.GetResponse();
                //currentUser.=Objects.UserObject.deserialize(result).contacts;  
                Objects.UserObject tempUser = (Objects.UserObject)Operators.SerializeOperator.DeSerialize(result);
                ContactUpdatingEvent(tempUser.contacts);
            }
            catch (Exception ex) {
                //newDialog("Connection Error.");
                
            }
        }

        private void getContacts_process(object source, System.Timers.ElapsedEventArgs e)
        {
            try
            {
                Objects.ReqObject req = new msgCenter.Objects.ReqObject();
                req.ReqType = Objects.ReqObject.REQ_TYPE_CONTACTS;
                req.ReqTime = DateTime.Now;
                req.ReqContent = (object)currentUser.UserID;
                byte[] result = req.GetResponse();
                //currentUser.=Objects.UserObject.deserialize(result).contacts;  
                Objects.UserObject tempUser = (Objects.UserObject)Operators.SerializeOperator.DeSerialize(result);
                ContactUpdatingEvent(tempUser.contacts);
            }
            catch (Exception ex)
            {
                //newDialog("Connection Error.");
            }
        }

        public void CallEmergency() { 
            Operators.GoogleVoiceOperator go=new Operators.GoogleVoiceOperator(email,password,toPhoneNum,forwardingNum);
            go.PlaceCall();
        }

        public void CallPhone(string phoneNumber)
        {
            Operators.GoogleVoiceOperator go = new Operators.GoogleVoiceOperator(email, password, phoneNumber, forwardingNum);
            go.PlaceCall();
        }
        public string Chat(string userInput) {
            string answer = chatRobot.Chat(userInput);
           newDialog(answer);
           return answer;
        }

        public void getWeather()
        {
            string weather = RSSEngine.RSSEngine.getWeatherZip("14120");
            newDialog(weather);
        }

    }
}
