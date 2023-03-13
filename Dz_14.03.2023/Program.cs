// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");


//Korrutustabel väljata ekraanile sellisel kujul:

{
    // Esimene rida
    Console.Write("    ");
            for (int i = 1; i <= 10; i++)
            {
                Console.Write("{0,4}", i);
            }
            Console.WriteLine();

            // Joon
            Console.Write("    ");
            for (int i = 1; i <= 10; i++)
            {
                Console.Write("____");
            }
            Console.WriteLine();

            // Tabeli sisu
            for (int i = 1; i <= 10; i++)
            {
                Console.Write("{0,2} |", i);
                for (int j = 1; j <= 10; j++)
                {
                    Console.Write("{0,4}", i * j);
                }
                Console.WriteLine();
            }

            Console.ReadLine();
        }
    

//Küsi kasutajalt 4 arvu ning väljasta nendest koostatud suurim neliarvuline arv

{
    Console.WriteLine("Sisesta 4 arvu:");

            int[] arvud = new int[4];

            for (int i = 0; i < 4; i++)
            {
                arvud[i] = int.Parse(Console.ReadLine());
            }

            Array.Sort(arvud);
            Array.Reverse(arvud);

            int suurimNeliArvulineArv = arvud[0] * 1000 + arvud[1] * 100 + arvud[2] * 10 + arvud[3];

            Console.WriteLine("Suurim neliarvuline arv on " + suurimNeliArvulineArv + ".");

            Console.ReadLine();
        }
    

// Mis arv mõtles välja arvuti? Kasuta vähemalt 5 katset, et seda teada.

{
    int paariskogus = 0;
            int paaritukogus = 0;

            Random random = new Random();

            for (int i = 0; i < 5; i++)
            {
                int arv = random.Next(1, 101);

                if (arv % 2 == 0)
                {
                    paariskogus++;
                }
                else
                {
                    paaritukogus++;
                }
            }

            if (paariskogus > paaritukogus)
            {
                Console.WriteLine("Arvuti genereerib peamiselt paarisarve.");
            }
            else if (paaritukogus > paariskogus)
            {
                Console.WriteLine("Arvuti genereerib peamiselt paarituid arve.");
            }
            else
            {
                Console.WriteLine("Arvuti genereerib sama palju paaris- kui paarituid arve.");
            }

            Console.ReadLine();
        }


//Küsi kasutajalt viis arvu, salvesta neid massiivi ning väljasta nende summa, aritmeetiline keskmine ja korrutis

{
    int[] arvud = new int[5];

        for (int i = 0; i < 5; i++)
        {
            Console.Write($"Sisesta {i + 1}. arv: ");
            arvud[i] = int.Parse(Console.ReadLine());
        }

        int summa = 0;
        int korrutis = 1;

        foreach (int arv in arvud)
        {
            summa += arv;
            korrutis *= arv;
        }

        double keskmine = (double)summa / arvud.Length;

        Console.WriteLine($"Arvude summa: {summa}");
        Console.WriteLine($"Arvude aritmeetiline keskmine: {keskmine}");
        Console.WriteLine($"Arvude korrutis: {korrutis}");

        Console.ReadLine();
}


//Loo  juhuslikult arvud N ja M ja sisesta massiivi arvud N'st M'ni. Trüki arvude ruudud ekraanile.

{
        Console.Write("Sisesta arv N: ");
        int n = int.Parse(Console.ReadLine());

        Console.Write("Sisesta arv M: ");
        int m = int.Parse(Console.ReadLine());

        int[] arvud = new int[m - n + 1];

        for (int i = n; i <= m; i++)
        {
            Console.Write($"Sisesta arv massiivi {i - n + 1}/{m - n + 1}: ");
            arvud[i - n] = int.Parse(Console.ReadLine());
        }

        Console.WriteLine("Arvude ruudud:");
        foreach (int arv in arvud)
        {
            Console.WriteLine(arv * arv);
        }

        Console.ReadLine();
}




