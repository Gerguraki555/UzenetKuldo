using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace UzenetKuldo.Pages
{
    public class EmailKuldesModel : PageModel
    {
        [BindProperty]
        public string Email { get; set; } //Ez itt a fogadó email címe, amit megadunk

        [BindProperty]
        public string Szoveg { get; set; }

        public void OnPost()
        {
            Email ujEmail = new Email();

            ujEmail.Fogado = Email;

            ujEmail.Szoveg = Szoveg;

            ujEmail.KuldesDatuma = DateTime.Now;

            ujEmail.Kuldo = Tarhely.EmailCím; //Beállítjuk azt az email címet, amivel beléptünk

            Tarhely.ElkuldottUzenetek.Add(ujEmail);
        }
    }
}
