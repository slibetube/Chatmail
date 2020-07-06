using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chatmail
{
    class User
    {
        private int Id;
        private string Name;

        public int id
        {
            get { return Id; }
            set { Id = value; }
        }
        public string name
        {
            get { return Name; }
            set { Name = value; }
        }

        public User(int id, string name)
        {
            this.id = id;
            this.name = name;
        }
    }
}
