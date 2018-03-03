using ApiAiSDK.Model;
using ChatBotBackEnd.Helpers;
using System.Web.Http;

namespace ChatBotBackEnd.Controllers
{
    public class ApiAiController : ApiController
    {
        public dynamic Post(AIResponse aiResponse)
        {
            var commonModel = CommonModelMapper.ApiAiToCommonModel(aiResponse);

            if (commonModel == null)
                return null;

            commonModel = IntentRouter.Process(commonModel);

            return CommonModelMapper.CommonModelToApiAi(commonModel);
        }

        public string Get()
        {
            return "Hello API.AI!";
        }
    }
}
