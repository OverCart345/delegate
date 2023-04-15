namespace delegat
{


    delegate double Maths(double x, double y, double z);
    internal class Program
    {

        static void Main(string[] args)
        {
            Maths summ = (x,y,z) => x + y + z;
            Maths umn = (x, y, z) => x * y * z;
            Maths sred = (x, y, z) => (x + y + z)/3;
            Maths maxvalue = (x, y, z) => Math.Max(Math.Max(x, y), z);
            Maths minvalue = (x, y, z) => Math.Min(Math.Min(x, y), z);

            Console.WriteLine("Введите 3 значения");
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            int c = int.Parse(Console.ReadLine());

            Console.WriteLine("Сумма - " + summ(a,b,c));
            Console.WriteLine("Умножение - " + umn(a, b, c));
            Console.WriteLine("среднее значение - " + sred(a, b, c));
            Console.WriteLine("Максимальное значение - " + maxvalue(a, b, c));
            Console.WriteLine("Минимальное значение - " + minvalue(a, b, c));

            Console.ReadKey();
        }
    }
}
