public class Guerreiro : Personagem
{
    public Guerreiro(string nome, int ataque): base(nome, ataque){}
    
    public override void Atacar()
    {
        Console.WriteLine($"{nome}, ataca de ESPADA!");
    }

    public void BrilhoSentilhante()
    {
        ataque *= 2;
        Console.WriteLine($"Ataque modificado para: {ataque}");
        Console.WriteLine($"{nome}, ataca Brilho sentilhante. ADEUS!");
    }

    public override void Defesa()
    {
        Console.WriteLine($"{nome}, se esquivou do ataque");
    }
}
