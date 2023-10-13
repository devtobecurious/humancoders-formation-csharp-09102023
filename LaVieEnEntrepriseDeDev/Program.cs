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
var code2 = dev1.EcrireCode();


dev1.CodeACommencer -= chef1.DemarrerCompteur;
dev1.CodeACommencer -= director.DemarrerCompteur;

dev1.CodeFini -= chef1.ArreterCompteur;
dev1.CodeFini -= director.ArreterCompteur;

//var code = procedure();
//Console.WriteLine(code.Content);
