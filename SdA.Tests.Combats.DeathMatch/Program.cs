using SdA.Game.Libs.Models.GamePlay.Characters;
using SdA.Game.Libs.Models.GamePlay.Characters.Enemies;
using SdA.Game.Libs.Models.GamePlay.Combats;



Character player = new Player(new DateTime(1983, 10, 25), new(0, 0));
Character enemy = new Urukhai("U");


BaseCombat baseCombat = new DeathMatchCombat(player, enemy);
var result = baseCombat.Fight();

if (result != null && result.IsSuccess)
{
    Console.WriteLine("Le combat est fini !");
}