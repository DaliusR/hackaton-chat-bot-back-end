using ChatBotBackEnd.Models.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChatBotBackEnd.Handlers
{
    public class SecretIntent
    {
        internal static CommonModel Process(CommonModel commonModel)
        {
            commonModel.Response.Text = "Great! What seems to be the problem?";
            commonModel.Response.Prompt = "Secret prompt";

            commonModel.Session.EndSession = false;

            return commonModel;
        }
    }
}
