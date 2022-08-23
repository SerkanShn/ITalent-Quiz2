using ITalent_Quiz2.Models;

namespace ITalent_Quiz2.Repositories
{
    public interface IBlogRepository
    {

        List<Category> GetCategories();
        void Create(Post post);

        List<Post> GetAllPost();

        Post GetById(int id);
        Post Delete(int id);


    }
}
