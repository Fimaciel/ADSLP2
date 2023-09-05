

Console.WriteLine("Qual questão deseja acessar?");
Console.WriteLine("1) Faça um cadastro de alunos, onde cada aluno tem diferentes disciplinas e cada disciplina tem uma nota diferentes;");
Console.WriteLine("2) Faça um cadastro de fazendeiros, onde cada fazendeiro tem diferentes tipos de gado(bezerro, novilha, garote, vaca, boi) e cada tipo tem valor e quantidade diferente;");
int x = Convert.ToInt32(Console.ReadLine());

switch (x){
    case 1:
        Questao_1();
        break;
    case 2:
        quest_2();
        break;
}

void Questao_1(){ 
    Console.WriteLine("Quantos alunos tem na sala?");
    int quantidadeAlunos = int.Parse(Console.ReadLine()!);

    string[] alunos = new string[quantidadeAlunos];
    string[][] alunoDisciplina = new string[quantidadeAlunos][];
    double[][] alunoNota = new double[quantidadeAlunos][];

    for (int i = 0; i < quantidadeAlunos; i++)
    {
        Console.WriteLine("Digite o nome do Aluno:");
        alunos[i] = Console.ReadLine()!;

        Console.WriteLine("Quantas disciplinas o aluno possui?");
        int quantidadeDisciplinas = int.Parse(Console.ReadLine()!);

        alunoDisciplina[i] = new string[quantidadeDisciplinas];
        alunoNota[i] = new double[quantidadeDisciplinas];

        for (int j = 0; j < quantidadeDisciplinas; j++)
        {
            Console.WriteLine("Informe a disciplina:");
            alunoDisciplina[i][j] = Console.ReadLine()!;

            Console.WriteLine("Informe a nota:");
            alunoNota[i][j] = Convert.ToDouble(Console.ReadLine()!);
        }
    }

    Console.WriteLine("\nDados dos alunos cadastrados:");
    for (int i = 0; i < quantidadeAlunos; i++)
    {
        Console.WriteLine($"Aluno: {alunos[i]}");

        for (int j = 0; j < alunoDisciplina[i].Length; j++)
        {
            Console.WriteLine($"Disciplina: {alunoDisciplina[i][j]}");
            Console.WriteLine($"Nota: {alunoNota[i][j]}");
        }

        Console.WriteLine();
    }
}

void quest_2()
{
   

    Console.WriteLine("Informe a quantidade de fazendeiros:");
    int fazendeiros = Convert.ToInt32(Console.ReadLine());

    string[] fazendeiro = new string[fazendeiros];
    string[][] tipogado = new string[fazendeiros][];
    double[][] valorgado = new double[fazendeiros][];

    for (int i = 0; i < fazendeiros; i++)
    {
        Console.WriteLine("Informe o nome do fazendeiro:");
        fazendeiro[i] = Console.ReadLine();

        Console.WriteLine($"Quantos tipos de gado o fazendeiro {fazendeiro[i]} tem?:");
        int quantidadeTiposGado = Convert.ToInt32(Console.ReadLine());

        tipogado[i] = new string[quantidadeTiposGado];
        valorgado[i] = new double[quantidadeTiposGado];

        for (int j = 0; j < quantidadeTiposGado; j++)
        {
            Console.WriteLine("Informe o tipo de gado:");
            tipogado[i][j] = Console.ReadLine();

            Console.WriteLine("Informe o valor do gado:");
            valorgado[i][j] = Convert.ToDouble(Console.ReadLine());
        }
    }

    for (int i = 0; i < fazendeiros; i++)
    {
        Console.WriteLine($"O fazendeiro {fazendeiro[i]} tem:");

        for (int j = 0; j < tipogado[i].Length; j++)
        {
            Console.WriteLine("Tipo de gado: " + tipogado[i][j]);
            Console.WriteLine("Valor do gado: " + valorgado[i][j]);
        }
        Console.WriteLine("================================");
    }
    
}