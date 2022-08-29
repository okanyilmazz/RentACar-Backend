using Core.Utilities.Results;
using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Utilities.Helpers
{
    public interface IFileHelper
    {
        IResult Add(IFormFile file,string destinationFolderPath);
        IResult Update(IFormFile file, string oldFilePath);
        IResult Delete(string deletedFilePath);
    }
}
