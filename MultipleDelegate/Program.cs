using System;
namespace MulticastDelegate{
    public delegate void MultiCastDelegate();
    class MulticastDelegates{
        static void Main(string[] args){
            MultiCastDelegate md1 = new MultiCastDelegate(Hello);
            MultiCastDelegate md2 = new MultiCastDelegate(Hi);
            var md = md1+md2;
            md();
        }
        static void Hello(){
            Console.WriteLine("Hello");
        }
        static void Hi(){
            Console.WriteLine("Hi");
        }
    }
}

//-----------------------------string----------------------------------------
//         public delegate string MultiCastDelegate();
//         class MulticastDelegates{
//             static void Main(string[] args){
//                 MultiCastDelegate md1 = new MultiCastDelegate(Hello);
//                 MultiCastDelegate md2 = new MultiCastDelegate(Hi);
//                 var md = md1+md2;
//                 Console.WriteLine(md());
//             }
//             static string Hello(){
//                 return "Hello";
//             }
//             static string Hi(){
//                 return "Hi";
//             }
//     }
// }
