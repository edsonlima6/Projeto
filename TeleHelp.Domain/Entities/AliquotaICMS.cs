using System;
using System.Collections.Generic;

namespace TeleHelp.Domain.Entities
{
     public partial class AliquotaICMS
    {
        public int IdAliquotaICMS { get; set; }

        public int IdEstado { get; set; }

        public decimal Percentual { get; set; }

        //public virtual Estado Estado { get; set; }
    }
}
