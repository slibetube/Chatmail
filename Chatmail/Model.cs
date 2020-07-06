using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using DBConnectorTest;
using System.Data;
using System.Diagnostics;

namespace Chatmail
{
    class Model
    {
        private DBConnector DBVerbindung = new DBConnector("127.0.0.1", "chatmail", "admin", "1234Abcd");
        private List<User> userList = new List<User>();
        private List<Message> messageList = new List<Message>();
        private List<Receiver> receiverList = new List<Receiver>();

        public List<User> users
        {
            get { return userList; }   // get name method
            set { userList = value; }  // set name method
        }

        public List<Message> messages
        {
            get { return messageList; }   // get name method
            set { messageList = value; }  // set name method
        }

        public List<Receiver> receivers
        {
            get { return receiverList; }   // get name method
            set { receiverList = value; }  // set name method
        }

        //Constructor
        public Model()
        {
            FetchUsers();
            FetchMessages();
            FetchReceivers();
        }

        public void FetchUsers()
        {
            this.userList = new List<User>();

            DBVerbindung.Open();
            var tmpUsers = DBVerbindung.ExecuteTable("SELECT * FROM user");
            DBVerbindung.Close();

            foreach (DataRow dataRow in tmpUsers.Rows)
            {
                int tmpId = -1;
                string tmpName = "";

                foreach (var userItem in dataRow.ItemArray)
                {
                    if (int.TryParse(userItem.ToString(), out _))
                    {
                        int.TryParse(userItem.ToString(), out int id);
                        tmpId = id;
                        Debug.WriteLine("ID:" + tmpId);
                    }
                    else
                    {
                        tmpName = userItem.ToString();
                        Debug.WriteLine("Name:" + tmpName);
                    }
                }
                User user = new User(tmpId, tmpName);

                this.userList.Add(user);
            }
        }

        public void FetchMessages()
        {
            this.messageList = new List<Message>();

            DBVerbindung.Open();
            var tmpMessages = DBVerbindung.ExecuteTable("SELECT * FROM messages ORDER BY time");
            DBVerbindung.Close();

            foreach (DataRow dataRow in tmpMessages.Rows)
            {
                int tmpId = -1;
                string tmpMessage = "";
                int tmpSenderId = -1;
                string tmpTime = "";

                foreach (var messageItem in dataRow.ItemArray)
                {
                    if (int.TryParse(messageItem.ToString(), out _))
                    {
                        if(tmpId != -1)
                        {
                            int.TryParse(messageItem.ToString(), out int id);
                            tmpSenderId = id;
                            Debug.WriteLine("SenderID:" + tmpSenderId);
                        }
                        else
                        {
                            int.TryParse(messageItem.ToString(), out int id);
                            tmpId = id;
                            Debug.WriteLine("ID:" + tmpId);
                        }
                    }
                    else
                    {
                        if(tmpMessage != "")
                        {
                            tmpTime = messageItem.ToString();
                            Debug.WriteLine("Time:" + tmpTime);
                        }
                        else
                        {
                            tmpMessage = messageItem.ToString();
                            Debug.WriteLine("Message:" + tmpMessage);
                        }
                        
                    }
                }
                Message message = new Message(tmpId, tmpMessage, tmpSenderId, tmpTime);

                this.messageList.Add(message);
            }
        }

        public void FetchReceivers()
        {
            this.receiverList = new List<Receiver>();

            DBVerbindung.Open();
            var tmpReceivers = DBVerbindung.ExecuteTable("SELECT * FROM receivers");
            DBVerbindung.Close();

            foreach (DataRow dataRow in tmpReceivers.Rows)
            {
                int tmpId = -1;
                int tmpMessageId = -1;
                int tmpReceiverId = -1;

                foreach (var messageItem in dataRow.ItemArray)
                {
                    if (tmpId == -1)
                    {
                        int.TryParse(messageItem.ToString(), out int id);
                        tmpId = id;
                        Debug.WriteLine("ID:" + tmpId);
                    }
                    else if(tmpMessageId == -1)
                    {
                        int.TryParse(messageItem.ToString(), out int id);
                        tmpMessageId = id;
                        Debug.WriteLine("MessageID:" + tmpMessageId);
                    }  
                    else
                    {
                        int.TryParse(messageItem.ToString(), out int id);
                        tmpReceiverId = id;
                        Debug.WriteLine("ReceiverID:" + tmpReceiverId);
                    }
                }
                Receiver receiver = new Receiver(tmpId, tmpReceiverId, tmpMessageId);

                this.receiverList.Add(receiver);
            }
        }

        public void WriteMessage(string message, int senderId, int receiverId)
        {
            string time = DateTime.Now.ToString("HH:mm");

            DBVerbindung.Open();
            DBVerbindung.Execute("INSERT INTO `messages` (`id`, `message`, `sender_id`, `time`) VALUES (NULL, '" + message + "', '" + senderId + "', '" + time + "');");
            DBVerbindung.Close();

            List<Message> oldMessageList = messageList;

            FetchMessages();

            int newMessageId = -1;

            foreach (var newMessageItem in messageList)
            {
                bool isNew = true;

                foreach (var oldMessageItem in oldMessageList)
                {
                    if(oldMessageItem.id == newMessageItem.id)
                    {
                        isNew = false;
                        continue;
                    }
                }

                if(isNew)
                {
                    newMessageId = newMessageItem.id;
                }
            }

            DBVerbindung.Open();
            DBVerbindung.Execute("INSERT INTO `receivers` (`receiver_id`, `message_id`, `user_id`) VALUES (NULL, '" + newMessageId + "', '" + receiverId + "');");
            DBVerbindung.Close();
        }
    }
}
