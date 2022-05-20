using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Operadores
{
    internal class Ciclos
    {
        private double a = 0;
        private double b = 0;
        private double c = 0;
        private double d = 0;
        public double geta()
        {
            return this.a;
        }
        public void seta(double a)
        { this.a = a; }
        public double getb()
        {
            return this.b;
        }
        public void setb(double b)
        { this.b = b; }
        public double getc()
        {
            return this.c;
        }
        public void setc(double c)
        { this.c = c; }
        public double getd()
        {
            return this.d;
        }
        public void setd(double d)
        { this.d = d; }

        public void Ciiclos()
        {
            int s1 = 0;
            do
            {
                try
                {
                    Console.WriteLine("Bienvenido al menu de los ciclos");
                    Console.WriteLine("--------------------------------");
                    Console.WriteLine("1. Si desea imprimir todos los multiplos de 3 que hay entre 0 y 100");
                    Console.WriteLine("2. Si desea imprimir todos los impares que hay entre 0 y 100");
                    Console.WriteLine("3. Si desea imprimir todos los pares que hay entre 0 y 100");
                    Console.WriteLine("4  Si desea un programa que imprima todos los cuadrados de los numeros del 1 al 30");
                    Console.WriteLine("5. Si desea un programa que sume todos los cuadrados de los primeros 100 numeros naturales");
                    Console.WriteLine("6. Si desea un programa que dados 2 numeros muestre los numeros comprendidos entre la secuencia ascendente de estos");
                    Console.WriteLine("7. Si desea un programa que sume todos los numeros ingresados por consola");
                    s1 = char.Parse(Console.ReadLine());
                    switch (s1)
                    {
                        case '1': c1(); break;
                        case '2': c2(); break;
                        case '3': c3(); break;
                        case '4': c4(); break;
                        case '5': c5(); break;
                        case '6': c6();break;
                    }
                } catch (FormatException ex)
                {
                    Console.WriteLine("No especifico ninguna opcion valida");
                    Ciclos ciclos = new Ciclos();
                    ciclos.Ciiclos();
                }
                } while (s1 == 1 || s1 == 2 || s1 == 3 || s1 == 4 || s1 == 5 || s1 == 6 || s1 == 7 || s1 == 0);
        }
        public double c1()
        {
            Console.WriteLine("Ingrese un numero entero , para saber si es multiplo de 3");
            a = int.Parse(Console.ReadLine());
            if (a / 3 == 0)
            {
                Console.WriteLine(a + " Es multiplo de 3");
            }
            else
            {
                Console.WriteLine("No es multiplo de 3");
            }
            return a;
        }
        public double c2()
        {
            Console.WriteLine("Los numeros impares del 1 al 100 son: ");
            for (int i = 1; i < 100; i += 2)
            {
                Console.Write(" | " + i);
            }
            return 0;
        }
        public double c3()
        {
            Console.WriteLine("Los numeros pares del 1 al 100 son: ");
            {
                for (int i = 0; i < 101; i +=2)
                {
                    Console.Write(" | " + i);
                }
            }
            return 0;
        }
        public double c4()
        {
            Console.WriteLine("Los cuadrados de los numeros del 1 al 30 son: ");
            for (int i = 1; i < 30; i ++)
            {
                Console.WriteLine(i * i);
            }
            Console.ReadLine();
           return 0;
     
        }
        public double c5()
        {
            Console.WriteLine("Los cuadrados de los numeros del 1 al 30 son: ");
            for (int i = 1; i < 101; i++)
            {
                Console.WriteLine("El numero" + i);
                c = c + i * i;
                Console.WriteLine("el cuadrado es:" + Math.Pow(i, 2));
            }
            Console.WriteLine("la suma total de los cuadrados es: " + c);
            Console.ReadLine();
            return 0;

        }
        public double c6()
        {
            Console.WriteLine("Bienvenido al menu");
            Console.WriteLine("Ingrese 2 numeros");
            Console.WriteLine("Ingrese el primer numnero");
            a = double.Parse(Console.ReadLine());
            b = double.Parse(Console.ReadLine());
            if (a < b)
            {
                for (double i = a; i < b; i++)
                {
                    Console.WriteLine(i);
                }
             }
            else
            {
                Console.WriteLine("No especifico nada");
            }
            return 0;
        }
    }
    
}
