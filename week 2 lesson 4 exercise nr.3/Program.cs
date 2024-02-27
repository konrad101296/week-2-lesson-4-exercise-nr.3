Console.WriteLine("Enter the lenght of the rectangle:");
double lenght = double.Parse(Console.ReadLine());
Console.WriteLine("Enter the width of the rectangle");
double width = double.Parse(Console.ReadLine());

double pow1 = Math.Pow(lenght, 2);
double pow2 = Math.Pow(width, 2);
double sqrt = pow1 + pow2;
sqrt = Math.Sqrt(sqrt);
Console.WriteLine($"The diagonal is: {sqrt}");