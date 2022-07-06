namespace DL;
public class StaticStorage
{
    private static List<User> _allUsers = new List<User>();
    private static List<Medication> _allMedications = new List<Medication>();
    /// <summary>
    /// returns a list of medications from allMedications list
    /// </summary>
    /// <returns>all medications in list</returns>
    public List<Medication> GetAllMedications()
    {
        return StaticStorage._allMedications;
    }
    /// <summary>
    /// adds new medication to list
    /// </summary>
    /// <param name="MedicationToAdd">new medication object to add</param>
    public void AddNewMedication(Medication MedicationToAdd)
    {
        StaticStorage._allMedications.Add(MedicationToAdd);
    }
    private static List<Prescription> _allPrescriptions = new List<Prescription>();
    private static List<Reminder> _allReminders = new List<Reminder>();
}
