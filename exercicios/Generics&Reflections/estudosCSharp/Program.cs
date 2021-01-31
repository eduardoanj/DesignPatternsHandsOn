using System;
using System.ComponentModel.DataAnnotations;
using System.Runtime.CompilerServices;
using System.Text;
using estudosCSharp.Entities;

namespace estudosCSharp
{
    class Program
    {
        static void Main(string[] args)
        {
            var pai = new Galinha() {Cor = "branca"};
            var mae = new Galinha() {Cor = "azul"};

            var filhote = Cruzar(pai, mae);

            var avestruz = new Avestruz() {Correr = true};

            var tipo = filhote.GetType();

            Console.WriteLine($" O tipo do filhote é: {tipo}");

            Log(avestruz);
        }

        public static Ave<T> Cruzar<T>(T pai, T mae) where T : Ave<T>
        {
            var classeGenetica = Activator.CreateInstance<T>();

            classeGenetica.Mae = mae;
            classeGenetica.Pai = pai;
            return classeGenetica;
        }

        public static void Log(object obj)
        {
            var tipo = obj.GetType();

            foreach (var p in tipo.GetProperties())
            {
                Console.WriteLine($"{p.Name}: {p.GetValue(obj)}");
            }
        }
    }
}
