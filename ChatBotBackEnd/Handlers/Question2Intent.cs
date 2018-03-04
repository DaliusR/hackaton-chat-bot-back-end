using ChatBotBackEnd.Models.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChatBotBackEnd.Handlers
{
    public class Question2Intent
    {
        internal static CommonModel Process(CommonModel commonModel)
        {

            commonModel.Response.Text = "Thank you! I will forward your feedback to the relevant service owners.\n\nCan you still see yourself using this service, even after your review?";

            commonModel.Session.EndSession = false;

            return commonModel;
        }
    }
}

