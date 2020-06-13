using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PanelKey.Models
{
    public class PanelKeys
    {
        public int PanelKeyId { get; set; }
        public Nullable<int> PanelId { get; set; }
        public Nullable<int> KeyId { get; set; }
    }
}