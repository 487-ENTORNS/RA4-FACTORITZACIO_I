namespace Exercicis.Tests;
using Exercicis;

public class UnitTest1
{
    [Fact]
    public void TestLengthPassword()
    {
        string password = "12345678901234567890"; // 20 characters
        SecretPassword secretPassword = new SecretPassword(password);
        bool result = secretPassword.IsValidLenghtSecretPassword();
        Assert.True(result);
    }
    
}