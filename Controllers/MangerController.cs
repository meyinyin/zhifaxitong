using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MailKit.Net.Smtp;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.UI.V3.Pages.Account.Internal;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;
using MimeKit;
using MimeKit.Text;

namespace zhongyiCore.Controllers
{
    [Authorize]
    public class MangerController : Controller
    {
        public Maticsoft.BLL.Message mbll = new Maticsoft.BLL.Message();
        public Maticsoft.BLL.News nbll = new Maticsoft.BLL.News();
        public Maticsoft.BLL.SortType sbll = new Maticsoft.BLL.SortType();
        public Maticsoft.BLL.Product pbll = new Maticsoft.BLL.Product();
        public Maticsoft.BLL.About abll = new Maticsoft.BLL.About();
        public Maticsoft.BLL.Login lbll = new Maticsoft.BLL.Login();
        public Maticsoft.BLL.GMile gbll = new Maticsoft.BLL.GMile();
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult Welcome()
        {
            return View();
        }

        #region 留言板模块
        /// <summary>
        /// 留言板首页
        /// </summary>
        /// <returns></returns>
        public ActionResult Email(int page = 1, int sort = 0, int day = 0, string keyword = "", int pagesize = 10, int id = 0)
        {
            var temp = mbll.GetModelList("").OrderByDescending(c => c.MDate).ToList();
            ViewBag.PageStr = string.Format("?page={0}&sort={1}&day={2}&keyword={3}&pagesize={4}", page, sort, day, keyword, pagesize);
            ViewBag.Str = string.Format("&sort={0}&day={1}&keyword={2}&pagesize={3}", sort, day, keyword, pagesize);
            ViewBag.PageCount = (int)((temp.Count - 1) / pagesize) + 1;
            ViewBag.CurrentPage = page;
            ViewBag.RowCount = temp.Count;
            return View(temp.Skip((page - 1) * pagesize).Take(pagesize).ToList());
        }
        /// <summary>
        /// 留言板删除
        /// </summary>
        /// <param name="ID"></param>
        /// <returns></returns>
        public ActionResult EmailDel(int ID)
        {
            var del = mbll.Delete(ID);
            return RedirectToAction("Email");
        }
        public Maticsoft.Model.News model = new Maticsoft.Model.News();
        /// <summary>
        /// 留言锁定
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public JsonResult MessageSd(int id)
        {
            //suoping2.AddRz(User.Identity.Name, "锁定资讯ID" + id);
            var m = mbll.GetModel(id);
            m.MState = m.MState ? false : true;
            mbll.Update(m);
            model.Title = m.MName;
            model.Author = m.MEmail;
            model.IsLock = false;
            model.Description = m.MContent;
            nbll.Add(model);
            return Json(new { IsSuccess = true });
        }
        #endregion

