namespace fifteen
{
    class game
    {
        public static void Main()
        {
            int[,] field = new int[4, 4];
            Mechanic.Fill(ref field);
            int zeroI = 3;
            int zeroJ = 3;
            int countOfMove = 0;
            UI.Intro();

            ConsoleKeyInfo action;
            do
            {
                Console.Clear();
                UI.Print(field, zeroI, zeroJ);
                Console.WriteLine();
                action = Console.ReadKey();
                switch (action.Key)
                {
                    case ConsoleKey.W:
                        if (Mechanic.ChangeUp(ref field, zeroI, zeroJ))
                            --zeroI;
                        else
                            UI.OutOfBoundsMessage("Выход за пределы верхней границы");
                        break;

                    case ConsoleKey.A:
                        if (Mechanic.ChangeLeft(ref field, zeroI, zeroJ))
                            --zeroJ;
                        else
                            UI.OutOfBoundsMessage("Выход за пределы левой границы");

                        break;

                    case ConsoleKey.S:
                        if (Mechanic.ChangeDown(ref field, zeroI, zeroJ))
                            ++zeroI;
                        else
                            UI.OutOfBoundsMessage("Выход за пределы нижней границы");
                        break;

                    case ConsoleKey.D:
                        if (Mechanic.ChangeRight(ref field, zeroI, zeroJ))
                            ++zeroJ;
                        else
                            UI.OutOfBoundsMessage("Выход за пределы правой границы");
                        break;
                    default:
                        UI.InvalidActionMessage();
                        break;
                }
                countOfMove++;
            } while (!Mechanic.CheckField(field));
            Console.Clear();
            UI.Print(field, zeroI, zeroJ);
            Console.WriteLine("\nПоздравляю! Вы прошли игру.");
            Console.WriteLine($"\nКоличество выполненных ходов: {countOfMove}");
        }
    }
}