using Models;

namespace Services;

public static class PrescriptionService
{
    static List<Prescription> Prescriptions { get; }
    static int nextId = 3;
    static PrescriptionService()
    {
        Prescriptions = new List<Prescription>
        {
            new Prescription { Id = 1, User = {}, Medication = {}},
        };
    }

    public static List<Prescription> GetAll() => Prescriptions;

    public static Prescription? Get(int id) => Prescriptions.FirstOrDefault(p => p.Id == id);

    public static void Add(Prescription prescription)
    {
        prescription.Id = nextId++;
        Prescriptions.Add(prescription);
    }

    public static void Delete(int id)
    {
        var prescription = Get(id);
        if(prescription is null)
            return;

        Prescriptions.Remove(prescription);
    }

    public static void Update(Prescription prescription)
    {
        var index = Prescriptions.FindIndex(m => m.Id == prescription.Id);
        if(index == -1)
            return;

        Prescriptions[index] = prescription;
    }
}