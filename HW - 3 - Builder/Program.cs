using HW___3___Builder;

try
{
    var user = new UserBuilder("Bertha", "Martin")
        .AddMiddleName("R.")
        .AddBirthdate(new DateTime(1985, 4, 23))
        .AddPhone("8059908673")
        .AddAddress("Los Angeles, CA 90013")
        .AddEmail("BerthaRMartin@example.com")
        .Build();

    Console.WriteLine($"User created: {user.FirstName} {user.LastName}");
}
catch (Exception ex)
{
    Console.WriteLine($"Error: {ex.Message}");
}