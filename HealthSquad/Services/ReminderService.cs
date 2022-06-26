using Models;

namespace Services;

public static class ReminderService
{
    static List<Reminder> Reminders { get; }
    static int nextId = 3;
    static ReminderService()
    {
        Reminders = new List<Reminder>
        {
            new Reminder { Id = 1, User = {Id = 1, Username = "Classic Italian", Password = "false"}, Prescription = {Id = 1, User = {Id = 1, Username = "Classic Italian", Password = "false"}, Medication = {Id = 1, Name = "Atorvastatin 10 MG Tablet", Description = "Tablet", Dosage = "10 MG", Directions = "take one tablet per day", Count = 90}}, Alert = new TimeOnly(9, 0)},
        };
    }

    public static List<Reminder> GetAll() => Reminders;

    public static Reminder? Get(int id) => Reminders.FirstOrDefault(p => p.Id == id);

    public static void Add(Reminder reminder)
    {
        reminder.Id = nextId++;
        Reminders.Add(reminder);
    }

    public static void Delete(int id)
    {
        var reminder = Get(id);
        if(reminder is null)
            return;

        Reminders.Remove(reminder);
    }

    public static void Update(Reminder reminder)
    {
        var index = Reminders.FindIndex(m => m.Id == reminder.Id);
        if(index == -1)
            return;

        Reminders[index] = reminder;
    }
}