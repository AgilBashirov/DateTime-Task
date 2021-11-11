using System;
using System.Collections.Generic;
using System.Text;

namespace TaskDatatime
{
    class InvalidMeetingException : Exception
    {
        public InvalidMeetingException(string msg):base(msg)
        {

        }
    }
}
