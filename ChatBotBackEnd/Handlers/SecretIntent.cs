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


                commonModel.Response.Text = "Thank you! It would be really helpful, if you could expand on this issue about bad service?";
                commonModel.Response.Prompt = "Secret prompt";

                commonModel.Session.EndSession = false;

                return commonModel;
            }
        }
    }
