abstract class  Animal // calsse abstrata (não pode ter objetos que a tenham como origem)
{
public abstract void AnimalSound(); // método abstrato do qual deve ser feita a função através de uma classe de heranca
public void Sleep() // método normal (que também pode estar presente)
{
    Console.WriteLine("AHH FIIUU");
}
}
class Dog : Animal // classe herdada de animal
{
    public override void AnimalSound() // método abstrato ganha corpo com a chave "override" (para substituir)
    {
        Console.WriteLine("The Dog says: PUTA MADRE");
    }
}
class Cat : Animal // classe herdada de animal
{
    public override void AnimalSound() // método abstrato ganha corpo com a chave "override" (para substituir)
    {
        Console.WriteLine("The Cat says: HIJO DE PUTA");
    }
}
class Program // uso da classe herdada para usar os métodos criados
{
    static void Main(string[] args) // execucao dos metodos
    {
        Dog myDog = new Dog(); // cria o objeto myDog
        myDog.AnimalSound(); //método abstrato substituido usado no objeto
    myDog.Sleep(); //método regular
        Cat myCat = new Cat(); // cria o objeto myDog
        myCat.AnimalSound(); //método abstrato substituido usado no objeto
        myCat.Sleep(); //método regular
    }
}