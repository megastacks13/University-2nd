using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Intervals
{
    public class Bar:Interval
    {
        // additional attribute
        double height;
        // use of base
        public Bar():base() {
            //add code here
            height = 0;
        }

        public Bar(Interval i, double h) : base(i.Left, i.Right)
        {
            if (height < 0) throw new ArgumentException("Invalid height smaller than 0");
            this.height = h;
        }
        // use base for the other constructor
        public Bar(double? left,double ? right, double height): base(left, right) //use base here
        {
            // add code here
            this.height = height;
        }
        // use base here too 
        protected new bool Check()
        {
            //modify this
            return base.Check() && height >= 0;
        }
        // use base here too
        public override string ToString()
        {
            //modify this
            return base.ToString() + $" - Height: {height}";
        }
        // use base here too
        public override bool Equals(object obj)
        {
            if (!typeof(object).Equals(typeof(Bar))) return false;
            return base.Equals(obj) && ((Bar) obj).height == height;    
        }

        public override int GetHashCode()
        {
            return ToString().GetHashCode();
        }

        // use base here, rethink the modifier if you find a bug
        // related with the polymorphic method
        public override double? Size()
        { 
            //add code here
            return base.Size() * height;
        }

        public static Bar operator *(Bar a, Bar b)
        {
            return new Bar(a.Intersection(b), Math.Min(a.height, b.height));
        }
    }
}
