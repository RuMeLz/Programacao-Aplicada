abstract class  Animal // calsse abstrata (não pode ter objetos que a tenham como origem)
{
public abstract void AnimalSound(); // método abstrato do qual deve ser feita a função através de uma classhe de heranca
public void Sleep() // método normal (que também pode estar presente)
{
    Console.WriteLine("Zzz");
}
}
class Dog : Animal // classe herdada de animal
{
    public override void AnimalSound() // método abstrato ganha corpo com a chave "override" (para substituir)
    {
        Console.WriteLine("The pig says: MAMA MIA");
    }
}
class Cat : Animal // classe herdada de animal
{
    public override void AnimalSound() // método abstrato ganha corpo com a chave "override" (para substituir)
    {
        Console.WriteLine("The pig says: MAMA MIA");
    }
}
class Program // uso da classe herdada para usar os métodos criados
{
    static void Main(string[] args) // execucao dos metodos
    {
        Pig myPig = new Pig(); // cria o objeto mypig
        myPig.AnimalSound(); //método abstrato substituido usado no objeto
    myPig.Sleep(); //método regular
    }
}