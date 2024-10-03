//Arifmetik progressiya yig'indisi formulasidan foydalanildi
using System;

    namespace Vazifa
    {
        class Program{
            static void Main(string[] args){
                Console.Write("N raqamini kiriting: ");
                int N = Convert.ToInt32(Console.ReadLine());

                decimal natija = N*(1+N)/2;


                Console.Write($"Natija: {natija}");
            }
        }

    }

