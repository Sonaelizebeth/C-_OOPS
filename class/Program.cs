using System;
namespace MyApp{
    public class Fruit{
        public string color; //attribute of class Fruit or fields
        public void shape(){ //object methods
            Console.WriteLine("oval");
        }


    }
    public class Car{
        public string series; 
    }
    class Task{
        static void Main(string[] args){
            Fruit apple = new Fruit();
            apple.color="Red";
            Console.WriteLine(apple.color);
            Fruit mango = new Fruit();
            mango.shape();
            Car audi = new Car();
            audi.series = "9";
            Console.WriteLine(audi.series);
        }
    }
}