namespace Test.Realization
{
    public class SumNumbers
    {
        public int Sum(List<int> input)
        {
            List<int> IntermediateList = new List<int>(); //новый список для заполнение каждого 2 нечетного числа

            int schetchik = 0;

            int Result = 0;

            foreach (int i in input) //цикл для заполнения списка
            {
                if (i % 2 != 0)
                {
                    schetchik++;

                    if (schetchik == 2)
                    {
                        IntermediateList.Add(i);
                        schetchik = 0;
                    }
                }
            }

            foreach (int i in IntermediateList) //результат сложения чисел по модулю
            {
                Result += Math.Abs(i);
            }


            return Result;
        }
    }
}
