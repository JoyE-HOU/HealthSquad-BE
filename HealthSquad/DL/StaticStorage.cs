namespace DL;
public class StaticStorage
{
    private static List<User> _allUsers = new List<User>();
    /// <summary>
    /// returns a list of users from allUsers list
    /// </summary>
    /// <returns>all users in list</returns>
    public List<User> GetAllUsers()
    {
        return StaticStorage._allUsers;
    }
    /// <summary>
    /// adds a new user to list
    /// </summary>
    /// <param name="UserToAdd">new user object to add</param>
    public void AddNewUsers(User UserToAdd)
    {
        StaticStorage._allUsers.Add(UserToAdd);
    }
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
    /// adds a new medication to list
    /// </summary>
    /// <param name="MedicationToAdd">new medication object to add</param>
    public void AddNewMedication(Medication MedicationToAdd)
    {
        StaticStorage._allMedications.Add(MedicationToAdd);
    }
    private static List<Prescription> _allPrescriptions = new List<Prescription>();
    private static List<Reminder> _allReminders = new List<Reminder>();
}
