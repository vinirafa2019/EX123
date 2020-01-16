using System;
using System.Collections.Generic;
namespace EX1prova
{
    class Program
    {

        static void Main(string[] args)
        {

            Pessoa p1 = new Pessoa("João", 15);
            Pessoa p2 = new Pessoa("Leandro", 21);
            Pessoa p3 = new Pessoa("Paulo", 17);
            Pessoa p4 = new Pessoa("Jessica", 18);


            List<Pessoa> pessoas = new List<Pessoa>();
            pessoas.Add(p1);
            pessoas.Add(p2);
            pessoas.Add(p3);
            pessoas.Add(p4);

            Console.WriteLine("selecione a opcao");
            Console.WriteLine("1-Exibir a lista toda e a pessoa mais velha");
            Console.WriteLine("2-Exibir a quantidade a lista antes da exclusao");
            Console.WriteLine("3-Realizar remoçao e exibir quantidade da lista");
            Console.WriteLine("4-Verificar item");
            int op = int.Parse(Console.ReadLine());
            int pt = 0;
                switch (op)
                {
                     
                    case 1:
                        Console.WriteLine("Todos da lista");
                        foreach (Pessoa p in pessoas)
                        {
                            Console.WriteLine(p.Nome + " " + p.Idade);
                        }
                        Console.WriteLine("------------------------------------------ \n");
                        String indice = null;
                        int maiorid = 0;

                        foreach (Pessoa p in pessoas)
                        {
                            if (p.idade > maiorid)
                            {
                                maiorid = p.idade;
                                indice = p.nome;
                            }
                        }
                        Console.WriteLine("A pessoa mais velha é: " + (indice) + " com idade de " + maiorid + "anos");
                        Console.WriteLine("------------------------------------------");
                        break;
                    case 2:
                        foreach (Pessoa p in pessoas)
                        {
                            pt = pt + 1;
                        }
                        Console.WriteLine("Quantidade na lista antes da exclusao " + pt);
                        break;
                    case 3:
                        Console.WriteLine("Lista depois da exclusão");
                        foreach (Pessoa p in pessoas.ToArray())
                        {

                            if (p.idade < 18)
                            {
                                pessoas.Remove(p);
                                pt = pt + 1;
                            }
                            if (p.idade >= 18)
                            {
                                Console.WriteLine("Nome: " + p.nome);
                            }
                        }
                        Console.WriteLine("Quantidade depois da exclusao :" + pt);
                        Console.WriteLine("------------------------------");
                        break;
                    case 4:
                        foreach (Pessoa p in pessoas)
                        {
                        Console.WriteLine("Digite um nome na lista");
                        String n = Console.ReadLine();
                            if (p.nome == n)
                            {
                                Console.WriteLine("A " +n + " existe");
                            break;
                        }
                        }
                        break;
                    case 5:                       
                            Console.WriteLine("Sair");
                        break;
                }  
        }
    }
}
