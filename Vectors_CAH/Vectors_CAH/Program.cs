using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Vector_;
namespace Vectors_CAH
{
    class Program
    {
        static void Main(string[] args)
        {
            Vector u = new Vector(new List<double> { 1, 5, 3 });
            Vector v = new Vector(new List<double> { 4, 6, 9 });
            List<Vector> UandV = new List<Vector> { v, u };
            Vector result_add = v.add(UandV);
            Out(result_add);
            Vector scalar = v.scalar_multiply(5);
            Out(scalar);
            Console.WriteLine(v.dot_product(UandV));
            Out(v.convex_combination(UandV, 0.5, 0.5));
            Console.WriteLine("Geo dot product is: "+v.Geometric_dot_product(v, u,30));
            Console.WriteLine(u.find_Angle(v)+" radians");
            Console.ReadKey();
        }
        static void Out(Vector v)
        {
            Console.WriteLine(string.Join(",", v.v));
        }
    }
}
