using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using RazorCalc.Pages;

namespace RazorCalc;


public class AddAddress : PageModel
{
    [BindProperty]
    public AddressModel Address { get; set; }

    public void OnGet()
    {

    }

    public IActionResult OnPost()
    {
        if(ModelState.IsValid == false)
        {
            return Page();
        }

        return RedirectToPage("/Index", new { City = Address.City });
    }
}