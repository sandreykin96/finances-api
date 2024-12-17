using System.Collections.Generic;
using System.Threading.Tasks;
using Finances.Bll.Interfaces;
using Finances.Dal.Interfaces;

namespace Finances.Bll
{
    public class FinancesService : IFinancesServices
{
        private readonly IFinancesRepository _repository;

        public FinancesService(IFinancesRepository repository)
        {
            _repository = repository;
        }

        public Task<List<Dal.Entities.Finances>> GetFinancesAsync(int userId, string period) =>
             _repository.GetByUserAndPeriodAsync(userId, period);
    }
}
