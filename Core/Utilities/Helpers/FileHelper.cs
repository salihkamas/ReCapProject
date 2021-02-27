using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace Core.Utilities.Helpers
{
    public class FileHelper
    {
        public static string newPath(IFormFile formFile)
        {
            FileInfo fileInfo = new FileInfo(formFile.FileName);
            string fileExtension = fileInfo.Extension;
            var newPath = Guid.NewGuid().ToString() + "-" + DateTime.Now.Month + "-" + DateTime.Now.Day + "-" + DateTime.Now.Year + fileExtension;
            string path = Environment.CurrentDirectory + @"\Images\carImages";
            string result = $@"{path}\{newPath}";
            return result;
        }
        public static string Add(IFormFile formFile)
        {
            var sourcepath = Path.GetTempFileName();
            if (formFile.Length > 0)
            {
                using (var stream = new FileStream(sourcepath, FileMode.Create))
                {
                    formFile.CopyTo(stream);
                }
            }
            var result = newPath(formFile);
            File.Move(sourcepath, result);
            return result;
        }
        public static string Update(string sourcepath, IFormFile formFile)
        {
            var result = newPath(formFile);
            if (sourcepath.Length>0)
            {
                using (var stream = new FileStream(result,FileMode.Create))
                {
                    formFile.CopyTo(stream);
                }
            }
            File.Delete(sourcepath);
            return result;
        }
        public static void Delete(string path)
        {
            File.Delete(path);
        }
    }
}
