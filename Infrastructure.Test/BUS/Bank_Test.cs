namespace Infrastructure.Test.BUS
{
    public class Bank_Tests
    {
        [Fact]
        public void Create_Test()
        {
            //  Arrange
            var a = 10;
            var b = 20;
            var c = 30;
            //  Act
            var result = a + b + c;
            //  Assert
            Assert.Equal(result, 60);

        }
    }
}
