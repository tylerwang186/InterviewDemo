using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using PanelKey.Models;

namespace PanelKey.Controllers
{
    public class PanelController : ApiController
    {
        enum PanelStatus
        {
            Online,
            Offline
        }

        // GET api/<controller>
        public IHttpActionResult GetPanelData()
        {
            using (dbMyHouseKeyEntities dc = new dbMyHouseKeyEntities())
            {
                var tbPanelList = dc.Tbl_Panel.OrderBy(a => a.PanelName).ToList();
                List<Panels> panelList = new List<Panels>();
                foreach (var item in tbPanelList)
                {
                    Panels objPanel = new Panels();
                    objPanel.PanelId = item.PanelId;
                    objPanel.PanelName = item.PanelName;
                    objPanel.PanelStatus = Enum.GetName(typeof(PanelStatus), item.PanelStatusId); 
                    panelList.Add(objPanel);
                }

                return Json(new { result = panelList }); ;
            }
        }
    }
}