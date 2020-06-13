using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Runtime.CompilerServices;
using System.Web.Http;
using PanelKey.Models;

namespace PanelKey.Controllers
{
    public class KeyController : ApiController
    {
        enum KeyStatus
        {
            KeyIn,
            KeyOut,
            Overdue
        }

        // GET api/<controller>
        public IHttpActionResult GetKeyData(int panelId)
        {
            using (dbMyHouseKeyEntities dc = new dbMyHouseKeyEntities())
            {
                var tbKeyList = (dynamic)null;
                if (panelId == 0)
                {
                    tbKeyList = dc.Tbl_Key.OrderBy(a => a.KeyName).ToList();


                }
                else
                {
                    tbKeyList = dc.Database.SqlQuery<Keys>("Select k.KeyId, KeyName, KeyDescription, KeyStatus from Tbl_PanelKey p inner join Tbl_Key k on p.KeyId = k.KeyId where p.PanelId =" + panelId);
                }
                List<Keys> keyList = new List<Keys>();
                foreach (var item in tbKeyList)
                {
                    Keys objPanel = new Keys();
                    objPanel.KeyId = item.KeyId;
                    objPanel.KeyName = item.KeyName;
                    objPanel.KeyDescription = item.KeyDescription;
                    objPanel.KeyStatusName = Enum.GetName(typeof(KeyStatus), item.KeyStatus);
                    keyList.Add(objPanel);
                }

                return Json(new { result = keyList });
            }
        }
    }
}