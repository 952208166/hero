﻿using Surging.Hero.Common.Extensions;
using Surging.Hero.Organization.Domain.Shared.Organizations;
using System;
using System.Collections.Generic;
using System.Text;

namespace Surging.Hero.Organization.IApplication.Organization.Dtos
{
    public class QueryOrganizationOutput
    {
        public long Id { get; set; }

        public OrganizationType OrganizationType { get; set; }

        public string Name { get; set; }

        public string Code { get; set; }

        public string OrganizationTypeDesc { get {
                return OrganizationType.GetDescription();
            } }

        public string Memo { get; set; }
    }
}
