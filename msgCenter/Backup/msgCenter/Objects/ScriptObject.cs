using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace msgCenter.Objects
{
    class ScriptObject
    {
        private string doctorUID;
        private string patientUID;

        private float minValue;
        private float maxValue;

        private string content;

        public string DoctorUID {
            get { return doctorUID; }
            set { doctorUID = value; }
        }

        public string PatientUID
        {
            get { return patientUID; }
            set { patientUID = value; }
        }

        public float MinValue
        {
            get { return minValue; }
            set { minValue = value; }
        }

        public float MaxValue
        {
            get { return maxValue; }
            set { maxValue = value; }
        }

        public string Content
        {
            get { return content; }
            set { content = value; }
        }

    }
}
