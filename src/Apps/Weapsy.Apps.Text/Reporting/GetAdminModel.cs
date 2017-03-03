﻿using System;
using Weapsy.Infrastructure.Queries;

namespace Weapsy.Apps.Text.Reporting
{
    public class GetAdminModel : IQuery
    {
        public Guid SiteId { get; set; }
        public Guid ModuleId { get; set; }
        public Guid VersionId { get; set; }
    }
}
