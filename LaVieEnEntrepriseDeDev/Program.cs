using LaVieEnEntrepriseDeDev;

LeadTech lead = new();

var procedure = lead.GetProcedure();

Developpeur dev1 = new(procedure);
var code = dev1.EcrireCode();

Personne chef1 = new();
Personne director = new();

dev1.CodeACommencer += chef1.DemarrerCompteur;
dev1.CodeACommencer += director.DemarrerCompteur;

dev1.CodeFini += chef1.ArreterCompteur;
dev1.CodeFini += director.ArreterCompteur;


Developpeur dev2 = new(() => new(""));

try
{
    var code2 = dev1.EcrireCode();
}
catch (LaFlemmeException ex) when (ex.CodeCourant != null)
{
    Console.WriteLine("Flute il a la flemme");

    throw new Exception("", ex);
}
catch (LaFlemmeException ex) when (ex.CodeCourant == null)
{
    Console.WriteLine("Flute il a la flemme");

    throw new Exception("", ex);
}
finally
{
    Console.WriteLine("Dans tous les cas");
}
//catch (Exception)
//{

//}



dev1.CodeACommencer -= chef1.DemarrerCompteur;
dev1.CodeACommencer -= director.DemarrerCompteur;

dev1.CodeFini -= chef1.ArreterCompteur;
dev1.CodeFini -= director.ArreterCompteur;

//var code = procedure();
//Console.WriteLine(code.Content);
