// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: squareRoot.proto
// </auto-generated>
#pragma warning disable 0414, 1591
#region Designer generated code

using grpc = global::Grpc.Core;

namespace SquareRootPackage {
  public static partial class SquareRootService
  {
    static readonly string __ServiceName = "squareRootPackage.SquareRootService";

    static readonly grpc::Marshaller<global::SquareRootPackage.SquareRootRequest> __Marshaller_squareRootPackage_SquareRootRequest = grpc::Marshallers.Create((arg) => global::Google.Protobuf.MessageExtensions.ToByteArray(arg), global::SquareRootPackage.SquareRootRequest.Parser.ParseFrom);
    static readonly grpc::Marshaller<global::SquareRootPackage.SquareRootResponse> __Marshaller_squareRootPackage_SquareRootResponse = grpc::Marshallers.Create((arg) => global::Google.Protobuf.MessageExtensions.ToByteArray(arg), global::SquareRootPackage.SquareRootResponse.Parser.ParseFrom);

    static readonly grpc::Method<global::SquareRootPackage.SquareRootRequest, global::SquareRootPackage.SquareRootResponse> __Method_SquareRootUnary = new grpc::Method<global::SquareRootPackage.SquareRootRequest, global::SquareRootPackage.SquareRootResponse>(
        grpc::MethodType.Unary,
        __ServiceName,
        "SquareRootUnary",
        __Marshaller_squareRootPackage_SquareRootRequest,
        __Marshaller_squareRootPackage_SquareRootResponse);

    /// <summary>Service descriptor</summary>
    public static global::Google.Protobuf.Reflection.ServiceDescriptor Descriptor
    {
      get { return global::SquareRootPackage.SquareRootReflection.Descriptor.Services[0]; }
    }

    /// <summary>Base class for server-side implementations of SquareRootService</summary>
    [grpc::BindServiceMethod(typeof(SquareRootService), "BindService")]
    public abstract partial class SquareRootServiceBase
    {
      /// <summary>
      ///Unary Service
      /// </summary>
      /// <param name="request">The request received from the client.</param>
      /// <param name="context">The context of the server-side call handler being invoked.</param>
      /// <returns>The response to send back to the client (wrapped by a task).</returns>
      public virtual global::System.Threading.Tasks.Task<global::SquareRootPackage.SquareRootResponse> SquareRootUnary(global::SquareRootPackage.SquareRootRequest request, grpc::ServerCallContext context)
      {
        throw new grpc::RpcException(new grpc::Status(grpc::StatusCode.Unimplemented, ""));
      }

    }

    /// <summary>Client for SquareRootService</summary>
    public partial class SquareRootServiceClient : grpc::ClientBase<SquareRootServiceClient>
    {
      /// <summary>Creates a new client for SquareRootService</summary>
      /// <param name="channel">The channel to use to make remote calls.</param>
      public SquareRootServiceClient(grpc::ChannelBase channel) : base(channel)
      {
      }
      /// <summary>Creates a new client for SquareRootService that uses a custom <c>CallInvoker</c>.</summary>
      /// <param name="callInvoker">The callInvoker to use to make remote calls.</param>
      public SquareRootServiceClient(grpc::CallInvoker callInvoker) : base(callInvoker)
      {
      }
      /// <summary>Protected parameterless constructor to allow creation of test doubles.</summary>
      protected SquareRootServiceClient() : base()
      {
      }
      /// <summary>Protected constructor to allow creation of configured clients.</summary>
      /// <param name="configuration">The client configuration.</param>
      protected SquareRootServiceClient(ClientBaseConfiguration configuration) : base(configuration)
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
      public virtual global::SquareRootPackage.SquareRootResponse SquareRootUnary(global::SquareRootPackage.SquareRootRequest request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return SquareRootUnary(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      /// <summary>
      ///Unary Service
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="options">The options for the call.</param>
      /// <returns>The response received from the server.</returns>
      public virtual global::SquareRootPackage.SquareRootResponse SquareRootUnary(global::SquareRootPackage.SquareRootRequest request, grpc::CallOptions options)
      {
        return CallInvoker.BlockingUnaryCall(__Method_SquareRootUnary, null, options, request);
      }
      /// <summary>
      ///Unary Service
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="headers">The initial metadata to send with the call. This parameter is optional.</param>
      /// <param name="deadline">An optional deadline for the call. The call will be cancelled if deadline is hit.</param>
      /// <param name="cancellationToken">An optional token for canceling the call.</param>
      /// <returns>The call object.</returns>
      public virtual grpc::AsyncUnaryCall<global::SquareRootPackage.SquareRootResponse> SquareRootUnaryAsync(global::SquareRootPackage.SquareRootRequest request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return SquareRootUnaryAsync(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      /// <summary>
      ///Unary Service
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="options">The options for the call.</param>
      /// <returns>The call object.</returns>
      public virtual grpc::AsyncUnaryCall<global::SquareRootPackage.SquareRootResponse> SquareRootUnaryAsync(global::SquareRootPackage.SquareRootRequest request, grpc::CallOptions options)
      {
        return CallInvoker.AsyncUnaryCall(__Method_SquareRootUnary, null, options, request);
      }
      /// <summary>Creates a new instance of client from given <c>ClientBaseConfiguration</c>.</summary>
      protected override SquareRootServiceClient NewInstance(ClientBaseConfiguration configuration)
      {
        return new SquareRootServiceClient(configuration);
      }
    }

    /// <summary>Creates service definition that can be registered with a server</summary>
    /// <param name="serviceImpl">An object implementing the server-side handling logic.</param>
    public static grpc::ServerServiceDefinition BindService(SquareRootServiceBase serviceImpl)
    {
      return grpc::ServerServiceDefinition.CreateBuilder()
          .AddMethod(__Method_SquareRootUnary, serviceImpl.SquareRootUnary).Build();
    }

    /// <summary>Register service method with a service binder with or without implementation. Useful when customizing the  service binding logic.
    /// Note: this method is part of an experimental API that can change or be removed without any prior notice.</summary>
    /// <param name="serviceBinder">Service methods will be bound by calling <c>AddMethod</c> on this object.</param>
    /// <param name="serviceImpl">An object implementing the server-side handling logic.</param>
    public static void BindService(grpc::ServiceBinderBase serviceBinder, SquareRootServiceBase serviceImpl)
    {
      serviceBinder.AddMethod(__Method_SquareRootUnary, serviceImpl == null ? null : new grpc::UnaryServerMethod<global::SquareRootPackage.SquareRootRequest, global::SquareRootPackage.SquareRootResponse>(serviceImpl.SquareRootUnary));
    }

  }
}
#endregion
