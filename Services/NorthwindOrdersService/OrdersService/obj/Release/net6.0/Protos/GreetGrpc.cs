// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: Protos/greet.proto
// </auto-generated>
#pragma warning disable 0414, 1591
#region Designer generated code

using grpc = global::Grpc.Core;

namespace OrdersService {
  public static partial class NorthwindRPC
  {
    static readonly string __ServiceName = "greet.NorthwindRPC";

    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    static void __Helper_SerializeMessage(global::Google.Protobuf.IMessage message, grpc::SerializationContext context)
    {
      #if !GRPC_DISABLE_PROTOBUF_BUFFER_SERIALIZATION
      if (message is global::Google.Protobuf.IBufferMessage)
      {
        context.SetPayloadLength(message.CalculateSize());
        global::Google.Protobuf.MessageExtensions.WriteTo(message, context.GetBufferWriter());
        context.Complete();
        return;
      }
      #endif
      context.Complete(global::Google.Protobuf.MessageExtensions.ToByteArray(message));
    }

    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    static class __Helper_MessageCache<T>
    {
      public static readonly bool IsBufferMessage = global::System.Reflection.IntrospectionExtensions.GetTypeInfo(typeof(global::Google.Protobuf.IBufferMessage)).IsAssignableFrom(typeof(T));
    }

    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    static T __Helper_DeserializeMessage<T>(grpc::DeserializationContext context, global::Google.Protobuf.MessageParser<T> parser) where T : global::Google.Protobuf.IMessage<T>
    {
      #if !GRPC_DISABLE_PROTOBUF_BUFFER_SERIALIZATION
      if (__Helper_MessageCache<T>.IsBufferMessage)
      {
        return parser.ParseFrom(context.PayloadAsReadOnlySequence());
      }
      #endif
      return parser.ParseFrom(context.PayloadAsNewBuffer());
    }

    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    static readonly grpc::Marshaller<global::OrdersService.GetOrdersRequest> __Marshaller_greet_GetOrdersRequest = grpc::Marshallers.Create(__Helper_SerializeMessage, context => __Helper_DeserializeMessage(context, global::OrdersService.GetOrdersRequest.Parser));
    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    static readonly grpc::Marshaller<global::OrdersService.GetOrdersReply> __Marshaller_greet_GetOrdersReply = grpc::Marshallers.Create(__Helper_SerializeMessage, context => __Helper_DeserializeMessage(context, global::OrdersService.GetOrdersReply.Parser));
    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    static readonly grpc::Marshaller<global::OrdersService.GetOrderRequest> __Marshaller_greet_GetOrderRequest = grpc::Marshallers.Create(__Helper_SerializeMessage, context => __Helper_DeserializeMessage(context, global::OrdersService.GetOrderRequest.Parser));
    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    static readonly grpc::Marshaller<global::OrdersService.GetOrderReply> __Marshaller_greet_GetOrderReply = grpc::Marshallers.Create(__Helper_SerializeMessage, context => __Helper_DeserializeMessage(context, global::OrdersService.GetOrderReply.Parser));
    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    static readonly grpc::Marshaller<global::OrdersService.CreateOrderRequest> __Marshaller_greet_CreateOrderRequest = grpc::Marshallers.Create(__Helper_SerializeMessage, context => __Helper_DeserializeMessage(context, global::OrdersService.CreateOrderRequest.Parser));
    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    static readonly grpc::Marshaller<global::OrdersService.CreateOrderReply> __Marshaller_greet_CreateOrderReply = grpc::Marshallers.Create(__Helper_SerializeMessage, context => __Helper_DeserializeMessage(context, global::OrdersService.CreateOrderReply.Parser));
    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    static readonly grpc::Marshaller<global::OrdersService.UpdateOrderRequest> __Marshaller_greet_UpdateOrderRequest = grpc::Marshallers.Create(__Helper_SerializeMessage, context => __Helper_DeserializeMessage(context, global::OrdersService.UpdateOrderRequest.Parser));
    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    static readonly grpc::Marshaller<global::OrdersService.UpdateOrderReply> __Marshaller_greet_UpdateOrderReply = grpc::Marshallers.Create(__Helper_SerializeMessage, context => __Helper_DeserializeMessage(context, global::OrdersService.UpdateOrderReply.Parser));
    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    static readonly grpc::Marshaller<global::OrdersService.DeleteOrderRequest> __Marshaller_greet_DeleteOrderRequest = grpc::Marshallers.Create(__Helper_SerializeMessage, context => __Helper_DeserializeMessage(context, global::OrdersService.DeleteOrderRequest.Parser));
    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    static readonly grpc::Marshaller<global::OrdersService.DeleteOrderReply> __Marshaller_greet_DeleteOrderReply = grpc::Marshallers.Create(__Helper_SerializeMessage, context => __Helper_DeserializeMessage(context, global::OrdersService.DeleteOrderReply.Parser));

    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    static readonly grpc::Method<global::OrdersService.GetOrdersRequest, global::OrdersService.GetOrdersReply> __Method_GetOrders = new grpc::Method<global::OrdersService.GetOrdersRequest, global::OrdersService.GetOrdersReply>(
        grpc::MethodType.Unary,
        __ServiceName,
        "GetOrders",
        __Marshaller_greet_GetOrdersRequest,
        __Marshaller_greet_GetOrdersReply);

    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    static readonly grpc::Method<global::OrdersService.GetOrderRequest, global::OrdersService.GetOrderReply> __Method_GetOrder = new grpc::Method<global::OrdersService.GetOrderRequest, global::OrdersService.GetOrderReply>(
        grpc::MethodType.Unary,
        __ServiceName,
        "GetOrder",
        __Marshaller_greet_GetOrderRequest,
        __Marshaller_greet_GetOrderReply);

    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    static readonly grpc::Method<global::OrdersService.CreateOrderRequest, global::OrdersService.CreateOrderReply> __Method_CreateOrder = new grpc::Method<global::OrdersService.CreateOrderRequest, global::OrdersService.CreateOrderReply>(
        grpc::MethodType.Unary,
        __ServiceName,
        "CreateOrder",
        __Marshaller_greet_CreateOrderRequest,
        __Marshaller_greet_CreateOrderReply);

    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    static readonly grpc::Method<global::OrdersService.UpdateOrderRequest, global::OrdersService.UpdateOrderReply> __Method_UpdateOrder = new grpc::Method<global::OrdersService.UpdateOrderRequest, global::OrdersService.UpdateOrderReply>(
        grpc::MethodType.Unary,
        __ServiceName,
        "UpdateOrder",
        __Marshaller_greet_UpdateOrderRequest,
        __Marshaller_greet_UpdateOrderReply);

    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    static readonly grpc::Method<global::OrdersService.DeleteOrderRequest, global::OrdersService.DeleteOrderReply> __Method_DeleteOrder = new grpc::Method<global::OrdersService.DeleteOrderRequest, global::OrdersService.DeleteOrderReply>(
        grpc::MethodType.Unary,
        __ServiceName,
        "DeleteOrder",
        __Marshaller_greet_DeleteOrderRequest,
        __Marshaller_greet_DeleteOrderReply);

