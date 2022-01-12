namespace MakeUpBakery.Web.Areas.Administration.Controllers
{
    using MakeUpBakery.Common;
    using MakeUpBakery.Web.Controllers;

    using Microsoft.AspNetCore.Authorization;
    using Microsoft.AspNetCore.Mvc;

    [Authorize(Roles = GlobalConstants.AdministratorRoleName)]
    [Area("Administration")]
    public class AdministrationController : BaseController
    {
    }
}
