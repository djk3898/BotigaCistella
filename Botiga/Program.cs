internal class Program
{
    private static void Main(string[] args)
    {
        //variables Botiga
        string[] productesBotiga = {"Pera", "Yogur", "Pastanaga", "Patata", "Melón"};
        double[] preus = {10, 12, 14, 15, 25, 132, 2, 3};
        int nElementsBotiga = 3;

        //variables Cistella
        string[] productesCistella;
        int[] quantitat;
        int nElementsCistella;
        double diners;

        Mostrar(nElementsBotiga, productesBotiga, preus);
    }
    //afegir productes
    public static void AfegirProducte(string producte, double preu)
    {

    }

    //mostrar els productes de la botiga
    public static void Mostrar(int nElem, string[] productes, double[] preus)
    {
        for (int i = 0; i < nElem; i++)
        {
            Console.WriteLine("-----------------------------------------");
            Console.WriteLine(productes[i] + "\t" + preus[i] + "€");
        }
        Console.WriteLine("-----------------------------------------");
    }
}