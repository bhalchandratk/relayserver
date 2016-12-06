﻿using System;
using System.Threading.Tasks;
using Thinktecture.Relay.OnPremiseConnector.OnPremiseTarget;

namespace Thinktecture.Relay.Server.Communication
{
    public class RegistrationInformation
    {
        public string ConnectionId { get; set; }
        public string OnPremiseId { get; set; }
        public Func<IOnPremiseTargetRequest, Task> RequestAction { get; set; }
        public string IpAddress { get; set; }
        public string UserName { get; set; }
        public string Role { get; set; }
    }
}