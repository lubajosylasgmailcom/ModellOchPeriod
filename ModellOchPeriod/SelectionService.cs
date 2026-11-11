namespace ModellOchPeriod;

public class SelectionService
{
    private readonly List<EquipmentModel> models =
    [
        new EquipmentModel(Guid.NewGuid(), "Borrmaskin"),
        new EquipmentModel(Guid.NewGuid(), "Slipmaskin"),
        new EquipmentModel(Guid.NewGuid(), "Högtrycksmaskin")
    ];

    public List<EquipmentModel> GetModels()
    {
        return models;
    }

    public string? ValidatePeriod(DateOnly startDate, DateOnly endDate)
    {
        DateOnly today = DateOnly.FromDateTime(DateTime.Today);

        if (startDate < today)
        {
            return "Startdatumet kan inte vara tidigare än dagens datum.";
        }
        if (endDate < startDate)
        {
            return "Slutdatumet kan inte vara tidigare än startdatumet.";
        }
        return null;
    }
}
