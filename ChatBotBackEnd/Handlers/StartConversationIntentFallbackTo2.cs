﻿using ChatBotBackEnd.Models.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChatBotBackEnd.Handlers
{
    public class StartConversationIntentFallbackTo2
    {
        internal static CommonModel Process(CommonModel commonModel)
        {

            commonModel.Response.Event = "QUESTION2";

            return commonModel;
        }
    }
}
