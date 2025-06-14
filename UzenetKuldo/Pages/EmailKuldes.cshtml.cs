using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace UzenetKuldo.Pages
{
    public class EmailKuldesModel : PageModel
    {
        [BindProperty]
        public string Email { get; set; } //Ez itt a fogad� email c�me, amit megadunk

        [BindProperty]
        public string Szoveg { get; set; }

        public void OnPost()
        {
            Email ujEmail = new Email();

            ujEmail.Fogado = Email;

            ujEmail.Szoveg = Szoveg;

            ujEmail.KuldesDatuma = DateTime.Now;

            ujEmail.Kuldo = Tarhely.EmailC�m; //Be�ll�tjuk azt az email c�met, amivel bel�pt�nk

            Tarhely.ElkuldottUzenetek.Add(ujEmail);
        }
    }
}
