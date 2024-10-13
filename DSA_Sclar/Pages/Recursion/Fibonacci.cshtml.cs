using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.Security.Cryptography.X509Certificates;

namespace DSA_Scalar.Pages.Recursion
{
    public class FibonacciModel : PageModel
    {
        [BindProperty]
        public int? InputNumber { get; set; }
        public int? result { get; set; }

        public void OnGet()
        {

        }

        public void OnPost() 
        {
            if (InputNumber == null || InputNumber < 0)
            {
                result = null;
            }
            else
            {
                result = CalculateFibonacci(InputNumber.Value);
            }

        }


        int CalculateFibonacci(int inputNumber)
        {
            if (inputNumber == 0) return 0;
            if (inputNumber == 1) return 1;

            return CalculateFibonacci(inputNumber - 1) + CalculateFibonacci(inputNumber - 2);
        }
            
    }
}
