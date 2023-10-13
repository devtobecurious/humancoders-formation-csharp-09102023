
using DiscoverEvents;

Alarme alarme = new();

void RegarderAlarme(object? sender, EventArgs e)
{
    Console.WriteLine("Oh non l'alarme démarre");
}

void ReveillerLeChat(object? sender, EventArgs e)
{
    Console.WriteLine("Miaowww");
}

void MeReveiller(object? sender, EventArgs e)
{
    Console.WriteLine("La flemme, je veux dormir");
}

alarme.AlarmeStart += RegarderAlarme;
alarme.AlarmeStart += RegarderAlarme;
alarme.AlarmeStart += ReveillerLeChat;
alarme.AlarmeStart += MeReveiller;

Console.WriteLine("Ca commence");
alarme.Sonner(10);
Console.WriteLine("Ca finit");

alarme.AlarmeStart -= RegarderAlarme;
alarme.AlarmeStart -= RegarderAlarme;
alarme.AlarmeStart -= ReveillerLeChat;
alarme.AlarmeStart -= MeReveiller;


