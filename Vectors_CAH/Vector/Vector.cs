using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vector_
{
    public class Vector
    {
        public List<double> v;
        public Vector(List<double> vec)
        {
            v = vec;
        }
        public Vector add(List<Vector> vectors)
        {

            Vector result = new Vector(new List<double>());
            for (int pos = 0; pos < vectors[0].v.Count(); ++pos)
            {
                double i = 0;
                foreach (Vector item in vectors)
                {
                    i += item.v[pos];
                }
                result.v.Add(i);
            }
            return result;
        }
        public Vector scalar_multiply(double scalar)
        {
            Vector res = new Vector(new List<double>());
            foreach (int item in v)
            {
                res.v.Add(item * scalar);
            }
            return res;
        }
        public double dot_product(List<Vector> collection)
        {
            Vector result = new Vector(new List<double>());
            for (int pos = 0; pos < collection[0].v.Count(); ++pos) //same as add except i am multiplying
            {
                double i = 1;
                foreach (Vector item in collection)
                {
                    i *= item.v[pos];
                }
                result.v.Add(i);
            }
            return result.v.Sum();
        }

        public Vector convex_combination(List<Vector> collection,double a, double b)
        {
            Vector first = collection[0];
            Vector second = collection[1];
            return first.add(new List<Vector> { first.scalar_multiply(a), second.scalar_multiply(b) });
        }

        public double Geometric_dot_product(Vector u, Vector v, double angle)
        {
            double res1 = u.Vector_Mag() + v.Vector_Mag();
            double res2 = res1 * Math.Cos(angle);
            return res2;
        }
        public double Vector_Mag()
        {
            double i = 0;
            foreach(double item in v)
            {
                i += (item * item);
            }
            return i;
        }
        public double find_Angle(Vector u) //only works for vectors that form right angled trianles. will create another function
        {
            double adjacent = Vector_Mag();
            double hypotoneuse = u.Vector_Mag();
            double entry = adjacent / hypotoneuse;
            return Math.Acos(entry);
        }
    }
}
