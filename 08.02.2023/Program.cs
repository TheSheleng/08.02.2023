using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Obj3Dim;

namespace _08._02._2023
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var vec_1 = new Vector(3, 5, 6);
            var vec_2 = new Vector(4, 6, 4);

            vec_1.Output();
            Console.WriteLine(vec_2);

            vec_1.Increase(2);
            vec_2.Decrease(3);

            vec_2.Increase(vec_1);
            vec_1.Decrease(vec_2);

            vec_1.Product(vec_2);
            vec_2.Input();
            Console.WriteLine($"Равенство векторов: {vec_1.Equals(vec_2)}");
        }
    }
}
