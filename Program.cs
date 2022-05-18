using System;

namespace CalculadoraSimple{

    class CalculadoraSimple{
        static void Main(string[] args){
            bool isTrue = true;
            double result = 0;
            int i = 0;
                while(isTrue){
                    
                    System.Console.WriteLine("qual valor deseja inserir?");
                    double userValue = double.Parse(Console.ReadLine());
                    if(i == 0)result = userValue;
                    i++;
                    Console.Clear();
                    System.Console.WriteLine("qual tipo de operação deseja usar?\nsubstracao\nadicao\nmultiplicacao\ndivisao\nigual(= resultado final)\n[digite o nome da operacao da mesma forma que foi apresentada]");
                    string userInput = Console.ReadLine();
                    Console.Clear();
                    if(userInput == "igual"){
                        System.Console.WriteLine("o resultado foi este: {0}", result);
                        isTrue = false;
                        break;
                    }
                    switch(userInput){
                        case "adicao":
                        result += userValue;
                        break;
                    }
                }
            
        }
    }
}
