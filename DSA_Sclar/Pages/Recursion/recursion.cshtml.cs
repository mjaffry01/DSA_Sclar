using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.Collections.Generic;

namespace DSA_Scalar.Pages.Recursion
{
    public class recursionModel : PageModel
    {
        [BindProperty]
        public int InputNumber1 { get; set; }

        [BindProperty]
        public int InputNumber2 { get; set; }

        public List<string> RecursionSteps { get; set; }

        public int RecursionResult { get; set; }

        public void OnPost()
        {
            RecursionSteps = new List<string>();
            RecursionResult = Foo(InputNumber1, InputNumber2);
        }

        // Recursive method Bar
        public int Bar(int x, int y)
        {
            if (y == 0)
            {
                RecursionSteps.Add($"Bar({x}, {y}) = 0");
                return 0;
            }
            int result = x + Bar(x, y - 1);
            RecursionSteps.Add($"Bar({x}, {y}) = {x} + Bar({x}, {y - 1}) = {result}");
            return result;
        }

        // Recursive method Foo
        public int Foo(int x, int y)
        {
            if (y == 0)
            {
                RecursionSteps.Add($"Foo({x}, {y}) = 1");
                return 1;
            }
            int result = Bar(x, Foo(x, y - 1));
            RecursionSteps.Add($"Foo({x}, {y}) = Bar({x}, Foo({x}, {y - 1})) = {result}");
            return result;
        }
    }
}
