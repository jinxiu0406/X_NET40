﻿using System;
using System.IO;
using System.Net.Sockets;
using System.Text;

namespace NewLife.Net
{
    /// <summary>基础Socket接口</summary>
    /// <remarks>
    /// 封装所有基础接口的共有特性！
    /// 
    /// 核心设计理念：事件驱动，接口统一，简单易用！
    /// 异常处理理念：确保主流程简单易用，特殊情况的异常通过事件处理！
    /// </remarks>
    public interface ISocket : IDisposable2
    {
        #region 属性
        /// <summary>基础Socket对象</summary>
        Socket Socket { get; /*set;*/ }

        /// <summary>本地地址</summary>
        NetUri Local { get; set; }

        /// <summary>端口</summary>
        Int32 Port { get; set; }

        /// <summary>是否抛出异常，默认false不抛出。Send/Receive时可能发生异常，该设置决定是直接抛出异常还是通过<see cref="Error"/>事件</summary>
        Boolean ThrowException { get; set; }

        /// <summary>接收数据包统计信息，默认关闭，通过<see cref="IStatistics.Enable"/>打开。</summary>
        IStatistics Statistics { get; }

        ///// <summary>异步操作计数</summary>
        //Int32 AsyncCount { get; }
        #endregion

        #region 方法
        ///// <summary>绑定本地终结点</summary>
        //void Bind();

        ///// <summary>关闭网络操作</summary>
        //void Close();
        #endregion

        #region 事件
        /// <summary>错误发生/断开连接时</summary>
        event EventHandler<ExceptionEventArgs> Error;
        #endregion
    }

    /// <summary>远程通信Socket，仅具有收发功能</summary>
    public interface ISocketRemote : ISocket
    {
        #region 属性
        /// <summary>远程地址</summary>
        NetUri Remote { get; set; }
        #endregion

        #region 方法
        /// <summary>发送数据</summary>
        /// <remarks>
        /// 目标地址由<seealso cref="Remote"/>决定
        /// </remarks>
        /// <param name="buffer">缓冲区</param>
        /// <param name="offset">偏移</param>
        /// <param name="count">数量</param>
        /// <returns>是否成功</returns>
        Boolean Send(Byte[] buffer, Int32 offset = 0, Int32 count = -1);

        /// <summary>接收数据</summary>
        /// <returns></returns>
        Byte[] Receive();

        /// <summary>读取指定长度的数据，一般是一帧</summary>
        /// <param name="buffer">缓冲区</param>
        /// <param name="offset">偏移</param>
        /// <param name="count">数量</param>
        /// <returns></returns>
        Int32 Receive(Byte[] buffer, Int32 offset = 0, Int32 count = -1);
        #endregion

        #region 异步接收
        /// <summary>开始异步接收数据</summary>
        /// <returns>是否成功</returns>
        Boolean ReceiveAsync();

        /// <summary>数据到达，在事件处理代码中，事件参数不得另作他用，套接字事件池将会将其回收。</summary>
        event EventHandler<ReceivedEventArgs> Received;
        #endregion
    }

    /// <summary>远程通信Socket扩展</summary>
    public static class SocketRemoteHelper
    {
        #region 发送
        /// <summary>发送数据流</summary>
        /// <param name="session">会话</param>
        /// <param name="stream"></param>
        /// <returns></returns>
        /// <returns>返回自身，用于链式写法</returns>
        public static ISocketRemote Send(this ISocketRemote session, Stream stream)
        {
            var size = 1460;
            var remain = (Int32)(stream.Length - stream.Position);
            if (remain < size) size = remain;
            var buffer = new Byte[size];
            while (true)
            {
                var count = stream.Read(buffer, 0, buffer.Length);
                if (count <= 0) break;

                session.Send(buffer, 0, count);

                if (count < buffer.Length) break;
            }
            return session;
        }

        /// <summary>发送字符串</summary>
        /// <param name="session">会话</param>
        /// <param name="msg"></param>
        /// <param name="encoding"></param>
        /// <returns>返回自身，用于链式写法</returns>
        public static ISocketRemote Send(this ISocketRemote session, String msg, Encoding encoding = null)
        {
            if (String.IsNullOrEmpty(msg)) return session;

            if (encoding == null) encoding = Encoding.UTF8;
            session.Send(encoding.GetBytes(msg));

            return session;
        }
        #endregion

        #region 接收
        /// <summary>接收字符串</summary>
        /// <param name="session">会话</param>
        /// <param name="encoding"></param>
        /// <returns></returns>
        public static String ReceiveString(this ISocketRemote session, Encoding encoding = null)
        {
            var buffer = session.Receive();
            if (buffer == null || buffer.Length < 1) return null;

            if (encoding == null) encoding = Encoding.UTF8;
            return encoding.GetString(buffer);
        }
        #endregion
    }
}