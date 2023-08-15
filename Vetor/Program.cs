namespace Vetor
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Quantos alunos irá informar as notas?");
            int tamanho = Convert.ToInt32(Console.ReadLine());
            double[] nota1 = new double[tamanho];
            double[] nota2 = new double[tamanho];
            double[] media = new double[tamanho];
            string[] nomeAluno = new string[tamanho];
            nomeAluno = new string[tamanho];

            for (int i = 0; i< nomeAluno.Length; i++)
            {
                Console.WriteLine("Digite o nome do Aluno");
                nomeAluno[i] = Console.ReadLine()!;

                Console.WriteLine("Informe a nota 1:");
                nota1[i] = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("Informe a nota 2:");
                nota2[i] = Convert.ToDouble(Console.ReadLine());

                media[i] = (nota1[i] + nota2[i]) / 2;
            }
            Console.Clear();

            for(int i = 0; i< nomeAluno.Length; ++i)
            {
                Console.WriteLine("Calculando notas:");
                for(int j = 0;j < 10; ++j)
                {
                    System.Threading.Thread.Sleep(30);
                    Console.Write(".");
                }
                Console.WriteLine("#########################");

                Console.WriteLine("A nota do aluno" + nomeAluno[i] + "\n");
                Console.WriteLine("Nota 1 é: " + nota1[i]);
                Console.WriteLine("Nota 2 é: " + nota2[i]);
                Console.WriteLine("A média é: " + media[i]);
                if (media[i] >= 60)
                {
                    Console.WriteLine("Aprovado");
                }
                else
                {
                    Console.WriteLine("Reprovado");
                }
            }

            Console.ReadKey();
        }
    }
}