namespace CleanMovie.Domain.Models
{
    public class Rental
    {
        public int RentalId { get; set; }
        public DateTime RentalDate { get; set; }
        public DateTime RentalExpiry { get; set; }
        public decimal RentalCost { get; set; }
        public ICollection<Member> Members { get; set; }
    }
}