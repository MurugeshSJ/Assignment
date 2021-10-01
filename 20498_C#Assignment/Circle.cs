namespace day2
{
    class Circle
    {
        double radius;

        public void SetRadius(double radius)
        {
            this.radius = radius;
        }

        public double GetRadius()
        {
            return radius;
        }

        public double CalcDiameter()
        {
            return 2 * radius;
        }

        public double CalcArea()
        {
            return Math.PI * radius * radius;
        }
    }
    class CircleTest
    {
        public static void Main()
        {
            Circle c1 = new Circle();
            c1.SetRadius(2);

            Console.WriteLine(c1.GetRadius());
            Console.WriteLine(c1.CalcDiameter());
            Console.WriteLine(c1.CalcArea());
        }
    }
}