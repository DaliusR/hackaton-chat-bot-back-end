using System;
using System.Threading.Tasks;
using Microsoft.Bot.Builder.Dialogs;
using Microsoft.Bot.Connector;
using ApiAiSDK;
using ChatBotBackEnd.Helpers;

namespace ChatBotBackEnd.Dialogs
{
    [Serializable]
    public class RootDialog : IDialog<object>
    {
        private const string clientAccessToken = "a25493b84af8474a939bbddf30b0c2e1";
        private static AIConfiguration config = new AIConfiguration(clientAccessToken, SupportedLanguage.English);
        private static ApiAi apiAi = new ApiAi(config);

        public Task StartAsync(IDialogContext context)
        {
            context.Wait(MessageReceivedAsync);

            return Task.CompletedTask;
        }

        private async Task MessageReceivedAsync(IDialogContext context, IAwaitable<object> result)
        {
            var activity = await result as Activity;

            var aiResponse = apiAi.TextRequest(string.IsNullOrWhiteSpace(activity.Text) ? "hello" : activity.Text);

            await context.PostAsync(aiResponse.Result.Fulfillment.Speech);

            context.Wait(MessageReceivedAsync);

            //var activity = await result as Activity;

            //// calculate something for us to return
            //int length = (activity.Text ?? string.Empty).Length;

            //// return our reply to the user
            //await context.PostAsync($"You sent {activity.Text} which was {length} characters");

            //context.Wait(MessageReceivedAsync);
        }
    }
}