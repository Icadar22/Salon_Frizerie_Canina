using System.ComponentModel.DataAnnotations;

namespace Salon_Frizerie_Canina.Models
{
    public class Appointment
    {
        public int Id { get; set; }

        [DataType(DataType.Date)] 
        public DateTime AppointmentDate { get; set; }


        [DataType(DataType.Time)]
        public DateTime AppointmentHour { get; set; }
        

    }
}
