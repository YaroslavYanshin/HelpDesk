using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HelpDesk.Enums
{
    public enum RequestStatus
    {
        Open = 1,
        Distributed = 2,
        Proccesing = 3,
        Checking = 4,
        Closed = 5
    }
}