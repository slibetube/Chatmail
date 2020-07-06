using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace Chatmail
{
    public partial class Chatmail : Form
    {
        Model db = new Model();

        string activeUserName = "";
        int activeUserId = 0;

        public Chatmail()
        {
            InitializeComponent();
            this.groupBoxReceive.Visible = false;
            this.groupBoxChangeUser.Visible = false;
            this.groupBoxSend.Visible = false;
            this.groupBoxLogin.Visible = true;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            foreach (var user in db.users)
            {
                this.comboBoxReceiver.Items.Add(user.name);
                this.comboBoxUser.Items.Add(user.name);
            }
        }

        private void buttonSenden_Click(object sender, EventArgs e)
        {
            int receiverId = -1;

            foreach (var user in db.users)
            {
                if (this.comboBoxReceiver.Text == user.name)
                {
                    receiverId = user.id;
                }
            }

            if (this.comboBoxReceiver.Text != null && this.comboBoxReceiver.Text != "" 
                && this.richTextBoxSend.Text != null && this.richTextBoxSend.Text != "")
            {
                db.WriteMessage(this.richTextBoxSend.Text, this.activeUserId, receiverId);
            }
        }

        private void buttonStarten_Click(object sender, EventArgs e)
        {
            if(this.comboBoxUser.Text != null && this.comboBoxUser.Text != "")
            {
                this.activeUserName = this.comboBoxUser.Text;

                foreach (var user in db.users)
                {
                    if (user.name == activeUserName)
                    {
                        this.activeUserId = user.id;
                    }
                }

                this.groupBoxReceive.Visible = true;
                this.groupBoxSend.Visible = true;
                this.groupBoxLogin.Visible = false;
                this.groupBoxChangeUser.Visible = true;
            }

            db = new Model();
            checkMessages();
        }

        private void checkMessages()
        {
            this.richTextBoxReceive.Text = "";

            foreach (var receiver in db.receivers)
            {
                if(receiver.receiverId == this.activeUserId)
                {
                    foreach (var message in db.messages)
                    {
                        if(message.id == receiver.messageId)
                        {
                            string userName = "";

                            foreach (var user in db.users)
                            {
                                if (message.senderId == user.id)
                                {
                                    userName = user.name;
                                }
                            }

                            this.richTextBoxReceive.Text += (userName + " schrieb um " + message.time + ":\n" + message.messageContent + "\n\n");
                        }
                    }
                }
            }
        }

        private void buttonLogout_Click(object sender, EventArgs e)
        {
            this.groupBoxReceive.Visible = false;
            this.groupBoxChangeUser.Visible = false;
            this.groupBoxSend.Visible = false;
            this.groupBoxLogin.Visible = true;
        }
    }
}
