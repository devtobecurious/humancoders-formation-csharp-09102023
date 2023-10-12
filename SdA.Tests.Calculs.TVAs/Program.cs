using Sda.Invoices.Libs.Models;

GameProduct produit = new(() => 0.2M);
GameProduct produit2 = new(() => 0.055M);

GameProduct produit3 = new(() =>
{
    decimal tva = 0;
    // Aller faire une request http

    HttpClient client = new();
    client.GetAsync("http://monapi.com/tva");

    return tva;
});

produit3.PrixHT = 10;