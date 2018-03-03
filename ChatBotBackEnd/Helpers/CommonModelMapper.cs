using ApiAiSDK.Model;
using ChatBotBackEnd.Models.Common;
using System.Collections.Generic;
using System.Linq;

namespace ChatBotBackEnd.Helpers
{
    public class CommonModelMapper
    {
        internal static CommonModel ApiAiToCommonModel(AIResponse aiResponse)
        {
            var commonModel = new CommonModel()
            {
                Id = aiResponse.Id
            };

            commonModel.Session.Id = aiResponse.SessionId;
            commonModel.Request.Text = aiResponse.Result.ResolvedQuery;
            commonModel.Request.Intent = aiResponse.Result.Metadata.IntentName;
            commonModel.Request.State = aiResponse.Result.ActionIncomplete ? "IN_PROGRESS" : "COMPLETED";
            commonModel.Request.Channel = aiResponse.Result.Source;
            commonModel.Request.Parameters = aiResponse.Result.Parameters.ToList()
                .ConvertAll(p => new KeyValuePair<string, string>(p.Key, p.Value.ToString()));

            return commonModel;
        }

        internal static dynamic CommonModelToApiAi(CommonModel commonModel)
        {
            if (string.IsNullOrWhiteSpace(commonModel.Response.Event))
                return new
                {
                    speech = (string.IsNullOrWhiteSpace(commonModel.Response.Ssml) || commonModel.Request.Channel == "agent") ? commonModel.Response.Text : "<speak>" + commonModel.Response.Ssml + "</speak>",
                    displayText = commonModel.Response.Text,
                    data = new { slack = new { text = commonModel.Response.Text }, google = new { expectUserResponse = !commonModel.Session.EndSession } },
                    source = "Review ChatBot"
                };
            else
                return new
                {
                    followupEvent = new
                    {
                        name = commonModel.Response.Event
                    }
                };
        }
    }
}