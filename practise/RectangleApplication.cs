using System;

namespace RectangleApplication {
   class Rectangle {
      
      // member variables added
      double length;
      double width;
      
      public void Acceptdetails() {
         length = 4.5;    
         width = 3.5;
      }
      public double GetArea() {
         return length * width; //returns sol
      }
      public void Display() {
         Console.WriteLine("Length: {0}", length);//length added
         Console.WriteLine("Width: {0}", width);//width added
         Console.WriteLine("Area: {0}", GetArea());//Area added
      }
   }
   class ExecuteRectangle {
      static void Main(string[] args) {
         Rectangle r = new Rectangle();
         r.Acceptdetails();
         r.Display();
         Console.ReadLine(); 
      }
   }
}
