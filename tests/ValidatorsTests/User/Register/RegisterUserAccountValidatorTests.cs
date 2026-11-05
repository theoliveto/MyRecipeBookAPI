using MyRecipeBook.Application.UseCases.User.Register;
using MyRecipeBook.Communication.Requests;

namespace ValidatorsTests.User.Register;

public class RegisterUserAccountValidatorTests
{
    [Fact]
    public void Success()
    {
        // Arrange
        var request = new RequestRegisterUserAccountJson
        {
            Name = "Oliveto",
            Email = "olivetoovinicius@gmail.com",
            Password = "@Oliveto10"
        };

        var validator = new RegisterUserAccountValidator();

        // Act
        var result = validator.Validate(request);

        // Assert
        Assert.True(result.IsValid);
    }
}