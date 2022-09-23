namespace fifteen
{
    class Mechanic
    {
        public static void Fill(ref int[,] field)
        {
            var rnd = new Random();
            int[] values = new int[15] { 1, 2, 3, 4, 5, 6, 7, 8, 9,
                                         10, 11, 12, 13, 14, 15 };
            values = values.OrderBy(x => rnd.Next()).ToArray();

            int counter = 0;
            for (int i = 0; i < field.GetLength(0); ++i)
                for (int j = 0; j < field.GetLength(1); ++j)
                    if (counter < 15)
                        field[i, j] = values[counter++];

            field[field.GetLength(0) - 1, field.GetLength(1) - 1] = 0;
        }

        public static bool CheckField(in int[,] field)
        {
            var ideal = new int[,] { { 1, 2, 3, 4 },
                                 { 5, 6, 7, 8 },
                                 { 9, 10, 11, 12 },
                                 { 13, 14, 15, 0 } };

            if (field.GetLength(0) != ideal.GetLength(0)) return false;
            if (field.GetLength(1) != ideal.GetLength(1)) return false;

            for (int i = 0; i < field.GetLength(0); i++)
                for (int j = 0; j < field.GetLength(1); j++)
                    if (field[i, j] != ideal[i, j]) return false;

            return true;
        }

        public static bool ChangeUp(ref int[,] field, int zeroI, int zeroJ)
        {
            if (zeroI - 1 < 0)
                return false;
            field[zeroI, zeroJ] = field[zeroI - 1, zeroJ];
            field[zeroI - 1, zeroJ] = 0;
            return true;
        }

        public static bool ChangeDown(ref int[,] field, int zeroI, int zeroJ)
        {
            if (zeroI + 1 >= field.GetLength(0))
                return false;
            field[zeroI, zeroJ] = field[zeroI + 1, zeroJ];
            field[zeroI + 1, zeroJ] = 0;
            return true;
        }

        public static bool ChangeLeft(ref int[,] field, int zeroI, int zeroJ)
        {
            if (zeroJ - 1 < 0)
                return false;
            field[zeroI, zeroJ] = field[zeroI, zeroJ - 1];
            field[zeroI, zeroJ - 1] = 0;
            return true;
        }

        public static bool ChangeRight(ref int[,] field, int zeroI, int zeroJ)
        {
            if (zeroJ + 1 >= field.GetLength(1))
                return false;
            field[zeroI, zeroJ] = field[zeroI, zeroJ + 1];
            field[zeroI, zeroJ + 1] = 0;
            return true;
        }
    }
}
