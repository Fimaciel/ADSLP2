using System;
using System.IO;
using System.Threading;

namespace prova
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            int op = 0;
            Cliente novo = null, inicio = null, aux = null, lista = null;
            do
            {
                Console.Clear();
                Console.WriteLine("Informe uma Opção:");
                Console.WriteLine(
                    "1. Cadastrar cliente e programa de exercicios; \n2. Consultar cliente; \n3. Listar todos os clientes \n4. Calcular calorias gastas \n5. Sair");
                 op = Convert.ToInt32(Console.ReadLine());

                switch (op)
                {
                    case 1:
                        novo = new Cliente();

                        Console.WriteLine("Informe o ID:");
                        novo.id = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("Informe o nome do cliente:");
                        novo.nome = Console.ReadLine();
                        Console.WriteLine("Informe o peso do cliente:");
                        novo.peso = Convert.ToDouble(Console.ReadLine());
                        Console.WriteLine("Informe a idade do cliente:");
                        novo.idade = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("Informe o sexo do cliente?");
                        novo.sexo = Console.ReadLine();

                        Programa programa = new Programa();
                        Console.WriteLine($"Quantos aparelhos {novo.nome} vai utilizar:");
                        int quant = int.Parse(Console.ReadLine());
                        programa.aparelho = new string[quant];
                        programa.calorias = new double[quant];

                        for (int i = 0; i < quant; i++)
                        {
                            Console.WriteLine("Informe o aparelho:");
                            programa.aparelho[i] = Console.ReadLine();

                            Console.WriteLine("Informe quanto gasta de caloria este aparelho:");
                            programa.calorias[i] = Convert.ToDouble(Console.ReadLine());
                        }

                        novo.programa = programa;

                        if (inicio == null)
                        {
                            inicio = novo;
                            inicio.prox = null;
                        }
                        else
                        {
                            if (inicio.prox == null)
                            {
                                lista = novo;
                                inicio.prox = lista;
                                lista.prox = null;
                            }
                            else
                            {
                                lista.prox = novo;
                                lista = novo;
                                lista.prox = null;
                            }
                        }
                        break;
                    case 2:
                        Console.WriteLine("Deseja consultar por nome ou ID? 1. nome 2. ID");
                        aux = inicio;
                        int x = int.Parse(Console.ReadLine());
                        if (x == 1)
                        {
                            Console.WriteLine("informe o nome do cliente que deseja consultar:");
                            string nome = Console.ReadLine();
                            bool achou = false;
                            while (aux != null)
                            {
                                string nm = aux.nome.ToLower();
                                nome = nome.ToLower();
                                if (nm.Equals(nome))
                                {
                                    Console.WriteLine($"Id do cliente: {aux.id}");
                                    Console.WriteLine($"Nome do cliente: {aux.nome}");
                                    Console.WriteLine($"Idade do cliente: {aux.idade}");
                                    Console.WriteLine($"Sexo do cliente: {aux.sexo}");
                                    Console.WriteLine($"peso do cliente: {aux.peso}");
                                    
                                    achou = true;
                                }
                                else
                                {
                                    achou = false;
                                }

                                aux = aux.prox;
                                
                            }

                            if (!achou)
                            {
                                Console.WriteLine("não achou");
                            }
                            Console.ReadKey();

                        }
                        else
                        {
                            bool achou = false;
                            Console.WriteLine("informe o ID do cliente que deseja consultar:");
                            int id = int.Parse(Console.ReadLine());

                            while (aux != null)
                            {
                                if (aux.id == id)
                                {
                                    Console.WriteLine($"Id do cliente: {aux.id}");
                                    Console.WriteLine($"Nome do cliente: {aux.nome}");
                                    Console.WriteLine($"Idade do cliente: {aux.idade}");
                                    Console.WriteLine($"Sexo do cliente: {aux.sexo}");
                                    Console.WriteLine($"peso do cliente: {aux.peso}");
                                    achou = true;

                                }
                                else
                                {
                                    achou = false;
                                }
                                aux = aux.prox;
                            }

                            if (!achou)
                            {
                                Console.WriteLine("não achou");
                            }
                            
                            Console.ReadKey();
                        }

                        break;
                    case 3:
                        aux = inicio;
                        Console.WriteLine("==================");
                        while (aux != null)
                        {
                            Console.WriteLine($"Id do cliente: {aux.id}");
                            Console.WriteLine($"Nome do cliente: {aux.nome}");
                            Console.WriteLine($"Idade do cliente: {aux.idade}");
                            Console.WriteLine($"Sexo do cliente: {aux.sexo}");
                            Console.WriteLine($"peso do cliente: {aux.peso}");
                            Console.WriteLine("==================");
                            aux = aux.prox;
                        }

                        Console.WriteLine("Deseja salvar os clientes em um arquivo? 1. sim 2. não");
                        int res = int.Parse(Console.ReadLine());
                        if (res == 1)
                        {
                            string path = @"/home/ef/Documentos/ok/prova/prova/texto/test.txt";

                            using (StreamWriter sw = new StreamWriter(path))
                            {
                                aux = inicio;
                                while (aux != null)
                                {
                                    sw.WriteLine($"{aux.id}");
                                    sw.WriteLine($"{aux.nome}");
                                    sw.WriteLine($"Id do cliente: {aux.id}");
                                    sw.WriteLine($"Nome do cliente: {aux.nome}");
                                    sw.WriteLine($"Idade do cliente: {aux.idade}");
                                    sw.WriteLine($"Sexo do cliente: {aux.sexo}");
                                    sw.WriteLine($"peso do cliente: {aux.peso}");
                                    sw.WriteLine($";");

                                    // 5 recebe o proximo
                                    aux = aux.prox;
                                }
                
                            }
                        }

                        break;
                    case 4:
                        aux = inicio;
                        while (aux != null)
                        {
                            Calcularcaloriasgastas(aux);
                            aux = aux.prox;
                        }
                        Console.ReadKey();
                        break;
                    case 5:
                        Console.Clear();
                        Console.WriteLine("tchau");
                        break;
                    default:
                        Console.WriteLine("opção Inválida");
                        break;
                }
            } while (op != 5);
        }

        private static void Calcularcaloriasgastas(Cliente novo)
        {
            Cliente aux = novo;
            while (aux != null)
            {
                Console.WriteLine("Cliente: " + aux.nome);
                double total = 0;

                if (aux.programa.calorias == null && aux.programa.calorias ==null)
                {
                    Console.WriteLine("Dados de calorias indisponíveis para este cliente.");
                }
                else
                {
                    for (int i = 0; i < aux.programa.aparelho.Length; i++)
                    {
                        total =+ aux.programa.calorias[i];
                    }
                
                    Console.WriteLine("Calorias gastas no treinamento: " + total);
                }

                aux = aux.prox;
            }

        }
    }
}