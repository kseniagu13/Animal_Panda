using System;
using System.Collections.Generic;


namespace Animal
{
    class Animal
    {
        //loome objekti omadused ja suure tähega
        protected string Name;
        protected int Age;

        public void PrintAnimalBaseInfo() //kuvame Panda nime ja vanust, teeme klassi sees
        {
            Console.WriteLine($"Your pet's name is {Name}, it is {Age} years old.");
        }
    }

    class Panda : Animal //saame kasutada selles klassis Animali klassi omadused
    {
        protected string EatsOnly; //Panda omadus

        public Panda(string _name, int _age, string _eatsOnly) //konstruktor sama nimega mis klassil
        {
            Name = _name;
            Age = _age;
            EatsOnly = _eatsOnly;
            Console.WriteLine("Congrats. The Panda has been created.");

        }

        public void PrintPandaFoodInfo() //meetod
        {
            Console.WriteLine($"Your Panda eats only {EatsOnly}");
        }


    }
    class Program
    {
        static void Main(string[] args)
        {
            /*Panda panda1 = new Panda("Panda1", 1, "bamboo"); //loome panda objekti Panda konstruktorist
            Panda panda2 = new Panda("Panda2", 2, "bananas");
            Panda panda3 = new Panda("Panda3", 3, "apples");
            panda1.PrintAnimalBaseInfo();
            panda1.PrintPandaFoodInfo();*/

            Console.WriteLine("Let s create a panda: ");
            string userPanda = Console.ReadLine();
            string[] userPandaArray = userPanda.Split(new char[] { ' ', ',' }, StringSplitOptions.RemoveEmptyEntries); //looem massiivi et salvestada vastused

            /*foreach (string element in userPandaArray) //peab sama nimega olema mis massivi nimi, muidu ei loe sealt
                {
                Console.WriteLine($"{element}");
            }*/

            Panda panda = new Panda(userPandaArray[0], int.Parse(userPandaArray[1]), userPandaArray[2]); //objekti loomine
            //kui mitu pandat peame looma listi, et saaks neid salvestada sinna sisse

            List<Panda> listOfPandas = new List<Panda>();
            listOfPandas.Add(panda);

            foreach (Panda pandaAnimal in listOfPandas)
            {
                pandaAnimal.PrintPandaFoodInfo(); //kuvame mida ta sööb
            }





        }
    }
}
