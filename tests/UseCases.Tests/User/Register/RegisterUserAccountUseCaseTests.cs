using CommonTestUtilities.Repositories;
using CommonTestUtilities.Requests;
using CommonTestUtilities.Security;
using MyRecipeBook.Application.UseCases.User.Register;

namespace UseCases.Tests.User.Register;

public class RegisterUserAccountUseCaseTests
{
    [Fact]
    public async Task Success()
    {
        var request = RequestRegisterUserAccountJsonBuilder.Build();
        var useCase = CreateUseCase();
    }

    private RegisterUserAccountUseCase CreateUseCase()
    {
        var passwordHasher = new IPasswordHasherBuilder().Build();
        var userWriteOnlyRepository = IUserWriteOnlyRepositoryBuilder.Build();
        var userReadOnlyRepository = new IUserReadOnlyRepositoryBuilder().Build();
        var unitOfWork = IUnitOfWorkBuilder.Build();

        return new RegisterUserAccountUseCase(
            passwordHasher, userWriteOnlyRepository, userReadOnlyRepository, unitOfWork);
    }
}