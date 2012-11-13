using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Runtime.Serialization.Formatters.Binary;
using System.Runtime.Serialization;
using System.Security.Permissions;
using System.IO;

namespace msgCenter.Operators
{
    public class SerializeOperator
    {
        public static byte[] Serialize(object obj) {
            MemoryStream ms = new MemoryStream();
            BinaryFormatter formatter = new BinaryFormatter();
            formatter.Serialize(ms, obj);
            byte[] bytes = ms.ToArray();
            ms.Position = 0;
            return bytes;
        }

        public static object DeSerialize(byte[] byteMsg) {
            MemoryStream ms = new MemoryStream(byteMsg);
            BinaryFormatter formatter = new BinaryFormatter();
            object obj = formatter.Deserialize(ms);
            return obj;
        }
    }
}
