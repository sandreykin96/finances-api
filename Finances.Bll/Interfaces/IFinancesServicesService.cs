using System.Collections.Generic;
using System.Threading.Tasks;

namespace Finances.Bll.Interfaces
{
    public interface IFinancesServices
    {
        Task<List<Dal.Entities.Finances>> GetFinancesAsync(int userId, string period);
    }
}