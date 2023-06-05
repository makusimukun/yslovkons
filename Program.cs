Console.Write("Введите коэффициент a: ");
double a = double.Parse(Console.ReadLine());
Console.Write("Введите коэффициент b: ");
double b = double.Parse(Console.ReadLine());
Console.Write("Введите коэффициент c: ");
double c = double.Parse(Console.ReadLine());
double discriminant = Math.Pow(b, 2) - 4 * a * c;
if (discriminant < 0)
{
    Console.WriteLine("Уравнение не имеет действительных корней.");
}
else if (discriminant == 0)
{
    double root = -b / (2 * a);
    Console.WriteLine("Уравнение имеет один корень: x={0}", root);
}
else
{
    double root1 = (-b + Math.Sqrt(discriminant)) / (2 * a);
    double root2 = (-b - Math.Sqrt(discriminant)) / (2 * a);
    Console.WriteLine("Уравнение имеет два корня: x1={0}, x2={1}", root1, root2);
}