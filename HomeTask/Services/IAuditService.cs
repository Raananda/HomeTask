using Shared.Dtos;

namespace HomeTask.Services;

public interface IAuditService
{
    Task Create(AuditDto entity);
    Task<List<AuditDto>> Get(FilterDto filterDto);
}
