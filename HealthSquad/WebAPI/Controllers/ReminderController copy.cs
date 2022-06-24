using Models;
using Services;
using Microsoft.AspNetCore.Mvc;

namespace Controllers;

[ApiController]
[Route("[controller]")]
public class ReminderController : ControllerBase
{
    public ReminderController()
    {
    }

    [HttpGet]
    public ActionResult<List<Reminder>> GetAll() =>
        ReminderService.GetAll();

    [HttpGet("{id}")]
    public ActionResult<Reminder> Get(int id)
    {
        var reminder = ReminderService.Get(id);

        if(reminder == null)
            return NotFound();

        return reminder;
}

    [HttpPost]
    public IActionResult Create(Reminder reminder)
    {            
        ReminderService.Add(reminder);
        return CreatedAtAction(nameof(Create), new { id = reminder.Id }, reminder);
    }

    [HttpPut("{id}")]
    public IActionResult Update(int id, Reminder reminder)
    {
        if (id != reminder.Id)
            return BadRequest();
            
        var existingReminder = ReminderService.Get(id);
        if(existingReminder is null)
            return NotFound();
    
        ReminderService.Update(reminder);           
    
        return NoContent();
    }

    [HttpDelete("{id}")]
    public IActionResult Delete(int id)
    {
        var reminder = ReminderService.Get(id);
    
        if (reminder is null)
            return NotFound();
        
        ReminderService.Delete(id);
    
        return NoContent();
    }
}