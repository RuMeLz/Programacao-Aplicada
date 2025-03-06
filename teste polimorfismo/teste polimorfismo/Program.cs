// See https://aka.ms/new-console-template for more information
class Animal // Classe base (pai)
{
    public void animalSound()
    {
        Console.WriteLine("O animal faz um som");

    }
}
class Pig : Animal // Classe derivada (Filha)
{
    public void animalSound()
    {
        Console.WriteLine("O porco diz: xixi");
    }
}
class Dog : Animal // Classe derivada (Filha)
{
    public void animalSound()
    {
        Console.WriteLine("O cão diz: uau");
    }
}
class Program
{

    static void Main(string[] args)
    {
        Animal myAnimal = new Animal(); // Crie o objeto Animal

        Pig myPig = new Pig(); // Crie o objeto Porco
        Dog myDog = new Dog(); // Crie o objeto Cão
        myAnimal.animalSound();
        myPig.animalSound();
        myDog.animalSound();
    }
}
