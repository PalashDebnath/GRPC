using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using BlogPackage;
using Grpc.Core;
using MongoDB.Bson;
using MongoDB.Driver;
using static BlogPackage.BlogService;

namespace GRPCServer
{
    public class BlogServiceConstruct : BlogServiceBase
    {
        private static MongoClient _mongoClient = new MongoClient("mongodb://localhost:27017");
        private static IMongoDatabase _mongoDatabase = _mongoClient.GetDatabase("local");
        private static IMongoCollection<BsonDocument> _mongoCollection = _mongoDatabase.GetCollection<BsonDocument>("blogs");

        public override Task<BlogResponse> CreateBlogUnary(BlogPackage.BlogRequest request, Grpc.Core.ServerCallContext context)
        {
            Console.WriteLine("Server received a normal blog request. Server will response normally!!!");
            Blog blog = request.Blog;

            BsonDocument doc = new BsonDocument();
            doc.Add("author_id", blog.AuthorId);
            doc.Add("title", blog.Title);
            doc.Add("content", blog.Content);

            _mongoCollection.InsertOne(doc);
            blog.Id = doc.GetValue("_id").ToString();

            return Task.FromResult(new BlogResponse(){ Blog = blog });
        }

        public override Task<BlogResponse> ReadBlogUnary(BlogRequest request, Grpc.Core.ServerCallContext context)
        {
            Console.WriteLine("Server received a normal blog request. Server will response normally!!!");
            var filter = new FilterDefinitionBuilder<BsonDocument>().Eq("_id", new ObjectId(request.Blog.Id));
            var result = _mongoCollection.Find(filter).FirstOrDefault();
            if(result == null)
                throw new RpcException(new Status(StatusCode.NotFound, String.Format("Blog Id {0} not found", request.Blog.Id)));
            Blog blog = new Blog()
            {
                Id = request.Blog.Id,
                AuthorId = result.GetValue("author_id").AsString,
                Title = result.GetValue("title").AsString,
                Content = result.GetValue("content").AsString
            };

            return Task.FromResult(new BlogResponse(){ Blog = blog });
        }

        public override Task<BlogResponse> UpdateBlogUnary(BlogRequest request, Grpc.Core.ServerCallContext context)
        {
            Console.WriteLine("Server received a normal blog request. Server will response normally!!!");
            var filter = new FilterDefinitionBuilder<BsonDocument>().Eq("_id", new ObjectId(request.Blog.Id));
            var result = _mongoCollection.Find(filter).FirstOrDefault();
            if(result == null)
                throw new RpcException(new Status(StatusCode.NotFound, String.Format("Blog Id {0} not found", request.Blog.Id)));
            
            Blog blog = request.Blog;
            BsonDocument doc = new BsonDocument();
            doc.Add("author_id", blog.AuthorId);
            doc.Add("title", blog.Title);
            doc.Add("content", blog.Content);

            _mongoCollection.ReplaceOne(filter, doc);

            return Task.FromResult(new BlogResponse(){ Blog = blog });
        }

        public override Task<BlogResponse> DeleteBlogUnary(BlogRequest request, Grpc.Core.ServerCallContext context)
        {
            Console.WriteLine("Server received a normal blog request. Server will response normally!!!");
            var filter = new FilterDefinitionBuilder<BsonDocument>().Eq("_id", new ObjectId(request.Blog.Id));
            var result = _mongoCollection.DeleteOne(filter);
            if(result.DeletedCount == 0)
                throw new RpcException(new Status(StatusCode.NotFound, String.Format("Blog Id {0} not found", request.Blog.Id)));
            

            Blog blog = new Blog()
            {
                Id = request.Blog.Id
            };

            return Task.FromResult(new BlogResponse(){ Blog = blog });
        }
    }
}