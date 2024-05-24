using HomeHarbor1.Exception;
using HomeHarbor1.Models;
using HomeHarbor1.Repositories_Slot;

namespace HomeHarbor1.Services_Slot
{
    public class SlotService : ISlotService
    {
        private readonly ISlotRepository repo;

        public SlotService(ISlotRepository repo)
        {

            this.repo = repo;
        }
        public List<Slot> GetSlot()
        {
            return repo.GetSlot();
        }
        public int AddSlot(Slot Slot)
        {
            if (repo.GetSlot(Slot.Slot_Id) != null)
            {
                throw new SlotAlreadyExistsException($"Slot with Service id {Slot.Slot_Id} already exists");
            }
            return repo.AddSlot(Slot);
        }
        public int DeleteSlot(int id)
        {
            if (repo.GetSlot(id) == null)
            {
                throw new SlotNotFoundException($"Slot with Slot id {id} does not exists");
            }
            return repo.DeleteSlot(id);
        }

        public Slot GetSlot(int id)
        {
            Slot c = repo.GetSlot(id);
            if (c == null)
            {
                throw new SlotNotFoundException($"Slot with Slot id {id} does not exists");
            }
            return c;
        }
        public int UpdateSlot(int id, Slot Slot)
        {
            if (repo.GetSlot(id) == null)
            {
                throw new SlotNotFoundException($"Slot with Slot id {id} does not exists");
            }
            return repo.UpdateSlot(id, Slot);
        }
    }
}
