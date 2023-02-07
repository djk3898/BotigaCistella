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

        Console.WriteLine("Indica\n1.\t2.\t3.\t4.");
        int seleccio = int.Parse(Console.ReadLine());

        switch (seleccio)
        {
            case 1:
                Mostrar(nElementsBotiga, productesBotiga, preus);
                break;
            case 2:
                Console.WriteLine("abans: " + espais);
                espais = AmpliarTenda(espais);
                Console.WriteLine("després: " + espais);
                break;
            case 3:
                Console.WriteLine("MODIFICA PREU");
                Console.Write("Indica el producte: ");
                string producte = Console.ReadLine();
                Console.Write("Indica el nou preu: ");
                int preu = int.Parse(Console.ReadLine());
                ModificarPreu(producte, preu, productesBotiga, preus, nElementsBotiga);
                break;
            case 4:
                Console.WriteLine("MODIFICA PRODUCTE");
                Console.Write("Indica el producte: ");
                producte = Console.ReadLine();
                Console.Write("Indica el nou producte: ");
                string prodNou = Console.ReadLine();
                ModificarProducte(producte, prodNou, productesBotiga, nElementsBotiga);
                break;
        }
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
    //modificar preu
    public static void ModificarPreu(string producte, double preu, string[]productes, double[]preus, int nElements)
    {
        //troba la posicio a partir del producte
        int posicio = -1;
        for(int i = 0; i < nElements; i++) 
        {
            if (productes[i] == producte)
                posicio = i;
        }
        if (posicio > 0)  //si troba el producte
        {
            //modifica el preu del producte
            preus[posicio] = preu;
            Console.WriteLine("Preu modificat correctament!!");
            Thread.Sleep(3000);
        }
        else  //si no troba el producte
        {
            Console.WriteLine("Producte no trobat...");
            Thread.Sleep(3000);
        }
    }
    //modificar producte
    public static void ModificarProducte(string prodAntic, string nom, string[] productes, int nElements)
    {
        //troba la posicio a partir del producte
        bool trobat = false;
        for (int i = 0; i < nElements; i++)
        {
            if (productes[i] == prodAntic)
            {
                //si troba el producte li canvia el nom
                trobat = true;
                productes[i] = nom;
                Console.WriteLine("Producte modificat correctament!!");
                Thread.Sleep(3000);
            }
        }
        if(!trobat)  //si no troba el producte
        {
            Console.WriteLine("Producte no trobat...");
            Thread.Sleep(3000);
        }
    }
} 