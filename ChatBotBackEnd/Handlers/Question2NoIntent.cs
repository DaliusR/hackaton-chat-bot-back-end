using ChatBotBackEnd.Models.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChatBotBackEnd.Handlers
{
    public class Question2NoIntent
    {
        internal static CommonModel Process(CommonModel commonModel)
        {
            commonModel.Response.Event = "QUESTION4";

            return commonModel;
        }
    }
}
