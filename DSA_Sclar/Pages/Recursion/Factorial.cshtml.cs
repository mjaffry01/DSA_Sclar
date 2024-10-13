using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace DSA_Scalar.Pages.Recursion
{
    public class FactorialModel : PageModel
    {
        [BindProperty]
        public int? InputNumber { get; set; }

        public long? Result { get; set; }
        public string ErrorMessage { get; set; }

        public void OnPost()
        {
            if (InputNumber == null || InputNumber < 0)
            {
                ErrorMessage = "Please enter a valid non-negative integer.";
                Result = null;
            }
            else if (InputNumber > 20)
            {
                // Restricting to 20 because factorials above 20 will cause long overflow
                ErrorMessage = "Input is too large. Please enter a number less than or equal to 20.";
                Result = null;
            }
            else
            {
                Result = CalculateFactorial(InputNumber.Value);
                ErrorMessage = null;
            }
        }

        private long CalculateFactorial(int n)
        {
            if (n == 0 || n == 1)
            {
                return 1;
            }
            return n * CalculateFactorial(n - 1);
        }
    }
}
