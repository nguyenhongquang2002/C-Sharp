using System;

namespace T2009M.session2
{
    public abstract class Animal
    {
        public string kind;

        public virtual void Eat()
        {
            Console.WriteLine("Eat...");
        }

        public abstract void AnimalSound();
    }
}