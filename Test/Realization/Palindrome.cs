namespace Test.Realization
{
    public class Palindrome
    {
        public bool IsPalindrome(string input)
        {
            input = input.ToLower().Replace(" ", "");  //делаем нижний регистр и удаляем пробелы, чтобы не было проблем при проверке

            for (int i = 0; i < input.Length / 2; i++)
            {
                if (input[i] != input[input.Length - i - 1]) // сравниваю элементы (первый с последним, второй с предпоследним и т.д.)
                {
                    return false;
                }
            }

            return true;
        }
    }
}
