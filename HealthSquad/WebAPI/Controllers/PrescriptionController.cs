using Models;
using Services;
using Microsoft.AspNetCore.Mvc;

namespace Controllers;

[ApiController]
[Route("[controller]")]
public class PrescriptionController : ControllerBase
{
    public PrescriptionController()
    {
    }

    [HttpGet]
    public ActionResult<List<Prescription>> GetAll() =>
        PrescriptionService.GetAll();

    [HttpGet("{id}")]
    public ActionResult<Prescription> Get(int id)
    {
        var prescription = PrescriptionService.Get(id);

        if(prescription == null)
            return NotFound();

        return prescription;
}

    [HttpPost]
    public IActionResult Create(Prescription prescription)
    {            
        PrescriptionService.Add(prescription);
        return CreatedAtAction(nameof(Create), new { id = prescription.Id }, prescription);
    }

    [HttpPut("{id}")]
    public IActionResult Update(int id, Prescription prescription)
    {
        if (id != prescription.Id)
            return BadRequest();
            
        var existingPrescription = PrescriptionService.Get(id);
        if(existingPrescription is null)
            return NotFound();
    
        PrescriptionService.Update(prescription);           
    
        return NoContent();
    }

    [HttpDelete("{id}")]
    public IActionResult Delete(int id)
    {
        var prescription = PrescriptionService.Get(id);
    
        if (prescription is null)
            return NotFound();
        
        PrescriptionService.Delete(id);
    
        return NoContent();
    }
}