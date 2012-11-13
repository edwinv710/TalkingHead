using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace msgCenter.Objects
{
    public class EmotionObject
    {
        public static int Emotion_Happy = 1;
        public static int Emotion_Sad = 2;

        public static void New(int emotion,DateTime time){
            string sqlText = "insert into tb_EmotionHistory (emotionID,[Time]) values ("+emotion.ToString()+",'"+time+"');";
            Operators.DBOperator.Acc_ExcuteNon(sqlText);
        }
    }
}