        #region 新闻模块
        /// <summary>
        /// 新闻首页
        /// </summary>
        /// <param name="page">当前页码</param>
        /// <param name="sort">当前栏目</param>
        /// <param name="day">时间</param>
        /// <param name="keyword">关键字</param>
        /// <param name="pagesize">每页显示多少条记录</param>
        /// <returns></returns>
        public ActionResult News(int page = 1, int sort = 0, int day = 0, string keyword = "", int pagesize = 10, int id = 0)
        {
            //int SiteID = int.Parse(Session["StoreID"].ToString());
            //string where = "";
            //if (SiteID != 0)
            //{
            //    where = "ShopMenberID=" + SiteID;
            //}
            var temp = nbll.GetModelList("").OrderByDescending(c => c.AddDateTime).ToList();
            //var temp = new List<Maticsoft.Model.News>();
            
            if (sort != 0)
            {
                temp = temp.Where(c => c.SortID == sort).ToList();
            }
            if (day != 0)
            {
                DateTime now = DateTime.Now;
                temp = temp.Where(c => (((DateTime)c.AddDateTime) - now) <= new TimeSpan(day, 0, 0, 0, 0)).ToList();
            }
            ViewBag.PageStr = string.Format("?page={0}&sort={1}&day={2}&keyword={3}&pagesize={4}", page, sort, day, keyword, pagesize);
            ViewBag.Str = string.Format("&sort={0}&day={1}&keyword={2}&pagesize={3}", sort, day, keyword, pagesize);
            ViewBag.PageCount = (int)((temp.Count - 1) / pagesize) + 1;
            ViewBag.CurrentPage = page;
            ViewBag.RowCount = temp.Count;
            return View(temp.Skip((page - 1) * pagesize).Take(pagesize).ToList());
        }
        /// <summary>
        /// 新闻添加页
        /// </summary>
        /// <param name="IsSuccess"></param>
        /// <returns></returns>
        public ActionResult NewsAdd(bool IsSuccess = false)
        {
            ViewBag.IsSuccess = IsSuccess;
            return View();
        }
        [HttpPost]
        [System.Web.Mvc.ValidateInput(false)]
        public ActionResult NewsAdd(Maticsoft.Model.News model)
        {
            try
            {
                nbll.Add(model);
                //HuaXuCommon.AddRz(User.Identity.Name, "添加了新文章,标题:" + model.Title);
                return RedirectToAction("NewsAdd", new { IsSuccess = true });
            }
            catch
            {
                return RedirectToAction("NewsAdd", new { IsSuccess = false });
            }
        }
        /// <summary>
        /// 新闻查询页
        /// </summary>
        /// <param name="id"></param>
        /// <param name="IsSuccess"></param>
        /// <returns></returns>
        public ActionResult NewsLook(int id, bool IsSuccess = false)
        {
            ViewBag.IsSuccess = IsSuccess;
            return View(nbll.GetModel(id));
        }
        /// <summary>
        /// 新闻修改页
        /// </summary>
        /// <param name="id"></param>
        /// <param name="IsSuccess"></param>
        /// <returns></returns>
        public ActionResult NewsEdit(int id, bool IsSuccess = false)
        {
            ViewBag.IsSuccess = IsSuccess;
            return View(nbll.GetModel(id));
        }
        [HttpPost]
        [System.Web.Mvc.ValidateInput(false)]
        public ActionResult NewsEdit(Maticsoft.Model.News model)
        {
            var target = nbll.GetModel(model.ID);
            target.Title = model.Title;
            target.SortID = model.SortID;
            target.Author = model.Author;
            target.VideoURL = model.VideoURL;
            target.PicURL = model.PicURL;
            target.Content = model.Content;
            target.KeyWord = model.KeyWord;
            target.Description = model.Description;
            target.FromWhere = model.FromWhere;
            target.IsTJ = model.IsTJ;
            target.IsTop = model.IsTop;
            target.IsHot = model.IsHot;
            target.ReadCount = model.ReadCount;
            target.VideoURL = model.VideoURL;
            target.Tag = model.Tag;
            target.Info = model.Info;
            target.IsLock = model.IsLock;
            nbll.Update(target);
            return RedirectToAction("NewsEdit", new { IsSuccess = true });
        }
        /// <summary>
        /// 新闻删除
        /// </summary>
        /// <param name="ID"></param>
        /// <returns></returns>
        public ActionResult NewsDel(int ID)
        {
            nbll.Delete(ID);
            return RedirectToAction("News");
        }

        /// <summary>
        /// 新闻分类页
        /// </summary>
        /// <returns></returns>
        public ActionResult NewsSort(bool IsSuccess = false)
        {
            ViewBag.IsSuccess = IsSuccess;
            var list = sbll.GetModelList("");
            return View(list);
        }
        /// <summary>
        /// 新闻分类添加
        /// </summary>
        /// <param name="IsSuccess"></param>
        /// <returns></returns>
        public ActionResult NewsSortAdd(bool IsSuccess = false)
        {
            ViewBag.IsSuccess = IsSuccess;
            return View();
        }
        [HttpPost]
        public ActionResult NewsSortAdd(Maticsoft.Model.SortType model)
        {
            try
            {
                var result = sbll.Add(model);
                return RedirectToAction("NewsSortAdd", new ResultCode { IsSuccess = true, Msg = "留言提交成功", Code = 200 });
            }
            catch (Exception ex)
            {
                return RedirectToAction("NewsSortAdd", new ResultCode { IsSuccess = false, Msg = "留言提交出现错误:" + ex, Code = 200 });
            }
        }
        /// <summary>
        /// 新闻分类删除
        /// </summary>
        /// <param name="ID"></param>
        /// <returns></returns>
        public ActionResult NewsSortDel(int ID)
        {
            var del = sbll.Delete(ID);
            return RedirectToAction("NewsSort");
        }
        /// <summary>
        /// 新闻分类修改
        /// </summary>
        /// <param name="id"></param>
        /// <param name="IsSuccess"></param>
        /// <returns></returns>
        public ActionResult NewsSortEdit(int id, bool IsSuccess = false)
        {
            ViewBag.IsSuccess = IsSuccess;
            return View(sbll.GetModel(id));
        }
        [HttpPost]
        public ActionResult NewsSortEdit(Maticsoft.Model.SortType model)
        {
            var target = sbll.GetModel(model.ID);
            target.Name = model.Name;
            sbll.Update(target);
            return RedirectToAction("NewsSort", new { IsSuccess = true });
        }
        /// <summary>
        /// 新闻锁定
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public JsonResult NewsSd(int id)
        {
            //suoping2.AddRz(User.Identity.Name, "锁定资讯ID" + id);
            var m = nbll.GetModel(id);
            m.IsLock = m.IsLock ? false : true;
            nbll.Update(m);
            return Json(new { IsSuccess = true });
        }
        public class Pdata { 
            string name { get; set; }
        }
        
