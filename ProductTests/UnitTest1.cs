namespace ProductTests;

public class UnitTest1
{
    [Fact]
    public void Test1()
    {
        var result = Product.Add(3, 4);
        Assert.Equal(7, result);
    }
}