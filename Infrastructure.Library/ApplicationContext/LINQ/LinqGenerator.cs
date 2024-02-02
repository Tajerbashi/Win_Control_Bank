using static System.Collections.Specialized.BitVector32;

namespace Infrastructure.Library.ApplicationContext.LINQ
{
    public class LinqGenerator
    {
        

    }
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
                Students.Add(new Student { ID = i, Name = $"Student-{i}", Age = (10 + i) });
                Lessons.Add(new Lesson { ID = i, Title = $"Lesson-{i}", Unit = i });
                Sections.Add(new Section { ID = i, LessonID = i, StudentID = i });
            }
        }
        public List<Student> Students { get; set; }
        public List<Lesson> Lessons { get; set; }
        public List<Section> Sections { get; set; }
    }
    public class Student
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public int Age { get; set; }
        public List<Section> Sections { get; set; }
    }
    public class Lesson
    {
        public int ID { get; set; }
        public string Title { get; set; }
        public int Unit { get; set; }
        public List<Section> Sections { get; set; }
    }
    public class Section
    {
        public int ID { get; set; }
        public int LessonID { get; set; }
        public int StudentID { get; set; }
    }
    public class ResultDTO<T>
        where T : class
    {
        public T Data { get; set; }
    }
}
