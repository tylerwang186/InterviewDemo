using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PanelKey.Models
{
    public class Panels
    {
        public int PanelId { get; set; }
        public string PanelName { get; set; }
        public Nullable<int> PanelStatusId { get; set; }
        public string PanelStatus { get; set; }
    }
}