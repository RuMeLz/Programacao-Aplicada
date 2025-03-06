// See https://aka.ms/new-console-template for more information

class Animal 
{
    public virtual void animalSound()
    {
        Console.WriteLine("O animal faz um som. ");
    }

}

class Pig : Animal 
{
    public override void animalSound()
    {
        Console.WriteLine("O porco faz: MAMA MIA");
    }
}

class Dog : Animal 
{
    public override void animalSound()

    {
        Console.WriteLine("O cachorro diz: PUTA MADRE");
    }
}

class Program
{
    static void Main(string[] args)
    {
        Animal myAnimal = new Animal(); 
        Animal myPig = new Pig(); 
        Animal myDog = new Dog(); 
    
        myAnimal.animalSound();
        myPig.animalSound();
        myDog.animalSound();
    }
}