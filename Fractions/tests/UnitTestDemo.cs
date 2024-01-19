namespace tests;


// Simple Unit test, just to Demo simple Assert construction
public class DemoUnitTest
{
    readonly Stack<int> stack;

    public DemoUnitTest()
    {
        stack = new Stack<int>();
    }


    [Fact]
    public void TestAssertTrue()
    {
        Assert.True(1 == 1);
    }

    [Fact]
    public void TestAssertFalse()
    {
        Assert.False(1 == 0);
    }

    [Fact]
    public void TestAssertEqual()
    {
        String name = "Per";
        String lastname = "Madsen";

        String full = name + " " + lastname;
        Assert.Equal("Per Madsen", full);
    }

    [Fact]
    public void TestAssertNotNull()
    {
        String name = "Per";

        Assert.NotNull(name);
    }

    [Fact]
    public void TestAssertNull()
    {
        String? name = "Per";
        Assert.Equal("Per", name);

        name = null;

        Assert.Null(name);
    }

    [Fact]
    public void TestAddToStack()
    {
        stack.Push(1);
        Assert.Single(stack);
    }

}
