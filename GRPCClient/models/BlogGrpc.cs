// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: blog.proto
// </auto-generated>
#pragma warning disable 0414, 1591
#region Designer generated code

using grpc = global::Grpc.Core;

namespace BlogPackage {
  public static partial class BlogService
  {
    static readonly string __ServiceName = "blogPackage.BlogService";

    static readonly grpc::Marshaller<global::BlogPackage.BlogRequest> __Marshaller_blogPackage_BlogRequest = grpc::Marshallers.Create((arg) => global::Google.Protobuf.MessageExtensions.ToByteArray(arg), global::BlogPackage.BlogRequest.Parser.ParseFrom);
    static readonly grpc::Marshaller<global::BlogPackage.BlogResponse> __Marshaller_blogPackage_BlogResponse = grpc::Marshallers.Create((arg) => global::Google.Protobuf.MessageExtensions.ToByteArray(arg), global::BlogPackage.BlogResponse.Parser.ParseFrom);

    static readonly grpc::Method<global::BlogPackage.BlogRequest, global::BlogPackage.BlogResponse> __Method_CreateBlogUnary = new grpc::Method<global::BlogPackage.BlogRequest, global::BlogPackage.BlogResponse>(
        grpc::MethodType.Unary,
        __ServiceName,
        "CreateBlogUnary",
        __Marshaller_blogPackage_BlogRequest,
        __Marshaller_blogPackage_BlogResponse);

    static readonly grpc::Method<global::BlogPackage.BlogRequest, global::BlogPackage.BlogResponse> __Method_ReadBlogUnary = new grpc::Method<global::BlogPackage.BlogRequest, global::BlogPackage.BlogResponse>(
        grpc::MethodType.Unary,
        __ServiceName,
        "ReadBlogUnary",
        __Marshaller_blogPackage_BlogRequest,
        __Marshaller_blogPackage_BlogResponse);

    static readonly grpc::Method<global::BlogPackage.BlogRequest, global::BlogPackage.BlogResponse> __Method_UpdateBlogUnary = new grpc::Method<global::BlogPackage.BlogRequest, global::BlogPackage.BlogResponse>(
        grpc::MethodType.Unary,
        __ServiceName,
        "UpdateBlogUnary",
        __Marshaller_blogPackage_BlogRequest,
        __Marshaller_blogPackage_BlogResponse);

    static readonly grpc::Method<global::BlogPackage.BlogRequest, global::BlogPackage.BlogResponse> __Method_DeleteBlogUnary = new grpc::Method<global::BlogPackage.BlogRequest, global::BlogPackage.BlogResponse>(
        grpc::MethodType.Unary,
        __ServiceName,
        "DeleteBlogUnary",
        __Marshaller_blogPackage_BlogRequest,
        __Marshaller_blogPackage_BlogResponse);

    /// <summary>Service descriptor</summary>
    public static global::Google.Protobuf.Reflection.ServiceDescriptor Descriptor
    {
      get { return global::BlogPackage.BlogReflection.Descriptor.Services[0]; }
    }

    /// <summary>Base class for server-side implementations of BlogService</summary>
    [grpc::BindServiceMethod(typeof(BlogService), "BindService")]
    public abstract partial class BlogServiceBase
    {
      /// <summary>
      ///Unary Service
      /// </summary>
      /// <param name="request">The request received from the client.</param>
      /// <param name="context">The context of the server-side call handler being invoked.</param>
      /// <returns>The response to send back to the client (wrapped by a task).</returns>
      public virtual global::System.Threading.Tasks.Task<global::BlogPackage.BlogResponse> CreateBlogUnary(global::BlogPackage.BlogRequest request, grpc::ServerCallContext context)
      {
        throw new grpc::RpcException(new grpc::Status(grpc::StatusCode.Unimplemented, ""));
      }

      /// <summary>
      ///Unary Service
      /// </summary>
      /// <param name="request">The request received from the client.</param>
      /// <param name="context">The context of the server-side call handler being invoked.</param>
      /// <returns>The response to send back to the client (wrapped by a task).</returns>
      public virtual global::System.Threading.Tasks.Task<global::BlogPackage.BlogResponse> ReadBlogUnary(global::BlogPackage.BlogRequest request, grpc::ServerCallContext context)
      {
        throw new grpc::RpcException(new grpc::Status(grpc::StatusCode.Unimplemented, ""));
      }

