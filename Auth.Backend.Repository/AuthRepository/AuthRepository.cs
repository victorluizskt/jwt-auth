using Auth.Backend.Model.Interface.IAuthRepository;

namespace Auth.Backend.Repository.AuthRepository
{
    public class AuthRepository : IAuthRepository
    {
        public Task<bool> GetUserDatabaseAsync(string username, string password)
        {
            // TODO: Adicionar dapper, criar db aws
            throw new NotImplementedException();
        }
    }
}
