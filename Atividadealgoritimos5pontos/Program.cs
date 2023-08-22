//Aluno: Filipe Maciel
// Todas as questões estão no mesmo arquivo.


void MenuPrincipal()
{
    Console.Clear();
    int quest;
    Console.WriteLine("Informe a questão que deseja ver: \n2 para questão 2 \n3 para questão 3");
    Console.WriteLine("7 para 7 \n8 para 8 \n9 para 9");
    quest = int.Parse(Console.ReadLine()!);

    switch (quest)
    {
        case 2:
            quest2();
            break;
        case 3:
            quest3();
            break;
        case 7:
            quest7();
            break;
        case 8:
            quest8();
            break;
        case 9:
            quest9();
            break;
        default:
            Console.WriteLine("Essa Questão não foi solicitada");
            Console.WriteLine("Precione qualquer tecla para voltar para o Menu:");
            Console.ReadKey();
            MenuPrincipal();
            break;
    }
}

MenuPrincipal();

void quest2()
{
    Console.Clear();

    
    double[] temperatura = new double[7];
    var contador = 0;
    var media = 0.00;
    var mediano = 0.00;

    for (int i = 0; i < temperatura.Length; i++) 
    {
            Console.WriteLine("Qual a temperatura de hoje: ");
            temperatura[i] = Convert.ToDouble(Console.ReadLine());
            contador++;
            mediano = mediano + temperatura[i];
  

        media = mediano / contador;
    }

    Console.Clear();

    Console.WriteLine("A média é: " + media.ToString("F2"));
    foreach(double temp in temperatura)
    {
        if(temp > media)
        {
            Console.WriteLine("A temperatura maior que á média é: " + temp);
        }
    }

    Console.WriteLine("Precione qualquer tecla para voltar para o Menu:");
    Console.ReadKey();
    MenuPrincipal();
}

void quest3()
{

    Console.Clear();

    char[] vogais = { 'a', 'e', 'i', 'o', 'u' };

    double[] alturas = new double[10];
    for (int i = 0; i < 10; i++)
    {
        Console.Write($"Digite a altura da pessoa {i + 1} em metros: ");
        alturas[i] = Convert.ToDouble(Console.ReadLine());
    }

    string[] meses = { "Janeiro", "Fevereiro", "Março", "Abril", "Maio", "Junho", "Julho", "Agosto", "Setembro", "Outubro", "Novembro", "Dezembro" };

    Console.WriteLine("\nVogais do alfabeto:");
    foreach (char vogal in vogais)
    {
        Console.Write($"{vogal} ");
    }

    Console.WriteLine("\nAlturas das pessoas:");
    foreach (double altura in alturas)
    {
        Console.WriteLine(altura);
    }

    Console.WriteLine("\nMeses do ano:");
    foreach (string mes in meses)
    {
        Console.WriteLine(mes);
    }

    Console.WriteLine("\nPrecione qualquer tecla para voltar para o Menu:");
    Console.ReadKey();
    MenuPrincipal();
}

void quest7() {
    Console.Clear();

    double[] temperaturas = new double[7];
    string[] semana = { "D", "S", "T", "Q", "Q", "S", "S" };

    for (int i = 0; i < semana.Length; i++)
    {

        Console.WriteLine("Qual a temperatura de hoje: ");
        temperaturas[i] = Convert.ToDouble(Console.ReadLine());


    }

        for (int i = 0; i < semana.Length; i++)
        {
            Console.Write(semana[i] + ": ");
            for (int j = 0; j < temperaturas[i]; j++)
            {

                System.Threading.Thread.Sleep(30);
                Console.Write("■ ");
            }
            Console.WriteLine("");
        }


    Console.WriteLine("\nPrecione qualquer tecla para voltar para o Menu:");
    Console.ReadKey();
    MenuPrincipal();
}
void quest8() {
    Console.Clear();

    int[] a = new int[10]; ;
    int[] b = new int[a.Length];
    int[] c = new int[a.Length];

    int inverso = b.Length - 1;

    for (int i = 0; i < a.Length; i++)
    {

        Console.WriteLine("Informe os valores do vetor A:");
        a[i] = Convert.ToInt16(Console.ReadLine());


    }
    Console.WriteLine("======================================================================");
    for (int i = 0; i < b.Length; i++)
    {

        Console.WriteLine("Informe os valores do vetor B:");
        b[i] = Convert.ToInt16(Console.ReadLine());


    }
    for (int i = 0; i < c.Length; i++)
    {
        c[i] = a[i] + b[inverso];

        inverso--;
        Console.WriteLine("Valores do Vetor C: " + c[i]);
    }


    Console.WriteLine("Precione qualquer tecla para voltar para o Menu:");
    Console.ReadKey();
    MenuPrincipal();
}

void quest9() {
    Console.Clear();

    int[] a = { 3, 5, 6, 4, 1, 2, 9};
    int[] b = { 1, 2, 1, 2, 9, 10, 5 };
    int[] c = new int[a.Length + b.Length]; 
    int cLength = 0; 

    for (int i = 0; i < a.Length; i++)
    {
        bool foundInB = false; 

        for (int j = 0; j < b.Length; j++)
        {
            if (a[i] == b[j])
            {
                foundInB = true;
                break;
            }
        }

        if (!foundInB)
        {
            c[cLength] = a[i];
            cLength++;
        }
    }

    for (int i = 0; i < b.Length; i++)
    {
        bool foundInA = false; 

        for (int j = 0; j < a.Length; j++)
        {
            if (b[i] == a[j])
            {
                foundInA = true;
                break;
            }
        }

        if (!foundInA)
        {
            c[cLength] = b[i];
            cLength++;
        }
    }
    Console.WriteLine("Vetor C:");
    for (int i = 0; i < cLength; i++)
    {
        Console.Write(c[i] + "|");
    }

    Console.WriteLine("Precione qualquer tecla para voltar para o Menu:");
    Console.ReadKey();
    MenuPrincipal();
}


