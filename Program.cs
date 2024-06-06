using System.ComponentModel.Design;

bool menu = true;
bool play = true;
Guerreiro guerreiro;
Mago mago;
Suporte inimigo

int escolha = 0;

do
{
    string opcao = "";
    string nome = "";

    Console.Clear();
    Console.WriteLine("##### BEM-VINDO À DUNGEONS #####");
    Console.WriteLine("Aperte um numero para escolher seu personagem");
    Console.WriteLine("1- Guerreiro | 2- Mago | 3- Suporte | 4- Sair");
    opcao = Console.ReadLine();

    switch (opcao)
    {
        case "1":
        escolha = 1;
        Console.WriteLine("Digite seu nome guerreiro");
        nome = Console.ReadLine();
        Guerreiro soldado = new Guerreiro(nome, 50);
        soldado.Status();
        menu = false;
        break;
        case "2":
        escolha = 2;
        Console.WriteLine("Digite seu nome magico");
        nome = Console.ReadLine();
        Mago Inimigo = new Mago(nome, 25);
        Inimigo.Status();
        break;
        case "3":
        Suporte Invocador = new Suporte("Ana", 20);
        Invocador.Status();
        break;
        case "4":
        play = false;
        break;
        default:
        Console.WriteLine("Escolha uma das opções do menu");
        break;
    }

    Console.WriteLine("Aperte Enter para continuar...");
    Console.ReadLine();
}
    while(play);

    if(play)
    {
        Console.WriteLine("Prepare-se a luta esta adiante...");
        Console.ReadLine();
        do
        {
            Console.WriteLine("Escolha o 1-Ataque | 2-Defesa | 3-Especial");

            switch(opcao)
            {
                case 1:
                if(escolha == 1)
                {
                    guerreiro.Atacar();
                    inimigo.Defesa();
                }
                else
                {
                    mago.Atacar();
                    inimigo.defesa();
                }
            }
        }while(play);
    }


/*anonimo.Atacar();
anonimo.TansmutacaoUniversal();

soldado.Atacar();
soldado.BrilhoSentilhante();

Inimigo.Atacar();
Inimigo.GolpeMagiaJiboia();

Invocador.Atacar();
Invocador.Compartilhar();*/ 