public  abstract class Personagem
{
    //atributos ou membros da classe

    protected string nome;
    protected int ataque;
    protected float vida = 100;
    protected bool comVida = true;

    //construtor
    public Personagem(string nome, int ataque) //dentro dos parenteses estão os parametros
    {
        this.nome = nome; //this = uma palavra reserveda que aponta para a propria classe
        this.ataque = ataque; 
    }

    //metodo = comportamento da classe

    public virtual void Atacar()
    { 
        Console.WriteLine($"{nome}, ataca!");
    }

    public void TansmutacaoUniversal()
    {
        ataque *= 2;
        Console.WriteLine($"Ataque modificado para: {ataque}");
        Console.WriteLine($"{nome}, usa transmutação universal. IDIOTA!");
    }

    public abstract void Defesa();

    public void Status()
    {
        Console.WriteLine("----------------------");
        Console.WriteLine($"☬ Nome: \t {nome} \t ");
        Console.WriteLine($"☬ Ataque: \t {ataque} \t ");
        Console.WriteLine($"☬ Vida: \t {vida} \t ");
        Console.WriteLine("----------------------");
    }
}