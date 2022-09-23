namespace fifteen
{
    class UI
    {
        public static void Intro()
        {
            Console.WriteLine("пустое поле обозначено за 0, для перестановки используйте клавиши:");
            Console.WriteLine("W - (перестановка с верхним числом");
            Console.WriteLine("A - (перестановка с левым числом");
            Console.WriteLine("S - (перестановка с нижним числом");
            Console.WriteLine("D - (перестановка с правым числом");
            Console.WriteLine("\n\nДля начала игры нажмите ENTER");
            Console.ReadLine();
            Console.Clear();
        }

        public static void OutOfBoundsMessage(string message)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine(message);
            Console.ForegroundColor = ConsoleColor.White;
            Console.ReadLine();
        }

        public static void InvalidActionMessage()
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("\nInvalid action");
            Console.ForegroundColor = ConsoleColor.White;
            Console.ReadLine();
        }

        public static void Print(in int[,] field, int zeroI, int zeroJ)
        {
            for (int i = 0; i < field.GetLength(0); ++i)
            {
                for (int j = 0; j < field.GetLength(1); ++j)
                {
                    if (i == zeroI && j == zeroJ)
                    {

                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.Write(field[i, j] + "\t");
                        Console.ForegroundColor = ConsoleColor.White;
                    }
                    else
                        Console.Write(field[i, j] + "\t");
                }
                Console.WriteLine();
            }
        }
    }
}
