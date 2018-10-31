using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E3_EstDatos
{
    public class Operacion
    {
        public void Principal()
        {
            Stack Lista = new Stack();
            Queue Cola = new Queue();

        }
        private Stack Lista = new Stack(); 
        public void Ejercicio1()
        {
            //¿Qué valores se devuelven durante la siguiente serie de operaciones de pila,
            //si se ejecutan en una pila inicialmente vacía ?
            //push(5), push(3), pop(), push(2), push(8),
            //pop(), pop(), push(9), push(1), pop(), push(7), push(6), pop(), pop(), push(4),
            //pop(), pop()
            Console.WriteLine("Ejercicio 1: ");
            Lista.Push(5);
            Lista.Push(3);
            Lista.Pop();
            Lista.Push(2);
            Lista.Push(8);
            Lista.Pop();
            Lista.Pop();
            Lista.Push(9);
            Lista.Push(1);
            Lista.Pop();
            Lista.Push(7);
            Lista.Push(6);
            Lista.Pop();
            Lista.Pop();
            Lista.Push(4);
            Lista.Pop();
            Lista.Pop();          
            Console.WriteLine("Los valores almacenados en esta pila son: ");
            foreach (int item in Lista)
            {
                Console.WriteLine(item);
            }
            Console.ReadKey();
            Console.Clear();
        }

        public void Ejercicio2()
        {
            //Escriba en este metodo un modulo que pueda leer  y almacenar palabras reservadas en una lista enlazada 
            //e identificadores y literales en Otra lista enlazada.
            //Cuando el programa haya terminado de leer la entrada, mostrar
            //Los contenidos de cada lista enlazada.
            //Revise que es un Identificador y que es un literal
            Console.WriteLine("Ejercio 2: ");
            Console.WriteLine("La verdad no le entendí a este problema y por falta de tiempo no pude realizarla");
            Console.WriteLine("Puede proceder con los otros ejercicios");
            Console.ReadKey();


        }

        public void Ejercicio3()
        {
            //mida el tiempo entre Un lista ligada y una lista normal en el tiempo de ejecucion de 9876 elementos agregados.
            Console.WriteLine("Ejercicio 3: ");
            Console.WriteLine("Cargando...");
            const int elm = 9876;
            List<string> Lista = new List<string>();
            LinkedList<string> Listaligada = new LinkedList<string>();
            for (int i = 0; i <= elm; i++)
            {
                Lista.Add("Listalig");
                Listaligada.AddLast("Listalig");
            }
            var l1 = Stopwatch.StartNew();
            for (int i = 0; i <= elm; i++)
            {
                foreach(string item in Lista)
                {
                    if(item.Length != 8)
                    {
                        throw new Exception();
                    }
                }
            }
            l1.Stop();
            var l2 = Stopwatch.StartNew();
            for (int i = 0; i <= elm; i++)
            {
                foreach (string item in Listaligada)
                {
                    if (item.Length != 8)
                    {
                        throw new Exception();
                    }
                }
            }
            l2.Stop();
            Console.Clear();
            Console.WriteLine("Ejercicio 3: ");
            Console.WriteLine("El tiempo de ejecución de la lista es : " + (l1.Elapsed.TotalSeconds) + " segundos.");
            Console.WriteLine("El tiempo de ejecución de la lista ligada es : " + (l2.Elapsed.TotalSeconds) + " segundos.");
            Console.ReadKey();
            Console.Clear();
        }

        public void Ejercicio4()
        {

            // Diseñar e implementar una clase que le permita a un maestro hacer un seguimiento de las calificaciones
            // en un solo curso.Incluir métodos que calculen la nota media, la
            //calificacion más alto, y el calificacion más bajo. Escribe un programa para poner a prueba tu clase.
            //implementación. Minimo 30 Calificaciones, de 30 alumnos.
            Console.WriteLine("Ejercicio 4: ");
            Console.WriteLine("Calificaciones.");
            Console.WriteLine("De qué materia ingresará los datos?");
            string materia = Console.ReadLine();
            Console.WriteLine("Ingrese su nombre de profesor");
            Calificaciones Cali;
            string Profe = Console.ReadLine();
            Console.WriteLine("Cúantos alumnos ingresará?");
            int Al = int.Parse(Console.ReadLine());
            List<Calificaciones> Calific = new List<Calificaciones>();
            int Cmenor = 100, Cmayor = 0, Emenor = 0, Emayor = 0, cont = 0, suma = 0;
            for (int i = 0; i <Al; i++)
            {
                Cali = new Calificaciones();
                Console.WriteLine("Ingrese el nombre del alumno");
                Cali.Alumno = Console.ReadLine();
                Console.WriteLine("Ingrese la calificación asignada");
                Cali.Calificacion = int.Parse(Console.ReadLine());
                Console.Clear();
            }
            Console.WriteLine("Las calificaciones de la materia " + materia + " ingresadas por el profesor " + Profe + " son:");
            foreach (var item in Calific)
            {
                Console.WriteLine(item.Alumno + ": " + item.Calificacion);
            }
            foreach (var item in Calific)
            {
                if (item.Calificacion < Cmenor)
                {
                    Cmenor = item.Calificacion; Emenor = cont;
                }
                if (item.Calificacion > Cmayor)
                {
                    Cmayor = item.Calificacion; Emayor = cont;
                }
                suma = item.Calificacion + suma; cont++;
            }
            Console.WriteLine("La menor calificacion es " + Cmenor);
            Console.WriteLine("La mayor calificación es " + Cmayor);
            Console.ReadKey();

        }
    }
}
