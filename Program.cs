using System;
// comment out the
/* comment */
namespace Rectangle{
    class Rectangle{
        double lenght;
        double width;
    
        public void Values(){
            lenght = 4;
            width = 5;
        }
        public double GetArea(){
            return lenght * width;
        }
        public void Display(){
            Console.WriteLine("Lenght: " + lenght);
            Console.WriteLine("Width: " + width);
            Console.WriteLine("Area: "+ GetArea());
        }
    }
    class ExcuteRectangle{
        static void Main(string[] args){
            Rectangle r = new Rectangle();
            r.Values();
            r.Display();
            Console.ReadLine();
        }
    }
}