namespace tests;

using Moq;

public class SomeComplicateClass(string init)
{
    private readonly string str = init;

    public string GetWeirdString(int SomeNumber)
    {
        return "WeirdString; " + this.str;
    }

}
// Simple Unit test, just to Demo Mock objects
public class DemoUnitMoqTest
{
    readonly Stack<int> stack;

    public DemoUnitMoqTest()
    {
        stack = new Stack<int>();

        var mock = new Mock<SomeComplicateClass>();

        mock.Setup(x => x.GetWeirdString(42)).Returns("Hello");

        SomeComplicateClass obj = mock.Object;

        obj.GetWeirdString(42);

    }
}