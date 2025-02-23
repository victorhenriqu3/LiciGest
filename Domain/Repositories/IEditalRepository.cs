using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Domain.Entities;

namespace Domain.Repositories
{
    public interface IEditalRepository : IRepository<Edital>
    {
        Task<IEnumerable<Edital>> GetEditaisAbertosAsync();
    }
}
