// See https://aka.ms/new-console-template for more information
bool isValid=false;
Console.WriteLine("Welcome to the Secret Password Validator!");
do
{
    Console.WriteLine("Please enter your secret password: ");
    string secretPassword = Console.ReadLine();
    SecretPassword password = new SecretPassword(secretPassword);
    isValid = password.IsValid();
    if (isValid)
    {
        Console.WriteLine("Your password is valid!");
        LibraryManagement.StartLibrary();
    }
    else
    {
        Console.WriteLine("Your password is invalid. Please try again.");
    }
} while (!isValid);

