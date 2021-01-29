using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/********************************************
Creador: Mauricio Lopez
Fecha: 25/02/2019
Version unica
/*******************************************/
namespace Calculo_1
{
    class Program
    {
        static void Main(string[] args)
        {

            bool NumerosAmigosPerfectos(int A, int B, int Contador, int respuestaA, int respuestaB) //retorna tru si son amigos o es un numero perfcto y false si no son ninguna de las opciones anteriores
            {
                if (A > B)
                {
                    if (Contador < A)
                    {
                        if (A % Contador == 0 && B % Contador == 0)
                        {
                            respuestaA = respuestaA + Contador;
                            respuestaB = respuestaB + Contador;
                            Contador++;
                            return NumerosAmigosPerfectos(A, B, Contador, respuestaA, respuestaB);
                        }
                        else if (A % Contador == 0)
                        {
                            respuestaA = respuestaA + Contador;
                            Contador++;
                            return NumerosAmigosPerfectos(A, B, Contador, respuestaA, respuestaB);
                        }
                        else if (B % Contador == 0 && B > Contador)
                        {
                            respuestaB = respuestaB + Contador;
                            Contador++;
                            return NumerosAmigosPerfectos(A, B, Contador, respuestaA, respuestaB);
                        }
                        else
                        {
                            Contador++;
                            return NumerosAmigosPerfectos(A, B, Contador, respuestaA, respuestaB);
                        }
                    }
                    else
                    {
                        if (A == respuestaB && B == respuestaA)
                        {
                            return true;
                        }
                        else
                        {
                            return false;
                        }
                    }
                }
                else if (B > A)
                {
                    if (Contador < B)
                    {
                        if (A % Contador == 0 && B % Contador == 0)
                        {
                            respuestaA = respuestaA + Contador;
                            respuestaB = respuestaB + Contador;
                            Contador++;
                            return NumerosAmigosPerfectos(A, B, Contador, respuestaA, respuestaB);
                        }
                        else if (A % Contador == 0 && A > Contador)
                        {
                            respuestaA = respuestaA + Contador;
                            Contador++;
                            return NumerosAmigosPerfectos(A, B, Contador, respuestaA, respuestaB);
                        }
                        else if (B % Contador == 0)
                        {
                            respuestaB = respuestaB + Contador;
                            Contador++;
                            return NumerosAmigosPerfectos(A, B, Contador, respuestaA, respuestaB);
                        }
                        else
                        {
                            Contador++;
                            return NumerosAmigosPerfectos(A, B, Contador, respuestaA, respuestaB);
                        }
                    }
                    else
                    {
                        if (A == respuestaB && B == respuestaA)
                        {
                            return true;
                        }
                        else
                        {
                            return false;
                        }
                    }
                }
                else
                {
                    if (Contador < A)
                    {
                        if (A % Contador == 0)
                        {
                            respuestaA = respuestaA + Contador;
                            Contador++;
                            return NumerosAmigosPerfectos(A, B, Contador, respuestaA, respuestaB);
                        }
                        else
                        {
                            Contador++;
                            return NumerosAmigosPerfectos(A, B, Contador, respuestaA, respuestaB);
                        }
                    }
                    else
                    {
                        if (A == respuestaA)
                        {
                            return true;
                        }
                        else
                        {
                            return false;
                        }
                    }
                }
            }

            int variablea = 0;
            int variableb = 0;
            if (NumerosAmigosPerfectos(6, 6, 1, variablea, variableb))
            {
                Console.WriteLine("hola mundo");
                Console.ReadKey();
            }

            int SumaRusa(int Multiplicador, int Multiplicando)
            {
                if(Multiplicador == 1)
                {
                    return Multiplicando;
                }
                else if ((Multiplicador % 2) == 1)
                {
                    return Multiplicando + SumaRusa(Multiplicador / 2, Multiplicando * 2);
                }
                else
                { 
                    return SumaRusa(Multiplicador / 2, Multiplicando * 2);
                }
            }
            
            int Factorial(int numero, int Contador)
            {
                if (Contador < numero)
                {
                    return Contador * Factorial(numero, Contador++);
                }
                else
                {
                    return Contador;
                }
            }
            int SumaRecursivaFactorial(int[] vector, int TamañoVector, int Contador)
            {
                if (TamañoVector < Contador)
                {
                    return Factorial(vector[Contador], 1) + SumaRecursivaFactorial(vector, TamañoVector, ++Contador);
                }
                else
                {
                    return 0;
                }
             }

            int prueba = SumaRusa(37, 12);
            int[] pruebita = { 5, 7, 4 };
            int apoyo = 0;





            int[] vectorsito = { 9, 8, 5, 10 };
            
            Console.WriteLine(Convert.ToString(Resta_recursiva(20, 3, 0)));
            Console.WriteLine("esta es la suma de 9, 8, 5, 10 y su resultado es =" + SumaVector(vectorsito, 4, 0));
            Console.ReadKey();



            int Resta_recursiva(int dividendo, int divisor, int contador)
            {
                if(dividendo >= divisor){
                    dividendo = dividendo - divisor;
                    return Resta_recursiva(dividendo, divisor, ++contador);
                }
                else{
                    return contador;
                }

            }
            int SumaVector(int[] vector, int TamanoVector, int contador)
            {
                if(contador < TamanoVector)
                {
                    return vector[contador] + SumaVector(vector, TamanoVector, ++contador);
                }
                else
                {
                return 0;
                }
            }



            string funcion(int r)
            {
                string funcion1 = "1";
                if(r ==1)
                { funcion1 = "Cos(x)"; }
                else if(r == 2)
                { funcion1 = "Sen(x)"; }
                else if(r == 3)
                { funcion1 = "Sec^2(x)"; }
                else if(r == 4)
                { funcion1 = "-Csc^2(x)"; }
                else if(r == 5)
                { funcion1 = "Sec(x) * Tan(x)"; }
                else if(r == 6)
                { funcion1 = "-Csc(x) * Cot(x)"; }
                return funcion1;
            }
            Random r1 = new Random();
            for (; ;)
            {
                Console.Clear();
                int int1 = r1.Next(0, 7);

                if(int1 == 1)
                {
                    Console.Write("Derivada de Sen(x) es igual a ");
                }
                else if (int1 == 2)
                {
                    Console.Write("Derivada de Cos(x) es igual a ");
                }
                else if(int1 == 3)
                {
                    Console.Write("Derivada de Tan(x) es igual a ");
                }
                else if(int1 == 4)
                {
                    Console.Write("Derivada de Cot(x) es igual a ");
                }
                else if(int1 == 5)
                {
                    Console.Write("Derivada de Sec(x) es igual a ");
                }
                else if(int1 == 6)
                {
                    Console.Write("Derivada de Csc(x) es igual a ");
                }
                Console.Write(funcion(int1));
                Console.ReadKey();
            }
        }
    }
}
