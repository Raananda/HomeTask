using Shared.Dtos;
using HomeTask.Services;
using Microsoft.AspNetCore.Mvc;


namespace HomeTask.Controllers;

[Route("api/[controller]")]
[ApiController]
public class AuditController : ControllerBase
{
    private readonly IAuditService _auditService;

    public AuditController(IAuditService auditService)
    {
        _auditService = auditService;
    }


    [HttpGet]
    public async Task<IActionResult> GetAudits([FromQuery]FilterDto filterDto)
    {
        var auditsDto = await _auditService.Get(filterDto);
        return Ok(auditsDto);
    }


    [HttpPost]
    public async Task<IActionResult> CreateAudit(AuditDto auditDto)
    {
        await _auditService.Create(auditDto);
        return Ok();
    }

}
