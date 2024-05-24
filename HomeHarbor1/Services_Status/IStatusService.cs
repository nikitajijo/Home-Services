using HomeHarbor1.Models;

namespace HomeHarbor1.Services_Status
{
    public interface IStatusService
    {
        public List<Status> GetStatus();
        Status GetStatus(int id);
        int AddStatus(Status Status);
        int UpdateStatus(int id, Status Status);
        int DeleteStatus(int id);
    }
}
