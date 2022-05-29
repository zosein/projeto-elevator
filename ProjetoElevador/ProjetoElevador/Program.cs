using System;
using ProjetoElevador.Model;
namespace ProjetoElevador
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Elevador elevador = new Elevador();

            Console.WriteLine("Seja bem vindo(a) ao elevador do Edifício Don Tenet!");
            Console.WriteLine("-------------------------------------------------");
            Console.WriteLine("Digite a quantidade de andares");
            string totalAndares = Console.ReadLine();
            Console.WriteLine("-------------------------------------------------");

            Console.WriteLine("Digite a capacidade do elevador");
            string capacidadeElevador = Console.ReadLine();
            Console.WriteLine("-------------------------------------------------");

          
            int numero = 0;

            do
            {
                Console.WriteLine("1 - digite para Inicializar");
                Console.WriteLine("2 - digite para entrar no elevador");
                Console.WriteLine("3 - digite para sair do elevador");
                Console.WriteLine("4 - digite para subir um andar");
                Console.WriteLine("5 - digite para descer um andar");
                Console.WriteLine("6 - digite para finalizar");
                string textoDigitado = Console.ReadLine();
                numero = int.Parse(textoDigitado);

                elevador.Inicializar(int.Parse(capacidadeElevador), int.Parse(totalAndares));
                Console.WriteLine("Elevador Inicializado");
                Console.WriteLine("-------------------------------------------------");

                string retorno;

                switch (numero)
                {
                    case 1:
                        elevador.Inicializar(int.Parse(capacidadeElevador), int.Parse(totalAndares));
                        break;

                    case 2:
                        retorno = elevador.Entrar();
                        Console.WriteLine(retorno);
                        break;

                    case 3:
                        retorno = elevador.Sair();
                        Console.WriteLine(retorno);
                        break;

                    case 4:
                        retorno = elevador.Subir();
                        Console.WriteLine(retorno);
                        break;

                    case 5:
                        retorno = elevador.Descer();
                        Console.WriteLine(retorno);
                        break;

                    case 6:
                        Console.WriteLine("Fim do programa");
                        break;

                    default:
                        Console.WriteLine("Número incorreto");
                        break;
                }

            } while (numero != 6);
            
        
            }
        }
    }
