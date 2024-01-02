using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace RazorPagesPratica.Pages
{
    public class IndexModel : PageModel
    {
        public string Title { get; set; }

        public void OnGet()
        {
            Title = "My frist app, from index model";
        }
    }
}
