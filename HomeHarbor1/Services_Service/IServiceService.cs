using HomeHarbor1.Models;

namespace HomeHarbor1.Services_Service
{
    public interface IServiceService
    {
        public List<Service> GetService();
        Service GetService(int id);
        int AddService(Service Service);
        int UpdateService(int id, Service Service);
        int DeleteService(int id);
        List<Service> SearchServices(string service);
    }
}
