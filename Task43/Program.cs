System.Console.WriteLine("Enter k1, b1, k2, b2:");
double k1 = Convert.ToDouble(Console.ReadLine());
double b1 = Convert.ToDouble(Console.ReadLine());
double k2 = Convert.ToDouble(Console.ReadLine());
double b2 = Convert.ToDouble(Console.ReadLine());
FindPointOfIntersection (k1, b1, k2, b2);
void FindPointOfIntersection(double k1, double b1, double k2, double b2)
{
    double x = (b2 - b1) / (k1 - k2);
    double y = k1 * x + b1;
    x = Math.Round(x, 3);
    y = Math.Round(y, 3);
    System.Console.WriteLine($"Two lines (y = k1 * x + b1) and (y = k2 * x + b2) intersect at [{x}, {y}]");
}