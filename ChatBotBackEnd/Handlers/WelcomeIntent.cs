using ChatBotBackEnd.Models.Common;

namespace ChatBotBackEnd.Handlers
{
    public class WelcomeIntent
    {
        internal static CommonModel Process(CommonModel commonModel)
        {
            var sessionId = commonModel.Session.Id;
            var msg = commonModel.Request.Text;

            commonModel.Response.Text = "Hi there, my name is Trustum, can we talk for a minute about your review?"; //\n\n Please type yes/no

            using (var data = new ChatBotBackEnd.Data.ChatBotDBEntities())
            {
                data.Messages.Add(new Data.Message
                {
                    SessionId = sessionId,
                    Msg = msg
                });

                data.SaveChanges();
            }

            commonModel.Session.EndSession = false;

            return commonModel;
        }
    }
}