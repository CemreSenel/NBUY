using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using OzelDers.Business.Abstract;
using OzelDers.Core;
using OzelDers.Entity.Concrete;
using OzelDers.Web.Areas.Admin.Models.Dtos;

namespace OzelDers.Web.Areas.Admin.Controllers
{
    [Authorize(Roles = "Admin")]
    [Area("Admin")]
    public class BranchController : Controller
    {
        private readonly IBranchService _branchService;

        public BranchController(IBranchService branchService)
        {
            _branchService = branchService;
        }

        public async Task<IActionResult> Index()
        {
            var branches = await _branchService.GetAllAsync();
            var branchListDto = new BranchListDto
            {
                Branches = branches
            };
            return View(branchListDto);
        }

        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }


        [HttpPost]
        public async Task<IActionResult> Create(BranchAddDto branchAddDto)
        {
            if (ModelState.IsValid)
            {
                var branch = new Branch
                {
                    Name = branchAddDto.Name,
                    Url = Jobs.InitUrl(branchAddDto.Name)
                };
                await _branchService.CreateAsync(branch);
                return RedirectToAction("Index");
            }
            return View();

        }
        [HttpGet]
        public async Task<IActionResult> Edit(int id)
        {
            var branch = await _branchService.GetByIdAsync(id);
            if (branch == null) { return NotFound(); }
            var branchUpdateDto = new BranchUpdateDto
            {
                Id = branch.Id,
                Name = branch.Name,
                Url = branch.Url
            };
            return View(branchUpdateDto);
        }

        [HttpPost]
        public async Task<IActionResult> Edit(BranchUpdateDto branchUpdateDto)
        {
            if (ModelState.IsValid)
            {
                var branch = await _branchService.GetByIdAsync(branchUpdateDto.Id);
                if (branch == null) { return NotFound(); }
                branch.Name = branchUpdateDto.Name;
                branch.Url = Jobs.InitUrl(branchUpdateDto.Url);
                _branchService.Update(branch);
                return RedirectToAction("Index");
            }
            return View(branchUpdateDto);
        }

        [HttpGet]
        public async Task<IActionResult> Delete(int id)
        {
            var branch = await _branchService.GetByIdAsync(id);
            if (branch == null)
            {
                return NotFound();
            }
            _branchService.Delete(branch);
            return RedirectToAction("Index");

        }
    }

}

