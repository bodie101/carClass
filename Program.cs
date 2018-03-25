using System;

namespace carClass
{
    public class Car
    {
        private string colour; 
        public Car(string col)
        {
            colour = col; 
        }
        public string Colour
        {
            get { return colour; }
            set { colour = value; }
        }
        string make {get; set;}
        string gearbox {get; set;} 

        class Program
        {

        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }
    }
}
}
