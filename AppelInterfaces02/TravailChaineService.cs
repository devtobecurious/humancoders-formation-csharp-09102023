using MesInterfaces;

namespace AppelInterfaces02
{
    public class TravailChaineService : IGetListChaines, INbElementsList
    {
        public int Number { get; set; } = 3;

        public List<string> GetAll()
        {
            return new List<string>()
            {
                "Ah",
                "Que",
                "Johny"
            };
        }

        public void AhBon()
        {

        }
    }

    public class TravailChaineEnMajusculeService : IGetListChaines
    {
        public List<string> GetAll()
        {
            return new List<string>()
            {
                "Ah",
                "Que",
                "Johny"
            }.Select(item => item.ToUpper()).ToList();
        }
    }


}
