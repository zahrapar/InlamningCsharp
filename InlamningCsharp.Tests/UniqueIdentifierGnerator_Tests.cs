using InlamningCsharp.Helpers;

namespace InlamningCsharp.Tests;

public class UniqueIdentifierGnerator_Tests
{

    [Fact]
    public void Generate_ShouldReturnStringOfTypeGuid()
    {
        // Act
        string id = UniqueIdentifierGenerator.GenerateUniqueId();

        // Assert
        Assert.False(string.IsNullOrEmpty(id));
        Assert.True(Guid.TryParse(id, out _));
    }









}

