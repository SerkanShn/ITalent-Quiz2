using AutoMapper;
using ITalent_Quiz2.Models;
using ITalent_Quiz2.Repositories;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace ITalent_Quiz2.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly IBlogRepository _blogRepository;
        private readonly IMapper _mapper;

        public HomeController(ILogger<HomeController> logger, IBlogRepository blogRepository, IMapper mapper)
        {
            _logger = logger;
            _blogRepository = blogRepository;
            _mapper = mapper;
        }

        public IActionResult Index(int page=1, int pageSize=5)
        {
            var postListViewModel = _mapper.Map<List<IndexPostViewModel>>(_blogRepository.GetAllPost().Skip((page-1)*pageSize).Take(pageSize).ToList());
            var totalCount = _blogRepository.GetAllPost().Count;
            var categories = _mapper.Map<List<CategoryViewModel>>(_blogRepository.GetCategories());


            ViewBag.page = page;
            ViewBag.pageSize = pageSize;


            return View((postListViewModel,totalCount,categories));
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}