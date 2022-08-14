internal class Program
{
    private static void Main(string[] args)
    {
        // A (3,6,8); B (2,1,-7), -> 15.84
        // A (7,-5, 0); B (1,-1,9) -> 11.53
        void Coordinates()
        {
            Console.WriteLine();
            int x1 = Coordinate("x", "A");
            int y1 = Coordinate("y", "A");
            int z1 = Coordinate("z", "A");
            int x2 = Coordinate("x", "B");
            int y2 = Coordinate("y", "B");
            int z2 = Coordinate("z", "B");

            int Coordinate(string coorName, string pointName)
            {
                Console.Write($"Введите координаты {coorName} точки {pointName}: ");
                return Convert.ToInt16(Console.ReadLine()); // Преобразует заданное строковое представление числа в эквивалентное 16-битовое целое число без знака.
            }

            double Decision(double x1, double x2,
            double y1, double y2,
            double z1, double z2)
            {
                return Math.Sqrt(Math.Pow(x2 - x1, 2) + // Math.sqrt - Возвращает квадратный корень числа
                Math.Pow(y2 - y1, 2) + // Math. Pow – возведения числа в степень
                Math.Pow(z2 - z1, 2));
            }

            double Length = Math.Round(Decision(x1, x2, y1, y2, z1, z2), 2); // Возвращает число, округлённое к ближайшему целому.
            Console.WriteLine($"Длина отрезка {Length}");
        }
        Coordinates();
    }
}