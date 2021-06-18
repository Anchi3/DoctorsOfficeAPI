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
    public class DoctorsController : ControllerBase
    {
        private readonly ILogger<DoctorsController> _logger;
        private readonly ApplicationDbContext _context = new ApplicationDbContext();

        public DoctorsController(ILogger<DoctorsController> logger)
        {
            _logger = logger;
        }

        [HttpGet]
        public IEnumerable<Doctor> Get()
        {
            return _context.Doctors.ToList();
        }
    }
}