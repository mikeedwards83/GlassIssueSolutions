using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Glass.Mapper.Sc.Configuration.Attributes;

namespace Mvc7.Models
{
    [SitecoreType(AutoMap = true)]
    public class Header
    {
        public virtual string Title { get; set; }
    }
}