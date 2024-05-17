namespace Services.Interfaces
{
    public interface IAuthProvider
    {
        int GetClientIdByEmail(string email, bool createNew = false);
        int GetClientIdByTelegram(int telegramId, bool createNew = false);
    }
}