      /// <summary>
      ///Unary Service
      /// </summary>
      /// <param name="request">The request received from the client.</param>
      /// <param name="context">The context of the server-side call handler being invoked.</param>
      /// <returns>The response to send back to the client (wrapped by a task).</returns>
      public virtual global::System.Threading.Tasks.Task<global::BlogPackage.BlogResponse> UpdateBlogUnary(global::BlogPackage.BlogRequest request, grpc::ServerCallContext context)
      {
        throw new grpc::RpcException(new grpc::Status(grpc::StatusCode.Unimplemented, ""));
      }

      /// <summary>
      ///Unary Service
      /// </summary>
      /// <param name="request">The request received from the client.</param>
      /// <param name="context">The context of the server-side call handler being invoked.</param>
      /// <returns>The response to send back to the client (wrapped by a task).</returns>
      public virtual global::System.Threading.Tasks.Task<global::BlogPackage.BlogResponse> DeleteBlogUnary(global::BlogPackage.BlogRequest request, grpc::ServerCallContext context)
      {
        throw new grpc::RpcException(new grpc::Status(grpc::StatusCode.Unimplemented, ""));
      }

    }

    /// <summary>Client for BlogService</summary>
    public partial class BlogServiceClient : grpc::ClientBase<BlogServiceClient>
    {
      /// <summary>Creates a new client for BlogService</summary>
      /// <param name="channel">The channel to use to make remote calls.</param>
      public BlogServiceClient(grpc::ChannelBase channel) : base(channel)
      {
      }
      /// <summary>Creates a new client for BlogService that uses a custom <c>CallInvoker</c>.</summary>
      /// <param name="callInvoker">The callInvoker to use to make remote calls.</param>
      public BlogServiceClient(grpc::CallInvoker callInvoker) : base(callInvoker)
      {
      }
      /// <summary>Protected parameterless constructor to allow creation of test doubles.</summary>
      protected BlogServiceClient() : base()
      {
      }
      /// <summary>Protected constructor to allow creation of configured clients.</summary>
      /// <param name="configuration">The client configuration.</param>
      protected BlogServiceClient(ClientBaseConfiguration configuration) : base(configuration)
      {
      }

