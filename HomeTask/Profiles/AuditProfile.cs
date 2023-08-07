using AutoMapper;
using Shared.Dtos;
using HomeTask.Models;

namespace HomeTask.Profiles;

public class AuditProfile : Profile
{
    public AuditProfile()
    {
        // Source -> Target
        CreateMap<AuditDto, Audit>();
        CreateMap<Audit, AuditDto>();

    }
}
