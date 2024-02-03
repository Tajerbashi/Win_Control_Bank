namespace Infrastructure.Library.ApplicationContext.LINQ
{
    public record Lesson(int ID, string Title, int Unit, List<Section> Sections);
}
