using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Operadores
{
     class Class1
    {
        public 
            void carlos()
        {
            int operadores;
            Console.WriteLine("Bienvenido al menu");
            Console.WriteLine("Elija 1. si desea hacer operaciones");
            Console.WriteLine("Elija 2. si desea ver los condicionales");
            Console.WriteLine("Elija 3. si desea ver los Ciclos");
            Console.WriteLine("Elija 4. si desea ver los bucles");
            Console.WriteLine("Elija 0. si dese salir del programa");
            operadores = char.Parse(Console.ReadLine());
            switch (operadores)
            {
                case '1': operaciones(); break;
                case '2': Condicionales(); break;
                case '3': Ciclos(); break;
                case '4': Bucles(); break;
                case '0': Environment.Exit(1); ; break;
                default: Console.WriteLine("no especifico ninguna opcion"); break;
            }
        }
        public static void operaciones()
        {
            int a;
            int b;
            int c;
            char ej1;
            Console.WriteLine("Bienvenido al menu");
            Console.WriteLine("------------------");
            Console.WriteLine(" Elija 1 si desea ver el Area de un triangulo");
            Console.WriteLine(" Elija 2 si desea hacer una suma  Suma ");
            Console.WriteLine(" Elija 3 si desea hacer una Potencia al cuadrado");
            Console.WriteLine(" Elija 4 si desea hacer una Conversion euros a dolares");
            Console.WriteLine(" Elija 5 si desea un algoritmo que muestre el valor del area y el perimetro de un cuadrardo con el lado de un cuadrado.");
            Console.WriteLine(" Elija 6 si desea Escribir un algoritmo que determine el área y el volúmen de un cilindro.");
            Console.WriteLine(" Elija 7 si desea un algoritmo que lea el radio de una circunferencia y escriba la longitud de la misma y el area del circulo inscrito");
            Console.WriteLine(" Elija 8 si desea Calcular el promedio de tres números ingresados por teclado.");
            Console.WriteLine(" Elija 0 si desea salir del programa");
            ej1 = char.Parse(Console.ReadLine());
            switch (ej1)
            {
                case '1': Art(); break;
                case '2': Sum(); break;
                case '3': Pot(); break;
                case '4': Con(); break;
                case '5': Cuadrado(); break;
                case '6': Cilindro(); break;
                case '7': Circulo(); break;
                case '8': promedio(); break;
                case '0': Environment.Exit(1); break;
                default: break;
            }
        }
        static void Art()

        {
            int a;
            int b;
            int area;
            Console.WriteLine("Por favor, digite la base del triangulo");
                b = int.Parse(Console.ReadLine());
                Console.WriteLine("no especifico ningun dato valido , se tomara su numero como 1");
                b = 1;
            
            Console.WriteLine("Por favor digite la atura del triangulo");
                a = int.Parse(Console.ReadLine());
                Console.WriteLine("no especifico ningun dato valido,se tomara su numero como 1");
                a = 1;
            area = b * a / 2;
            Console.WriteLine("El area del tringulo es: " + area);
        }

        static void Sum()
        {
            int n1;
            int n2;
            int total;
            Console.WriteLine("Por favor digite el primer numero para realizar la suma"); 
            n1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Por favor digite el segundo numero para completar la suma");
            n2 = Convert.ToInt32(Console.ReadLine());
            total = n1 * n2;
            Console.WriteLine("El resultado de la suma es: " + total);

        }
        static void Pot()
        {
            int numero1;
            int total;
            Console.WriteLine("Por favor digite un numero para saber el cuadrado");
            numero1 = Convert.ToInt32(Console.ReadLine());
            total = numero1 * numero1;
            Console.WriteLine("El resultado de la potencia es: " + total);


        }

        static void Con()

        {
            float e;
            float d;
            Console.WriteLine("Digite el numero en Euros");
            e = Convert.ToSingle(Console.ReadLine());
            d = (float)(e * 1.0831);
            Console.WriteLine(e + " en doloares es " + d);
        }


        static void Cuadrado()
        {
            int lado;
            int p;
            int a;
            Console.WriteLine("Digite la medida de un lado del cuadrado");
            lado = Convert.ToInt32(Console.ReadLine());
            p = lado * 4;
            a = lado * lado;
            Console.WriteLine("El perimetro de su cuadrado es: " + p);
            Console.WriteLine("El area de su cuadrado es: " + a);


        }
        static void Cilindro()
        {
            int area;
            int volumen;
            int radio;
            int altura;
            Console.WriteLine("Digite el radio de su cilindro");
            radio = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Digite la altura del cilindro");
            altura = Convert.ToInt32(Console.ReadLine());
            area = (int)(System.Math.PI * 2 * radio + altura + System.Math.PI * 2 * radio * radio);
            volumen = ((int)(System.Math.PI * radio * radio * altura));
            Console.WriteLine("El area de su cilindro es: " + area);
            Console.WriteLine("El volumen de su cilindro es " + volumen);

        }
        static void Circulo()
        {
            int radio;
            int area;
            int longitud;
            Console.WriteLine("Digite el radio de la circunferencia");
            radio = Convert.ToInt32(Console.ReadLine());
            longitud = (int)(radio * 2 * System.Math.PI);
            area = (int)(System.Math.PI * radio * radio);
            Console.WriteLine("El area del circulo es: " + area);
            Console.WriteLine("La longitud de la circunferencia es: " + longitud);
        }
        static void promedio()
        {
            int datos;
            int d2;
            int d3;
            int promedio;
            Console.WriteLine("Digite 3 numeros enteros para saber su promedio");
            Console.WriteLine("Digite el primer numero");
            datos = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Digite el segundo numero");
            d2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Digite el tercer numero");
            d3 = Convert.ToInt32(Console.ReadLine());
            promedio = datos + d2 + d3 / 3;
            Console.WriteLine("El promedio de sus numeros es: " + promedio);

        }
        public static void Bucles()
        {
            Console.WriteLine("Seccion en proceso");
        }
        public static void Condicionales()
        {
            int gg;
            Console.WriteLine("Bienvenido a los condicionales");
            Console.WriteLine("---------------------------");
            Console.WriteLine("1. Si desea saber si el numero que ingreso es positivo o negativo");
            Console.WriteLine("2. Si desea escribir 2 numeros y saber cual es menor y cual es mayor");
            Console.WriteLine("3. Si desea un programa que lea tres números enteros positivos y que calcule e imprima en pantalla el menor y el mayor de ellos.");
            Console.WriteLine("4. Si desea poner 2 numeros y si el primero es mayor sumarlo sino restarlos ");
            Console.WriteLine("5. Si desea elegir dos números A y B encontrar el cociente entre A y B.");
            Console.WriteLine("6. Si desea dados dos números A y B, sumarlos si al menos uno de ellos es negativo, en caso contrario multiplicarlos.");
            Console.WriteLine("6. Si desea un algoritmo que deermine si un año es biciesto o no");
            gg = char.Parse(Console.ReadLine());
            switch (gg)
            {
                case '1': pos(); break;
                case '2': ej2(); break;
                case '3': ej3(); break;
                case '4': ej4(); break;
                case '5': ej5(); break;
                case '6': ej6(); break;
                case '7': ej7(); break;
                case '8':; break;
                case '0': Environment.Exit(1); break;
                default: break;
            }

        }
        public static void pos()
        {
            int a;
            Console.WriteLine(" digite un numero para saber si es positivo o negativo");
            a = Convert.ToInt32(Console.ReadLine());
            if (a < 0)
            {
                Console.WriteLine("su numero es negativo");

            }
            if (a > 0)
            {
                Console.WriteLine("su numero es positivo");
            }


        }
        public static void ej2()
        {
            int a;
            int b;
            Console.WriteLine("Digite 2 numeros enteros para saber cual es mayor y cual es menor");
            Console.WriteLine("Digite el primer numero");
            a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Digite el segundo numero");
            b = Convert.ToInt32(Console.ReadLine());
            if (a < b)
            {
                Console.WriteLine(a + " Es el numero menor ");
                Console.WriteLine(b + " Es el numero mayor");

            }
            if (b < a)
            {
                Console.WriteLine(b + " Es el numero menor");
                Console.WriteLine(a + " Es el numero mayor");
            }

        }
        public static void ej3()
        {
            int a;
            int b;
            int c;
            Console.WriteLine("Digite 3 numero enteros");
            Console.WriteLine("Digite el primer numero");
            a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Digite el segundo numero");
            b = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Digite el tercer numero");
            c = Convert.ToInt32(Console.ReadLine());
            if (a < b && a < c)
            {
                Console.WriteLine(a + " Es el numero mayor");
                
            }
            else if (b < c && b < a)
            {
                Console.WriteLine(b + " Es el numero mayor");
                
            }
            else 
            {
                Console.WriteLine(c + " Es el numero mayor");
            }
            if (a > b && a > c)
            {
                Console.WriteLine(a + " Es el numero Menor");
            }
            else if (b > c && b > a)
            {
                Console.WriteLine(b + " Es el numero menor");
            }
            else
            {
               Console.WriteLine(c + " Es el numero menor");
            }

        }
        public static void ej4()
        {
            int a, b, r, r2;
            Console.WriteLine("Digite 2 numeros enteros");
            Console.WriteLine("Digite el primer numero");
            a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Digite el segundo numero");
            b = Convert.ToInt32(Console.ReadLine());
            r = a + b;
            r2 = a - b;
            if (a > b)
            {
                Console.WriteLine("El resultado de la suma de los 2 numeros es: " + r);
            }
            else if (a < b)
            {
                Console.WriteLine("El resultado de la resta de los 2 numeros es: " + r2);
            }
        }
        public static void ej5()
        {
            int a, b, r, r2;
            Console.WriteLine("Digite 2 numeros enteeros para saber su cociente");
            Console.WriteLine("Digite el primer numero");
            a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Digite el segundo numero");
            b = Convert.ToInt32(Console.ReadLine());
            r2 = a / b;
            if (a == 0 || b == 0)
            {
                Console.WriteLine("No se puede divir entre 0");
            }
            if (a < 0 || b < 0)
            {
                Console.WriteLine("El resultado de la division es: " + r2);
            }

        }
        public static void ej6()
        {
            int a;
            int b;
            int c;
            int r ,r2;
            Console.WriteLine("Digite 3 numero enteros");
            Console.WriteLine("Digite el primer numero");
            a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Digite el segundo numero");
            b = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Digite el tercer numero");
            c = Convert.ToInt32(Console.ReadLine());
            r = a + b;
            r2 = a * b;
            if (a < 0 || b < 0)
            {
                Console.WriteLine("Se va sumar sus numeros");
                Console.WriteLine("EL resultado de la suma es" + r);
            }
            else if (a > 0 || b > 0)
            {
                Console.WriteLine("Se van a multiplicar sus numeros" + r);
                Console.WriteLine("El resultado de la multiplicacion es " + r2);
            }    
        }
        public static void ej7()
        {
            int a;
            Console.WriteLine("Digite un año para saber si es bisiesto");
            a = Convert.ToInt32(Console.ReadLine());
            if (a % 4 == 0 && a % 100 != 0 || a % 400 == 0)
            {
                Console.WriteLine("Es bisiesto "+ a);
            }
            else
            {
                Console.WriteLine("no es bisiesto " + a);
            }
            



        }
        


        public  void Ciclos()
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
            int s1;
            s1 = char.Parse(Console.ReadLine());
            switch(s1)
            {
                case '1': c1(); break;
                case '2': c2(); break;
            }
        }
        public static void c1()
        {
            int a, b, c, r;
            Console.WriteLine("Ingrese un numero entero , para saber si es multiplo de 3");
            a = int.Parse(Console.ReadLine());  
            if(a / 3 == 0)
            {
                Console.WriteLine(a + " Es multiplo de 3");
            }
            else
            {
                Console.WriteLine("No es multiplo de 3");
            }
        }
        public static void c2()
        {
           
           for(int i = 0; i < 10; i += 2)
            {
                Console.WriteLine("UWU");
            }
        }
        public static void uwu()
        {
            do
            {
                Console.WriteLine("UWU");
            }while(true);
        }
    }
    
    
}
