﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NetworkModel.Actors.ActorEvents
{
    public enum ActorEventType
    {
        ChannelAdded,
        ChannelRemoved,
        MessageReceived,
        TimerElapsed
    }
}
