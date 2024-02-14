using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace TPP.Lab02
{
    internal class Circunference
    {

        private Point2D center;
        private double radious;

        public Circunference(Point2D center, double radious)
        {
            this.center = center;
            this.radious = radious > 0? radious: 0;
        }

        ~Circunference() { }

        public Circunference TangentWithCenter(Point2D center)
        {
            double distance = this.center.Distance(center);
            if (distance > radious) return new Circunference(center, distance - radious);
            return new Circunference(center, distance + radious);
        }

        public static bool operator <(Circunference c1, Circunference c2)
        {
            return c1.center.Distance(c2.center) + c2.radious  < c1.radious;
        }

        public static bool operator >(Circunference c1, Circunference c2)
        {
            return c1.center.Distance(c2.center) + c2.radious > c1.radious;
        }

        public override string ToString()
        {
            return $"Center Point: {center} - Radious: {radious}";
        }
    }
}
