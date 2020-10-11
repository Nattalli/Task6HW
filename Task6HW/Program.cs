using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Task6HW
{
    public class Triangle
    {
        public double FirstSide, SecondSide, Angle;

        public Triangle() { }
        public Triangle(double a, double b, double c)
        {
            FirstSide = a;
            SecondSide = b;
            Angle = c;
        }
        public bool IsEquality()
        {
            return FirstSide == SecondSide && Angle == 60;
        }
        public bool IsIsosceles()
        {
            return FirstSide == SecondSide && Angle != 60;
        }
        public double GetThirdSide()
        {
            double ThirdSide = Math.Sqrt(Math.Pow(FirstSide, 2) + Math.Pow(SecondSide, 2) - 2 * FirstSide * SecondSide * Math.Cos(Angle));
            return ThirdSide;
        }
        virtual public double Perimeter()
        {
            return FirstSide + SecondSide + GetThirdSide();
        }
        virtual public double Area()
        {
            double p = 0.5 * Perimeter();
            return Math.Sqrt(p * (p - FirstSide) * (p - SecondSide) * (p - GetThirdSide()));
        }
    }

    public class EqulibriumTriangle : Triangle
    {
        virtual public double EqulibriumTrianglePerimeter()
        {
            return FirstSide * 3;
        }
        virtual public double EqulibriumTriangleArea()
        {
            return (FirstSide * FirstSide * Math.Sqrt(3)) / 4;
        }
    }
    public class IsoscelesTriangle : Triangle
    {
        virtual public double IsoscelesTrianglePerimeter()
        {
            return FirstSide * 2 + GetThirdSide();
        }
        virtual public double IsoscelesTriangleArea()
        {
            return (1 / 2) * GetThirdSide() * Math.Sqrt(FirstSide * FirstSide - (1 / 4) * SecondSide * SecondSide);
        }
    }
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
        }
    }
}
