using HomeTask.Data;
using Shared.Dtos;
using HomeTask.Models;
using Microsoft.EntityFrameworkCore;
using System.Linq;

namespace HomeTask.Repository
{
    public class AuditRepository : IAuditRepository
    {
        private readonly AuditContext _auditContext;

        public AuditRepository(AuditContext auditContext)
        {
            _auditContext = auditContext;
        }
        public async Task Create(Audit entity)
        {
            _auditContext.Audit.Add(entity);
            await _auditContext.SaveChangesAsync();
        }

        public async Task<List<Audit>> Get(FilterDto filterDto)
        {
            IQueryable<Audit> query = _auditContext.Audit;

            #region Filters
            if (filterDto.ID.HasValue)
            {
                query = query.Where(entity => entity.ID == filterDto.ID.Value);
            }

            if (filterDto.DateTime.HasValue)
            {
                query = query.Where(entity => entity.DateTime == filterDto.DateTime.Value);
            }

            if (filterDto.ActionType.HasValue)
            {
                query = query.Where(entity => entity.ActionType == filterDto.ActionType.Value);
            }

            if (filterDto.EntityType.HasValue)
            {
                query = query.Where(entity => entity.EntityType == filterDto.EntityType.Value);
            }
            #endregion

            return await query.ToListAsync();
        }
    }
}
