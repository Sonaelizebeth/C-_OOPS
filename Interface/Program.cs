using System;
namespace Interface{
    interface IChatSystem{
        void SendMessage();
        void ReceiveMessage();
    }
    interface IChatSystem2{
        void SendMessage2();
        void ReceiveMessage2();
    }
    class Whatsapp : IChatSystem,IChatSystem2{
        public void SendMessage(){
            Console.WriteLine("Message sent via whatsapp");
        }
        public void ReceiveMessage(){
            Console.WriteLine("Message Received via whatsapp");
        }
        public void SendMessage2(){
            Console.WriteLine("Message sent via whatsapp in system2");
        }
        public void ReceiveMessage2(){
            Console.WriteLine("Message Received via whatsapp in system2");
        }
    }
    class Telegram : IChatSystem{
        public void SendMessage(){
            Console.WriteLine("Message sent via telegram");
        }
        public void ReceiveMessage(){
            Console.WriteLine("Message Received via telegram");
        }
    }
    class Interfaces{
        static void Main(string[] args){
            IChatSystem w = new Whatsapp();
            w.SendMessage();
            w.ReceiveMessage();
            IChatSystem t = new Telegram();
            t.SendMessage();
            t.ReceiveMessage();
            IChatSystem2 w1 = new Whatsapp();
            w1.SendMessage2();
            w1.ReceiveMessage2();
        }
    }
}