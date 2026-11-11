
namespace ModellOchPeriod;

public class EquipmentModel(Guid id, string name)
{
    public Guid Id { get; set; } = id;
    public string Name { get; set; } = name;
    public string Description { get; set; } = string.Empty;
    public string Category { get; set; } = string.Empty;
    public decimal DailyPrice { get; set; }

}
    

