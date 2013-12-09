﻿namespace Pingdom.Client.Contracts
{
    using System.Collections.Generic;

    public class GetCheckListResponse : PingdomResponse
    {
        public IEnumerable<Check> Checks { get; set; }
    }
}