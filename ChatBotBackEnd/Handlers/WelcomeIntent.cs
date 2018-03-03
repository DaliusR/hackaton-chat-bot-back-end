using ChatBotBackEnd.Models.Common;

namespace ChatBotBackEnd.Handlers
{
    public class WelcomeIntent
    {
        internal static CommonModel Process(CommonModel commonModel)
        {
            var sessionId = commonModel.Session.Id;
            var msg = commonModel.Request.Text;

            commonModel.Response.Text = "Hi there, this is ReviewChatBot speaking, can we talk for a minute? Please type yes/no";
            commonModel.Response.Prompt = "My job is to figure out why you want to leave a negative review";   

            using (var data = new ChatBotBackEnd.Data.ChatBotDBEntities())
            {
                data.Messages.Add(new Data.Message
                {
                    SessionId = sessionId,
                    Msg = msg
                });

                data.SaveChanges();
            }

            commonModel.Session.EndSession = true;

            return commonModel;
        }
    }
}