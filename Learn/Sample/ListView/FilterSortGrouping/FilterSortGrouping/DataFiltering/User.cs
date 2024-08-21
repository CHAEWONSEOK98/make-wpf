namespace FilterSortGrouping.DataFiltering
{
    public class User
    {
        public string Name { get; set; }
        public string Country { get; set; }
        public string Status { get; set; }

        public User(string name, string country, string status)
        {
            Name = name;
            Country = country;
            Status = status;
        }
    }
}
