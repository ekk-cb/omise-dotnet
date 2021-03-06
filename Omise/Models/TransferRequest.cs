﻿using Newtonsoft.Json;

namespace Omise.Models
{
    public class CreateTransferRequest : Request
    {
        public long Amount { get; set; }
        public string Recipient { get; set; }
        [JsonProperty("fail_fast")]
        public bool FailFast { get; set; }
    }

    public class UpdateTransferRequest : Request
    {
        public long Amount { get; set; }
    }
}