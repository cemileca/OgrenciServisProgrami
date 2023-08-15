using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OgrenciServis.Domain.Entities
{
    public class Kinship : BaseEntity // akrabalık adı, hala teyze anne, baba?
    {
        public string KinshipName { get; set; }
        public string KinshipDescription { get; set; }
    }
}
