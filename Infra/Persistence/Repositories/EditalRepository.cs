using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Domain.Entities;
using Domain.Repositories;
using Domain.ValueObjects;
using Infra.Config;
using Microsoft.EntityFrameworkCore;

namespace Infra.Persistence.Repositories
{
    public class EditalRepository : BaseRepository<Edital>, IEditalRepository
    {
        public EditalRepository(ApplicationDbContext context)
            : base(context) { }

        public async Task<IEnumerable<Edital>> GetEditaisAbertosAsync()
        {
            return await _context.Editais.Where(e => e.Status == StatusEdital.Aberto).ToListAsync();
        }
    }
}
