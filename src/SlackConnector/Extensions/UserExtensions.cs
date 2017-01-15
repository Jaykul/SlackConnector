using SlackConnector.Connections.Models;
using SlackConnector.Models;
using System.Collections.Generic;

namespace SlackConnector.Extensions
{
    internal static class UserExtensions
    {
        public static SlackUser ToSlackUser(this User user, Dictionary<string, SlackUser> userCache = null)
        {
            var slackUser = new SlackUser
            {
                Id = user.Id,
                Name = user.Name,
                TimeZoneOffset = user.TimeZoneOffset,
                IsBot = user.IsBot
            };

            if (!string.IsNullOrWhiteSpace(user.Presence))
            {
                slackUser.Online = user.Presence == "active";
            }

            if(userCache != null)
            {
                userCache[slackUser.Id] = slackUser;
            }

            return slackUser;
        }
    }
}