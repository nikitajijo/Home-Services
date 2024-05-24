using HomeHarbor1.Models;

namespace HomeHarbor1.Repositories_Status
{
    public class StatusRepository : IStatusRepository
    {
        private readonly HomeDbContext db;

        public StatusRepository(HomeDbContext db)
        {
            this.db = db;
        }
        public List<Status> GetStatus()
        {
            return db.Statuses.ToList();
        }
        public int AddStatus(Status Status)
        {
            db.Statuses.Add(Status);
            return db.SaveChanges();
        }
        public int DeleteStatus(int id)
        {
            Status c = db.Statuses.Where(x => x.Status_Id == id).FirstOrDefault();
            db.Statuses.Remove(c);
            return db.SaveChanges();
        }

        public Status GetStatus(int id)
        {
            return db.Statuses.Where(x => x.Status_Id == id).FirstOrDefault();
        }
        public int UpdateStatus(int id, Status Status)
        {
            Status c = db.Statuses.Where(x => x.Status_Id == id).FirstOrDefault();
            c.Description = Status.Description;

            db.Entry(c).State = Microsoft.EntityFrameworkCore.EntityState.Modified;
            return db.SaveChanges();
        }
    }
}
