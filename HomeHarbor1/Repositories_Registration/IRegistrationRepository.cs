using HomeHarbor1.Models;

namespace HomeHarbor1.Repositories_Registration

{
    public interface IRegistrationRepository
    {
        List<Registration> GetRegistration();
        Registration GetRegistration(int id);
        int AddRegistration(Registration Registration);
        int UpdateRegistration(int id, Registration Registration);
        int DeleteRegistration(int id);
        string Login(string email, string password);

   
    }
}
