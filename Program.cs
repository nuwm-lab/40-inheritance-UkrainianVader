using System;

namespace LabWork
{
    // Даний проект є шаблоном для виконання лабораторних робіт
    // з курсу "Об'єктно-орієнтоване програмування та патерни проектування"
    // Необхідно змінювати і дописувати код лише в цьому проекті
    // Відео-інструкції щодо роботи з github можна переглянути 
    // за посиланням https://www.youtube.com/@ViktorZhukovskyy/videos 

    // Клас "Куля" (сфера)
    class Sphere
    {
        protected double b1, b2, b3, R;

        public virtual void SetCoefficients(double b1, double b2, double b3, double R)
        {
            this.b1 = b1;
            this.b2 = b2;
            this.b3 = b3;
            this.R = R;
        }

        public virtual void PrintCoefficients()
        {
            Console.WriteLine($"Куля: центр=({b1}, {b2}, {b3}), радіус={R}");
        }

        public virtual double GetVolume()
        {
            return 4.0 / 3.0 * Math.PI * Math.Pow(R, 3);
        }
    }

    // Похідний клас "Еліпсоїд"
    class Ellipsoid : Sphere
    {
        private double a1, a2, a3;

        public void SetCoefficients(double b1, double b2, double b3, double a1, double a2, double a3)
        {
            this.b1 = b1;
            this.b2 = b2;
            this.b3 = b3;
            this.a1 = a1;
            this.a2 = a2;
            this.a3 = a3;
        }

        public override void PrintCoefficients()
        {
            Console.WriteLine($"Еліпсоїд: центр=({b1}, {b2}, {b3}), a1={a1}, a2={a2}, a3={a3}");
        }

        public override double GetVolume()
        {
            return 4.0 / 3.0 * Math.PI * a1 * a2 * a3;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            // Куля
            Sphere sphere = new Sphere();
            sphere.SetCoefficients(1, 2, 3, 5); // b1, b2, b3, R
            sphere.PrintCoefficients();
            Console.WriteLine($"Об'єм кулі: {sphere.GetVolume():F3}");

            // Еліпсоїд
            Ellipsoid ellipsoid = new Ellipsoid();
            ellipsoid.SetCoefficients(0, 0, 0, 2, 3, 4); // b1, b2, b3, a1, a2, a3
            ellipsoid.PrintCoefficients();
            Console.WriteLine($"Об'єм еліпсоїда: {ellipsoid.GetVolume():F3}");
        }
    }
}
