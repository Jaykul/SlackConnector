using SlackConnector.Models;
using System;

namespace SlackConnector.Events
{
    public class UserJoinedEventArgs : EventArgs
    {
        public SlackUser User { get; set; }
    }

    public delegate void UserJoinedEventHandler(object sender, UserJoinedEventArgs eventArgs);
}
