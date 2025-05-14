using Microsoft.EntityFrameworkCore;
using Location.Data; 
using Location.Models;

namespace Location.Services
{
    public class MaisonService : IMaisonService
    {
        private readonly ApplicationDbContext1 _context;
        public MaisonService(ApplicationDbContext1 context) => _context = context;

        //public IEnumerable<Maison> GetAllMaisons()
        //{
        //    return _context.Maisons.include(m => m.Client).ToList();
        //}

        //public IEnumerable<Maison> FilterMaisons(decimal? prixMax, int? surfaceMin)
        //{
        //    var query = _context.Maisons.include(m => m.Client).AsQueryable();
        //    if (prixMax.HasValue) query = query.Where(m => m.Prix <= prixMax);
        //    if (surfaceMin.HasValue) query = query.Where(m => m.Surface >= surfaceMin);
        //    return query.ToList();
        //}

        public Maison? GetMaisonById(int id)
        {
            throw new NotImplementedException();
        }

        public async Task<IEnumerable<Maison>> GetFilteredMaisonsAsync(Maison filter)
        {
            var query = _context.Maison
                                .Include(m => m.Owner)
                                .AsQueryable();

            if (!string.IsNullOrWhiteSpace(filter.AdresseFilter))
                query = query.Where(m => m.adresse.Contains(filter.AdresseFilter));

            if (!string.IsNullOrWhiteSpace(filter.ZoneFilter))
                query = query.Where(m => m.zone == filter.ZoneFilter);

            if (filter.MinPrix.HasValue)
                query = query.Where(m => m.prix >= filter.MinPrix.Value);

            if (filter.MaxPrix.HasValue)
                query = query.Where(m => m.prix <= filter.MaxPrix.Value);

            if (!string.IsNullOrWhiteSpace(filter.GenreFilter))
                query = query.Where(m => m.Genre == filter.GenreFilter);

            if (filter.DisponibiliteFilter.HasValue)
                query = query.Where(m => m.disponibilite == filter.DisponibiliteFilter.Value);

            return await query.ToListAsync();
        }
    }



}