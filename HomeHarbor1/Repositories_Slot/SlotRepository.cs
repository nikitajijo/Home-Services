using HomeHarbor1.Models;

namespace HomeHarbor1.Repositories_Slot
{
    public class SlotRepository : ISlotRepository
    {
        private readonly HomeDbContext db;

        public SlotRepository(HomeDbContext db)
        {
            this.db = db;
        }
        public List<Slot> GetSlot()
        {
            return db.Slots.ToList();
        }
        public int AddSlot(Slot Slot)
        {
            db.Slots.Add(Slot);
            return db.SaveChanges();
        }
        public int DeleteSlot(int id)
        {
            Slot c = db.Slots.Where(x => x.Slot_Id == id).FirstOrDefault();
            db.Slots.Remove(c);
            return db.SaveChanges();
        }

        public Slot GetSlot(int id)
        {
            return db.Slots.Where(x => x.Slot_Id == id).FirstOrDefault();
        }
        public int UpdateSlot(int id, Slot Slot)
        {
            Slot c = db.Slots.Where(x => x.Slot_Id == id).FirstOrDefault();
            c.Time = Slot.Time;
            db.Entry(c).State = Microsoft.EntityFrameworkCore.EntityState.Modified;
            return db.SaveChanges();
        }
    }
}
