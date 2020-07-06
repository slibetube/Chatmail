using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chatmail
{
    class Message
    {
        private int Id;
        private string MessageContent;
        private int SenderId;
        private string Time;

        public int id
        {
            get { return Id; }
            set { Id = value; }
        }

        public string messageContent
        {
            get { return MessageContent; }
            set { MessageContent = value; }
        }

        public int senderId
        {
            get { return SenderId; }
            set { SenderId = value; }
        }

        public string time
        {
            get { return Time; }
            set { Time = value; }
        }

        //Constructor
        public Message(int id, string message, int senderId, string time)
        {
            this.id = id;
            this.messageContent = message;
            this.senderId = senderId;
            this.time = time;
        }
    }
}
