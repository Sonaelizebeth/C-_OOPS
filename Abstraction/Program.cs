using System;
namespace Abstraction{
    public abstract class Animal{//parent // absract class
        public abstract void MakeSound(); //abstract methods //cannot declare body because it is abstract
        public void Run(){ //can give implementation in normal methods
            Console.WriteLine("Animals can run");
        }
    }
    public class Dog : Animal{//child
        public  override void MakeSound(){
            Console.WriteLine("Dogs bark");
        }
    }
    class Abstraction{
        static void Main(string[] args){
            Dog dog =  new Dog();
            dog.MakeSound();
            dog.Run();
            // Dog dog2 =  new Animal(); Cannot create an instance of the abstract type or interface 'Animal'
            Animal dog1 =  new Dog();
            dog1.MakeSound();
            dog1.Run();
            
        }
    }
}