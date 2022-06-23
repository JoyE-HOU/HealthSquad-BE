using Models;
using Services;
using Microsoft.AspNetCore.Mvc;

namespace Controllers;

[ApiController]
[Route("[controller]")]
public class MedicationController : ControllerBase
{
    public MedicationController()
    {
    }

    [HttpGet]
    public ActionResult<List<Medication>> GetAll() =>
        MedicationService.GetAll();

    [HttpGet("{id}")]
    public ActionResult<Medication> Get(int id)
    {
        var medication = MedicationService.Get(id);

        if(medication == null)
            return NotFound();

        return medication;
}

    [HttpPost]
    public IActionResult Create(Medication medication)
    {            
        MedicationService.Add(medication);
        return CreatedAtAction(nameof(Create), new { id = medication.Id }, medication);
    }

    [HttpPut("{id}")]
    public IActionResult Update(int id, Medication medication)
    {
        if (id != medication.Id)
            return BadRequest();
            
        var existingMedication = MedicationService.Get(id);
        if(existingMedication is null)
            return NotFound();
    
        MedicationService.Update(medication);           
    
        return NoContent();
    }

    [HttpDelete("{id}")]
    public IActionResult Delete(int id)
    {
        var medication = MedicationService.Get(id);
    
        if (medication is null)
            return NotFound();
        
        MedicationService.Delete(id);
    
        return NoContent();
    }
}