        /// <summary>
        /// 新闻分类锁定
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public JsonResult NewsSortSd(int id)
        {
            //suoping2.AddRz(User.Identity.Name, "锁定资讯ID" + id);
            var l = sbll.GetModel(id);
            l.IsLock = l.IsLock ? false : true;
            sbll.Update(l);
            return Json(new { IsSuccess = true });
        }
        #endregion


        #region 前台其他页面

        /// <summary>
        /// 关于我们
        /// </summary>
        /// <param name="IsSuccess"></param>
        /// <returns></returns>
        
        public ActionResult AboutEdit(int page = 1, int sort = 0, int day = 0, int keyword = 0, int pagesize = 10, int id = 0)
        {
            //int SiteID = int.Parse(Session["StoreID"].ToString());
            //string where = "";
            //if (SiteID != 0)
            //{
            //    where = "ShopMenberID=" + SiteID;
            //}
            var temp = nbll.GetModelList("").OrderByDescending(c => c.AddDateTime).ToList();
            //var temp = new List<Maticsoft.Model.News>();
            if (keyword !=0) {
                if (keyword == 1)  temp = temp.Where(c => c.IsLock == true).ToList(); 
                else if(keyword == 2) { temp = temp.Where(c => c.IsLock == false).ToList(); }
            }
            
            ViewBag.PageStr = string.Format("?page={0}&sort={1}&day={2}&keyword={3}&pagesize={4}", page, sort, day, keyword, pagesize);
            ViewBag.Str = string.Format("&sort={0}&day={1}&keyword={2}&pagesize={3}", sort, day, keyword, pagesize);
            ViewBag.PageCount = (int)((temp.Count - 1) / pagesize) + 1;
            ViewBag.CurrentPage = page;
            ViewBag.RowCount = temp.Count;
            return View(temp.Skip((page - 1) * pagesize).Take(pagesize).ToList());
        }
        /// <summary>
        /// 工作地点（关于我们）
        /// </summary>
        /// <param name="IsSuccess"></param>
        /// <returns></returns>
        public ActionResult WorkAdressEdit(bool IsSuccess = false)
        {
            ViewBag.IsSuccess = IsSuccess;
            return View();
        }
        [HttpPost]
        public ActionResult WorkAdressEdit(Maticsoft.Model.News model)
        {
            try
            {
                MimeMessage message = new MimeMessage();
                //发件人
                message.From.Add(new MailboxAddress(model.Author, "www_jiuwanli@163.com"));
                //收件人
                message.To.Add(new MailboxAddress(model.AddressName, model.Address));
                //标题
                message.Subject = model.Title;
                //产生一个支持HTml 的TextPart
                TextPart body = new TextPart(TextFormat.Html)
                {
                    Text = model.Content
                };
                //创建Multipart添加附件

                //正文内容，发送
                message.Body = body;
                using (SmtpClient client = new SmtpClient())
                {
                    //Smtp服务器
                    client.Connect("smtp.163.com", 25, false);
                    //登录，发送
                    //特别说明，对于服务器端的中文相应，Exception中有编码问题，显示乱码了
                    client.Authenticate("www_jiuwanli@163.com", "SSSSSSSSSSSSS");

                    client.Send(message);
                    //断开
                    client.Disconnect(true);
                    Console.WriteLine("发送邮件成功");
                }
                return RedirectToAction("WorkAdressEdit", new { IsSuccess = true });
            }
            catch {
                return RedirectToAction("WorkAdressEdit", new { IsSuccess = false });
            }

            
        }
        /// <summary>
        /// 职位分类（关于我们）
        /// </summary>
        /// <param name="IsSuccess"></param>
        /// <returns></returns>
        public ActionResult workSort(bool IsSuccess = false)
        {
            ViewBag.IsSuccess = IsSuccess;
            var where = "Title1='职位分类'";
            int id = abll.GetModelList(where).FirstOrDefault().ID;
            return View(abll.GetModel(id));
        }
        [HttpPost]
        public ActionResult workSort(Maticsoft.Model.About model)
        {
            var where = "Title1='职位分类'";
            int id = abll.GetModelList(where).FirstOrDefault().ID;
            var target = abll.GetModel(id);
            target.PicURL = model.PicURL;
            target.PicURL1 = model.PicURL1;
            target.PicURL10 = model.PicURL10;
            target.PicURL11 = model.PicURL11;
            target.PicURL12 = model.PicURL12;
            target.PicURL13 = model.PicURL13;
            target.PicURL2 = model.PicURL2;
            target.PicURL3 = model.PicURL3;
            target.PicURL4 = model.PicURL4;
            target.PicURL5 = model.PicURL5;
            target.PicURL6 = model.PicURL6;
            target.PicURL7 = model.PicURL7;
            target.PicURL8 = model.PicURL8;
            target.PicURL9 = model.PicURL9;
            abll.Update(target);
            return RedirectToAction("workSort", new { IsSuccess = true });
        }

