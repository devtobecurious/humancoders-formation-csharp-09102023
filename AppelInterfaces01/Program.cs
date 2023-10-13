using AppelInterfaces01;
using AppelInterfaces02;
using MesInterfaces;
using System.Reflection;

void RecupereLesChaines(IGetListChaines service)
{
    var withNbElements = service as INbElementsList;

    //if (withNbElements != null)
    //{
    //    var num = withNbElements.Number;
    //}
    var result = withNbElements?.Number;

    var list = service.GetAll();

    list.ForEach(item => Console.WriteLine(item));
}

RecupereLesChaines(new TravailChaineService());

RecupereLesChaines(new TravailChaineEnMajusculeService());

RecupereLesChaines(new TravailChaineEnMinusculeService());




#region Vips ?

List<object> list = new();

//var vips = list.Cast<IVIP>();

var vips = list.Select(item => item as IVIP).Where(item => item != null);

void VoirBackStage(IVIP personnePlusPlus)
{
    Console.WriteLine("Wahoo c'est trop chouette, et ya du champagne");
}

//VoirBackStage(new PersonLambda());

void VoirBackStageOuPas(Object person)
{
    var vip = person as IVIP;

    if (vip != null)
    {
        VoirBackStage(vip);
    }
}


void DetecterVip(object person)
{
    var type = person.GetType();

    var attr = type.GetCustomAttribute<LambdaAttribute<string>>();
    if (attr != null)
    {

    }

}
#endregion
