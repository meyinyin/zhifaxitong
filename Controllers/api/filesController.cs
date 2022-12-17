using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using MailKit.Net.Smtp;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MimeKit;
using MimeKit.Text;

namespace zhongyiCore.Controllers.api
{
    
    [ApiController]
    public class filesController : ControllerBase
    {
        //private IPathProvider pathProvider;
        //public ValuesController(IPathProvider pathProvider)
        //{
        //    this.pathProvider = pathProvider;
        //}
        private IWebHostEnvironment _env;
        public filesController(IWebHostEnvironment env)
        {
            _env = env;
        }
        //[Authorize]
        [HttpPost]
        [Route("api/news/upload")]
        public ReturnStateModel<string> upload(IFormFile file)
        {
            var dir = _env.WebRootPath;
            long size = file.Length;
            if (size > 0) {
                try
                {
                    var filename = Guid.NewGuid().ToString().Replace("-", "") + file.FileName.Substring(file.FileName.LastIndexOf('.'));
                    using (var fileStrem = new FileStream(Path.Combine(dir + "\\uploadshop", filename), FileMode.Create, FileAccess.Write))
                    {
                        file.CopyTo(fileStrem);
                    }
                    return new ReturnStateModel<string> { IsSuccess = true, Msg = "上传成功！", Data = string.Join("", filename) };
                }
                catch(Exception ex)
                { return new ReturnStateModel<string> { IsSuccess = false, Msg = "上传失败",Data = ex.ToString() }; }
            }
            return new ReturnStateModel<string> { IsSuccess = false, Msg = "上传失败"};


        }
        
    }
}
