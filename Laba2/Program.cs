using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Laba2
{
    internal class Program
    {
        public static double A, B;
        static void Main(string[] args)
        {
            while (true) {
                Console.WriteLine(
                    "Меню:\n1. Ввести А\n2. Ввести B\n3. Сложение\n4. Вычитание\n5. Умножение\n6. Деление\n0. Выход"
                    );
                string menu = Console.ReadLine();

                switch (menu)
                {
                    case "1":
                        InputA(A); break;
                    case "2":
                        InputB(B); break;
                    case "3":
                        Add(A,B); break;
                    case "4":
                        Sub(A,B); break;
                    case "5":
                        Mult(A,B); break;
                    case "6":
                        Div(A,B); break;
                    case "0":
                        return;
                    default:
                        Console.WriteLine("Something went wrong");break;
                }
            }

        }
        static void InputA(double x) { }
        static void InputB(double x) { }
        static void Add(double x,double y) { }
        static void Sub(double x, double y) { }
        static void Mult (double x, double y) { }
        static void Div(double x, double y) { }
    }
}
