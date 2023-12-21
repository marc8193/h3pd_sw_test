namespace tests;


// Simple Unit test, just to Demo simple Assert construction
public class DemoUnitTest
{
    [Fact]
    public void TestAssertTrue()
    {
        Assert.True(1==1);
    }

    [Fact]
    public void TestAssertFalse()
    {
        Assert.True(1 == 0);
    }

    [Fact]
    public void TestAssertEqual()
    {
        String name = "Per";
        String lastname = "Madsen";

        String full = name + " " + lastname;
        Assert.Equal("Per Madsen", full);
    }
}


