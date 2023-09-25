
menu();
void menu()
{
    while (true)
    {
        Console.WriteLine("Informa qual atividade deseja fazer: \n1. Ativdade 1 \n2. Ativdade 2 \n3. Atividade 3 \n4. Atividade 4\n5. Atividade 9\n6. Sair ");
        int op = Convert.ToInt32(Console.ReadLine());

        switch (op)
        {
            case 1:
                atividade1();
                break;
            case 2:
                atividade2();
                break;
            case 3:
                atividade3();
                break;
            case 4:
                atividade4();
                break;
            case 5:
               atividade9();
                break;
            case 6:
                return;
            default:
                Console.WriteLine("Informa uma opção válida");
                break;
        }
    }
}

//Exercicios
void atividade1()
{
    Console.WriteLine("Informe três números:");

    Console.Write("Número 1: ");
    int numero1 = int.Parse(Console.ReadLine());

    Console.Write("Número 2: ");
    int numero2 = int.Parse(Console.ReadLine());

    Console.Write("Número 3: ");
    int numero3 = int.Parse(Console.ReadLine());

    OrdenarNumeros(ref numero1, ref numero2, ref numero3);
   
    Console.WriteLine("Números ordenados: {0}, {1}, {2} \n\n", numero1, numero2, numero3);
    static void OrdenarNumeros(ref int a, ref int b, ref int c)
    {
        if (a > b)
        {
            Trocar(ref a, ref b);
        }
        if (b > c)
        {
            Trocar(ref b, ref c);
        }
        if (a > b)
        {
            Trocar(ref a, ref b);
        }
    }

    static void Trocar(ref int x, ref int y)
    {
        int temp = x;
        x = y;
        y = temp;
    }

}

void atividade2()
{

        Console.Write("Informe o número de linhas da matriz: ");
        int linhas = int.Parse(Console.ReadLine());

        Console.Write("Informe o número de colunas da matriz: ");
        int colunas = int.Parse(Console.ReadLine());

        int[,] matrizA = new int[linhas, colunas];

        for (int i = 0; i < linhas; i++)
        {
            for (int j = 0; j < colunas; j++)
            {
                Console.Write($"Informe o valor para a posição [{i},{j}]: ");
                matrizA[i, j] = int.Parse(Console.ReadLine());
            }
        }

        while (true)
        {
            Console.WriteLine("\nEscolha uma função:");
            Console.WriteLine("1. Exibir matriz original");
            Console.WriteLine("2. Exibir números pares");
            Console.WriteLine("3. Exibir números múltiplos de 5");
            Console.WriteLine("4. Exibir números em ordem");
            Console.WriteLine("5. Sair");
            Console.Write("Opção: ");

            int opcao = int.Parse(Console.ReadLine());

            switch (opcao)
            {
                case 1:
                    ExibirMatriz(matrizA);
                    break;
                case 2:
                    int[,] matrizPares = ObterNumerosPares(matrizA);
                    ExibirMatriz(matrizPares);
                    break;
                case 3:
                    int[,] matrizMultiplosDe5 = ObterMultiplosDe5(matrizA);
                    ExibirMatriz(matrizMultiplosDe5);
                    break;
                case 4:
                    OrdenarMatriz(matrizA);
                    ExibirMatriz(matrizA); 
                    break;
                case 5:
                    return; 
                default:
                    Console.WriteLine("Opção inválida. Tente novamente.");
                    break;
            }
        }
 }

