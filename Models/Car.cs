namespace CarRentalSystem.Models
{
    public class Car
    {

       
        public int Id { get; set; }
        public string Name { get; set; }
        public string CompanyName { get; set; }
        public string OwnerName { get; set; }
        public string ModelNo { get; set; }
        public string PhotoUrl { get; set; }

        public Double RatePerHr { get; set; }

        public Double HrUsed { get; set; }

        public DateTime CreatedDate { get; set; }
    }
}
