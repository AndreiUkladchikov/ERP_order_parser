using Services.Interfaces;

namespace Services
{
    public class AuthProvider : IAuthProvider
    {
        public int GetClientIdByEmail(string email, bool createNew = false)
        {
            throw new NotImplementedException();
        }

        public int GetClientIdByTelegram(int telegramId, bool createNew = false)
        {
            throw new NotImplementedException();
        }
    }
}