      /// <summary>
      ///Unary Service
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="headers">The initial metadata to send with the call. This parameter is optional.</param>
      /// <param name="deadline">An optional deadline for the call. The call will be cancelled if deadline is hit.</param>
      /// <param name="cancellationToken">An optional token for canceling the call.</param>
      /// <returns>The response received from the server.</returns>
      public virtual global::BlogPackage.BlogResponse CreateBlogUnary(global::BlogPackage.BlogRequest request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return CreateBlogUnary(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      /// <summary>
      ///Unary Service
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="options">The options for the call.</param>
      /// <returns>The response received from the server.</returns>
      public virtual global::BlogPackage.BlogResponse CreateBlogUnary(global::BlogPackage.BlogRequest request, grpc::CallOptions options)
      {
        return CallInvoker.BlockingUnaryCall(__Method_CreateBlogUnary, null, options, request);
      }
      /// <summary>
      ///Unary Service
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="headers">The initial metadata to send with the call. This parameter is optional.</param>
      /// <param name="deadline">An optional deadline for the call. The call will be cancelled if deadline is hit.</param>
      /// <param name="cancellationToken">An optional token for canceling the call.</param>
      /// <returns>The call object.</returns>
      public virtual grpc::AsyncUnaryCall<global::BlogPackage.BlogResponse> CreateBlogUnaryAsync(global::BlogPackage.BlogRequest request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return CreateBlogUnaryAsync(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      /// <summary>
      ///Unary Service
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="options">The options for the call.</param>
      /// <returns>The call object.</returns>
      public virtual grpc::AsyncUnaryCall<global::BlogPackage.BlogResponse> CreateBlogUnaryAsync(global::BlogPackage.BlogRequest request, grpc::CallOptions options)
      {
        return CallInvoker.AsyncUnaryCall(__Method_CreateBlogUnary, null, options, request);
      }
      /// <summary>
      ///Unary Service
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="headers">The initial metadata to send with the call. This parameter is optional.</param>
      /// <param name="deadline">An optional deadline for the call. The call will be cancelled if deadline is hit.</param>
      /// <param name="cancellationToken">An optional token for canceling the call.</param>
      /// <returns>The response received from the server.</returns>
      public virtual global::BlogPackage.BlogResponse ReadBlogUnary(global::BlogPackage.BlogRequest request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return ReadBlogUnary(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      /// <summary>
      ///Unary Service
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="options">The options for the call.</param>
      /// <returns>The response received from the server.</returns>
      public virtual global::BlogPackage.BlogResponse ReadBlogUnary(global::BlogPackage.BlogRequest request, grpc::CallOptions options)
      {
        return CallInvoker.BlockingUnaryCall(__Method_ReadBlogUnary, null, options, request);
      }
      /// <summary>
      ///Unary Service
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="headers">The initial metadata to send with the call. This parameter is optional.</param>
      /// <param name="deadline">An optional deadline for the call. The call will be cancelled if deadline is hit.</param>
      /// <param name="cancellationToken">An optional token for canceling the call.</param>
      /// <returns>The call object.</returns>
      public virtual grpc::AsyncUnaryCall<global::BlogPackage.BlogResponse> ReadBlogUnaryAsync(global::BlogPackage.BlogRequest request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return ReadBlogUnaryAsync(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      /// <summary>
      ///Unary Service
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="options">The options for the call.</param>
      /// <returns>The call object.</returns>
      public virtual grpc::AsyncUnaryCall<global::BlogPackage.BlogResponse> ReadBlogUnaryAsync(global::BlogPackage.BlogRequest request, grpc::CallOptions options)
      {
        return CallInvoker.AsyncUnaryCall(__Method_ReadBlogUnary, null, options, request);
      }
      /// <summary>
      ///Unary Service
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="headers">The initial metadata to send with the call. This parameter is optional.</param>
      /// <param name="deadline">An optional deadline for the call. The call will be cancelled if deadline is hit.</param>
      /// <param name="cancellationToken">An optional token for canceling the call.</param>
      /// <returns>The response received from the server.</returns>
      public virtual global::BlogPackage.BlogResponse UpdateBlogUnary(global::BlogPackage.BlogRequest request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return UpdateBlogUnary(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      /// <summary>
      ///Unary Service
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="options">The options for the call.</param>
      /// <returns>The response received from the server.</returns>
      public virtual global::BlogPackage.BlogResponse UpdateBlogUnary(global::BlogPackage.BlogRequest request, grpc::CallOptions options)
      {
        return CallInvoker.BlockingUnaryCall(__Method_UpdateBlogUnary, null, options, request);
      }
      /// <summary>
      ///Unary Service
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="headers">The initial metadata to send with the call. This parameter is optional.</param>
      /// <param name="deadline">An optional deadline for the call. The call will be cancelled if deadline is hit.</param>
      /// <param name="cancellationToken">An optional token for canceling the call.</param>
      /// <returns>The call object.</returns>
      public virtual grpc::AsyncUnaryCall<global::BlogPackage.BlogResponse> UpdateBlogUnaryAsync(global::BlogPackage.BlogRequest request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return UpdateBlogUnaryAsync(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      /// <summary>
      ///Unary Service
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="options">The options for the call.</param>
      /// <returns>The call object.</returns>
      public virtual grpc::AsyncUnaryCall<global::BlogPackage.BlogResponse> UpdateBlogUnaryAsync(global::BlogPackage.BlogRequest request, grpc::CallOptions options)
      {
        return CallInvoker.AsyncUnaryCall(__Method_UpdateBlogUnary, null, options, request);
      }
      /// <summary>
      ///Unary Service
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="headers">The initial metadata to send with the call. This parameter is optional.</param>
      /// <param name="deadline">An optional deadline for the call. The call will be cancelled if deadline is hit.</param>
      /// <param name="cancellationToken">An optional token for canceling the call.</param>
      /// <returns>The response received from the server.</returns>
      public virtual global::BlogPackage.BlogResponse DeleteBlogUnary(global::BlogPackage.BlogRequest request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return DeleteBlogUnary(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      /// <summary>
      ///Unary Service
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="options">The options for the call.</param>
      /// <returns>The response received from the server.</returns>
      public virtual global::BlogPackage.BlogResponse DeleteBlogUnary(global::BlogPackage.BlogRequest request, grpc::CallOptions options)
      {
        return CallInvoker.BlockingUnaryCall(__Method_DeleteBlogUnary, null, options, request);
      }
      /// <summary>
      ///Unary Service
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="headers">The initial metadata to send with the call. This parameter is optional.</param>
      /// <param name="deadline">An optional deadline for the call. The call will be cancelled if deadline is hit.</param>
      /// <param name="cancellationToken">An optional token for canceling the call.</param>
      /// <returns>The call object.</returns>
      public virtual grpc::AsyncUnaryCall<global::BlogPackage.BlogResponse> DeleteBlogUnaryAsync(global::BlogPackage.BlogRequest request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return DeleteBlogUnaryAsync(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      /// <summary>
      ///Unary Service
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="options">The options for the call.</param>
      /// <returns>The call object.</returns>
      public virtual grpc::AsyncUnaryCall<global::BlogPackage.BlogResponse> DeleteBlogUnaryAsync(global::BlogPackage.BlogRequest request, grpc::CallOptions options)
      {
        return CallInvoker.AsyncUnaryCall(__Method_DeleteBlogUnary, null, options, request);
      }
      /// <summary>Creates a new instance of client from given <c>ClientBaseConfiguration</c>.</summary>
      protected override BlogServiceClient NewInstance(ClientBaseConfiguration configuration)
      {
        return new BlogServiceClient(configuration);
      }
    }

    /// <summary>Creates service definition that can be registered with a server</summary>
    /// <param name="serviceImpl">An object implementing the server-side handling logic.</param>
    public static grpc::ServerServiceDefinition BindService(BlogServiceBase serviceImpl)
    {
      return grpc::ServerServiceDefinition.CreateBuilder()
          .AddMethod(__Method_CreateBlogUnary, serviceImpl.CreateBlogUnary)
          .AddMethod(__Method_ReadBlogUnary, serviceImpl.ReadBlogUnary)
          .AddMethod(__Method_UpdateBlogUnary, serviceImpl.UpdateBlogUnary)
          .AddMethod(__Method_DeleteBlogUnary, serviceImpl.DeleteBlogUnary).Build();
    }

    /// <summary>Register service method with a service binder with or without implementation. Useful when customizing the  service binding logic.
    /// Note: this method is part of an experimental API that can change or be removed without any prior notice.</summary>
    /// <param name="serviceBinder">Service methods will be bound by calling <c>AddMethod</c> on this object.</param>
    /// <param name="serviceImpl">An object implementing the server-side handling logic.</param>
    public static void BindService(grpc::ServiceBinderBase serviceBinder, BlogServiceBase serviceImpl)
    {
      serviceBinder.AddMethod(__Method_CreateBlogUnary, serviceImpl == null ? null : new grpc::UnaryServerMethod<global::BlogPackage.BlogRequest, global::BlogPackage.BlogResponse>(serviceImpl.CreateBlogUnary));
      serviceBinder.AddMethod(__Method_ReadBlogUnary, serviceImpl == null ? null : new grpc::UnaryServerMethod<global::BlogPackage.BlogRequest, global::BlogPackage.BlogResponse>(serviceImpl.ReadBlogUnary));
      serviceBinder.AddMethod(__Method_UpdateBlogUnary, serviceImpl == null ? null : new grpc::UnaryServerMethod<global::BlogPackage.BlogRequest, global::BlogPackage.BlogResponse>(serviceImpl.UpdateBlogUnary));
      serviceBinder.AddMethod(__Method_DeleteBlogUnary, serviceImpl == null ? null : new grpc::UnaryServerMethod<global::BlogPackage.BlogRequest, global::BlogPackage.BlogResponse>(serviceImpl.DeleteBlogUnary));
    }

  }
}
#endregion