    /// <summary>Service descriptor</summary>
    public static global::Google.Protobuf.Reflection.ServiceDescriptor Descriptor
    {
      get { return global::OrdersService.GreetReflection.Descriptor.Services[0]; }
    }

    /// <summary>Base class for server-side implementations of NorthwindRPC</summary>
    [grpc::BindServiceMethod(typeof(NorthwindRPC), "BindService")]
    public abstract partial class NorthwindRPCBase
    {
      /// <summary>
      /// Sends a greeting
      /// </summary>
      /// <param name="request">The request received from the client.</param>
      /// <param name="context">The context of the server-side call handler being invoked.</param>
      /// <returns>The response to send back to the client (wrapped by a task).</returns>
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public virtual global::System.Threading.Tasks.Task<global::OrdersService.GetOrdersReply> GetOrders(global::OrdersService.GetOrdersRequest request, grpc::ServerCallContext context)
      {
        throw new grpc::RpcException(new grpc::Status(grpc::StatusCode.Unimplemented, ""));
      }

      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public virtual global::System.Threading.Tasks.Task<global::OrdersService.GetOrderReply> GetOrder(global::OrdersService.GetOrderRequest request, grpc::ServerCallContext context)
      {
        throw new grpc::RpcException(new grpc::Status(grpc::StatusCode.Unimplemented, ""));
      }

      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public virtual global::System.Threading.Tasks.Task<global::OrdersService.CreateOrderReply> CreateOrder(global::OrdersService.CreateOrderRequest request, grpc::ServerCallContext context)
      {
        throw new grpc::RpcException(new grpc::Status(grpc::StatusCode.Unimplemented, ""));
      }

      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public virtual global::System.Threading.Tasks.Task<global::OrdersService.UpdateOrderReply> UpdateOrder(global::OrdersService.UpdateOrderRequest request, grpc::ServerCallContext context)
      {
        throw new grpc::RpcException(new grpc::Status(grpc::StatusCode.Unimplemented, ""));
      }

      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public virtual global::System.Threading.Tasks.Task<global::OrdersService.DeleteOrderReply> DeleteOrder(global::OrdersService.DeleteOrderRequest request, grpc::ServerCallContext context)
      {
        throw new grpc::RpcException(new grpc::Status(grpc::StatusCode.Unimplemented, ""));
      }

    }

