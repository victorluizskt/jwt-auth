namespace Auth.Backend.Model.Interface.IAuthBusiness
{
    public interface IAuthBusiness
    {
        Task<bool> GetUserDatabaseAsync(string username, string password);
    }
}
