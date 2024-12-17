using System.Collections.Generic;
using System.Threading.Tasks;

namespace Finances.Dal.Interfaces
{
    public interface IFinancesRepository
    {       
        Task<List<Entities.Finances>> GetByUserAndPeriodAsync(int userId, string period);
    }
}
