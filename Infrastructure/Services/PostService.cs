using Domain.Models;

namespace Infrastructure.Services;

public class PostService
{
    private List<Post> _posts;
    public PostService()
    {
        _posts = new List<Post>();
    }

    public void AddPost(Post post)
    {
         post.Id = _posts.Count + 1;
         _posts.Add(post);
    }

    public List<Post> GetPosts()
    {
        return _posts;
    }

    public Post GetPostById(int id)
    {
        foreach (var post in _posts)
        {
            if (post.Id == id) return post;
        }
        return null;
    }

    public Post Update(Post post)
    {
        foreach (var s in _posts)
        {
            if (s.Id == post.Id)
            {
                s.Title = post.Title;
                s.Description = post.Description;
                s.VoteAmount = post.VoteAmount;
                s.CreatedAt = post.CreatedAt;
                return s;
            }
        }
        return post;
    }

    public void DeletePost(int id)
    {
        Post pos = new Post();
        foreach (var post in _posts)
        {
            if (post.Id == id) pos = post;
        }
        _posts.Remove(pos);
    }

    public void Show()
    {
        Console.WriteLine("Id|        Title|         Description|         VoteAmount|           CreatedAt");
        foreach (var post in _posts)
        {
            Console.WriteLine($"{post.Id}|        {post.Title}|         {post.Description}|         {post.VoteAmount}           {post.CreatedAt}");

        }
    }

    public int CountPost()
    {
        return _posts.Count;
    }
}
