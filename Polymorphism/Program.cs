using System;
namespace Poly{
//     public class Animal{//parent
//         public void MakeSound(){
//             Console.WriteLine("All animals makes sound");
//         }
//     }
//     public class Dog : Animal{//child
//         public void MakeSound(){
//             Console.WriteLine("Dogs bark");
//         }
//     }
//     class Polymorphism{
//         static void Main(string[] args){
//             Animal animal = new Animal();
//             animal.MakeSound();
//             Animal dog =  new Dog();
//             dog.MakeSound();
//             Dog dog1 =  new Dog();
//             dog1.MakeSound();


//         }
//     }
// }

    //overriding
    public class Animal{//parent
        public virtual void MakeSound(){
            Console.WriteLine("All animals makes sound");
        }
    }
    public class Dog : Animal{//child
        public  override void MakeSound(){
            Console.WriteLine("Dogs bark");
        }
    }
    class Polymorphism{
        static void Main(string[] args){
            Animal animal = new Animal();
            animal.MakeSound();
            Animal dog =  new Dog();
            dog.MakeSound();
        }
    }
}

