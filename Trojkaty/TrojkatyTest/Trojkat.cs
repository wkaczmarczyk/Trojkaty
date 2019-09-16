using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrojkatyTest
{
    class Trojkat
    {
        //fields (dane)
        private decimal a;
        public double A
        { get { return (double)a; }
            set {
                if (!jestWarunekTrojkata((decimal)value, b, c))
                    throw new ArgumentException("nie można zmienić boku A)");
                a = (decimal)value; }
        }
        private decimal b;
        public double B
        {
            get => (double)b;
            set {
                if (!jestWarunekTrojkata(a, (decimal)value, c))
                    throw new ArgumentException("nie można zmienić boku B)");
                b = (decimal)value; }
        }

        private decimal c;
        public double C

        {
            get => (double)c;
            set {
                if (!jestWarunekTrojkata(a, b, (decimal)value))
                    throw new ArgumentException("nie można zmienić boku C)");
                c = (decimal)value; }
        }
        private bool jestWarunekTrojkata(decimal x, decimal y, decimal z)
        {
            return x + y > z && x + z > y && z + y > x;
        }

        //konstruktory (proces wytwarzania trojkata)
        public Trojkat(double a, double b, double c)
        {
            if (a <= 0 || b <= 0 || c <= 0)
                throw new ArgumentException("Arguent usi być dodatni");
            if (!jestWarunekTrojkata((decimal)a, (decimal)b, (decimal)c))

                throw new ArgumentException("Nie spełniony warunek trójkąta");
            this.a = (decimal)a;
            this.b = (decimal)b;
            this.c = (decimal)c;
        }

        public Trojkat()
        {
            a = b = c = 1;
        }

        //przeciążenie ToString (przeonwertuje do postaci testowej)


        public override string ToString()
        {
            return $"Trojkat:a={a} b={b} c={c}";
        }

        //methods
        public double Obwod()
        {
            return (double)(a + b + c);
        }

        public double Obwód
        {
            get { return (double)(a + b + c); }

        }
        public double Pole
        {
            get
            {
                decimal p = (decimal)(0.5 * Obwód);
                return Math.Sqrt((double)(p * (p - a) * (p - b) * (p - c)));
            }
        }

        public bool jest prostokatny
        {
            get
            {
            throw new NotImplementedException();
            }

        }
           
    }

}
