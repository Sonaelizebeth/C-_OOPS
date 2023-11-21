using System;
namespace Delegate{
    class Delegates{
        delegate int ChangeNumber(int n);
        static void Main(string[] args){
            Console.WriteLine(Add10(20));
            Console.WriteLine(Multiply10(100));
            ChangeNumber delegate1 =  new ChangeNumber(Add10);
            Console.WriteLine(delegate1.Invoke(30));
            ChangeNumber delegate2 =  new ChangeNumber(Multiply10);
            Console.WriteLine(delegate2.Invoke(30));
            //or
            Console.WriteLine(delegate2(30));
        }
        static int Add10(int n){
            return n+10;
        }
        static int Multiply10(int n)
        {
            return n*10;
        }   
    }
}
