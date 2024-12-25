namespace Problema_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Mamifer tigru = new Mamifer();
            tigru.Nume = "Tigru";
            tigru.CuloareBlana = "Roscat-Alba cu elemente negre";

            Pasare bufnita = new Pasare();
            bufnita.Nume = "Bufnita";
            bufnita.TipZbor = "Silentios";

            Papagal papagal = new Papagal();
            papagal.Nume = "Perus";
            papagal.TipZbor = "Rapid si agil";
            papagal.Vocabular = 12;

            tigru.AfisareDetalii();
            bufnita.AfisareDetalii();
            papagal.AfisareDetalii();
        }
    }
}
