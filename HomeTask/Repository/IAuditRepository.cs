using Shared.Dtos;
using HomeTask.Models;

namespace HomeTask.Repository;

public interface IAuditRepository
{
    Task Create(Audit entity);
    Task<List<Audit>> Get(FilterDto filterDto);
}
