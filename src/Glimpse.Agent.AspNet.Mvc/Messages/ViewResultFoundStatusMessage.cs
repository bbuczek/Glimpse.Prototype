﻿using System.Collections.Generic;

namespace Glimpse.Agent.AspNet.Mvc.Messages
{
    public class ViewResultFoundStatusMessage
    {
        public string ActionId { get; set; }

        public string ActionName { get; set; }

        public string ControllerName { get; set; }

        public string ViewName { get; set; }

        public bool DidFind { get; set; }

        public IEnumerable<string> SearchedLocations { get; set; }

        public ViewResult ViewData { get; set; }
    }
}