namespace UzenetKuldo
{
    public class Email
    {
        public string Szoveg { get; set; }

        public string Kuldo { get; set; } //Ez az az email cím lesz, aki elküldi az emailt

        public string Fogado { get; set; } //Ez az az email cím lesz, aki megkapja az emailt

        public DateTime KuldesDatuma { get; set; }
    }
}
