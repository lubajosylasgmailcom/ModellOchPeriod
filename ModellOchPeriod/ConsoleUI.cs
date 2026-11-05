namespace ModellOchPeriod;

public class ConsoleUI(SelectionService service)
{
    public void Run()
    {
        Console.WriteLine("Välj en utrustningsmodell:");

        foreach (EquipmentModel model in service.GetModels())
        {
            Console.WriteLine($"{model.Id}. {model.Name}");
        }

        EquipmentModel? selectedModel = null;

        while (selectedModel == null)
        {
            Console.WriteLine("Ange modellens nummer:");

            if (int.TryParse(Console.ReadLine(), out int modelid))
            {
                selectedModel = service.GetModels()
                    .Find(model => model.Id == modelid);
            }

            if (selectedModel == null)
            {
                Console.WriteLine("Ogiltigt modellnummer. Försök igen.");
            }
        }

        Console.WriteLine($"Du har valt: {selectedModel.Name}");

        while (true)
        {

            Console.WriteLine("Ange startdatum (YYYY-MM-DD):");

            bool validStartDate = DateOnly.TryParse
                (

                Console.ReadLine(), out DateOnly startDate

                );

            Console.WriteLine("Ange slutdatum (YYYY-MM-DD):");

            bool validEndDate = DateOnly.TryParse
                (

                Console.ReadLine(), out DateOnly endDate

                );

            if (!validStartDate || !validEndDate)
            {
                Console.WriteLine("Ange giltiga datum i formatet YYYY-MM-DD.");
                continue;
            }

            string? error = service.ValidatePeriod(startDate, endDate);

            if (error != null)
            {
                Console.WriteLine(error);
                continue;
            }

            Console.WriteLine($"\nMoodel: {selectedModel.Name}");
            Console.WriteLine($"Period: {startDate:yyyy-MM-dd} - {endDate:yyyy-MM-dd}");
            Console.WriteLine("Ingen bokning har gjorts.");
            break;

        }

    }
}
