using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace Obj3Dim
{
    public class Vector
    {
        static void EndIfNotDouble(string s, out double o, int code)
        {
            if (!(double.TryParse(s, out o)))
            {
                Console.WriteLine("Error " + code);
                Console.ReadKey();
                Environment.Exit(code);
            }
        }

        void SetLen()
        {
            len = Math.Sqrt(Math.Pow(x, 2) + Math.Pow(y, 2) + Math.Pow(z, 2));
        }

        double x; double y; double z;
        double len;
        public double X { get => x; }
        public double Y { get => y; }
        public double Z { get => z; }
        public double Length { get => len; }
        public Vector(double x, double y, double z)
        {
            this.x = x;
            this.y = y;
            this.z = z;
            SetLen();
        }
        public Vector() : this(0, 0, 0) { }
        public Vector(int i) : this(i, i, i) { }
        public void Input()
        {
            Console.Write("X: ");
            EndIfNotDouble(Console.ReadLine(), out x, 1);

            Console.Write("Y: ");
            EndIfNotDouble(Console.ReadLine(), out y, 1);
            
            Console.Write("Y: ");
            EndIfNotDouble(Console.ReadLine(), out z, 1);

            SetLen();
        }
        public void Output()
        {
            Console.WriteLine($"X: {x}");
            Console.WriteLine($"Y: {y}");
            Console.WriteLine($"Z: {z}");
        }

        public void Increase(double scal)
        {
            x = (len + scal) * x / len;
            y = (len + scal) * y / len;
            z = (len + scal) * z / len;
            SetLen();
        }
        public void Decrease(double scal)
        {
            Increase(-scal);
        }
        public void Increase(Vector vec)
        {
            x += vec.x;
            y += vec.y;
            z += vec.z;
            SetLen();
        }
        public void Decrease(Vector vec)
        {
            x -= vec.x;
            y -= vec.y;
            z -= vec.z;
            SetLen();
        }
        public void Product(Vector vec)
        { 
            x *= vec.x;
            y *= vec.y;
            z *= vec.z;
            SetLen();
        }
        public bool Equality(Vector vec)
        {
            return x == vec.x && y == vec.y && z == vec.z;
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append($"X: {x}");
            sb.Append($"Y: {y}");
            sb.Append($"Z: {z}");
            return sb.ToString();
        }
    }
}
