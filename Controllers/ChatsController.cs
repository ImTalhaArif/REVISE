using System;
using Microsoft.AspNet.SignalR;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TheFinalProduct_FYP_.db_fypManagement;

namespace TheFinalProduct_FYP_.Controllers
{
    public class ChatsController : Controller
    {
        // GET: Chats
       public ActionResult SupervisorInbox()
        {
            using (TableContext db = new TableContext())
            {
                ViewData["groups"] = db.tblGroups.SqlQuery("SELECT * FROM tblGroups WHERE groupSupervisor = '"+Session["supervisorName"]+"'").ToList();
            }
            return View();
        }
        [HttpPost]
        public ActionResult SupervisorInbox(string grp)
        {
            TempData["group"] = grp;
            return RedirectToAction("groupChat");

        }
        public ActionResult groupChat()
        {
            if(TempData.ContainsKey("group"))
                {
                string chatting = TempData["group"].ToString();
                using (TableContext db = new TableContext())
                {
                    ViewData["received"] = db.tblChats.SqlQuery("Select * From tblChats Where senderName = '" + chatting + "'").ToList();
                    ViewData["sent"] = db.tblChats.SqlQuery("Select * From tblChats Where senderName = '" + Session["supervisorName"] + "'").ToList();

                }
            }
            return View();
        }
        [HttpPost]
        public ActionResult groupChat(string msg)
        {
          using(TableContext db = new TableContext())
            {
                var news = "Insert into tblChats (senderName, message, receiverName) VALUES";
            }
            return View();
        }
    }
}