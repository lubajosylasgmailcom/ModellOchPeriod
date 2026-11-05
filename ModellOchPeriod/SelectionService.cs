namespace ModellOchPeriod;

public class SelectionService
{
    private readonly List<EquipmentModel> models =
    [
        new EquipmentModel(1, "Borrmaskin"),
        new EquipmentModel(2, "Slipmaskin"),
        new EquipmentModel(3, "Högtrycksmaskin")
    ];

    public List<EquipmentModel> GetModels()
    {
        return models;
    }

    public static string? ValidatePeriod(DateOnly startDate, DateOnly endDate)
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
