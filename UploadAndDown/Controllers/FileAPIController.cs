using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using WalkingTec.Mvvm.Core;
using WalkingTec.Mvvm.Mvc;

namespace UploadAndDown.Controllers
{
    [ActionDescription("文件API")]
    [Public]
    public class FileAPIController : BaseApiController
    {

        [HttpPost]
        [ActionDescription("UploadFileRoute")]
        public IActionResult Upload(SaveFileModeEnum? sm = null, string groupName = null, bool IsTemprory = true, string _DONOT_USE_CS = "default")
        {
            CurrentCS = _DONOT_USE_CS ?? "default";
            var FileData = Request.Form.Files[0];
            sm = sm == null ? ConfigInfo.FileUploadOptions.SaveFileMode : sm;
            var vm = CreateVM<FileAttachmentVM>();
            vm.Entity.FileName = FileData.FileName;
            vm.Entity.Length = FileData.Length;
            vm.Entity.UploadTime = DateTime.Now;
            vm.Entity.SaveFileMode = sm;
            vm = FileHelper.GetFileByteForUpload(vm, FileData.OpenReadStream(), ConfigInfo, FileData.FileName, sm, groupName);
            vm.Entity.IsTemprory = IsTemprory;
            if ((!string.IsNullOrEmpty(vm.Entity.Path) && (vm.Entity.SaveFileMode == SaveFileModeEnum.Local || vm.Entity.SaveFileMode == SaveFileModeEnum.DFS)) || (vm.Entity.FileData != null && vm.Entity.SaveFileMode == SaveFileModeEnum.Database))
            {
                vm.DoAdd();
                return Ok(new { Id = vm.Entity.ID.ToString(), Name = vm.Entity.FileName });
            }
            return Ok(new { Id = string.Empty, Name = string.Empty });
        }

        [ActionDescription("获取文件")]
        public IActionResult GetFile(Guid id, bool stream = false, string _DONOT_USE_CS = "default")
        {
            CurrentCS = _DONOT_USE_CS ?? "default";
            if (id == Guid.Empty)
            {
                return new StatusCodeResult(StatusCodes.Status404NotFound);
            }
            var vm = CreateVM<FileAttachmentVM>(id);
            var data = FileHelper.GetFileByteForDownLoadByVM(vm, ConfigInfo);
            if (data == null)
            {
                data = new byte[0];
            }
            var ext = vm.Entity.FileExt.ToLower();
            var contenttype = "application/octet-stream";
            if (ext == "pdf")
            {
                contenttype = "application/pdf";
            }
            if (ext == "png" || ext == "bmp" || ext == "gif" || ext == "tif" || ext == "jpg" || ext == "jpeg")
            {
                contenttype = $"image/{ext}";
            }
            if (stream == false)
            {
                return File(data, contenttype, vm.Entity.FileName ?? (Guid.NewGuid().ToString() + ext));
            }
            else
            {
                Response.Body.Write(data, 0, data.Count());
                return new EmptyResult();
            }
        }
    }
}