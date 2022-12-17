using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using zhongyiCore.Models;
using System.IO;
using Microsoft.Extensions.Configuration;
using System.Data;
using Maticsoft.DBUtility;
using Maticsoft.Model;

namespace zhongyiCore.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }


        public Maticsoft.BLL.Message mbll = new Maticsoft.BLL.Message();
        public Maticsoft.BLL.News nbll = new Maticsoft.BLL.News();
        public Maticsoft.BLL.SortType sbll = new Maticsoft.BLL.SortType();
        public Maticsoft.BLL.Product pbll = new Maticsoft.BLL.Product();
        public Maticsoft.BLL.About abll = new Maticsoft.BLL.About();
        public Maticsoft.BLL.Login lbll = new Maticsoft.BLL.Login();
        public Maticsoft.BLL.GMile gbll = new Maticsoft.BLL.GMile();
        /// <summary>
        /// 前台首页
        /// </summary>
        /// <returns></returns>
        //public ActionResult Index()
        //{
        //    var where = "Title1='首页'";
        //    int id = abll.GetModelList(where).FirstOrDefault().ID;
        //    return View(abll.GetModel(id));
        //}
        /// <summary>
        /// 关于我们
        /// </summary>
        /// <returns></returns>
        //public IActionResult About()
        //{
        //    var where = "Title1='关于我们'";
        //    int id = abll.GetModelList(where).FirstOrDefault().ID;
        //    return View(abll.GetModel(id));
        //}
        /// <summary>
        /// 类别
        /// </summary>
        /// <returns></returns>
        //public IActionResult Category(int page = 1, int sort = 0, int day = 0, string keyword = "", int pagesize = 10, int id = 0)
        //{
        //    var where1 = "IsLock=1";
        //    var temp = nbll.GetModelList(where1).OrderByDescending(c => c.AddDateTime).ToList();
        //    if (sort != 0) {
        //        temp = temp.Where(c => c.SortID == sort).ToList();
        //    }
        //    ViewBag.PageStr = string.Format("?page={0}&sort={1}&day={2}&keyword={3}&pagesize={4}", page, sort, day, keyword, pagesize);
        //    ViewBag.Str = string.Format("&sort={0}&day={1}&keyword={2}&pagesize={3}", sort, day, keyword, pagesize);
        //    ViewBag.PageCount = (int)((temp.Count - 1) / pagesize) + 1;
        //    ViewBag.PageCounts = (int)((temp.Count - 1) / pagesize) - 1;
        //    ViewBag.CurrentPage = page;
        //    ViewBag.RowCount = temp.Count;
        //    ViewBag.SortID = sort;
        //    return View(temp.Skip((page - 1) * pagesize).Take(pagesize).ToList());
        //}
        /// <summary>
        /// 联系我们
        /// </summary>
        /// <returns></returns>
        //public IActionResult Contact(bool IsSuccess = false)
        //{
        //    ViewBag.IsSuccess = IsSuccess;
        //    return View();
        //}
        //[HttpPost]
        //public IActionResult Contact(Maticsoft.Model.Message model)
        //{
        //    try
        //    {
        //        var result = mbll.Add(model);
        //        return RedirectToAction("Contact", new ResultCode { IsSuccess = true, Msg = "提交成功", Code = 200 });
        //    }
        //    catch 
        //    {
        //        return RedirectToAction("Contact", new ResultCode { IsSuccess = true, Msg = "提交出现不可预知的错误", Code = 500 });
        //    }
        //}
        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
