// a mettre static dans une classe Proxy
using SdA.Game.Libs.Models.GamePlay.Characters;

//Random random = new Random();

//List<Character> list = new()
//{
//    new Orc("Orc"),
//    new Urukhai("U"),
//    new Goblin()
//};

//Console.WriteLine("-----> Avant déplacement -----");
//list.ForEach(character =>
//{
//    Console.WriteLine($"{character.Position.X} / {character.Position.Y}");
//});

//Console.WriteLine("-----> Après déplacement -----");
//list.ForEach(character =>
//{
//    character.SeDeplacer(new(random.Next(0, 100), random.Next(0, 100)));
//});
//list.ForEach(character =>
//{
//    Console.WriteLine($"{character.Position.X} / {character.Position.Y}");
//});


// -----------------------
EchangeUI ui = new()
{
    AfficherInfo = Console.WriteLine,
    RecupererSaisie = Console.ReadLine
};

Character player = new Player(new DateTime(1983, 10, 25), new(0, 0), ui);
player.SeDeplacer(new SdA.Game.Libs.Models.GamePlay.Position2DR(0, 0));

ui.AfficherInfo($"Position nouvelle : [{player.Position.X}, {player.Position.Y}]");