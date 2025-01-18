namespace LocacaoImovel
{
    internal static class Program
    {
        [STAThread]
        static void Main()
        {
            ApplicationConfiguration.Initialize();
            //Application.Run(new Form1());
            Locatario l1 = new Locatario("Maria", "12345678910", "123456789", "Masculino", Convert.ToDateTime("21/12/1986"));
        }
    }
}