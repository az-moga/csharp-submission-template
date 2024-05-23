namespace ProjectTests;
using Xunit;

public class UnitTest1
{
    [Fact]
    public void Test1()
    {
        var output = new StringWriter();
        Console.SetOut(output);

        var greeter = new Greeter();
        
        greeter.Greet();

        Assert.Equivalent("Hello World!", output.ToString());
    }
}