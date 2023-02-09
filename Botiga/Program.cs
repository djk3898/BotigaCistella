﻿internal class Program
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

        int seleccio = -1;

        do
        {
            Console.Clear();
            Menu();
            //Pinta(">", 2, 8);
            Console.SetCursorPosition(0,1);
            seleccio = int.Parse(Console.ReadLine());
            Console.Clear();
            switch (seleccio)
            {
                case 1:
                    Mostrar(nElementsBotiga, productesBotiga, preus);
                    Console.WriteLine("\nPrem enter per tornat al menú");
                    Console.ReadLine();
                    break;
                case 2:
                    Console.WriteLine("abans: " + espais);
                    espais = AmpliarTenda(espais);
                    Console.WriteLine("després: " + espais);
                    Console.WriteLine("\nPrem enter per tornat al menú");
                    Console.ReadLine();
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
                case 12:
                    ToString(nElementsBotiga, productesBotiga, preus);
                    Console.WriteLine("\nPrem enter per tornat al menú");
                    Console.ReadLine();
                    break;
                case -1:
                    break;
            }
        } while (seleccio != -1);
    }
    //menu
    public static void Pinta(string line, int x, int y)
    {
        Console.SetCursorPosition(x, y);
        Console.Write(line);
    }
    public static void Menu()
    {
        //menú
        for (int i = 0; i != 11; i++)
        {
            //titulo
            Pinta("*********************", 4, 4);
            Pinta("*       BOTIGA      *", 4, 5);
            Pinta("*********************", 4, 6);
            //menú
            Pinta("1. Mostrar Productes", 4, 8);
            Pinta("2. Ampliar Botiga", 4, 9);
            Pinta("3. Modificar Preu", 4, 10);
            Pinta("4. Modificar Producte", 4, 11);

            Pinta("12. ToString", 4, 12);
            Pinta("-1. Sortir", 4, 13);
        }

    }
    //afegir productes
    public static void AfegirProducte(string producte, double preu)
    {
        int ampliar, i = 0;
        char resposta = ' ';
        Console.WriteLine("Quant productes vol afegir?");
        ampliar = Convert.ToInt32(Console.ReadLine);
        AmpliarTenda(ampliar);
        do
        {
            Console.WriteLine("Producte que vols afegir");
            producte = Console.ReadLine();
            Console.WriteLine("Preu del producte");
            preu = Convert.ToDouble(Console.ReadLine());
            Console.Clear();
        }
        while (i < ampliar);
    }
    //afegirProducte
    public static void AfegirProducte(string[] productes, double[] preu)
    {
        int i = productes.Length, produc;

        Console.WriteLine("Quants productes vols afegir?");
        produc = Convert.ToInt32(Console.ReadLine());
        while (i < productes.Length + produc)
        {
            Console.WriteLine("Escriu producte");
            productes[i] = Console.ReadLine();
            Console.WriteLine("Escriu el preu");
            preu[i] = Convert.ToDouble(Console.ReadLine());
            i++;
        }
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
        Console.WriteLine("               PRODUCTES");
        for (int i = 0; i < nElem; i++)
        {
            Console.WriteLine("-----------------------------------------");
            Console.WriteLine(productes[i] + "\t" + preus[i] + "€");
        }
        Console.WriteLine("-----------------------------------------");
    }
    public static void ToString(int nElem, string[] productes, double[] preus)
    {
        Console.WriteLine("               PRODUCTES");
        for (int i = 0; i < nElem; i++)
        {
            Console.WriteLine("-----------------------------------------");
            Console.WriteLine(productes[i] + "\t" + preus[i] + "€");
        }
        Console.WriteLine("-----------------------------------------");
        Console.WriteLine("TOTAL: " + nElem + "\tEspais disponibles: " + (productes.Length - nElem));
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
    public static void ordernarProducte()
    {

    }

    //comprova producte
    public static bool ComprovaProducte(string producte, string[]productes, int nElem)
    {
        bool trobat = false;
        for(int i = 0; i < nElem - 1; i++)
        {
            if (productes[i] == producte)
                trobat = true;
        }
        return trobat;
    }
    //comprar productes
    public static bool ComprarProducte(string producte, int quantitat, string[]cistella, int nElements, int[]quantitatCistella)
    {
        bool comprat = false;
        //comprova producte
        if (ComprovaProducte(producte, cistella, nElements))
        {

            comprat = true;
        }
        else
            Console.WriteLine($"No hi ha {producte} a la botiga.");
        return comprat;
    }
    //mostrar tiquet

} 