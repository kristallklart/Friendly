using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FriendlyModel
{
    class Message
    {
        private string messageId;
        private string messageDate;
        private string messageTime;
        private string messageContent;

        public string MessageId
        {
            get
            {
                return messageId;
            }

            set
            {
                messageId = value;
            }
        }

        public string MessageDate
        {
            get
            {
                return messageDate;
            }

            set
            {
                messageDate = value;
            }
        }

        public string MessageTime
        {
            get
            {
                return messageTime;
            }

            set
            {
                messageTime = value;
            }
        }

        public string MessageContent
        {
            get
            {
                return messageContent;
            }

            set
            {
                messageContent = value;
            }
        }
    }
}
