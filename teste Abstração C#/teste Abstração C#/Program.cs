abstract class  Animal // calsse abstrata (não pode ter objetos que a tenham como origem)
{
public abstract void AnimalSound(); // método abstrato do qual deve ser feita a função através de uma classhe de heranca
public void Sleep() // método normal (que também pode estar presente)
{
    Console.WriteLine("Zzz");
}
}
class Pig : Animal // classe herdada de animal
{
    public override void AnimalSound() // método abstrato ganha corpo com a chave "override" (para substituir)
    {
        Console.WriteLine("The pig says: wee wee");
    }
}
class Program // uso da classe herdada para us
{
    static void Main(string[] args)
    {
        Pig myPig = new Pig();
        myPig.AnimalSound();
    myPig.Sleep();
    }
}