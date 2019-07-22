using System;

namespace Demo {
    class Program {
        static void Main(string[] args) {

            string ip = "127.0.0.1";
            //string ip = "39.106.190.110";
            //string ip = "111.73.45.233";
            //string ip = "111.73.46.139";

            //连接100次，测试反应速度
            for (int i = 0; i < 100; i++) {
                int tick = Environment.TickCount;
                using (SimpleSessionClient.Session session = new SimpleSessionClient.Session(ip, 8601, "000000")) {

                    // 创建一个新的交互标识
                    if (!session.SetSessionID("c83e7a19bf2b4c9f861465fd243696d2")) session.CreateNewSessionID();
                    //session.CreateNewSessionID();
                    Console.WriteLine("ID " + session.SessionID);

                    ////Console.WriteLine("Test before " + session["Test"]);
                    //session["Test"] = Guid.NewGuid().ToString();
                    //Console.WriteLine("Test after " + session["Test"]);

                }
                Console.WriteLine("Take " + (Environment.TickCount - tick) + " ms");
            }

        }
    }
}
