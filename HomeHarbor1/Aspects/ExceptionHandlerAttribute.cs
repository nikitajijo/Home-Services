using Microsoft.AspNetCore.Mvc.Filters;
using Microsoft.AspNetCore.Mvc;
using HomeHarbor1.Exception;

namespace HomeHarbor1.Aspects
{
    public class ExceptionHandlerAttribute : ExceptionFilterAttribute
    {
        public override void OnException(ExceptionContext context)
        {
            var exceptionType = context.Exception.GetType();
            var message = context.Exception.Message;

            if (exceptionType == typeof(BookingNotFoundException))
            {
                var result = new NotFoundObjectResult(message);
                context.Result = result;
            }
            else if (exceptionType == typeof(BookingAlreadyExistsException))
            {
                var result = new ConflictObjectResult(message);
                context.Result = result;
            }
            else if (exceptionType == typeof(UserAlreadyExistsException))
            {
                var result = new ConflictObjectResult(message);
                context.Result = result;
            }
            else if (exceptionType == typeof(UserNotFoundException))
            {
                var result = new ConflictObjectResult(message);
                context.Result = result;
            }
            else if (exceptionType == typeof(FeedbackAlreadyExistsException))
            {
                var result = new ConflictObjectResult(message);
                context.Result = result;
            }
            else if (exceptionType == typeof(FeedbackNotFoundException))
            {
                var result = new ConflictObjectResult(message);
                context.Result = result;
            }
            else if (exceptionType == typeof(ServiceAlreadyExistsException))
            {
                var result = new ConflictObjectResult(message);
                context.Result = result;
            }
            else if (exceptionType == typeof(ServiceNotFoundException))
            {
                var result = new ConflictObjectResult(message);
                context.Result = result;
            }
            else if (exceptionType == typeof(SlotAlreadyExistsException))
            {
                var result = new ConflictObjectResult(message);
                context.Result = result;
            }
            else if (exceptionType == typeof(SlotNotFoundException))
            {
                var result = new ConflictObjectResult(message);
                context.Result = result;
            }
            else if (exceptionType == typeof(StatusAlreadyExistsException))
            {
                var result = new ConflictObjectResult(message);
                context.Result = result;
            }
            else if (exceptionType == typeof(StatusNotFoundException))
            {
                var result = new ConflictObjectResult(message);
                context.Result = result;
            }
            else
            {
                var result = new StatusCodeResult(500);
                context.Result = result;
            }
        }
    }
}
