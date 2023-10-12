using LaVieEnEntrepriseDeDev;

LeadTech lead = new();

var procedure = lead.GetProcedure();

Developpeur dev1 = new(procedure);
var code = dev1.EcrireCode();


Developpeur dev2 = new(() => new(""));
var code2 = dev1.EcrireCode();


//var code = procedure();
//Console.WriteLine(code.Content);
