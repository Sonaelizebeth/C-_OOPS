using System;
namespace inherit{
    public class Mobile{ //parent class
        public string os= "Android";
        public void MakeCalls(){
            Console.WriteLine("Any mobile can make calls");
        }
    }
    public class Android : Mobile{ //child class

    }
    class Inheritances{
        static void Main(string[] args){
            Android android = new Android();
            android.os ="IOS";
            android.MakeCalls();
            Console.WriteLine(android.os);
        }
    }
}