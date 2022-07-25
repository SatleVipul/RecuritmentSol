using Recuritment.Models;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Recuritment.Controllers
{
    public class HomeController : Controller
    {
        RecruitmentDbEntities1 db = new RecruitmentDbEntities1();
        public ActionResult Index()
        {
            return View(db.Database.SqlQuery<tb_CandidateMaster>(@"Exec [dbo].[RetriveAll]"));
        }
        [HttpGet]
        public ActionResult Delete(int Id)
        {
            ViewBag.id = Id;
            return View();
        }
        [HttpGet]
        public ActionResult DeletePost(int Id)
        {
            SqlParameter ids = new SqlParameter("@Id",Id);
            var a = db.Database.ExecuteSqlCommand("[dbo].[DeleteByID] @Id", ids);
            return RedirectToAction("Index");
        }
        [HttpGet]
        public ActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Create(tb_CandidateMaster model)
        {
            object[] sqlParams =
            {
                new SqlParameter("@CandidateName",model.CandidateName),
                new SqlParameter("@DateOfBirth",model.DateOfBirth),
                new SqlParameter("@Discription",model.Discription),
                new SqlParameter("@Skills",model.Skills),
                new SqlParameter("@Isdeleted",1),
                new SqlParameter("@Created",1),
                new SqlParameter("@CreatedOn",DateTime.Now)
            };
            db.Database.ExecuteSqlCommand("[dbo].[InsertData] @CandidateName,@DateOfBirth,@Discription,@Skills,@Isdeleted,@Created,@CreatedOn", sqlParams);
            return RedirectToAction("Index");
        }
        [HttpGet]
        public ActionResult Edit(int id)
        {
            SqlParameter param = new SqlParameter("@ID", id);
            var a = db.Database.SqlQuery<tb_CandidateMaster>(@"Exec [dbo].[GetByID] @ID", param).FirstOrDefault();
            return View(a);
        }
        [HttpPost]
        public ActionResult Edit(tb_CandidateMaster model)
        {
            object[] sqlParams =
            {
                new SqlParameter("@Id",model.Id),
                new SqlParameter("@CandidateName",model.CandidateName),
                new SqlParameter("@DateOfBirth",model.DateOfBirth),
                new SqlParameter("@Discription",model.Discription),
                new SqlParameter("@Skills",model.Skills),
                new SqlParameter("@Modified",1),
                new SqlParameter("@ModifiedOn",DateTime.UtcNow )

            };
            db.Database.ExecuteSqlCommand("[dbo].[UpdateData] @Id,@CandidateName,@DateOfBirth,@Discription,@Skills,@Modified,@ModifiedOn", sqlParams);
            return RedirectToAction("Index");
        }
        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}