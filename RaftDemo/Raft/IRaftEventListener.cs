﻿using RaftDemo.Raft.Messages;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RaftDemo.Raft
{
    public interface IRaftEventListener
    {
        void OnElectionStarted();
        void OnAppendEntries();
    }
}
