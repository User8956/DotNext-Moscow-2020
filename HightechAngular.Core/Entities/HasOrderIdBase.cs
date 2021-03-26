using HightechAngular.Core.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HightechAngular.Web.Areas.Shared
{
    public class HasOrderIdBase : ChangeOrderStateBase
    {
        public int OrderId { get; set; }
    }
}
