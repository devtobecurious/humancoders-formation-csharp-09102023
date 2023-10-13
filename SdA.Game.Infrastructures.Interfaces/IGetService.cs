namespace SdA.Game.Infrastructures.Interfaces;

/// <summary>
/// Contract de base pour tous les services de récupération
/// </summary>
/// <typeparam name="T"></typeparam>
public interface IGetService<T> where T : class //IDisposable, new()
{
    IEnumerable<T> GetAll();
}
