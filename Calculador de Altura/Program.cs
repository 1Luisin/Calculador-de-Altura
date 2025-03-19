using System.Numerics;

enum Paginainicial { Começar = 1, Opções, Sair}

internal class Program {

    static void Main(string[] args)
    { 
        bool dontexit = true;
        while (dontexit)
        {
            try
            {

                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("Calculador de altura!");
                Console.ResetColor();

                Console.WriteLine("\nDigite o número respectivo à função desejada");
                Console.WriteLine("\n1 - Começar\n2 - Opções\n3 - Sair");

                string funcaodesejadatxt = Console.ReadLine();
                var funcaodesejadaint = float.Parse(funcaodesejadatxt);
                Paginainicial opcaodesejada = (Paginainicial)funcaodesejadaint;

                if (funcaodesejadaint <= 0)
                {
                    Console.Clear();
                    Console.ForegroundColor= ConsoleColor.Red;
                    Console.WriteLine("Opção não listada, tente novamente.");
                    Console.ResetColor();
                    Console.ReadLine();
                    Console.Clear();

                }
                if (funcaodesejadaint >= 4)
                {
                    Console.Clear();
                    Console.ForegroundColor= ConsoleColor.Red;
                    Console.WriteLine("Opção não listada, tente novamente.");
                    Console.ResetColor();
                    Console.ReadLine();
                    Console.Clear();
                }

                if (opcaodesejada == Paginainicial.Começar)
                {
                    Comeco();
                }

                if (opcaodesejada == Paginainicial.Opções)
                {
                    Console.Clear();
                    Console.WriteLine("Porque um calculador de altura teria opções??????");
                    Console.WriteLine("\nPressione qualquer tecla para voltar ao menu.");
                    Console.ReadLine();
                    Console.Clear();
                }

                if (opcaodesejada == Paginainicial.Sair)
                {
                    break; //saída do aplicativo
                }
              }
            catch (System.FormatException)
            {

                Console.Clear();
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Digite somente NÚMEROS:");
                Console.ResetColor();
                Console.WriteLine("Pressione qualquer tecla para voltar ao menu principal. . .");
                Console.ReadLine();
                Console.Clear();

            }

        
        }
    }   
    static void Comeco()
    {
        Console.Clear();
        Console.WriteLine("Digite sua altura abaixo em metros.");
        
        float alturausuario = float.Parse(Console.ReadLine());

        Console.WriteLine("\nAgora digite sua altura em centímetros.");
        Console.ReadLine();
        Console.Clear();
        Console.WriteLine("\nPressione qualquer tecla para calcular sua altura.");
        Console.ReadKey();
        Console.Write("[███ . .] Pesquisando no wikipedia");
        Console.ReadLine();
        Console.Write("[█████ .] Stamina recuperada");
        Console.ReadLine();
        Console.Write("[███████] Se o seu HP cair para 0, você morre.");
        Console.ReadKey();

        Console.ForegroundColor = ConsoleColor.Green;
        Console.WriteLine("\nPronto!");
        Console.ResetColor();
        Console.WriteLine($"\nA sua altura é {alturausuario} ;D");
        Console.WriteLine("\nPressione qualquer tecla para voltar ao menu");
        Console.ReadKey();
        Console.Clear();
    }




}

