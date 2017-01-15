using System.Threading.Tasks;
using SlackConnector.Models;

namespace SlackConnector.Events
{
    public delegate Task ChatHubJoinedEventHandler(SlackChatHub chatHub);
}
