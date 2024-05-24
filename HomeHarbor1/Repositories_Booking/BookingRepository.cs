using HomeHarbor1.Models;

namespace HomeHarbor1.Repositories_Booking
{
    public class BookingRepository : IBookingRepository
    {
        private readonly HomeDbContext db; //to interact with the database

        public BookingRepository(HomeDbContext db)
        {
            this.db = db;
        }
        public List<Booking> GetBooking()
        {
            return db.Bookings.ToList();
        }
        public int AddBooking(Booking Booking)
        {
            db.Bookings.Add(Booking);
            return db.SaveChanges();
        }
        public int DeleteBooking(int id)
        {
            Booking c = db.Bookings.Where(x => x.Booking_Id == id).FirstOrDefault();
            db.Bookings.Remove(c);
            return db.SaveChanges();
        }

        public Booking GetBooking(int id)
        {
            return db.Bookings.Where(x => x.Booking_Id == id).FirstOrDefault();
        }
        public int UpdateBooking(int id, Booking Booking)
        {
            Booking c = db.Bookings.Where(x => x.Booking_Id == id).FirstOrDefault();
            c.Booking_Date = Booking.Booking_Date;
            c.Booked_Date = Booking.Booked_Date;


            db.Entry(c).State = Microsoft.EntityFrameworkCore.EntityState.Modified;
            return db.SaveChanges();

            // tells Entity Framework that the entity has been changed and needs to be updated in the database
        }
    }
}
