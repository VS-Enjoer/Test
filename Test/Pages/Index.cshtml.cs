using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Test.Services;

namespace Test.Pages
{
    public class IndexModel : PageModel
    {
        private readonly ICalculationService _calculationService;

        public IndexModel(ICalculationService calculationService)
        {
            _calculationService = calculationService;
        }

        [BindProperty]
        public string Numbers { get; set; }

        [BindProperty]
        public string Input { get; set; }

        public int? SumResult { get; private set; }
        public int[] SortedNumbers { get; private set; }
        public bool? IsPalindromeResult { get; private set; }

        public void OnGet()
        {
        }

        public void OnPostSum()
        {
            if (!string.IsNullOrEmpty(Numbers))
            {
                var numbersArray = Array.ConvertAll(Numbers.Split(','), int.Parse);
                SumResult = _calculationService.SumModule(new List<int>(numbersArray));
            }
        }

        public void OnPostSort()
        {
            var numbersArray = Array.ConvertAll(Numbers.Split(','), int.Parse);
            SortedNumbers = _calculationService.SortNumbers(numbersArray);
        }

        public void OnPostIsPalindrome()
        {
            IsPalindromeResult = _calculationService.IsPalindrome(Input);
        }
    }
}