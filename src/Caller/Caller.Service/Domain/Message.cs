﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Caller.Service.Domain
{
    public class Message
    {
        public Message()
        {
            Content = "Hello!!";
        }
        public string Content { get; set; }
    }
}
