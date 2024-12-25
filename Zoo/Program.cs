namespace Zoo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Animal cat = new Cat();
            Animal dog = new Dog();
            cat.Eat();
            cat.MakeSound();
            dog.Eat();
            dog.MakeSound();
            if (dog is Irunnable runableDog)
            {
                runableDog.Run();
            }
            if (cat is Irunnable runableCat)
            {
                runableCat.Run();
            }

        }
    }
}
