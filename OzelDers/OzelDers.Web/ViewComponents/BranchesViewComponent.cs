using Microsoft.AspNetCore.Mvc;
using OzelDers.Business.Abstract;

namespace OzelDers.Web.ViewComponents
{
    public class BranchesViewComponent : ViewComponent
    {
        private readonly IBranchService _branchService;

        public BranchesViewComponent(IBranchService branchService)
        {
            _branchService = branchService;
        }

        public async Task<IViewComponentResult> InvokeAsync()
        {
            if (RouteData.Values["branchurl"] != null)
            {
                ViewBag.SelectedBranch = RouteData.Values["branchurl"];
            }
            var branches = await _branchService.GetAllAsync();
            return View(branches);
        }
    }
}
