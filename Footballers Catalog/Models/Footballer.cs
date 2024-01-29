namespace Footballers_Catalog.Models
{
    public enum Country : byte
    {
        USA,
        Russia,
        Italy
    }
    public enum Sex : byte
    {
        Male,
        Female
    }
    public class Footballer
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }    
        public Sex Sex { get; set; }
        public Country Country { get; set; }
        public string TeamName { get; set; }
        public Footballer(string firstName, string lastName, Sex sex, Country country, string teamName)
        {
            FirstName = firstName;
            LastName = lastName;
            Sex = sex;
            Country = country;
            TeamName = teamName;
        }
    }
}
