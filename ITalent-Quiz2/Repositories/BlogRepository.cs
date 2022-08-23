using ITalent_Quiz2.Models;
using Microsoft.EntityFrameworkCore;

namespace ITalent_Quiz2.Repositories
{
    public class BlogRepository : IBlogRepository
    {
        private readonly AppDbContext _context;

        public BlogRepository(AppDbContext context)
        {
            _context = context;
        }


        public void Create(Post post)
        {
            _context.Posts.Add(post);
            _context.SaveChanges();
        }

        public Post Delete(int id)
        {
            var post = _context.Posts.Find(id);

            _context.Posts.Remove(post);
            _context.SaveChanges();
            return post;
        }

        public List<Post> GetAllPost()
        {
            return _context.Posts.Include(x => x.Category).ToList();

        }

        public Post GetById(int id)
        {
            return _context.Posts.Include(x=> x.Category).First(x=>x.Id == id);
        }

        public List<Category> GetCategories()
        {
            return _context.Categories.ToList();
        }

   
    }
}
