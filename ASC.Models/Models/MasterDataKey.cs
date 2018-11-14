﻿using System;
using System.Collections.Generic;
using System.Text;
using ASC.Models.BaseTypes;

namespace ASC.Models.Models
{
    public class MasterDataKey : BaseEntity, IAuditTracker
    {
        public MasterDataKey() {}

        public MasterDataKey(string key)
        {
            this.RowKey = Guid.NewGuid().ToString();
            this.PartitionKey = key;
        }

        public bool IsActive { get; set; }
        public string Name { get; set; }
    }
}
