namespace Auth.Backend.Model.Interface.IAuthRepository
{
    public interface IAuthRepository
    {
        Task<bool> GetUserDatabaseAsync(string username, string password);
    }
}
