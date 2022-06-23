using Models;

namespace Services;

public static class MedicationService
{
    static List<Medication> Medications { get; }
    static int nextId = 3;
    static MedicationService()
    {
        Medications = new List<Medication>
        {
            new Medication { Id = 1, Name = "Atorvastatin 10 MG Tablet", Description = "Tablet", Dosage = "10 MG", Directions = "take one tablet per day", Count = 90 },
        };
    }

    public static List<Medication> GetAll() => Medications;

    public static Medication? Get(int id) => Medications.FirstOrDefault(p => p.Id == id);

    public static void Add(Medication medication)
    {
        medication.Id = nextId++;
        Medications.Add(medication);
    }

    public static void Delete(int id)
    {
        var medication = Get(id);
        if(medication is null)
            return;

        Medications.Remove(medication);
    }

    public static void Update(Medication medication)
    {
        var index = Medications.FindIndex(m => m.Id == medication.Id);
        if(index == -1)
            return;

        Medications[index] = medication;
    }
}