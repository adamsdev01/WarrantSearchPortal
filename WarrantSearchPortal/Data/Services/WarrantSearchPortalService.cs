using System.Diagnostics;
using WarrantSearchPortal.Data.Models;

namespace WarrantSearchPortal.Data.Services
{
    public class WarrantSearchPortalService
    {
        public readonly WarrantPortalDbContext _dbContext;

        public WarrantSearchPortalService(WarrantPortalDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public IEnumerable<OffenseDescription> GetAllOffenseDescriptions()
        {
            return _dbContext.OffenseDescriptions
                .OrderBy(od => od.OffenseName)
                .ToList();
        }
    }
}
