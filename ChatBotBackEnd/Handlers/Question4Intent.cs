using ChatBotBackEnd.Models.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChatBotBackEnd.Handlers
{
    public class Question4Intent
    {
        internal static CommonModel Process(CommonModel commonModel)
        {
            commonModel.Response.Text = "I understand your decision.\n\n I will keep this in mind and let you know once the service owner responds to your feedback.";

            commonModel.Session.EndSession = true;

            return commonModel;
        }
    }
}
