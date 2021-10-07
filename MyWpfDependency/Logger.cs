using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyWpfDependency
{
    public class Logger
    {
        private string message;

        public string Message
        {
            get { return message; }
            set { message = value; }
        }

    }
}
