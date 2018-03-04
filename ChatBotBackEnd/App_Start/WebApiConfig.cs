using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;
using System.Web.Http;
using ChatBotBackEnd.Models;

namespace ChatBotBackEnd
{
    public static class WebApiConfig
    {
        public static IntentsList IntentHandlers { get; private set; }

        public static void Register(HttpConfiguration config)
        {
            IntentHandlers = new IntentsList
            {
                //Register intents here
                { "Question4Intent", (cm) => Handlers.Question4Intent.Process(cm) },
                { "Question2NoIntent", (cm) => Handlers.Question2NoIntent.Process(cm) },
                { "Question2YesIntent", (cm) => Handlers.Question2YesIntent.Process(cm) },
                { "Question3Intent", (cm) => Handlers.Question3Intent.Process(cm) },
                { "Question2IntentFallback", (cm) => Handlers.Question2IntentFallback.Process(cm) },
                { "Question2Intent", (cm) => Handlers.Question2Intent.Process(cm) },
                { "StartConversationIntentFallbackTo2", (cm) => Handlers.StartConversationIntentFallbackTo2.Process(cm) },
                { "StartConversationIntentFallback", (cm) => Handlers.StartConversationIntentFallback.Process(cm) },
                { "YesIntentDefaultWelcome", (cm) => Handlers.YesIntent.Process(cm) },
                { "StartConversationIntent", (cm) => Handlers.SecretIntent.Process(cm) },
                { "DefaultWelcomeIntent", (cm) => Handlers.WelcomeIntent.Process(cm) }
            };

            // Json settings
            config.Formatters.JsonFormatter.SerializerSettings.NullValueHandling = NullValueHandling.Ignore;
            config.Formatters.JsonFormatter.SerializerSettings.ContractResolver = new CamelCasePropertyNamesContractResolver();
            config.Formatters.JsonFormatter.SerializerSettings.Formatting = Formatting.Indented;
            JsonConvert.DefaultSettings = () => new JsonSerializerSettings()
            {
                ContractResolver = new CamelCasePropertyNamesContractResolver(),
                Formatting = Newtonsoft.Json.Formatting.Indented,
                NullValueHandling = NullValueHandling.Ignore,
            };

            // Web API configuration and services

            // Web API routes
            config.MapHttpAttributeRoutes();

            config.Routes.MapHttpRoute(
                name: "DefaultApi",
                routeTemplate: "api/{controller}/{id}",
                defaults: new { id = RouteParameter.Optional }
            );
        }
    }
}
