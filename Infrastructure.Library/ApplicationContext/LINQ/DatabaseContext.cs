namespace Infrastructure.Library.ApplicationContext.LINQ
{
    public class DatabaseContext
    {
        public DatabaseContext()
        {
            Students = new List<Student>();
            Lessons = new List<Lesson>();
            Sections = new List<Section>();
        }
        public void FillData()
        {
            for (int i = 1; i <= 20; i++)
            {
                Students.Add(new Student(i, $"Student-{i}", 10 + i, default) { Age = (10 + i) });
                Lessons.Add(new Lesson(i, $"Lesson-{i}", i, default));
                Sections.Add(new Section(i, i, i));
            }
        }
        public List<Student> Students { get; set; }
        public List<Lesson> Lessons { get; set; }
        public List<Section> Sections { get; set; }
    }
}
