using Location.Models;

namespace Location.Services
{
    public interface IMaisonService
    {
      /*  IEnumerable<Maison> GetAllMaisons();
        IEnumerable<Maison> FilterMaisons(decimal? prixMax, int? surfaceMin);*/
        Maison? GetMaisonById(int id);

   
        Task<IEnumerable<Maison>> GetFilteredMaisonsAsync(Maison filter);
    }
}
