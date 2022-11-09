using Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Concretes
{
    public class Document : IEntity
    {
        public int Id { get; set; }
        public byte[] Data { get; set; }
        public string Extension { get; set; }
        public string FileName { get; set; }
    }
}
