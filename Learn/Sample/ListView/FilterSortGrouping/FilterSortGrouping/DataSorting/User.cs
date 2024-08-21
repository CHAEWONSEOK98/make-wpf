namespace FilterSortGrouping.DataSorting
{
    public class User
    {
        public string Name { get; set; }
        public string Country { get; set; }
        public int Age { get; set; }

        public User(string name, string country, int age)
        {
            Name = name;
            Country = country;
            Age = age;
        }
    }
}
