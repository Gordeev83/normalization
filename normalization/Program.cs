namespace normalization
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите начало диапазона:");
            int start = int.Parse(Console.ReadLine());

            Console.WriteLine("Введите конец диапазона:");
            int end = int.Parse(Console.ReadLine());

            // Нормализация границ диапазона
            if (start > end)
            {
                int temp = start;
                start = end;
                end = temp;
            }

            Console.WriteLine($"Четные числа в диапазоне от {start} до {end}:");

            for (int i = start; i <= end; i++)
            {
                if (i % 2 == 0)
                {
                    Console.WriteLine(i);
                }
            }
        }
    }
}
