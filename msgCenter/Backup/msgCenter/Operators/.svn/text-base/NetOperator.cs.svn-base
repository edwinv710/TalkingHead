using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Net;
using System.Net.Sockets;
using System.Threading;
using System.IO;

namespace msgCenter.Operators
{
    public class NetOperator
    {
        public static  int serverPort = 8000;
        public static  int clientPort = 8001;
        public static string serverIP = GetServerIP().ToString();

       // private string serverIP = "192.168.1.18";
        //private string serverIP = GetServerIP().ToString();
        //public string ServerIP {
        //    get { return serverIP; }
        //    set { serverIP = value; }
        //}

        private byte[] content;

        public byte[] Content
        {
            get { return content; }
            set { content = value; }
        }

        private Thread sendingThread;
        private Thread listeningThread;
        public void Send() {
            sendingThread = new Thread(new ThreadStart(Sending));
            sendingThread.Start();
        }

        private void Sending()
        {
            IPAddress serverIp = IPAddress.Parse(NetOperator.serverIP);
            IPEndPoint iep = new IPEndPoint(serverIp, NetOperator.serverPort);

            Socket socket = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
            socket.Connect(iep);
            //byte[] byteMessage;
            //byteMessage = Encoding.ASCII.GetBytes(content);
            socket.Send(content);
            socket.Shutdown(SocketShutdown.Both);
            socket.Disconnect(true);
            socket.Close();
        }

        public byte[] GetResponse()
        {
            IPAddress serverIp = IPAddress.Parse(NetOperator.serverIP);
            IPEndPoint iep = new IPEndPoint(serverIp, NetOperator.serverPort);
            Socket socket = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
            socket.Connect(iep);
            //byte[] byteMessage;
            //byteMessage = Encoding.ASCII.GetBytes(content);
            socket.Send(content);
            byte[] temp = new byte[1024];
            int read = socket.Receive(temp, 0, 1024, SocketFlags.None);
            byte[] result=new byte[read];
           Array.Copy(temp, 0, result, 0, read);
            socket.Shutdown(SocketShutdown.Both);
            socket.Disconnect(false);
            socket.Close();
            return temp;
        }

        private void Listening()
        {
            IPAddress ServerIp = GetServerIP();
            int port =NetOperator.clientPort;
            IPEndPoint iep = new IPEndPoint(ServerIp, port);
            Socket socket = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);

            byte[] byteMessage;
            socket.Bind(iep);
            while (true)
            {
                try
                {
                    socket.Listen(5);
                    Socket newSocket = socket.Accept();
                    byteMessage = new byte[newSocket.Available];
                    newSocket.Receive(byteMessage);

                    //mainProcess._globalMsgList;
                    //processMsg(byteMessage);
                }
                catch (SocketException ex)
                {
                    
                }
            }
        }

        public static IPAddress GetServerIP()
        {
            IPHostEntry ieh = Dns.GetHostByName(Dns.GetHostName());
            return ieh.AddressList[0];
        }

    }
}
