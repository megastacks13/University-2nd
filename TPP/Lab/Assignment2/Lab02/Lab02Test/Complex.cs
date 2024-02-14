using System;

namespace ComplexNumbers.Test
{
    public class Complex
    {
        private double re;
        private double im;

        public Complex(double re, double im)
        {
            this.re = re;
            this.im = im;
        }

        public static Complex operator +(Complex a, Complex b)
        {
            return new Complex(a.re + b.re , a.im + b.im);
        }

        public static Complex operator *(Complex a, Complex b)
        {
            return new Complex((a.re * b.re - a.im * b.im), (a.re * b.im + a.im * b.re ));
        }


        public double R
        {
            get { return re; }
            set { re = value; }
        }
        public double I
        {
            get { return im; }
            set { im = value; }
        }

        internal double Module()
        {
            return Math.Sqrt(re * re + im * im);
        }

        internal Complex Conjugate()
        {
            return new Complex(re, -im);
        }
    }
}