using Xunit;
using System;

namespace Assignment26.Tests;

public class FirstNameTests
{
    // Positiv test
    [Fact]
    public void Constructor_ShouldNotThrowException_WhenLengthIsValid()
    {
        // Arrange
        string validName = "Anders";

        // Act
        var exception = Record.Exception(() => new FirstName(validName));

        // Assert
        Assert.Null(exception);
    }
    // Positiv test
    [Fact]
    public void Constructor_ShouldNotThrowException_WhenCharactersAreValid()
    {
        // Arrange
        string validName = "ÆrøAnders";

        // Act
        var exception = Record.Exception(() => new FirstName(validName));

        // Assert
        Assert.Null(exception);
    }
    // Negativ test: forkert længde
    [Theory]
    [InlineData("A")]         // for kort
    [InlineData("ThisNameIsWayTooLongToBeValid")] // for lang
    public void Constructor_ShouldThrowException_WhenLengthIsInvalid(string invalidName)
    {
        // Act & Assert
        Assert.Throws<ArgumentException>(() => new FirstName(invalidName));
    }

    // Negativ test: ugyldige karakterer
    [Theory]
    [InlineData("Anders123")]
    [InlineData("John!")]
    [InlineData("Mary@Doe")]
    public void Constructor_ShouldThrowException_WhenCharactersAreInvalid(string invalidName)
    {
        // Act & Assert
        Assert.Throws<ArgumentException>(() => new FirstName(invalidName));
    }

    // Negativ test: null input
    [Fact]
    public void Constructor_ShouldThrowException_WhenNameIsNull()
    {
        // Act & Assert
        Assert.Throws<ArgumentException>(() => new FirstName(null));
    }
}
