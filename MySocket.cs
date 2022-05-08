using System;
using System.Collections.Generic;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading;
using WPF_stock_client.Views;
using System.Windows;

namespace WPF_stock_client
{
    // State object for receiving data from remote device.  
    public class MySocket
    {
        public Socket socket;
        public static string data = null;
        Thread listenthread;
        public MySocket(Socket s)
        {
            socket = s;
        }

        public static MySocket connect()
        {
            try
            {
                IPHostEntry ipHostInfo = Dns.GetHostEntry(Dns.GetHostName());
                IPAddress ipAddress = ipHostInfo.AddressList[0];
                IPEndPoint remoteEP = new IPEndPoint(ipAddress, 11000);

                Socket s = new Socket(ipAddress.AddressFamily, SocketType.Stream, ProtocolType.Tcp);

                s.Connect(remoteEP);
                return new MySocket(s);
            }
            catch {
                return null;
            }
        }

        public void send(string line)
        {
            try
            {
                byte[] msg = Encoding.UTF8.GetBytes(line);
                socket.Send(msg);
            }
            catch { }
        }

        public void disconnect()
        {
            send("<EOF>");

            socket.Shutdown(SocketShutdown.Both);
            socket.Close();
        }

        //把讀到的資料轉成字串
        public string receive()
        {
            data = null;
            byte[] bytes = new Byte[1024];
            int bytesRec = socket.Receive(bytes);
            data += Encoding.UTF8.GetString(bytes, 0, bytesRec);

            return data;
        }

        public void listen()
        {
            try
            {
                while (true)
                {
                    string line = receive();

                    if(line == "")
                    {
                        disconnect();
                    }
                }
            }
            catch (Exception ex)
            {

            }
        }

        public void listener()
        {
            listenthread = new Thread(listen);
            listenthread.Start();
        }
    }
}
