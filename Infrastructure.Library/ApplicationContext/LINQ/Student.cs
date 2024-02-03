namespace Infrastructure.Library.ApplicationContext.LINQ
{
    public record Student(int ID, string Name, int Age, List<Section> Sections);
}
