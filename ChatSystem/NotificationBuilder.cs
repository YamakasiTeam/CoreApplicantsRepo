﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChatSystem.Core
{
    public class NotificationBuilder
    {
        private EventType _type;
        private string _message;

        public NotificationBuilder SetType(EventType type)
        {
            _type = type;
            return this;
        }

        public NotificationBuilder SetMessage(string message)
        {
            _message = message;
            return this;
        }

        public (EventType, object) Build()
        {
            return (_type, _message);
        }
    }
}