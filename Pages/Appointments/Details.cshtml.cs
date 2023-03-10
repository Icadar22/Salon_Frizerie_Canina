using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Salon_Frizerie_Canina.Data;
using Salon_Frizerie_Canina.Models;

namespace Salon_Frizerie_Canina.Pages.Appointments
{
    public class DetailsModel : PageModel
    {
        private readonly Salon_Frizerie_Canina.Data.Salon_Frizerie_CaninaContext _context;

        public DetailsModel(Salon_Frizerie_Canina.Data.Salon_Frizerie_CaninaContext context)
        {
            _context = context;
        }

      public Appointment Appointment { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null || _context.Appointment == null)
            {
                return NotFound();
            }

            var appointment = await _context.Appointment.FirstOrDefaultAsync(m => m.Id == id);
            if (appointment == null)
            {
                return NotFound();
            }
            else 
            {
                Appointment = appointment;
            }
            return Page();
        }
    }
}
