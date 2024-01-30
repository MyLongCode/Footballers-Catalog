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
        public DateTime Birthday { get; set; }
        public Country Country { get; set; }

        public Footballer(string firstName, string lastName, Sex sex, DateTime birthday,Country country, string teamName)
        {
            FirstName = firstName;
            LastName = lastName;
            Sex = sex;
            Birthday = birthday;
            Country = country;
            TeamName = teamName;
        }
        public Footballer(int id, string firstName, string lastName, Sex sex, DateTime birthday, Country country, string teamName)
        {
            Id = id;
            FirstName = firstName;
            LastName = lastName;
            Sex = sex;
            Birthday = birthday;
            Country = country;
            TeamName = teamName;
        }
    }
}
