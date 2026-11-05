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
    }
}
