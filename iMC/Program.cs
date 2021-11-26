using System;

namespace iMC
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ingrese su peso (Kg):");
            int peso = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Ingrese su estatura separada por coma (m):");
            double estatura = Convert.ToDouble(Console.ReadLine());
            double mc=peso/(Math.Pow(estatura, 2));
            Console.WriteLine("Diagnóstico:");
            if(mc<16){
                Console.WriteLine("Padece Delgadez severa");
            }else if(mc>=16 && mc<=16.99){
                Console.WriteLine("Padece Delgadez moderada");
            }else if(mc>=17 && mc<=18.49){
                Console.WriteLine("Padece Delgadez aceptable");
            }else if(mc>=18.5 && mc<=24.99){
                Console.WriteLine("Tiene Peso normal");
            }else if(mc>=25 && mc<=29.99){
                Console.WriteLine("Padece Sobrepeso");
            }else if(mc>=30 && mc<=34.99){
                Console.WriteLine("Padece Obesidad tipo I");
            }else if(mc>=35 && mc<=39.99){
                Console.WriteLine("Padece Obesidad tipo II");
            }else if(mc>=40 && mc<=49.99){
                Console.WriteLine("Padece Obesidad tipo III o mórbida");
            }else if(mc>50){
                Console.WriteLine("Padece Obesidad tipo IV o extrema");
            }
        }
    }
}
