using Shared.Enums;
namespace HomeTask.Models;

public class Audit
{
    public int ID { get; set; }
    public DateTime DateTime { get; set; }
    public ActionType ActionType { get; set; }
    public EntityType EntityType { get; set; }
    public string? JsonData { get; set; }
}
