using System;

namespace Demo {
    class Program {
        static void Main(string[] args) {
            using (SimpleSessionClient.Session session = new SimpleSessionClient.Session("127.0.0.1", 8601)) {

                // 创建一个新的交互标识
                if (!session.SetSessionID("c83e7a19bf2b4c9f861465fd243696d2")) session.CreateNewSessionID();
                Console.WriteLine("ID " + session.SessionID);

                Console.WriteLine("Test before " + session["Test"]);
                session["Test"] = Guid.NewGuid().ToString();
                Console.WriteLine("Test after " + session["Test"]);

            }
        }
    }
}
