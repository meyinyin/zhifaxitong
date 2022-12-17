using Nancy.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Web;
//using System.Web.Script.Serialization;

namespace zhongyiCore
{
    public class ResultCode
    {
        public bool IsSuccess { get; set; }

        public int Code { get; set; }

        public string Msg { get; set; }
    }
    public class InputModel
    {
        [Required]
        [DataType(DataType.Password)]
        [Display(Name = "Current password")]
        public string OldPassword { get; set; }

        [Required]
        [StringLength(100, ErrorMessage = "The {0} must be at least {2} and at max {1} characters long.", MinimumLength = 6)]
        [DataType(DataType.Password)]
        [Display(Name = "New password")]
        public string NewPassword { get; set; }

        [DataType(DataType.Password)]
        [Display(Name = "Confirm new password")]
        [Compare("NewPassword", ErrorMessage = "The new password and confirmation password do not match.")]
        public string ConfirmPassword { get; set; }
    }
    public class ResultToJson
    {
        public static HttpResponseMessage toJson(Object obj)
        {
            String str;
            if (obj is String || obj is Char)
            {
                str = obj.ToString();
            }
            else
            {
                JavaScriptSerializer serializer = new JavaScriptSerializer();
                str = serializer.Serialize(obj);
            }
            HttpResponseMessage result = new HttpResponseMessage { Content = new StringContent(str, Encoding.GetEncoding("UTF-8"), "application/json") };
            return result;
        }
    }
    /// <summary>
    /// 公共类
    /// </summary>
    public static class suoping2
    {
        //public static void AddRz(string username, string info)
        //{
        //    Maticsoft.BLL.AdminUser rzbll = new Maticsoft.BLL.AdminUser();
        //    rzbll.Add(new Maticsoft.Model.AdminUser
        //    {
        //        AdminUserName = username,
        //        AdminLoginName = info,
        //        PWD = DateTime.Now.ToLongDateString()
        //    });
        //}
    }
    public class ReturnStateModel<T>
    {
        public bool IsSuccess { get; set; }
        public string Msg { get; set; }

        public T Data { get; set; }
    }

    #region 数组去重
    public class CommonEqualityComparer<T, V> : IEqualityComparer<T>
    {
        private Func<T, V> keySelector;
        private IEqualityComparer<V> comparer;

        public CommonEqualityComparer(Func<T, V> keySelector, IEqualityComparer<V> comparer)
        {
            this.keySelector = keySelector;
            this.comparer = comparer;
        }

        public CommonEqualityComparer(Func<T, V> keySelector)
            : this(keySelector, EqualityComparer<V>.Default)
        { }

        public bool Equals(T x, T y)
        {
            return comparer.Equals(keySelector(x), keySelector(y));
        }

        public int GetHashCode(T obj)
        {
            return comparer.GetHashCode(keySelector(obj));
        }
    }
    public static class DistinctExtensions
    {
        public static IEnumerable<T> Distinct<T, V>(this IEnumerable<T> source, Func<T, V> keySelector)
        {
            return source.Distinct(new CommonEqualityComparer<T, V>(keySelector));
        }

        public static IEnumerable<T> Distinct<T, V>(this IEnumerable<T> source, Func<T, V> keySelector, IEqualityComparer<V> comparer)
        {
            return source.Distinct(new CommonEqualityComparer<T, V>(keySelector, comparer));
        }
    }
    #endregion

    public interface IPathProvider
    {
        string MapPath(string path);
    }

    public class PathProvider : IPathProvider
    {
        private Microsoft.AspNetCore.Hosting.IWebHostEnvironment _hostingEnvironment;

        public PathProvider(Microsoft.AspNetCore.Hosting.IWebHostEnvironment environment)
        {
            _hostingEnvironment = environment;
        }

        public string MapPath(string path)
        {
            var filePath = System.IO.Path.Combine(_hostingEnvironment.WebRootPath, path);
            return filePath;
        }
    }
}