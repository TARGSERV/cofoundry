﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Cofoundry.Web.Admin
{
    public class SiteViewerJsRouteLibrary : ModuleJsRouteLibrary
    {
        public SiteViewerJsRouteLibrary(
            ModuleRouteLibrary moduleRouteLibrary
            )
            : base(moduleRouteLibrary)
        {
        }

        #region custom routes

        public string EventAggregator
        {
            get
            {
                return Bundle("EventAggregator");
            }
        }

        #endregion
    }
}