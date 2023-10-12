using SdA.Game.Libs.Models.GamePlay.Characters;
using System.Diagnostics.CodeAnalysis;

namespace SdA.Game.Libs.Models.GamePlay.Combats;

public class DeathMatchSetting
{
    [AllowNull]
    public Character One { get; set; }

    [AllowNull]
    public Character Two { get; set; }

    public Action<string>? AfficherInfo { get; set; }
}

public class DeathMatchCombat : BaseCombat
{
    #region Fields
    private readonly Action<string>? AfficherInfo;
    #endregion

    #region Constructors
    public DeathMatchCombat(Character character1, Character character2) : base(character1, character2)
    {
    }

    public DeathMatchCombat(DeathMatchSetting setting) : base(setting.One, setting.Two)
    {
        this.AfficherInfo = setting.AfficherInfo;
    }
    #endregion

    #region Internal methods
    protected override bool DoFight()
    {
        bool isSuccess = false;
        // le death match va être ici

        do
        {
            this.Character1.Attaquer(this.Character2);
            this.Character2.Attaquer(this.Character1);

            this.AfficherInfo?.Invoke($"Cara1 : {this.Character1.PointsDeVie.Value} / Cara2 : {this.Character2.PointsDeVie.Value}");
        } while (this.Character1.EstEnVie && this.Character2.EstEnVie);

        isSuccess = true;

        return isSuccess;
    }
    #endregion
}
