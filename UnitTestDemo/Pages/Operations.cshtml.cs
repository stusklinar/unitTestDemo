using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using UnitTestDemo.Services;

namespace UnitTestDemo.Pages
{
    public class OperationsModel : PageModel
    {
        private readonly ICalculatorService _calculatorService;

        public OperationsModel(ICalculatorService calculatorService)
        {
            _calculatorService = calculatorService;
        }

        [BindProperty] public int Num1 { get; set; }
        [BindProperty] public int Num2 { get; set; }
        [BindProperty] public CalculatorOperation Operation { get; set; }

        public int Result { get; set; }

        public void OnGet()
        {

        }

        public async Task<IActionResult> OnPost()
        {
            Result = _calculatorService.Operation(Num1, Num2, Operation);
            return Page();
        }
    }
}