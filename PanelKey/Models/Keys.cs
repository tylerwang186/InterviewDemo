using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PanelKey.Models
{
    public class Keys
    {
        public int KeyId { get; set; }
        public string KeyName { get; set; }
        public string KeyDescription { get; set; }
        public Nullable<int> KeyStatus { get; set; }
        public string KeyStatusName { get; set; }
    }
}