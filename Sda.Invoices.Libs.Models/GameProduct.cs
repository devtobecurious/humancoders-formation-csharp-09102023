namespace Sda.Invoices.Libs.Models;

// public delegate decimal GetTva();

public class GameProduct
{
    //private readonly GetTva getTva;
    private readonly Func<decimal> getTva;
    private decimal prixHT;
    private decimal prixTTC;

    public GameProduct(Func<decimal> getTva)
    {
        this.getTva = getTva;
    }

    // Première piste
    // public decimal PrixTTC => (1 + this.getTva()) * this.PrixHT;
    public decimal PrixTTC
    {
        get => this.prixTTC;
        private set => this.prixTTC = value;
    }


    public decimal PrixHT
    {
        get => this.prixHT;
        set
        {
            this.prixHT = value;
            this.prixTTC = (1 + this.getTva()) * value;
        }
    }
}
