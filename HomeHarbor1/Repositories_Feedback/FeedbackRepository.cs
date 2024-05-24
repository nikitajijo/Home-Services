﻿using HomeHarbor1.Models;

namespace HomeHarbor1.Repositories_Feedback
{
    public class FeedbackRepository : IFeedbackRepository
    {
        private readonly HomeDbContext db;

        public FeedbackRepository(HomeDbContext db)
        {
            this.db = db;
        }
        public List<Feedback> GetFeedback()
        {
            return db.Feedbacks.ToList();
        }
        public int AddFeedback(Feedback Feedback)
        {
            db.Feedbacks.Add(Feedback);
            return db.SaveChanges();
        }
        public int DeleteFeedback(int id)
        {
            Feedback c = db.Feedbacks.Where(x => x.Feedback_Id == id).FirstOrDefault();
            db.Feedbacks.Remove(c);
            return db.SaveChanges();
        }

        public Feedback GetFeedback(int id)
        {
            return db.Feedbacks.Where(x => x.Feedback_Id == id).FirstOrDefault();
        }
        public int UpdateFeedback(int id, Feedback Feedback)
        {
            Feedback c = db.Feedbacks.Where(x => x.Feedback_Id == id).FirstOrDefault();
            c.Comment = Feedback.Comment;
            c.Rating = Feedback.Rating;
            c.Commented_Date = Feedback.Commented_Date;

            db.Entry(c).State = Microsoft.EntityFrameworkCore.EntityState.Modified;
            return db.SaveChanges();
        }
    }
}
