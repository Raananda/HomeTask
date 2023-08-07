using Shared.Enums;

namespace Shared.Dtos;

public class AuditDto
{
    public DateTime DateTime { get; set; }
    public ActionType ActionType { get; set; }
    public EntityType EntityType { get; set; }
    public string? JsonData { get; set; }
}
