using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Finances.Dal.EF;
using Finances.Dal.Interfaces;

namespace Finances.Dal.Repositories
{
    public class FinancesRepository : IFinancesRepository
    {
        private readonly FinancesContext _db;

        public FinancesRepository(FinancesContext context)
        {
            _db = context;
        }

        public async Task<List<Entities.Finances>> GetByUserAndPeriodAsync(int user_id, string period)
        {
            return await _db.Finances.Where(w => w.Period.Equals(period) && w.UserId == user_id).ToListAsync();
        }
    }
}
