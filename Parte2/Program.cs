//PARTE 2

// Funcionalidad 1: Obtener media
void getMedia(List<float> ListaNumbers)
{

    int n = ListaNumbers.Count;
    float sum = 0;

    for (int i = 0; i < n; i++)
        sum = sum + (float)1 / ListaNumbers[i];

    Console.Write("\n1- La Media Armonica es: {0}", (float)n / sum);

    double average = ListaNumbers.Count > 0 ? ListaNumbers.Average() : 0.0;
    Console.Write("\n1- La Media Aritmetica o Promedio es: {0}", average);

    ListaNumbers.Sort();

    if(n%2 != 0)
    {
        Console.Write("\n1- La Media Mediana es: {0}", ListaNumbers[n/2]);
    }
    else
    {
        Console.Write("\n1- La Media Mediana es: {0}", (ListaNumbers[(n / 2) - 1] + ListaNumbers[(n / 2)]) / 2);
    }

    Console.Write("\n1- La Media Mediana es: {0}", average);

    Console.WriteLine();
}

// Funcionalidad 2: Escalera
void getStaircase(int numeroEntero)
{
    //Agente A
    for (int i = numeroEntero; i>0; i--)
    {
        for (int z = 1; z< i; z++)
        {
            Console.Write(" ");
        }

        for (int y = 0; y <= numeroEntero - i; y++)
        {
            Console.Write("*");           
        }

        Console.WriteLine();     
    }

    Console.WriteLine();

    //Agent B
    for (int i = numeroEntero; i>0; i--)
    {
        for (int z = 0; z< numeroEntero - i; z++)
        {
            Console.Write(" ");
        }

        for (int y = 0; y < i; y++)
        {
            Console.Write("*");           
        }

        Console.WriteLine();       
    }

    Console.WriteLine();

    //Agente C

    int x = 0, p = 0;

    Console.WriteLine(" ");

    for (x = 0; x < numeroEntero - 1; x++)
    {
        Console.Write(" ");
    }
    for (x = 0; x < numeroEntero; x++)
    {
        Console.Write("*");
    }

    for (p = 1; p < numeroEntero - 1; p++)
    {
        Console.WriteLine(" ");
        for (x = 0; x < numeroEntero - p - 1; x++)
        {
            Console.Write(" ");
        }
        Console.Write("*");
        for (x = 0; x < numeroEntero + 2 * p - 2; x++)
        {
            Console.Write("*");
        }
        Console.Write("*");
    }

    for (p = numeroEntero; p > 1; p--)
    {
        Console.WriteLine(" ");
        for (x = 0; x < numeroEntero - p; x++)
        {
            Console.Write(" ");
        }
        Console.Write("*");
        for (x = 0; x < numeroEntero + 2 * p - 4; x++)
        {
            Console.Write("*");
        }
        Console.Write("*");
    }

    Console.WriteLine(" ");
    for (x = 0; x < numeroEntero - 1; x++)
    {
        Console.Write(" ");
    }
    for (x = 0; x < numeroEntero; x++)
    {
        Console.Write("*");
    }
    Console.WriteLine(" ");    
}

bool flag = true;

Console.WriteLine("Hello, World!\n");

do
{
    string option = "";
    Console.WriteLine("############## PARTE 2 ##############");
    Console.WriteLine("\n1- Funcionalidad 1: Obtener media");
    Console.WriteLine("\n2- Funcionalidad 2: Escalera");
    Console.WriteLine("\n3- Salir");
    Console.Write("\nElige una Option: ");
    option = Console.ReadLine();

    switch(option)
    {
        case "1":
            List<float> listaNumeros = new List<float>();
            float number;
            bool flag2 = true;
            string option2 = "";

            while (flag2)
            {
                try {
                    Console.Write("\nIngresar Un Numero Real: ");
                    number = Convert.ToSingle(Console.ReadLine());
                    listaNumeros.Add(number);
                }
                catch
                {
                    Console.WriteLine("\nDato Incorrecto\n");

                }

                Console.WriteLine("\nDesea Ingresar Otro Numero(press y or n)?: ");
                option2 = Console.ReadLine();

                if(option2 == "n")
                {
                    flag2= false;
                    getMedia(listaNumeros);
                    break;
                }               
            }

            Console.WriteLine();

            break;

        case "2":
            int size;
            bool flag3 = true;
            try
            {
                while (flag3)
                {
                    Console.WriteLine("\nIngresar el Tamaño de la Escalera: ");
                    size = Convert.ToInt32(Console.ReadLine());
                    if (size > 0 && size < 100)
                    {
                        getStaircase(size);
                        flag3 = false;
                    }
                    else
                    {
                        Console.WriteLine("\nIngrese un numero donde: 0 < n < 100");
                    }
                }
                               
            }
            catch
            {
                Console.WriteLine("\nDato Incorrecto\n");
            }

            Console.WriteLine();
            break;

        case "3":
            flag = false;
            break;

        default:
            Console.WriteLine("\n Opcion Incorrecta");
            break;

    }

} while(flag);


Console.WriteLine("Hello, World!");
Console.WriteLine();