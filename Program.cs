using System;

namespace DIs_class_3
{
      class Program
    {
        string color;
        int maxSpeed;
        static void Main(string[] args)
        {
            Program myObj = new Program();
            myObj.color = "red";
            myObj.maxSpeed = 200;
            Console.WriteLine(myObj.color);
            Console.WriteLine(myObj.maxSpeed);
        }
    }
}
