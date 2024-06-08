using Auth.Backend.Model.Interface.IAuthBusiness;
using Auth.Backend.Model.Interface.IAuthRepository;

namespace Auth.Backend.Business.AuthBusiness
{
    public class AuthBusiness(IAuthRepository authRepository) : IAuthBusiness
    {
        public IAuthRepository _authRepository = authRepository;

        public Task<bool> GetUserDatabaseAsync(string username, string password)
        {
            return _authRepository.GetUserDatabaseAsync(username, password);
        }
    }
}
