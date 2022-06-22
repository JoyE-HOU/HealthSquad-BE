using Xunit;
using Models;

namespace Tests;

public class UnitTest1
{
    [Fact]
    public void UserShouldCreate()
    {
        User testUser = new User();
        
        Assert.NotNull(testUser);
    }
}