void atividade3()
{
    while (true)
    {
        Console.WriteLine("Informa qual conversão deseja fazer:");
        Console.WriteLine("1. Real -> Dolar");
        Console.WriteLine("2. Real -> Libra");
        Console.WriteLine("3. Real -> Franco");
        Console.WriteLine("4. Real -> Iene");
        Console.WriteLine("5. Dolar -> Real");
        Console.WriteLine("6. Libra -> Real");
        Console.WriteLine("7. Franco -> Real");
        Console.WriteLine("8. Iene -> Real");
        Console.WriteLine("9. Voltar para o menu.");
        int op = Convert.ToInt32(Console.ReadLine());

        switch (op)
        {
            case 1:
                Console.WriteLine("Inform o valor em real:");
                float valor1 = float.Parse(Console.ReadLine());
                float resposta =  realToDolar(valor1);
                Console.WriteLine("Conversão: " + resposta);
                break;
            case 2:
                Console.WriteLine("Inform o valor em real:");
                float valor = float.Parse(Console.ReadLine());
                float resposta2= realTolibra(valor);
                Console.WriteLine("Conversão: " + resposta2);
                break;
            case 3:
                Console.WriteLine("Inform o valor em real:");
                float realtofrancoValor = float.Parse(Console.ReadLine());
                float resposta3 = realToFranco(realtofrancoValor);
                Console.WriteLine("Conversão: " + resposta3);
                break;
            case 4:
                Console.WriteLine("Inform o valor em real:");
                float realtoieneValor = float.Parse(Console.ReadLine());
                float resposta4 = realToIene(realtoieneValor);
                Console.WriteLine("Conversão: " + resposta4);
                break;
            case 5:
                Console.WriteLine("Inform o valor em dolar:");
                float dolartorealValor = float.Parse(Console.ReadLine());
                float resposta5 = dolarToReal(dolartorealValor);
                Console.WriteLine("Conversão: " + resposta5);
                break;
            case 6:
                Console.WriteLine("Inform o valor em líbra:");
                float libratorealValor = float.Parse(Console.ReadLine());
                float resposta6 = libraToReal(libratorealValor);
                Console.WriteLine("Conversão: " + resposta6);
                break;
            case 8:
                Console.WriteLine("Inform o valor em Franco suiço:");
                float francotorealValor = float.Parse(Console.ReadLine());
                float resposta8 = FrancoToReal(francotorealValor);
                Console.WriteLine("Conversão: " + resposta8);
                break;
            case 7:
                Console.WriteLine("Inform o valor em iene:");
                float irenetorealValor = float.Parse(Console.ReadLine());
                float resposta7 = IeneToReal(irenetorealValor);
                Console.WriteLine("Conversão: " + resposta7);
                break;
            case 9:
                return;
            default:
                Console.WriteLine("Informa uma opção válida");
                break;
        }
    }
}
void atividade4()
{
    Console.Write("Informe o primeiro número: ");
    int numero1 = Convert.ToInt32(Console.ReadLine());

    Console.Write("Informe o segundo número: ");
    int numero2 = Convert.ToInt32(Console.ReadLine());

    if (VerificarDivisibilidade(numero1, numero2))
    {
        Console.WriteLine($"{numero1} é divisível por {numero2}.\n");
    }
    else
    {
        Console.WriteLine($"{numero1} não é divisível por {numero2}. \n");
    }
}

void atividade9()
{
    int[] vetor = PreencherVetor(30);

    while (true)
    {
        Console.WriteLine("Informa uma opção: \n1. Vetor em ordem \n2. números múltiplos por 7 \n3. Sair ");
        int op = Convert.ToInt32(Console.ReadLine());
        
        Console.WriteLine("Vetor Original:");
        ExibirVetor(vetor);
        switch (op)
        {
            case 1:
                Console.WriteLine("\nVetor Ordenado:");
                OrdenarVetor(vetor);
                ExibirVetor(vetor);
                break;
            case 2:
                int quantidadeMultiplosDe7 = ContarMultiplosDe7(vetor);
                Console.WriteLine($"\nQuantidade de números múltiplos de 7: {quantidadeMultiplosDe7}");
                break;
            case 3:
                return;
            default:
                Console.WriteLine("Informa uma opção válida");
                break;
        }
    }


}

//funções auxiliares
static bool VerificarDivisibilidade(int numero1, int numero2)
{
    if (numero2 == 0)
    {
        Console.WriteLine("Erro: Divisão por zero não é permitida.");
        return false;
    }

    return numero1 % numero2 == 0;
}

