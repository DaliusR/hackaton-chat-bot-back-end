using ChatBotBackEnd.Models.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChatBotBackEnd.Handlers
{
    public class Question2YesIntent
    {
        internal static CommonModel Process(CommonModel commonModel)
        {
            commonModel.Response.Event = "QUESTION3";

            return commonModel;
        }
    }
}
