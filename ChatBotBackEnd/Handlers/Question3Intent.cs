using ChatBotBackEnd.Models.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChatBotBackEnd.Handlers
{
    public class Question3Intent
    {
        internal static CommonModel Process(CommonModel commonModel)
        {
            commonModel.Response.Text = "Great, it's good to see you still believe in this service!\n\nI appreciate and thank you for your time and input.";

            commonModel.Session.EndSession = true;

            return commonModel;
        }
    }
}

