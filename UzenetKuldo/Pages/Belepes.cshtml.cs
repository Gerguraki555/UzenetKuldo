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
                Tarhely.EmailCím = Email;
            }
            else //Ha túl hosszú email címet adnak meg akkor ez fut le.
            {
                throw new Exception("Gáz van. Túl hosszú email címet adtál meg.");
            }
            
        }
    }
}
