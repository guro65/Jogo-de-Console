public class Mago : Personagem
{
    public Mago(string nome, int ataque): base(nome, ataque){}

    public override void Atacar()
    {
        Console.WriteLine($"{nome}, lança MAGIA!");
    }

    public void GolpeMagiaJiboia()
    {
        ataque *= 2;
        Console.WriteLine($"Ataque modificado para: {ataque}");
        Console.WriteLine($"{nome}, invoca seu golpe magia jiboia. MORRA FDP!");
    }
     public override void Defesa()
    {
        Console.WriteLine($"{nome}, Absorveu o ataque");
    }
}