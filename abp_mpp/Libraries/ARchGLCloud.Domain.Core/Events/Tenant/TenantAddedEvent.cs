﻿using System;

namespace ARchGLCloud.Domain.Core.Events
{
    public class TenantAddedEvent : TenantEvent
    {
        public TenantAddedEvent(Guid id, Guid tenantId, string eName, string name, string host, string connectionString, bool enabled) : base(id, tenantId, eName, name, host, connectionString, enabled)
        {
        }
    }
}
