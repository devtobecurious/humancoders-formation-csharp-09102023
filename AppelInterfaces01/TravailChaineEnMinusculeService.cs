using MesInterfaces;

namespace AppelInterfaces01
{
    internal class TravailChaineEnMinusculeService : IGetListChaines, IGetOneChaine
    {
        public List<string> GetAll()
        {
            return new()
            {
                "1", "2"
            };
        }

        public string GetOne()
        {
            throw new NotImplementedException();
        }
    }
}
