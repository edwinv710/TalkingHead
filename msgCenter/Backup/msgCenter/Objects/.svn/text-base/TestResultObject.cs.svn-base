using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace msgCenter.Objects
{
    public class TestResultObject
    {
        public static  int STATE_FLAG_INVALID = 0;
        public static  int STATE_FLAG_GOOD = 1;
        public static  int STATE_FLAG_CRITICAL = 2;
        public static  int STATE_FLAG_SEVERE = 3;

        public static int TESTTYPE_HeartBeat = 1;
        public static int TESTTYPE_BloodPresure = 2;
        public static int TESTTYPE_Glucose = 3;




        [Serializable] 
        public struct TestResult
        {
            public string testType;
            public DateTime testTime;
            public float minValue;
            public float maxValue;
            public int stateFlag;

        }
        
        private List<TestResult> testResults=new List<TestResult>();


        public object TestResultObj
        {
            get { return (object)testResults; }
            set {  }
        }

        public List<TestResult> TestResultList
        {
            get { return testResults; }
            set { }
        }

        public void AddTestResult(TestResult result) {
            if (result.stateFlag.Equals(TestResultObject.STATE_FLAG_SEVERE)) {
                isSevere = true;
            }
            testResults.Add(result);
        }

        private bool isCritical=false;
        private bool isSevere = false;
        private bool invalid = false;

        public bool IsCritical {
            get{return isCritical;}
        }

         public bool IsSevere {
            get{return isSevere;}
        }

         public bool Invalid {
            get{return invalid;}
        }

        public void SaveResult() {
            string sqlText = string.Empty;
            foreach (TestResult t in testResults)
            {
                sqlText = "insert into tb_TestResult (testType,testTime,minValue,maxValue,stateFlag) values ('" + t.testType + "','" + t.testTime + "'," + t.minValue + "," + t.maxValue + "," + t.stateFlag + ");";
                Operators.DBOperator.Acc_ExcuteNon(sqlText);
            } 
            
        }
    }
}
