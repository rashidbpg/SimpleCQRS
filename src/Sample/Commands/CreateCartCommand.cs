﻿using System;
using SimpleCqrs.Commanding;

namespace Commands
{
    public class CreateCartCommand : Command
    {
        public CreateCartCommand()
        {
            AggregateRootId = Guid.NewGuid();
        }
    }
}