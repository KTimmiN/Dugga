using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DuggaNumreric
{
    public class NumrericNumbers
    {
        public string DuggaNumreric(string message)
        {
            if(message == null)
            {
                throw new ArgumentNullException("Message is null");
            }
            if (message.Trim().Equals(""))
            {
                throw new ArgumentException("Message is empty");

            }
            if (message.Trim().Equals("k"))
            {
                return "1000";
            }
            if (message.Trim().Equals("1k"))
            {
                return "1000";
            }
            return message;
        }
    }
}
