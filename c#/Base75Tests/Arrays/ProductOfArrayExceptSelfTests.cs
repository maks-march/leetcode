using Base75;
using FluentAssertions;

namespace RandomTasksTests;

public class ProductOfArrayExceptSelfTests
{
    private ProductOfArrayExceptSelf _task;
    
    [SetUp]
    public void Setup()
    {
        _task = new ();
    }

    [Test]
    public void ProductOfArrayExceptSelf_Test()
    {
        var nums = new[] { 1,2,3,4 };
        _task.ProductExceptSelf(nums).Should().BeEquivalentTo(new[] {24,12,8,6});
    }
}