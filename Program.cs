using System;

namespace CalculadoraSimple{

    class CalculadoraSimple{
        static double ReturnOperation(string input, double result, double userValue){
             if(input == "adicao" ){
                 result += userValue;
             }
             else if(input == "subtracao"){
                 result -= userValue;
             }
             else if(input == "multiplicacao"){
                 result *= userValue;
             }
             else if(input == "divisao"){
                 result /= userValue;
             }
             return result;
        }
        static void Main(string[] args){
            double result = 0;
                        System.Console.WriteLine("digite um valor desejado:");
                        double value = double.Parse(Console.ReadLine());
                        Console.Clear();
                         System.Console.WriteLine("qual operacao deseja fazer?(digite-a sem acentuacao ou caracter especial)");
                         string input = Console.ReadLine();
                        System.Console.WriteLine("digite um valor desejado:");
                        double aux = double.Parse(Console.ReadLine());
                        result = ReturnOperation(input, value, aux);
                        System.Console.WriteLine("O valor final foi: " + result);
        }
    }
}
