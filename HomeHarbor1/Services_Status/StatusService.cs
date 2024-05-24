using HomeHarbor1.Exception;
using HomeHarbor1.Models;
using HomeHarbor1.Repositories_Registration;
using HomeHarbor1.Repositories_Status;
using HomeHarbor1.Services_Registration;

namespace HomeHarbor1.Services_Status
{
    public class StatusService : IStatusService
    {
        private readonly IStatusRepository repo;

        public StatusService(IStatusRepository repo)
        {

            this.repo = repo;
        }
        public List<Status> GetStatus()
        {
            return repo.GetStatus();
        }
        public int AddStatus(Status Status)
        {
            if (repo.GetStatus(Status.Status_Id) != null)
            {
                throw new StatusAlreadyExistsException($"Status with Status id {Status.Status_Id} already exists");
            }
            return repo.AddStatus(Status);
        }
        public int DeleteStatus(int id)
        {
            if (repo.GetStatus(id) == null)
            {
                throw new UserNotFoundException($"Status with Status id {id} does not exists");
            }
            return repo.DeleteStatus(id);
        }

        public Status GetStatus(int id)
        {
            Status c = repo.GetStatus(id);
            if (c == null)
            {
                throw new StatusNotFoundException($"Status with Status id {id} does not exists");
            }
            return c;
        }
        public int UpdateStatus(int id, Status Status)
        {
            if (repo.GetStatus(id) == null)
            {
                throw new StatusNotFoundException($"Status with Status id {id} does not exists");
            }
            return repo.UpdateStatus(id, Status);
        }
    }
}
