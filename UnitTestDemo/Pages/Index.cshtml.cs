using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;
using UnitTestDemo.Services;

namespace UnitTestDemo.Pages
{
    public class IndexModel : PageModel
    {
        private readonly ILogger<IndexModel> _logger;
        private readonly ICalculatorService _calculatorService;

        [BindProperty] public int Num1 { get; set; }
        [BindProperty] public int Num2 { get; set; }

        public int Result { get; set; }

        public IndexModel(ILogger<IndexModel> logger, ICalculatorService calculatorService)
        {
            _logger = logger;
            _calculatorService = calculatorService;
        }

        public void OnGet()
        {

        }

        public async Task<IActionResult> OnPost()
        {
            Result = _calculatorService.Add(Num1, Num2);
            return Page();
        }
    }
}
