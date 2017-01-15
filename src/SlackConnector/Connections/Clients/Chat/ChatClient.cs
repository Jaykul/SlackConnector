using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Newtonsoft.Json;
using RestSharp;
using SlackConnector.Connections.Responses;
using SlackConnector.Models;

namespace SlackConnector.Connections.Clients.Chat
{
    internal class ChatClient : IChatClient
    {
        private readonly IRequestExecutor _requestExecutor;
        internal const string SEND_MESSAGE_PATH = "/api/chat.postMessage";

        public ChatClient(IRequestExecutor requestExecutor)
        {
            _requestExecutor = requestExecutor;
        }

        public async Task PostMessage(string slackKey, string channel, string text, string from = null, IList <SlackAttachment> attachments = null)
        {
            var request = new RestRequest(SEND_MESSAGE_PATH);
            request.AddParameter("token", slackKey);
            request.AddParameter("channel", channel);
            request.AddParameter("text", text);

            if (attachments != null && attachments.Any())
            {
                request.AddParameter("attachments", JsonConvert.SerializeObject(attachments));
            }

            if(!string.IsNullOrEmpty(from))
            {
                request.AddParameter("username", from);
            }
            else
            {
                request.AddParameter("as_user", "true");
            }

            await _requestExecutor.Execute<StandardResponse>(request);
        }

        public async Task PostMessage(string slackKey, string channel, string text, IList<SlackAttachment> attachments)
        {
            await PostMessage(slackKey, channel, text, attachments: attachments);
        }
    }
}