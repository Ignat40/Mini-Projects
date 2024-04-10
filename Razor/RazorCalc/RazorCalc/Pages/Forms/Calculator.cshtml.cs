using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using RazorCalc.Pages;

namespace RazorCalc; 

public class Calculator : PageModel
{
    [BindProperty]
    public CalculatorModel Calc { get; set; }

    public void OnGet()
    {

    }

    public double Addition()
    {
        return 0;
    }
}