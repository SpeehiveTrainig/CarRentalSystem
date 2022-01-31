namespace CarRentalSystem.DTOS
{
    public class CarDTO
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

        /// <summary>
        /// new props
        /// </summary>
        public string DisplayName { get; set; }

        public int ToatlRent { get; set; }




    }
}
