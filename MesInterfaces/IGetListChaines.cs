namespace MesInterfaces
{
    public interface IGetListChaines
    {
        List<string> GetAll();
    }

    public interface IGetOneChaine
    {
        string GetOne();
    }

    public interface INbElementsList
    {
        int Number { get; }
    }
}
