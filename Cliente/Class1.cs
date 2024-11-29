using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Poli
{
    public class Animal
    {
        public virtual void EmitirSom() { Console.WriteLine("Som genérico"); }
    }

    public class Cao : Animal
    {
        public override void EmitirSom() { Console.WriteLine("Au au"); }
    }

    public class Gato : Animal
    {
        public override void EmitirSom() { Console.WriteLine("Miau"); }
    }

    public class ExecutaSons
    {
        public void Executar()
        {
            var animais = new List<Animal> { new Cao(), new Gato() };

            foreach (var animalSom in animais)
            {
                animalSom.EmitirSom();
            }
        }
    }
}
