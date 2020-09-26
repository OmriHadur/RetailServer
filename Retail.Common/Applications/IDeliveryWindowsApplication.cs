using Microsoft.AspNetCore.Mvc;
using Retail.Standard.Shared.Resources.Order;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Retail.Common.Applications
{
    public interface IDeliveryWindowsApplication : IRestApplication<DeliveryWindowCreateResource, DeliveryWindowResource>
    {
        Task<ActionResult<Dictionary<string, DeliveryWindowResource>>> GetSorted();
    }
}