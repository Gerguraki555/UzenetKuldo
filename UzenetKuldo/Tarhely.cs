namespace UzenetKuldo
{
    public static class Tarhely
    {
        public static string EmailCím { get; set; }

        //Így hozunk létre listát a tárhelyhez
        public static List<Email> ElkuldottUzenetek { get; set; } = new List<Email>();
    }
}
