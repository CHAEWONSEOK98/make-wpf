namespace DataTemplateBasic
{
    public class Student
    {
        public string Name { get; set; } = "";
        public string Gender { get; set; } = "";
        public string Birthday { get; set; } = "";
        public string School { get; set; } = "";

        public override string ToString()
        {
            return $"Name: {Name}, Gender: {Gender}, Birthday: {Birthday}, School: {School}";
        }

        public static List<Student> Students => new()
        {
            new Student{Name="채일남", Gender="남", Birthday="19900811", School="서울대"},
            new Student{Name="채이남", Gender="남", Birthday="19920811", School="연세대"},
            new Student{Name="채삼남", Gender="남", Birthday="19940811", School="고려대"},
            new Student{Name="채일여", Gender="여", Birthday="19960811", School="포항공대"},
            new Student{Name="채이여", Gender="여", Birthday="19980811", School="카이스트"},
        };
    }
}
