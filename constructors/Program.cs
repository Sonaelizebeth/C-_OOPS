using System;
namespace MyApp{
    public class Car{
        public string series; 
        public string color;
        public Car(string model,string carcolor){ //object methods
            series=model;
            color=carcolor;
        }
        public void Displaymodel(){
            Console.WriteLine(series);
        }
        public void Displaycolor(){
            Console.WriteLine(color);
        }
    }
    class Task{
        static void Main(string[] args){
            Car audi = new Car("9","Black");
            audi.Displaymodel();
            audi.Displaycolor();
        }
    }
}