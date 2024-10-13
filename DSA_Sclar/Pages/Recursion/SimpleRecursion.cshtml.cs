using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.Collections.Generic;

namespace DSA_Scalar.Pages.Recursion
{
    public class SimpleRecursionModel : PageModel
    {
        [BindProperty]
        public int InputNumber { get; set; }

        public List<string> RecursionResultDescending { get; set; }
        public List<string> RecursionResultAscending { get; set; }

        public void OnPost()
        {
            // Initialize the result lists
            RecursionResultDescending = new List<string>();
            RecursionResultAscending = new List<string>();

            // Call the recursive method to fill the lists
            SimpleRecursionDescending(InputNumber);
            SimpleRecursionAscending(0, InputNumber);
        }

        // Recursive method for decreasing order
        public void SimpleRecursionDescending(int n)
        {
            if (n == 0)
            {
                RecursionResultDescending.Add("Reached the base case!");
            }
            else
            {
                RecursionResultDescending.Add($"n = {n}");
                SimpleRecursionDescending(n - 1); // Recursive call
            }
        }

        // Recursive method for increasing order
        public void SimpleRecursionAscending(int current, int max)
        {
            if (current > max)
            {
                return; // Stop when current exceeds max
            }
            else
            {
                RecursionResultAscending.Add($"n = {current}");
                SimpleRecursionAscending(current + 1, max); // Recursive call
            }
        }
    }
}
