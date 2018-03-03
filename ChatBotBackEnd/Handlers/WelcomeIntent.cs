using ChatBotBackEnd.Models.Common;

namespace ChatBotBackEnd.Handlers
{
    public class WelcomeIntent
    {
        internal static CommonModel Process(CommonModel commonModel)
        {
            commonModel.Response.Text = "Hi there, this is ReviewChatBot speaking";
            commonModel.Response.Prompt = "My job is to figure out why you want to leave a negative review";

            commonModel.Session.EndSession = false;

            return commonModel;
        }
    }
}