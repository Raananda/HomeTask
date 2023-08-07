using Shared.Enums;

namespace Shared.Dtos;

public class FilterDto
{
    public int? ID { get; set; }
    public DateTime? DateTime { get; set; }
    public ActionType? ActionType { get; set; }
    public EntityType? EntityType { get; set; }
}
