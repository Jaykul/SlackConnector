using SlackConnector.Models;
using System;

namespace SlackConnector.Events
{
    public class SlackMessageEventArgs : EventArgs
    {
        public SlackMessage Message { get; set; }
    }

    public delegate void MessageReceivedEventHandler(object sender, SlackMessageEventArgs eventArgs);
}