using System;


public class AnimalWorld
{
    protected abstract class Continent
    {
        protected abstract Herbivore CreateHerbivore();
        protected abstract Carnivore CreateCarnivore();
        public void RunFoodChain()
        {
            var herbivore = CreateHerbivore();
            var carnivore = CreateCarnivore();

            carnivore.Eat(herbivore);
        }
    }

    public abstract class Herbivore
    {

    }

    public abstract class Carnivore
    {
        public void Eat(Herbivore herbivore)
        {
            Console.WriteLine($"Carnivore {this.GetType()} cought herbivore {herbivore.GetType()}.");
        }
    }

    class Africa : Continent
    {
        protected override Herbivore CreateHerbivore()
        {
            return new Wildbeest();
        }

        protected override Carnivore CreateCarnivore()
        {
            return new Lion();
        }
    }

    class Lion : Carnivore { }

    class Wildbeest : Herbivore { }


    class America : Continent
    {
        protected override Herbivore CreateHerbivore()
        {
            return new Bison();
        }

        protected override Carnivore CreateCarnivore()
        {
            return new Wolf();
        }
    }

    class Wolf : Carnivore { }

    class Bison : Herbivore { }

    public void Run()
    {
        var africa = new Africa();
        var america = new America();

        //Carnivore lion = africa.CreateCarnivore();
        //Herbivore wildbeest = africa.CreateHerbivore();

        //Carnivore wolf = america.CreateCarnivore();
        //Herbivore bison = america.CreateHerbivore();
        Console.WriteLine("Hello America!");
        america.RunFoodChain();

        Console.WriteLine("Hello Africa!");
        africa.RunFoodChain();
    }
}