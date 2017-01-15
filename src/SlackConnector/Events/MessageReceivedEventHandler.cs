using System.Threading.Tasks;
using SlackConnector.Models;

namespace SlackConnector.Events
{
    public delegate Task MessageReceivedEventHandler(SlackMessage message);
}