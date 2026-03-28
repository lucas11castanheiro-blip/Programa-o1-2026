namespace Aula05.Models
{
    public class Service
    {
        public int Id { get; set; }
        public string? Id_Animal { get; }
        public DateTime Enter_Date { get; set; }
        public DateTime Out_Date { get; set; }
        public string? Observations { get; set; }
        public int Id_ClinicaVet { get; set; }

    }
}
