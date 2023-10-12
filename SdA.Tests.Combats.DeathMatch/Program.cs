using SdA.Game.Libs.Models.GamePlay.Characters;
using SdA.Game.Libs.Models.GamePlay.Characters.Enemies;
using SdA.Game.Libs.Models.GamePlay.Combats;

EchangeUI ui = new()
{
    AfficherInfo = Console.WriteLine,
    RecupererSaisie = Console.ReadLine
};

Character player = new Player(new DateTime(1983, 10, 25), new(0, 0), ui);
Character enemy = new Urukhai("U");


// BaseCombat baseCombat = new DeathMatchCombat(player, enemy);
BaseCombat baseCombat = new DeathMatchCombat(new DeathMatchSetting()
{
    AfficherInfo = Console.WriteLine,
    One = player,
    Two = enemy
});
var result = baseCombat.Fight();

if (result != null && result.IsSuccess)
{
    Console.WriteLine("Le combat est fini !");
}