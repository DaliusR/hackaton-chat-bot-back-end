using ChatBotBackEnd.Data;
using System;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace ChatBotBackEnd.Controllers
{
    public class ReviewController : ApiController
    {
        public HttpResponseMessage Post([FromBody] Models.UserReview model)
        {

            if (!string.IsNullOrWhiteSpace(model.text) && !string.IsNullOrWhiteSpace(model.username) && model.rating != 0)
            {
                using (var data = new ChatBotBackEnd.Data.ChatBotDBEntities())
                {
                    data.UserReviews.Add(new Data.UserReview
                    {
                        Username = model.username,
                        Msg = model.text,
                        ReviewTime = DateTime.Now,
                        uniqId = Guid.NewGuid().ToString(),
                        rating = model.rating
                });

                    if(data.SaveChanges() == 0)
                    {
                        return Request.CreateResponse(HttpStatusCode.InternalServerError);
                    }
                }

                var response = Request.CreateResponse(HttpStatusCode.Created, model.text + " " + model.username + "rating " + model.rating);
                return response;
            }
            else
            {
                return  Request.CreateResponse(HttpStatusCode.BadRequest);
            }
        }
    }
}
