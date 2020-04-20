using System;
using BlogPackage;
using Grpc.Core;
using static BlogPackage.BlogService;

namespace GRPCClient
{
    public class BlogConsumer
    {
        private Channel _channel;
        private Blog _blog;
        private BlogRequest _blogRequest;
        private BlogServiceClient _blogServiceClient;

        public BlogConsumer(Channel channel)
        {
            _channel = channel;
            _blog = new Blog();
            _blogRequest = new BlogRequest() { Blog = _blog};
            _blogServiceClient = new BlogServiceClient(_channel);
        }

        public void CallUnaryCreateBlogService(Action<string> action)
        {
            try
            {
                _blog.AuthorId = "Palash";
                _blog.Title = "New Blog!";
                _blog.Content = "Hello world, this is a new blog.";
                var blogResponse = _blogServiceClient.CreateBlogUnary(_blogRequest);
                _blog.Id = blogResponse.Blog.Id;
                action(blogResponse.Blog.ToString());
            }
            catch (RpcException e)
            {
                action(String.Format("Error status: {0} message: {1}", e.StatusCode, e.Status.Detail));
            }
        }

        public void CallUnaryReadBlogService(Action<string> action)
        {
            try
            {
                var blogResponse = _blogServiceClient.ReadBlogUnary(_blogRequest);
                action(blogResponse.Blog.ToString());
            }
            catch (RpcException e)
            {
                action(String.Format("Error status: {0} message: {1}", e.StatusCode, e.Status.Detail));
            }
        }

        public void CallUnaryUpdateBlogService(Action<string> action)
        {
            try
            {
                _blog.AuthorId = "Palash";
                _blog.Title = "Updated Blog!";
                _blog.Content = "Updated the blog.";
                var blogResponse = _blogServiceClient.UpdateBlogUnary(_blogRequest);
                action(blogResponse.Blog.ToString());
            }
            catch (RpcException e)
            {
                action(String.Format("Error status: {0} message: {1}", e.StatusCode, e.Status.Detail));
            }
        }

        public void CallUnaryDeleteBlogService(Action<string> action)
        {
            try
            {
                var blogResponse = _blogServiceClient.DeleteBlogUnary(_blogRequest);
                action(blogResponse.Blog.ToString());
            }
            catch (RpcException e)
            {
                action(String.Format("Error status: {0} message: {1}", e.StatusCode, e.Status.Detail));
            }
        }
    }
}