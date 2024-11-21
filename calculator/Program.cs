using System;

namespace _calculator_binary{
    class Program{

        static void Calculo_Binario_para_Decimal(){ // FUNÇÃO DE CALCULO BINARIO PARA DECIMAL
            Console.Clear();
            Console.WriteLine(">>> BINÁRIO PARA DECIMAL <<<");
            Console.Write("Binário -> ");
            string binario = Console.ReadLine(); // Pegando um valor binário

            long numero_decimal = Convert.ToInt64(binario, 2); // Convertendo Binario para decimal
            Console.WriteLine($"Decimal -> {numero_decimal}"); // Mostrando o Decimal na tela

            Console.Write("\npressione qualquer tecla para continuar...");
            Console.ReadLine();
        }


        static void Calculo_Decimal_para_Binario(){ // FUNÇÃO DE CALCULO DECIMAL PARA BINARIO
            Console.Clear();
            Console.WriteLine(">>> DECIMAL PARA BINÁRIO <<<");
            Console.Write("Decimal -> ");
            long numero_decimal = long.Parse(Console.ReadLine()); // Pegando valor decimal
            string binario = ""; // Variavel para o número binário

            // Loop para calcular o número binário
            while (numero_decimal > 0){
                binario = (numero_decimal % 2) + binario;
                numero_decimal /= 2;
            }
            Console.WriteLine($"Binário -> {binario}"); // Mostrando o Binário na tela

            Console.Write("\npressione qualquer tecla para continuar...");
            Console.ReadLine();
        }


        static void Main() { // INICIO DO PROGRAMA  
            char option = ' '; //Variável para o menu de opções

            while (option != '3'){
                Console.Clear(); // Limpar Terminal

                Console.WriteLine(">>>> CALCULADORA DE BASES <<<<");
                Console.Write("\n[1]Decimal para Binário\n[2]Binário para Decimal\n[3]Sair\n\n-> "); 
                option = char.Parse(Console.ReadLine());

                // Menu de opções
                switch(option){
                    case '1':
                        Calculo_Decimal_para_Binario();
                        break;
                    case '2':
                        Calculo_Binario_para_Decimal();
                        break;
                    case '3':
                        Environment.Exit(0);
                        break;
                }
            }
        }
    }
}