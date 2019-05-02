// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: bim.proto
// </auto-generated>
#pragma warning disable 1591
#region Designer generated code

using grpc = global::Grpc.Core;

namespace Mega.Bim {
  public static partial class Items
  {
    static readonly string __ServiceName = "Mega.Bim.Items";

    static readonly grpc::Marshaller<global::Mega.Bim.Item> __Marshaller_Item = grpc::Marshallers.Create((arg) => global::Google.Protobuf.MessageExtensions.ToByteArray(arg), global::Mega.Bim.Item.Parser.ParseFrom);
    static readonly grpc::Marshaller<global::Mega.Bim.Result> __Marshaller_Result = grpc::Marshallers.Create((arg) => global::Google.Protobuf.MessageExtensions.ToByteArray(arg), global::Mega.Bim.Result.Parser.ParseFrom);

    static readonly grpc::Method<global::Mega.Bim.Item, global::Mega.Bim.Result> __Method_sendItems = new grpc::Method<global::Mega.Bim.Item, global::Mega.Bim.Result>(
        grpc::MethodType.ClientStreaming,
        __ServiceName,
        "sendItems",
        __Marshaller_Item,
        __Marshaller_Result);

    /// <summary>Service descriptor</summary>
    public static global::Google.Protobuf.Reflection.ServiceDescriptor Descriptor
    {
      get { return global::Mega.Bim.BimReflection.Descriptor.Services[0]; }
    }

    /// <summary>Base class for server-side implementations of Items</summary>
    public abstract partial class ItemsBase
    {
      public virtual global::System.Threading.Tasks.Task<global::Mega.Bim.Result> sendItems(grpc::IAsyncStreamReader<global::Mega.Bim.Item> requestStream, grpc::ServerCallContext context)
      {
        throw new grpc::RpcException(new grpc::Status(grpc::StatusCode.Unimplemented, ""));
      }

    }

    /// <summary>Client for Items</summary>
    public partial class ItemsClient : grpc::ClientBase<ItemsClient>
    {
      /// <summary>Creates a new client for Items</summary>
      /// <param name="channel">The channel to use to make remote calls.</param>
      public ItemsClient(grpc::Channel channel) : base(channel)
      {
      }
      /// <summary>Creates a new client for Items that uses a custom <c>CallInvoker</c>.</summary>
      /// <param name="callInvoker">The callInvoker to use to make remote calls.</param>
      public ItemsClient(grpc::CallInvoker callInvoker) : base(callInvoker)
      {
      }
      /// <summary>Protected parameterless constructor to allow creation of test doubles.</summary>
      protected ItemsClient() : base()
      {
      }
      /// <summary>Protected constructor to allow creation of configured clients.</summary>
      /// <param name="configuration">The client configuration.</param>
      protected ItemsClient(ClientBaseConfiguration configuration) : base(configuration)
      {
      }

      public virtual grpc::AsyncClientStreamingCall<global::Mega.Bim.Item, global::Mega.Bim.Result> sendItems(grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return sendItems(new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      public virtual grpc::AsyncClientStreamingCall<global::Mega.Bim.Item, global::Mega.Bim.Result> sendItems(grpc::CallOptions options)
      {
        return CallInvoker.AsyncClientStreamingCall(__Method_sendItems, null, options);
      }
      /// <summary>Creates a new instance of client from given <c>ClientBaseConfiguration</c>.</summary>
      protected override ItemsClient NewInstance(ClientBaseConfiguration configuration)
      {
        return new ItemsClient(configuration);
      }
    }

    /// <summary>Creates service definition that can be registered with a server</summary>
    /// <param name="serviceImpl">An object implementing the server-side handling logic.</param>
    public static grpc::ServerServiceDefinition BindService(ItemsBase serviceImpl)
    {
      return grpc::ServerServiceDefinition.CreateBuilder()
          .AddMethod(__Method_sendItems, serviceImpl.sendItems).Build();
    }

  }
}
#endregion
