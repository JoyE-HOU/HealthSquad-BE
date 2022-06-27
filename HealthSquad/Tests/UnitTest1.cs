using Xunit;
using Models;

namespace Tests;

public class UnitTest1
{
    [Fact]
    public void UserShouldCreate()
    {
        User testUser = new User();
        
        Assert.NotNull(testUser);
    }
    [Fact]
    public void MedicationShouldCreate()
    {
        Medication testMedication = new Medication();

        Assert.NotNull(testMedication);
    }
    [Fact]
    public void PrescriptionShouldCreate()
    {
        Prescription testPrescription = new Prescription();

        Assert.NotNull(testPrescription);
    }
    [Fact]
    public void ReminderShouldCreate()
    {
        Reminder testReminder = new Reminder();

        Assert.NotNull(testReminder);
    }
}