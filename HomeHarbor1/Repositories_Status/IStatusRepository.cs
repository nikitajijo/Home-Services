using HomeHarbor1.Models;

namespace HomeHarbor1.Repositories_Status
{
    public interface IStatusRepository
    {
        List<Status> GetStatus();
        Status GetStatus(int id);
        int AddStatus(Status Status);
        int UpdateStatus(int id, Status Status);
        int DeleteStatus(int id);
    }
}
