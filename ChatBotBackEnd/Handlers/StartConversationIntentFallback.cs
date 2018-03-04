using ChatBotBackEnd.Models.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChatBotBackEnd.Handlers
{
    public class StartConversationIntentFallback
    {
        internal static CommonModel Process(CommonModel commonModel)
        {

            commonModel.Response.Text = "I'm glad you could share this with me.\n\nWhat do you think should have been done for you to not leave this negative review?";

            return commonModel;
        }
    }
}
