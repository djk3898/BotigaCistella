internal class Program
{
    private static void Main(string[] args)
    {
        //variables Botiga
        int nElementsBotiga = 1, espais = 1;
        string[] productesBotiga = new string[espais];
        double[] preus = new double[espais];

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
    //ampliar tenda
    public static int AmpliarTenda(int total)
    {
        Console.WriteLine("Quants espais vols afegir a la tenda?");
        int num = int.Parse(Console.ReadLine());
        total += num;
        return total;
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