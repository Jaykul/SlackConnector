using SlackConnector.Models;
using System;

namespace SlackConnector.Events
{
    public class ChatHubJoinedEventArgs : EventArgs
    {
        public SlackChatHub ChatHub { get; set; }
    }

    public delegate void ChatHubJoinedEventHandler(object sender, ChatHubJoinedEventArgs eventArgs);
}
