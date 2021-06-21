using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;


namespace DoctorsOffice.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class IntakeFormsController : ControllerBase
    {
        private readonly ILogger<IntakeFormsController> _logger;
        private readonly ApplicationDbContext _context = new ApplicationDbContext();

        public IntakeFormsController(ILogger<IntakeFormsController> logger)
        {
            _logger = logger;
        }

        [HttpGet]
        public IEnumerable<IntakeForm> Get()
        {
            return _context.IntakeForms.ToList();
        }

        [HttpPost]
        public void Post([FromBody] IntakeForm value)
        {
            int id = 1;

            if (_context.IntakeForms.ToList().Count != 0)
                id = _context.IntakeForms.Max(p => p.Id) + 1;

            IntakeForm newIntakeForm = new IntakeForm
            {
                Id = id,
                Symptoms = value.Symptoms,
                DoctorId = value.DoctorId,
                PatientId = value.PatientId
            };

            _context.IntakeForms.Add(newIntakeForm);
            _context.SaveChanges();
        }
    }
}
