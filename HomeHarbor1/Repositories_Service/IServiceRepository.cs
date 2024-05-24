using HomeHarbor1.Models;

namespace HomeHarbor1.Repositories_Service
{
    public interface IServiceRepository
    {
        List<Service> GetService();
        Service GetService(int id);
        int AddService(Service Service);
        int UpdateService(int id, Service Service);
        int DeleteService(int id);
        List<Service> SearchServices(string service);
    }
}