    /// <summary>Creates service definition that can be registered with a server</summary>
    /// <param name="serviceImpl">An object implementing the server-side handling logic.</param>
    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    public static grpc::ServerServiceDefinition BindService(NorthwindRPCBase serviceImpl)
    {
      return grpc::ServerServiceDefinition.CreateBuilder()
          .AddMethod(__Method_GetOrders, serviceImpl.GetOrders)
          .AddMethod(__Method_GetOrder, serviceImpl.GetOrder)
          .AddMethod(__Method_CreateOrder, serviceImpl.CreateOrder)
          .AddMethod(__Method_UpdateOrder, serviceImpl.UpdateOrder)
          .AddMethod(__Method_DeleteOrder, serviceImpl.DeleteOrder).Build();
    }

    /// <summary>Register service method with a service binder with or without implementation. Useful when customizing the  service binding logic.
    /// Note: this method is part of an experimental API that can change or be removed without any prior notice.</summary>
    /// <param name="serviceBinder">Service methods will be bound by calling <c>AddMethod</c> on this object.</param>
    /// <param name="serviceImpl">An object implementing the server-side handling logic.</param>
    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    public static void BindService(grpc::ServiceBinderBase serviceBinder, NorthwindRPCBase serviceImpl)
    {
      serviceBinder.AddMethod(__Method_GetOrders, serviceImpl == null ? null : new grpc::UnaryServerMethod<global::OrdersService.GetOrdersRequest, global::OrdersService.GetOrdersReply>(serviceImpl.GetOrders));
      serviceBinder.AddMethod(__Method_GetOrder, serviceImpl == null ? null : new grpc::UnaryServerMethod<global::OrdersService.GetOrderRequest, global::OrdersService.GetOrderReply>(serviceImpl.GetOrder));
      serviceBinder.AddMethod(__Method_CreateOrder, serviceImpl == null ? null : new grpc::UnaryServerMethod<global::OrdersService.CreateOrderRequest, global::OrdersService.CreateOrderReply>(serviceImpl.CreateOrder));
      serviceBinder.AddMethod(__Method_UpdateOrder, serviceImpl == null ? null : new grpc::UnaryServerMethod<global::OrdersService.UpdateOrderRequest, global::OrdersService.UpdateOrderReply>(serviceImpl.UpdateOrder));
      serviceBinder.AddMethod(__Method_DeleteOrder, serviceImpl == null ? null : new grpc::UnaryServerMethod<global::OrdersService.DeleteOrderRequest, global::OrdersService.DeleteOrderReply>(serviceImpl.DeleteOrder));
    }

  }
}
#endregion
