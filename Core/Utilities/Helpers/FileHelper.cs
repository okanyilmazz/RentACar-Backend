using Core.Utilities.Business;
using Core.Utilities.Results;
using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Utilities.Helpers
{
    public class FileHelper : IFileHelper
    {
        //Path.GetExtension --Dosya uzantısını alır

        public IResult Add(IFormFile file, string destinationFolderPath)
        {

            string newFileName = Guid.NewGuid().ToString() + Path.GetExtension(file.FileName);

            IResult result = BusinessRules.Run(IsExistDestinationFolder(destinationFolderPath));
            if (result != null)
            {
                return result;
            }
            return CreateFile(file, destinationFolderPath + newFileName);
        }

        public IResult Delete(string deletedFilePath)
        {
            IResult result = BusinessRules.Run(CheckFileExist(deletedFilePath));
            if (result != null)
            {
                return result;
            }

            File.Delete(deletedFilePath);
            return new SuccessResult();
        }

        public IResult Update(IFormFile file, string oldFilePath)
        {
            IResult result = BusinessRules.Run(CheckFileExist(oldFilePath));
            if (result != null)
            {
                return result;
            }

            Delete(oldFilePath);
            CreateFile(file, oldFilePath);

            return new SuccessResult(oldFilePath);

            // File.Delete(oldFilePath);
        }

        public IResult IsExistDestinationFolder(string destinationFolderPath)
        {
            if (!Directory.Exists(destinationFolderPath))
            {
                CreateDestinationFolder(destinationFolderPath);
            }
            return new SuccessResult();
        }

        public void CreateDestinationFolder(string destinationFolderPath)
        {
            Directory.CreateDirectory(destinationFolderPath);
        }

        public IResult CheckFileExist(string filePath)
        {
            if (File.Exists(filePath))
            {
                return new SuccessResult();
            }
            return new ErrorResult();
        }

        public IResult CreateFile(IFormFile file, string destinationFolderPath)
        {
            using (FileStream fileStream = File.Create(destinationFolderPath))
            {

                file.CopyTo(fileStream);
                fileStream.Flush();
            }
            return new SuccessResult(destinationFolderPath);
        }
    }
}
