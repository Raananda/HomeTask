using AutoMapper;
using HomeTask.Models;
using HomeTask.Repository;
using Shared.Dtos;

namespace HomeTask.Services;

public class AuditService : IAuditService
{
    private readonly IMapper _mapper;
    private readonly IAuditRepository _auditRepository;

    public AuditService(IMapper mapper, IAuditRepository auditRepository)
    {
        _mapper = mapper;
        _auditRepository = auditRepository;
    }
    public async Task Create(AuditDto auditDto)
    {
        await _auditRepository.Create(_mapper.Map<Audit>(auditDto));
    }

    public async Task<List<AuditDto>> Get(FilterDto filterDto)
    {
        var audits = await _auditRepository.Get(filterDto);

        return _mapper.Map<List<AuditDto>>(audits);
    }
}