static int[,] ObterMultiplosDe5(int[,] matriz)
{
    int linhas = matriz.GetLength(0);
    int colunas = matriz.GetLength(1);

    int totalMultiplosDe5 = 0;
    foreach (int numero in matriz)
    {
        if (numero % 5 == 0)
        {
            totalMultiplosDe5++;
        }
    }

    int[,] matrizMultiplosDe5 = new int[totalMultiplosDe5, colunas];

    int linhaIndex = 0;

    for (int i = 0; i < linhas; i++)
    {
        for (int j = 0; j < colunas; j++)
        {
            if (matriz[i, j] % 5 == 0)
            {
                for (int k = 0; k < colunas; k++)
                {
                    matrizMultiplosDe5[linhaIndex, k] = matriz[i, k];
                }
                linhaIndex++;
            }
        }
    }

    return matrizMultiplosDe5;
}
static void ExibirMatriz(int[,] matriz)
{
    Console.WriteLine("Matriz:");

    int linhas = matriz.GetLength(0);
    int colunas = matriz.GetLength(1);

    for (int i = 0; i < linhas; i++)
    {
        for (int j = 0; j < colunas; j++)
        {
            Console.Write(matriz[i, j] + "\n");
        }
        Console.WriteLine();
    }
}

static int[,] ObterNumerosPares(int[,] matriz)
{
    int linhas = matriz.GetLength(0);
    int colunas = matriz.GetLength(1);

    int totalPares = 0;
    foreach (int numero in matriz)
    {
        if (numero % 2 == 0)
        {
            totalPares++;
        }
    }

    int[,] matrizPares = new int[totalPares, colunas];

    int linhaIndex = 0;

    for (int i = 0; i < linhas; i++)
    {
        for (int j = 0; j < colunas; j++)
        {
            if (matriz[i, j] % 2 == 0)
            {
                for (int k = 0; k < colunas; k++)
                {
                    matrizPares[linhaIndex, k] = matriz[i, k];
                }
                linhaIndex++;
            }
        }
    }

    return matrizPares;
}

static void OrdenarMatriz(int[,] matriz)
{
    int linhas = matriz.GetLength(0);
    int colunas = matriz.GetLength(1);
    int[] elementos = new int[linhas * colunas];

    int index = 0;
    for (int i = 0; i < linhas; i++)
    {
        for (int j = 0; j < colunas; j++)
        {
            elementos[index++] = matriz[i, j];
        }
    }

    Array.Sort(elementos);

    index = 0;
    for (int i = 0; i < linhas; i++)
    {
        for (int j = 0; j < colunas; j++)
        {
            matriz[i, j] = elementos[index++];
        }
    }
}

static int[] PreencherVetor(int tamanho)
{
    int[] vetor = new int[tamanho];
    Random random = new Random();

    for (int i = 0; i < tamanho; i++)
    {
        vetor[i] = random.Next(0, 100); 
    }

    return vetor;
}

static void ExibirVetor(int[] vetor)
{
    foreach (int numero in vetor)
    {
        Console.Write(numero + " ");
    }
    Console.WriteLine();
}

static void OrdenarVetor(int[] vetor)
{
    int tamanho = vetor.Length;

    for (int i = 0; i < tamanho - 1; i++)
    {
        int indiceMinimo = i;

        for (int j = i + 1; j < tamanho; j++)
        {
            if (vetor[j] < vetor[indiceMinimo])
            {
                indiceMinimo = j;
            }
        }

        if (indiceMinimo != i)
        {
            int temp = vetor[i];
            vetor[i] = vetor[indiceMinimo];
            vetor[indiceMinimo] = temp;
        }
    }
}

static int ContarMultiplosDe7(int[] vetor)
{
    int contador = 0;

    foreach (int numero in vetor)
    {
        if (numero % 7 == 0)
        {
            contador++;
        }
    }

    return contador;
}

static float realToDolar(float valor1)
{
    return valor1 * 4.94f;
}

static float realTolibra(float valor1)
{ 
    return valor1 * 6.04f;
}
static float realToFranco(float valor1)
{
    return valor1 * 5.44f;
}
static float realToIene(float valor1)
{
    return valor1 * 0.033f;
}
static float dolarToReal(float valor1)
{
    return valor1 * 0.20f;
}
static float libraToReal(float valor1)
{
    return valor1 * 0.17f;
}
static float FrancoToReal(float valor1)
{
    return valor1 * 0.18f;
}
static float IeneToReal(float valor1)
{
    return valor1 * 30.07f;
}
