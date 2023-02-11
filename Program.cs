namespace StringInterpolation
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DateTime now = DateTime.Now;
            Console.WriteLine("DateInterpolation");  
            Console.WriteLine($"1.{now,40:MMMM dd, yyyy}");
            Console.WriteLine($"2.{now:yyyy.MM.dd}");
            Console.WriteLine($"3.Day {now:dd} of {now:MMMM}, {now:yyyy}");
            Console.WriteLine($"4.Year:{now:yyyy},Month:{now:MM},Day:{now:dd}");
            Console.WriteLine($"5.{now,10:dddd}");
            Console.WriteLine($"6.{now,10:hh:mm tt}{now,10:dddd}");
            Console.WriteLine($"7.h:{now:hh},m:{now:mm},s:{now:ss}");
            Console.WriteLine($"8.{now:yyyy.MM.dd.hh.mm.ss}");
            var pi = Math.PI;
            Console.WriteLine();
            Console.WriteLine("PIFormating");
            Console.WriteLine($"1.{pi:c2}");
            Console.WriteLine($"2. {pi,10:n3}");

           

        }
    }
}