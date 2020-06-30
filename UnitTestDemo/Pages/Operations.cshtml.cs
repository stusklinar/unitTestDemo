using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace UnitTestDemo.Pages
{
    public class OperationsModel : PageModel
    {
        [BindProperty] public int Num1 { get; set; }
        [BindProperty] public int Num2 { get; set; }

        public int Result { get; set; }

        public void OnGet()
        {

        }
    }
}