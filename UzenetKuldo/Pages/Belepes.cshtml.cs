using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace UzenetKuldo.Pages
{
    public class BelepesModel : PageModel
    {
        [BindProperty]
        public string Email { get; set; }

        public void OnPost()
        {
            if(Email.Length <= 200)
            {
                Tarhely.EmailC�m = Email;
            }
            else //Ha t�l hossz� email c�met adnak meg akkor ez fut le.
            {
                throw new Exception("G�z van. T�l hossz� email c�met adt�l meg.");
            }
            
        }
    }
}
