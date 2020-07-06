using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chatmail
{
    class Receiver
    {
        private int Id;
        private int ReceiverId;
        private int MessageId;

        public int id
        {
            get { return Id; }
            set { Id = value; }
        }

        public int receiverId
        {
            get { return ReceiverId; }
            set { ReceiverId = value; }
        }

        public int messageId
        {
            get { return MessageId; }
            set { MessageId = value; }
        }


        //Constructor
        public Receiver(int id, int receiverId, int messageId)
        {
            this.id = id;
            this.receiverId = receiverId;
            this.messageId = messageId;
        }
    }
}