        /// <summary>
        /// 热搜（关于我们）
        /// </summary>
        /// <param name="IsSuccess"></param>
        /// <returns></returns>
        public ActionResult HotNews(bool IsSuccess = false)
        {
            ViewBag.IsSuccess = IsSuccess;
            var where = "Title1='热搜'";
            int id = abll.GetModelList(where).FirstOrDefault().ID;
            return View(abll.GetModel(id));
        }
        [HttpPost]
        public ActionResult HotNews(Maticsoft.Model.About model)
        {
            var where = "Title1='热搜'";
            int id = abll.GetModelList(where).FirstOrDefault().ID;
            var target = abll.GetModel(id);
            target.PicURL = model.PicURL;
            target.PicURL1 = model.PicURL1;
            target.PicURL10 = model.PicURL10;
            target.PicURL11 = model.PicURL11;
            target.PicURL12 = model.PicURL12;
            target.PicURL13 = model.PicURL13;
            target.PicURL2 = model.PicURL2;
            target.PicURL3 = model.PicURL3;
            target.PicURL4 = model.PicURL4;
            target.PicURL5 = model.PicURL5;
            target.PicURL6 = model.PicURL6;
            target.PicURL7 = model.PicURL7;
            target.PicURL8 = model.PicURL8;
            target.PicURL9 = model.PicURL9;
            abll.Update(target);
            return RedirectToAction("HotNews", new { IsSuccess = true });
        }



        /// <summary>
        /// 联系我们
        /// </summary>
        /// <param name="IsSuccess"></param>
        /// <returns></returns>
        public ActionResult ContactEdit(bool IsSuccess = false)
        {
            ViewBag.IsSuccess = IsSuccess;
            var where = "Title1='联系我们'";
            int id = abll.GetModelList(where).FirstOrDefault().ID;
            return View(abll.GetModel(id));
        }
        [HttpPost]
        public ActionResult ContactEdit(Maticsoft.Model.About model)
        {
            var where = "Title1='联系我们'";
            int id = abll.GetModelList(where).FirstOrDefault().ID;
            var target = abll.GetModel(id);
            target.PicURL1 = model.PicURL1;
            target.PicURL2 = model.PicURL2;
            target.PicURL3 = model.PicURL3;
            target.PicURL4 = model.PicURL4;
            target.PicURL5 = model.PicURL5;
            target.PicURL6 = model.PicURL6;
            target.PicURL7 = model.PicURL7;
            target.PicURL8 = model.PicURL8;
            abll.Update(target);
            return RedirectToAction("ContactEdit", new { IsSuccess = true });
        }

        /// <summary>
        /// 提交案件
        /// </summary>
        /// <param name="IsSuccess"></param>
        /// <returns></returns>
        public ActionResult JiDiEdit(bool IsSuccess = false)
        {
            ViewBag.IsSuccess = IsSuccess;
            
            return View();
        }
        [HttpPost]
        public ActionResult JiDiEdit(Maticsoft.Model.Message model)
        {

            try
            {
                var result = mbll.Add(model);
                return RedirectToAction("JiDiEdit", new ResultCode { IsSuccess = true, Msg = "提交成功", Code = 200 });
            }
            catch
            {
                return RedirectToAction("JiDiEdit", new ResultCode { IsSuccess = true, Msg = "提交出现不可预知的错误", Code = 500 });
            }
        }


        #endregion


        #region 个人中心
        /// <summary>
        /// 更改密码
        /// </summary>
        /// <param name="IsSuccess"></param>
        /// <returns></returns>
        public ActionResult Self(bool IsSuccess = false)
        {
            ViewBag.IsSuccess = IsSuccess;
            return View();
        }
        //[HttpPost]
        //public ActionResult Self(Maticsoft.Model.Login model)
        //{
        //    var target = lbll.GetModel(1);
        //    if (model.avg2 == target.LPwd)
        //    {
        //        target.LPwd = model.LPwd;
        //        lbll.Update(target);
        //        return RedirectToAction("Self", new { IsSuccess = true });
        //    }
        //    else
        //    {
        //        return RedirectToAction("Self", new { IsSuccess = false });
        //    }
        //}

        #endregion
    }
}
