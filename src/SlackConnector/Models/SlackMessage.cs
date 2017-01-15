using SlackConnector.Connections.Sockets.Messages.Inbound;

namespace SlackConnector.Models
{
    public class SlackMessage
    {
        public SlackChatHub ChatHub { get; set; }
        public bool MentionsBot { get; set; }
        public string RawData { get; set; }
        public string Text { get; set; }
        public SlackUser User { get; set; }
        public double TimeStamp { get; set; }
        public MessageSubType MessageType { get; set; }
    }
}