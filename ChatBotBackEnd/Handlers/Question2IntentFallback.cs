using ChatBotBackEnd.Models.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChatBotBackEnd.Handlers
{
    public class Question2IntentFallback
    {
        internal static CommonModel Process(CommonModel commonModel)
        {
            commonModel.Response.Text = "Thanks for answering everything!";

            commonModel.Session.EndSession = true;

            return commonModel;
        }
    }
}
