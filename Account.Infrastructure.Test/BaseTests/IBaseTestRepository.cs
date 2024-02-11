namespace Infrastructure.Test.BaseTests
{
    public interface IBaseTestRepository<T>
        where T : class
    {
        //  MethodUnderTest_Scenario_ExpectedResult(){}
        List<T> DataBase { get; set; }
        IEnumerable<T> GetAll();
        T GetById(long id);
    }
}
