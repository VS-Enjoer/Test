using Test.Realization;

namespace Test.Services
{
    public interface ICalculationService
    {
        int SumModule(List<int> input);
        int[] SortNumbers(int[] input);
        bool IsPalindrome(string input);
    }
    public class CalculationService : ICalculationService
    {
        public int SumModule(List<int> input)
        {
            SumNumbers sumNumbers = new SumNumbers();
            return sumNumbers.Sum(input);
        }

        public int[] SortNumbers(int[] input)
        {
            SortNumbers sortNumbers = new SortNumbers();
            return sortNumbers.Sort(input);
        }

        public bool IsPalindrome(string input)
        {
            Palindrome palindrome = new Palindrome();
            return palindrome.IsPalindrome(input);
        }
    }
}
