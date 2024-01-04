using System;
using System.Collections.Generic;


namespace SistemaRegistro 
{
    class Perfil
    {
        public int Matricula { get; private set; }
        public string Nome { get; set; }
        public string Email { get; set; }
        public string Senha { get; set; }

        public Perfil(int matricula, string nome, string email, string senha)
        {
            Matricula = matricula;
            Nome = nome;
            Email = email;
            Senha = senha;

        }
    }
    class program
    {
        static List<Perfil> perfis = new List<Perfil>();
        static int proximaMatricula = 1;
        public static void Main(string[] args) 
        {
            Console.WriteLine("Seja bem-vindo!");

            bool continuar = true;
            while (continuar)
            {
                Console.WriteLine("O que deseja fazer ?");
                Console.WriteLine("1. Registro");
                Console.WriteLine("2. Excluir");
                Console.WriteLine("3. Listar");
                Console.WriteLine("4. Sair");

                String  opcao = Console.ReadLine();

                switch (opcao)
                {
                    case "1": RegistrarPerfil();
                        break;

                    case "2": ExcluirPerfil();
                        break;

                    case "3": ListarPerfil();
                        break;

                    case "4": continuar = false;
                        break;

                    default: Console.WriteLine("Opção invalida!!");
                        break;

                }
            }

        }
        
        static void RegistrarPerfil()
        {
            Console.WriteLine("Registrar novo perfil");

            Console.WriteLine("Digite seu nome:");
            string nome = Console.ReadLine();

            Console.WriteLine("Digite seu Email:");
            string email = Console.ReadLine();

            Console.WriteLine("Digite sua Senha:");
            string senha = Console.ReadLine();

            perfis.Add(new Perfil(proximaMatricula, nome, email, senha));
            Console.WriteLine("Perfil registrado com sucesso! Matricula:" + proximaMatricula);
            proximaMatricula++;


        }

        static void ExcluirPerfil()
        {
            Console.WriteLine("Digite a matricula do perfil a ser excluido");
            if (int.TryParse(Console.ReadLine(),out int matricula))
            {
                Perfil perfilParaExcluir = perfis.Find(p => p.Matricula == matricula);
                if(perfilParaExcluir != null)
                {
                    perfis.Remove(perfilParaExcluir);
                    Console.WriteLine("Perfil com a Matricula: " + matricula + " excluido com sucesso");

                }
                else
                {
                    Console.WriteLine("Matricula não encontrada");
                }
            }
            else
            {
                Console.WriteLine("Matricula invalida");
            }
        }

        static void ListarPerfil()
        {
            if (perfis.Count == 0)
            {
                Console.WriteLine("Nenhum perfil registrado!");
            }

            else { 

                   Console.WriteLine("Listar perfis registrados");

                  foreach(var perfil in perfis)
                  {
                   Console.WriteLine("Matricula: " +  perfil.Matricula +  " Nome: "  +  perfil.Nome +  " Email: "  + perfil.Email  );
                  }
                }
        }

    }
}