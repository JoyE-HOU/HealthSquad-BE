namespace DL;

public interface IRepo
{
    List<User> GetAllUsers();
    void AddNewUsers(User UserToAdd);

    List<Medication> GetAllMedications();
    void AddNewMedication(Medication MedicationToAdd);

    List<Prescription> GetAllPrescriptions();
    void AddNewPrescription(Prescription PrescriptionToAdd);
    
    List<Reminder> GetAllReminders();
    void AddNewReminder(Reminder ReminderToAdd);

}