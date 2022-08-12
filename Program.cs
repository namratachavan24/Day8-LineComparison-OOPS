
namespace LineComparisionUsingNonStatic
{
    class Public
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Line Comparison Computation Problem using OOP Concept.");
            Console.WriteLine("\n-----*--------*--------*---------*----------*---------*--------");
            Console.WriteLine("\n");
            Console.WriteLine("Enter x coordinate of point1");
            int x1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter y coordinate of point1");
            int y1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter x coordinate of point2");
            int x2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter y coordinate of point2");
            int y2 = Convert.ToInt32(Console.ReadLine());

            CartesianSystemNonStatic csns = new CartesianSystemNonStatic();
            csns.calculateLength(x1, y1, x2, y2);
            Console.WriteLine("\n");

            Console.WriteLine("To Check Both Line Equals or not by Equals method");
            Console.WriteLine("\n-----*--------*--------*---------*--------*-----");
            Console.WriteLine("\n");
            Console.WriteLine("Enter start and end points of First line: ");
            int a1 = Convert.ToInt32(Console.ReadLine());
            int b1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter start and end points of Second line: ");
            int a2 = Convert.ToInt32(Console.ReadLine());
            int b2 = Convert.ToInt32(Console.ReadLine());
            

            EqualityOfLength length = new EqualityOfLength();
            length.CheckEqualityOfLength(a1, b1, a2, b2);
            Console.WriteLine("\n");


            Console.WriteLine("To Compare Both Line by CompareTo method");
            Console.WriteLine("\n-----*--------*--------*--------*-----");
            Console.WriteLine("\n");
            Console.WriteLine("Please Enter the first line coordinates");
            int l1 = Convert.ToInt32(Console.ReadLine());
            int m1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter start and end points of Second line: ");
            int l2 = Convert.ToInt32(Console.ReadLine());
            int m2 = Convert.ToInt32(Console.ReadLine());
            

            CompareTwoLines com = new CompareTwoLines();
            com.CheckTwoLines(l1, m1, l2, m2);

            LineCompUC4 lineComp = new LineCompUC4();
            lineComp.check_equality();
            lineComp.Comparelines();

        }
    }
}