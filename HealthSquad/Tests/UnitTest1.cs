using System;
using System.Collections.Generic;
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
    public void UserPrescriptionShouldBeAbleToSet()
    {
        User testUser = new User();
        List<Prescription> testPrescriptions = new List<Prescription>();
        int testPrescriptionsCount = 0;

        testUser.Prescriptions = testPrescriptions;

        Assert.NotNull(testUser.Prescriptions);
        Assert.Equal(testPrescriptionsCount, testUser.Prescriptions.Count);
    }
    [Fact]
    public void UserReminderShouldBeAbleToSet()
    {
        User testUser = new User();
        List<Reminder> testReminders = new List<Reminder>();
        int testRemindersCount = 0;

        testUser.Reminders = testReminders;

        Assert.NotNull(testUser.Reminders);
        Assert.Equal(testRemindersCount, testUser.Reminders.Count);
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
        TimeOnly alert = new TimeOnly(); //unless you enter `using System`, you'll get this error: The type or namespace name 'TimeOnly' could not be found (are you missing a using directive or an assembly reference?)

        testReminder.User = user;
        testReminder.Prescription = prescription;
        testReminder.Alert = alert;

        Assert.NotNull(user);
        Assert.NotNull(prescription);
        Assert.NotNull(alert);
    }
}