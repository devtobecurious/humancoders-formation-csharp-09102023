// a mettre static dans une classe Proxy
using SdA.Game.Libs.Models.GamePlay.Characters;
using SdA.Game.Libs.Models.GamePlay.Characters.Enemies;

Random random = new Random();

List<Character> list = new()
{
    new Orc("Orc"),
    new Urukhai("U"),
    new Goblin()
};

Console.WriteLine("-----> Avant déplacement -----");
list.ForEach(character =>
{
    Console.WriteLine($"{character.Position.X} / {character.Position.Y}");
});

Console.WriteLine("-----> Après déplacement -----");
list.ForEach(character =>
{
    character.SeDeplacer(new(random.Next(0, 100), random.Next(0, 100)));
});
list.ForEach(character =>
{
    Console.WriteLine($"{character.Position.X} / {character.Position.Y}");
});