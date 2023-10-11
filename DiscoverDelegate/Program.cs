using DiscoverDelegate;

void AfficherEnCouleur(ConsoleColor color, string message, params object[] args)
{
    Console.ForegroundColor = color;

    Console.WriteLine(message, args);

    Console.ForegroundColor = ConsoleColor.White;
}

AfficherEnCouleur(ConsoleColor.Green, "Ah que johny", 1, 2, 3, 4, "test");

// La signature : retour void // un param string
Console.WriteLine("Message");


//int SommerEtAfficher(Afficher<string> afficher, params int[] args)
int SommerEtAfficher(Action<string> afficher, params int[] args)
{
    int result = args.Sum();
    //    afficher(result.ToString()); => si nullable, ça plante
    afficher?.Invoke(result.ToString()); // ici, ça planetra jamais

    return result;
}
SommerEtAfficher(Console.WriteLine, 1, 2);


void AfficherEnVert(string message)
{
    AfficherEnCouleur(ConsoleColor.Green, message);
}

SommerEtAfficher(AfficherEnVert, 1, 2);

SommerEtAfficher(mess => Console.WriteLine(mess.ToUpper()), 1, 2);


// Func<string, int, bool> 



Afficher<string> afficher = Console.WriteLine;
afficher("Coucou");


void UneFunction(string mess)
{
    Console.WriteLine($"{mess.ToUpper()}");
}
Afficher<string> afficher3 = UneFunction;
afficher3("Coucou");




Afficher<string> afficher2 = mess =>
{
    Console.WriteLine($"{mess.ToUpper()}");
};
afficher2("Oh yeah");


Afficher<string> afficherClouSpectacle = mess => Console.WriteLine($"{mess.ToUpper()}");
afficherClouSpectacle("Oh yeah");


var jePointeVers = (string mess) => Console.WriteLine($"{mess.ToUpper()}");
//var jePointeVers2 = (mess) => Console.WriteLine($"{mess.ToUpper()}");

