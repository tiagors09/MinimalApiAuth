public static class UserRepository 
{
    public static User Get(string? username, string? password)
    {
        var users = new List<User>
        {
            new User { Id = 1, Username = "Tiago Rodrigues Sousa", Password = "qwerty123", Role = "manager" },
        };

        return users.FirstOrDefault(x =>
                x.Username.ToLower() == username.ToLower()
                && x.Password.ToLower() == password.ToLower());
    }
}