using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abstracts
{
    public interface IDocumentService
    {
        void UploadDocument(string filePath);
    }
}
