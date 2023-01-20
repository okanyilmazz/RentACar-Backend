using Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Concrete
{
   public class News:IEntity
    {
        public int Id { get; set; }
        public string Mail { get; set; }
        public bool IsActive { get; set; }
    }
}
