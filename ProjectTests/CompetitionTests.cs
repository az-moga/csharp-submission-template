namespace ProjectTests;

public class CompetitionTests
{
  [Fact]
  public void MainScenario()
  {
    var output = new StringWriter();
    Console.SetOut(output);

    var greeter = new Greeter();

    greeter.Greet();

    Assert.Equivalent("Hello, World!\n", output.ToString());
  }

  [Fact]
  public void FailingScenario()
  {
    var output = new StringWriter();
    Console.SetOut(output);

    var greeter = new Greeter();

    greeter.Greet();

    Assert.Equivalent("Wrong Hello, World!\n", output.ToString());
  }
}