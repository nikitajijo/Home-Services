using HomeHarbor1.Models;

namespace HomeHarbor1.Repositories_Slot
{
    public interface ISlotRepository
    {
        List<Slot> GetSlot();
        Slot GetSlot(int id);
        int AddSlot(Slot Slot);
        int UpdateSlot(int id, Slot Slot);
        int DeleteSlot(int id);
    }
}
