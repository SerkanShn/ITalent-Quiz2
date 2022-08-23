using AutoMapper;
using ITalent_Quiz2.Models;
using ITalent_Quiz2.Repositories;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.Extensions.FileProviders;

namespace ITalent_Quiz2.Controllers
{
    public class BlogController : Controller
    {
        private readonly IBlogRepository _blogRepository;

        private readonly IMapper _mapper;

        private readonly IFileProvider _fileProvider;

        public BlogController(IBlogRepository blogRepository, IMapper mapper,IFileProvider fileProvider)
        {
            _blogRepository = blogRepository;
            _mapper = mapper;
            _fileProvider = fileProvider;
        }

        [HttpGet]
        public IActionResult Create()

        {

            var categoryList = _blogRepository.GetCategories();

            ViewBag.selectList = new SelectList(categoryList, "Id", "Title");

            return View();
        }


        [HttpPost]
        public async Task<IActionResult> Create(PostCreateViewModel request,IFormFile photo)

        {
            //if (!ModelState.IsValid)
            //{
            //    var categoryList = _blogRepository.GetCategories();

            //    ViewBag.selectList = new SelectList(categoryList, "Id", "Name");

            //    return View(request);
            //}

            if (photo != null && photo.Length > 0)
            {


                var root = _fileProvider.GetDirectoryContents("wwwroot");
                var picturesDirectory = root.Single(x => x.Name == "pictures");

                // var path2== "D:\\ITalentBootcamp\\WebApp\\wwwroot\\pictures" + "ahmet.jpg";

                var path = Path.Combine(picturesDirectory.PhysicalPath, photo.FileName);


                using var stream = new FileStream(path, FileMode.Create);
                await photo.CopyToAsync(stream);

                request.PostBanner = photo.FileName;
            }

            var newProduct = _mapper.Map<Post>(request);

            _blogRepository.Create(newProduct);
            return RedirectToAction(nameof(HomeController.Index), "Home");



        }

        [HttpGet]
        public IActionResult Post(int id)
        {
            var a = nameof(HomeController.Index);
            var post = _blogRepository.GetById(id);

            ViewBag.post = _mapper.Map<PostViewModel>(post);

            return View();
        }

        public IActionResult Delete(int id)
        {
            var post = _blogRepository.Delete(id);
            var root = _fileProvider.GetDirectoryContents("wwwroot");
            var picturesDirectory = root.Single(x => x.Name == "pictures");
            var path = Path.Combine(picturesDirectory.PhysicalPath, post.PostBanner);
            System.IO.File.Delete(path);

            return RedirectToAction(nameof(HomeController.Index), "Home");
        }


        //public IActionResult Update(int id)

        //{
        //    //Id'ye data varmı yokmu
        //    //var categoryList = _productRepository.GetCategories();

        //    //ViewBag.selectList = new SelectList(categoryList, "Id", "Name");

        //    //var productUpdateViewModel = _mapper.Map<ProductUpdateViewModel>(_productRepository.GetById(id));

        //    //return View(productUpdateViewModel);
        //}








































































    }
}
