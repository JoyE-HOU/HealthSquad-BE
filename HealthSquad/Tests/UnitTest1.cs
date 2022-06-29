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
    public void UserShouldSetValidData()
    {
        User testUser = new User();
        string username = "Test Username";
        string password = "Test Password";

        testUser.Username = username;
        testUser.Password = password;

        Assert.Equal(username, testUser.Username);
        Assert.Equal(password, testUser.Password);
    }
    [Fact]
    public void MedicationShouldCreate()
    {
        Medication testMedication = new Medication();

        Assert.NotNull(testMedication);
    }
    [Fact]
    public void MedicationShouldSetValidData()
    {
        Medication testMedication = new Medication();
        string name = "Test Name";
        string description = "Test Description";
        string dosage = "Test Dosage";
        string directions = "Test Directions";
        int count = 1;

        testMedication.Name = name;
        testMedication.Description = description;
        testMedication.Dosage = dosage;
        testMedication.Directions = directions;
        testMedication.Count = count;

        Assert.Equal(name, testMedication.Name);
        Assert.Equal(description, testMedication.Description);
        Assert.Equal(dosage, testMedication.Dosage);
        Assert.Equal(directions, testMedication.Directions);
        Assert.Equal(count, testMedication.Count);
    }
    [Fact]
    public void PrescriptionShouldCreate()
    {
        Prescription testPrescription = new Prescription();

        Assert.NotNull(testPrescription);
    }
    [Fact]
    public void PrescriptionShouldSetValidData()
    {
        Prescription testPrescription = new Prescription();
        User user = new User(); 
        Medication medication = new Medication();

        testPrescription.User = user;
        testPrescription.Medication = medication;

        Assert.NotNull(user);
        Assert.NotNull(medication);
    }
    [Fact]
    public void ReminderShouldCreate()
    {
        Reminder testReminder = new Reminder();

        Assert.NotNull(testReminder);
    }
    [Fact]
    public void ReminderShouldSetValidData()
    {
        Reminder testReminder = new Reminder();
        User user = new User(); 
        Prescription prescription = new Prescription(); 
        // new TimeOnly();

        testReminder.User = user;
        testReminder.Prescription = prescription;

        Assert.NotNull(user);
        Assert.NotNull(prescription);
    }
}