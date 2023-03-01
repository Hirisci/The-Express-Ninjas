namespace DAL.Model
{
    public class DriveLicense
    {
        public int Id { get; set; }
        public Driver Driver { get; set; } = new Driver();
        public DateOnly Expiration { get; set; }
    }
}