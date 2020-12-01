using System;

namespace DataTypeApp
{
    class Program
    {
        static void Main(string[] args)
        {

            object obj;
            obj = 100;
            //can find size of any datatype 
            Console.WriteLine("Size of int:{0}", sizeof(int));
            Console.WriteLine("Size of char:{0}", sizeof(char));
            Console.WriteLine("Size of double:{0}", sizeof(double));
            Console.WriteLine("Size of float:{0}", sizeof(float));
            Console.WriteLine("Value of obj:{0}", obj);
            Console.ReadLine();
        }
    }
}

/*Size of int:4
Size of char:2
Size of double:8
Size of float:4*/
