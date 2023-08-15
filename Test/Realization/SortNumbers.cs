namespace Test.Realization
{
    public class SortNumbers
    {
        public int[] Sort(int[] input)
        {
            int[] CopyArray = (int[])input.Clone(); // здесь мог сослаться на входящий массив в метод, но не стал, может входной массив input для чего то пригодился бы

            for (int i = 0; i < CopyArray.Length; i++)             // пузырьковая сортировка массива
            {
                for (int j = 0; j < CopyArray.Length - i - 1; j++)
                {
                    if (CopyArray[j] > CopyArray[j + 1])
                    {
                        int NextValue = CopyArray[j];
                        CopyArray[j] = CopyArray[j + 1];
                        CopyArray[j + 1] = NextValue;
                    }
                }
            }

            return CopyArray;
        }

    }
}
