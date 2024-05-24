using HomeHarbor1.Models;
using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;

namespace HomeHarbor1.Repositories_Service
{
    public class ServiceRepository : IServiceRepository
    {
        private readonly HomeDbContext db;

        public ServiceRepository(HomeDbContext db)
        {
            this.db = db;
        }
        public List<Service> GetService()
        {
            return db.Services.ToList();
        }
        public int AddService(Service Service)
        {
            db.Services.Add(Service);
            return db.SaveChanges();
        }
        public int DeleteService(int id)
        {
            Service c = db.Services.Where(x => x.Service_Id == id).FirstOrDefault();
            db.Services.Remove(c);
            return db.SaveChanges();
        }

        public Service GetService(int id)
        {
            return db.Services.Where(x => x.Service_Id == id).FirstOrDefault();
        }
        public int UpdateService(int id, Service Service)
        {
            Service c = db.Services.Where(x => x.Service_Id == id).FirstOrDefault();
            c.Service_Name = Service.Service_Name;
            c.Description = Service.Description;
            c.Price = Service.Price;


            db.Entry(c).State = Microsoft.EntityFrameworkCore.EntityState.Modified;
            return db.SaveChanges();
        }
        //public List<Service> SearchServices(string service)
        //{

        //    string searchByService = "exec SearchServices " +
        //        "@service = " + service;
        //    return db.Services.FromSqlRaw(searchByService).ToList();
        //}
        public List<Service> SearchServices(string service)
        {
            string searchByService = "exec SearchServices @service";
            return db.Services.FromSqlRaw(searchByService, new SqlParameter("@service", service)).ToList();
        }
    }
}
