class Game
{
    public void factorial(int number)
    {
        int result = 1;

        for (int i = 1; i <= number; i++)
        {
            result *= i;
        }

        Console.WriteLine(result);
    }

    public void fib(int number)
    {
        int prev = 0;
        int next = 1;

        for (int i = 1; i <= number; i++)
        {
            int temp = prev;
            prev = next;
            next += temp;
        }

        Console.WriteLine(prev);
    }

    static void Main(string[] args)
    {
        Console.WriteLine("""
            Добро пожаловать в игру! Чтобы начать выберите один из вариантов:
            Чтобы посчитать факториал введите 'факториал'
            Чтобы узнать число из ряда Фибоначчи введите 'фибоначчи'
            """);

        Game game = new Game();
        try
        {
            switch (Console.ReadLine().ToLower().Trim())
            {
                case "факториал":
                    Console.WriteLine("Введите искомое число");
                    game.factorial(int.Parse(Console.ReadLine()));
                    break;

                case "фибоначчи":
                    Console.WriteLine("Введите искомое число");
                    game.fib(int.Parse(Console.ReadLine()));
                    break;

                default:
                    Console.WriteLine("Некорректное имя игры, пожалуйста, введите либо:\n'факториал', либо 'фибоначчи' (без кавычек)");
                    break;
            }
        }

        catch (Exception) 
        { 
            Console.WriteLine("Введен некорректный аргумент для вычисления!\nПожалуйста, вводите только числа");
        }
    }
}
