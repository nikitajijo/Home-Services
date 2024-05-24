using HomeHarbor1.Models;

namespace HomeHarbor1.Repositories_Feedback
{
    public interface IFeedbackRepository
    {
        List<Feedback> GetFeedback();
        Feedback GetFeedback(int id);
        int AddFeedback(Feedback Feedback);
        int UpdateFeedback(int id, Feedback Feedback);
        int DeleteFeedback(int id);
    }
}
