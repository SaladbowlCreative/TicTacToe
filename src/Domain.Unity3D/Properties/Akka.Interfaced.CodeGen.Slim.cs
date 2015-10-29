// ------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by Akka.Interfaced CodeGenerator.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
// ------------------------------------------------------------------------------

using System;
using System.Threading.Tasks;
using Akka.Interfaced;
using ProtoBuf;
using TypeAlias;
using System.ComponentModel;

#region Domain.Interfaced.IGamePlayer

namespace Domain.Interfaced
{
    [PayloadTableForInterfacedActor(typeof(IGamePlayer))]
    public static class IGamePlayer_PayloadTable
    {
        public static Type[,] GetPayloadTypes()
        {
            return new Type[,]
            {
                {typeof(MakeMove_Invoke), null},
                {typeof(Say_Invoke), null},
            };
        }

        [ProtoContract, TypeAlias]
        public class MakeMove_Invoke : IInterfacedPayload, ITagOverridable, IAsyncInvokable
        {
            [ProtoMember(1)] public Domain.Interfaced.PlacePosition pos;
            [ProtoMember(2)] public System.String playerUserId;

            public Type GetInterfaceType() { return typeof(IGamePlayer); }

            public void SetTag(object value) { playerUserId = (System.String)value; }

            public Task<IValueGetable> InvokeAsync(object target)
            {
                return null;
            }
        }

        [ProtoContract, TypeAlias]
        public class Say_Invoke : IInterfacedPayload, ITagOverridable, IAsyncInvokable
        {
            [ProtoMember(1)] public System.String msg;
            [ProtoMember(2)] public System.String playerUserId;

            public Type GetInterfaceType() { return typeof(IGamePlayer); }

            public void SetTag(object value) { playerUserId = (System.String)value; }

            public Task<IValueGetable> InvokeAsync(object target)
            {
                return null;
            }
        }
    }

    public interface IGamePlayer_NoReply
    {
        void MakeMove(Domain.Interfaced.PlacePosition pos, System.String playerUserId = null);
        void Say(System.String msg, System.String playerUserId = null);
    }

    public class GamePlayerRef : InterfacedActorRef, IGamePlayer, IGamePlayer_NoReply
    {
        public GamePlayerRef(IActorRef actor, IRequestWaiter requestWaiter, TimeSpan? timeout)
            : base(actor, requestWaiter, timeout)
        {
        }

        public IGamePlayer_NoReply WithNoReply()
        {
            return this;
        }

        public GamePlayerRef WithRequestWaiter(IRequestWaiter requestWaiter)
        {
            return new GamePlayerRef(Actor, requestWaiter, Timeout);
        }

        public GamePlayerRef WithTimeout(TimeSpan? timeout)
        {
            return new GamePlayerRef(Actor, RequestWaiter, timeout);
        }

        public Task MakeMove(Domain.Interfaced.PlacePosition pos, System.String playerUserId = null)
        {
            var requestMessage = new RequestMessage
            {
                InvokePayload = new IGamePlayer_PayloadTable.MakeMove_Invoke { pos = pos, playerUserId = playerUserId }
            };
            return SendRequestAndWait(requestMessage);
        }

        public Task Say(System.String msg, System.String playerUserId = null)
        {
            var requestMessage = new RequestMessage
            {
                InvokePayload = new IGamePlayer_PayloadTable.Say_Invoke { msg = msg, playerUserId = playerUserId }
            };
            return SendRequestAndWait(requestMessage);
        }

        void IGamePlayer_NoReply.MakeMove(Domain.Interfaced.PlacePosition pos, System.String playerUserId)
        {
            var requestMessage = new RequestMessage
            {
                InvokePayload = new IGamePlayer_PayloadTable.MakeMove_Invoke { pos = pos, playerUserId = playerUserId }
            };
            SendRequest(requestMessage);
        }

        void IGamePlayer_NoReply.Say(System.String msg, System.String playerUserId)
        {
            var requestMessage = new RequestMessage
            {
                InvokePayload = new IGamePlayer_PayloadTable.Say_Invoke { msg = msg, playerUserId = playerUserId }
            };
            SendRequest(requestMessage);
        }
    }
}

#endregion

#region Domain.Interfaced.IUser

namespace Domain.Interfaced
{
    [PayloadTableForInterfacedActor(typeof(IUser))]
    public static class IUser_PayloadTable
    {
        public static Type[,] GetPayloadTypes()
        {
            return new Type[,]
            {
                {typeof(JoinGame_Invoke), typeof(JoinGame_Return)},
                {typeof(LeaveGame_Invoke), null},
                {typeof(RegisterPairing_Invoke), null},
                {typeof(UnregisterPairing_Invoke), null},
            };
        }

        [ProtoContract, TypeAlias]
        public class JoinGame_Invoke : IInterfacedPayload, IAsyncInvokable
        {
            [ProtoMember(1)] public System.Int64 gameId;
            [ProtoMember(2)] public System.Int32 observerId;

            public Type GetInterfaceType() { return typeof(IUser); }

            public Task<IValueGetable> InvokeAsync(object target)
            {
                return null;
            }
        }

        [ProtoContract, TypeAlias]
        public class JoinGame_Return : IInterfacedPayload, IValueGetable
        {
            [ProtoMember(1)] public System.Tuple<System.Int32, Domain.Interfaced.GameInfo> v;

            public Type GetInterfaceType() { return typeof(IUser); }

            public object Value { get { return v; } }
        }

        [ProtoContract, TypeAlias]
        public class LeaveGame_Invoke : IInterfacedPayload, IAsyncInvokable
        {
            [ProtoMember(1)] public System.Int64 gameId;

            public Type GetInterfaceType() { return typeof(IUser); }

            public Task<IValueGetable> InvokeAsync(object target)
            {
                return null;
            }
        }

        [ProtoContract, TypeAlias]
        public class RegisterPairing_Invoke : IInterfacedPayload, IAsyncInvokable
        {
            public Type GetInterfaceType() { return typeof(IUser); }

            public Task<IValueGetable> InvokeAsync(object target)
            {
                return null;
            }
        }

        [ProtoContract, TypeAlias]
        public class UnregisterPairing_Invoke : IInterfacedPayload, IAsyncInvokable
        {
            public Type GetInterfaceType() { return typeof(IUser); }

            public Task<IValueGetable> InvokeAsync(object target)
            {
                return null;
            }
        }
    }

    public interface IUser_NoReply
    {
        void JoinGame(System.Int64 gameId, System.Int32 observerId);
        void LeaveGame(System.Int64 gameId);
        void RegisterPairing();
        void UnregisterPairing();
    }

    public class UserRef : InterfacedActorRef, IUser, IUser_NoReply
    {
        public UserRef(IActorRef actor, IRequestWaiter requestWaiter, TimeSpan? timeout)
            : base(actor, requestWaiter, timeout)
        {
        }

        public IUser_NoReply WithNoReply()
        {
            return this;
        }

        public UserRef WithRequestWaiter(IRequestWaiter requestWaiter)
        {
            return new UserRef(Actor, requestWaiter, Timeout);
        }

        public UserRef WithTimeout(TimeSpan? timeout)
        {
            return new UserRef(Actor, RequestWaiter, timeout);
        }

        public Task<System.Tuple<System.Int32, Domain.Interfaced.GameInfo>> JoinGame(System.Int64 gameId, System.Int32 observerId)
        {
            var requestMessage = new RequestMessage
            {
                InvokePayload = new IUser_PayloadTable.JoinGame_Invoke { gameId = gameId, observerId = observerId }
            };
            return SendRequestAndReceive<System.Tuple<System.Int32, Domain.Interfaced.GameInfo>>(requestMessage);
        }

        public Task LeaveGame(System.Int64 gameId)
        {
            var requestMessage = new RequestMessage
            {
                InvokePayload = new IUser_PayloadTable.LeaveGame_Invoke { gameId = gameId }
            };
            return SendRequestAndWait(requestMessage);
        }

        public Task RegisterPairing()
        {
            var requestMessage = new RequestMessage
            {
                InvokePayload = new IUser_PayloadTable.RegisterPairing_Invoke {  }
            };
            return SendRequestAndWait(requestMessage);
        }

        public Task UnregisterPairing()
        {
            var requestMessage = new RequestMessage
            {
                InvokePayload = new IUser_PayloadTable.UnregisterPairing_Invoke {  }
            };
            return SendRequestAndWait(requestMessage);
        }

        void IUser_NoReply.JoinGame(System.Int64 gameId, System.Int32 observerId)
        {
            var requestMessage = new RequestMessage
            {
                InvokePayload = new IUser_PayloadTable.JoinGame_Invoke { gameId = gameId, observerId = observerId }
            };
            SendRequest(requestMessage);
        }

        void IUser_NoReply.LeaveGame(System.Int64 gameId)
        {
            var requestMessage = new RequestMessage
            {
                InvokePayload = new IUser_PayloadTable.LeaveGame_Invoke { gameId = gameId }
            };
            SendRequest(requestMessage);
        }

        void IUser_NoReply.RegisterPairing()
        {
            var requestMessage = new RequestMessage
            {
                InvokePayload = new IUser_PayloadTable.RegisterPairing_Invoke {  }
            };
            SendRequest(requestMessage);
        }

        void IUser_NoReply.UnregisterPairing()
        {
            var requestMessage = new RequestMessage
            {
                InvokePayload = new IUser_PayloadTable.UnregisterPairing_Invoke {  }
            };
            SendRequest(requestMessage);
        }
    }
}

#endregion

#region Domain.Interfaced.IUserLogin

namespace Domain.Interfaced
{
    [PayloadTableForInterfacedActor(typeof(IUserLogin))]
    public static class IUserLogin_PayloadTable
    {
        public static Type[,] GetPayloadTypes()
        {
            return new Type[,]
            {
                {typeof(Login_Invoke), typeof(Login_Return)},
            };
        }

        [ProtoContract, TypeAlias]
        public class Login_Invoke : IInterfacedPayload, IAsyncInvokable
        {
            [ProtoMember(1)] public System.String id;
            [ProtoMember(2)] public System.String password;
            [ProtoMember(3)] public System.Int32 observerId;

            public Type GetInterfaceType() { return typeof(IUserLogin); }

            public Task<IValueGetable> InvokeAsync(object target)
            {
                return null;
            }
        }

        [ProtoContract, TypeAlias]
        public class Login_Return : IInterfacedPayload, IValueGetable
        {
            [ProtoMember(1)] public System.Int32 v;

            public Type GetInterfaceType() { return typeof(IUserLogin); }

            public object Value { get { return v; } }
        }
    }

    public interface IUserLogin_NoReply
    {
        void Login(System.String id, System.String password, System.Int32 observerId);
    }

    public class UserLoginRef : InterfacedActorRef, IUserLogin, IUserLogin_NoReply
    {
        public UserLoginRef(IActorRef actor, IRequestWaiter requestWaiter, TimeSpan? timeout)
            : base(actor, requestWaiter, timeout)
        {
        }

        public IUserLogin_NoReply WithNoReply()
        {
            return this;
        }

        public UserLoginRef WithRequestWaiter(IRequestWaiter requestWaiter)
        {
            return new UserLoginRef(Actor, requestWaiter, Timeout);
        }

        public UserLoginRef WithTimeout(TimeSpan? timeout)
        {
            return new UserLoginRef(Actor, RequestWaiter, timeout);
        }

        public Task<System.Int32> Login(System.String id, System.String password, System.Int32 observerId)
        {
            var requestMessage = new RequestMessage
            {
                InvokePayload = new IUserLogin_PayloadTable.Login_Invoke { id = id, password = password, observerId = observerId }
            };
            return SendRequestAndReceive<System.Int32>(requestMessage);
        }

        void IUserLogin_NoReply.Login(System.String id, System.String password, System.Int32 observerId)
        {
            var requestMessage = new RequestMessage
            {
                InvokePayload = new IUserLogin_PayloadTable.Login_Invoke { id = id, password = password, observerId = observerId }
            };
            SendRequest(requestMessage);
        }
    }
}

#endregion

#region Domain.Interfaced.IGameObserver

namespace Domain.Interfaced
{
    public static class IGameObserver_PayloadTable
    {
        [ProtoContract, TypeAlias]
        public class Join_Invoke : IInvokable
        {
            [ProtoMember(1)] public System.Int32 playerId;
            [ProtoMember(2)] public System.String userId;

            public void Invoke(object target)
            {
                ((IGameObserver)target).Join(playerId, userId);
            }
        }

        [ProtoContract, TypeAlias]
        public class Leave_Invoke : IInvokable
        {
            [ProtoMember(1)] public System.Int32 playerId;

            public void Invoke(object target)
            {
                ((IGameObserver)target).Leave(playerId);
            }
        }

        [ProtoContract, TypeAlias]
        public class MakeMove_Invoke : IInvokable
        {
            [ProtoMember(1)] public System.Int32 playerId;
            [ProtoMember(2)] public Domain.Interfaced.PlacePosition pos;

            public void Invoke(object target)
            {
                ((IGameObserver)target).MakeMove(playerId, pos);
            }
        }

        [ProtoContract, TypeAlias]
        public class Say_Invoke : IInvokable
        {
            [ProtoMember(1)] public System.Int32 playerId;
            [ProtoMember(2)] public System.String msg;

            public void Invoke(object target)
            {
                ((IGameObserver)target).Say(playerId, msg);
            }
        }
    }
}

#endregion

#region Domain.Interfaced.IUserEventObserver

namespace Domain.Interfaced
{
    public static class IUserEventObserver_PayloadTable
    {
        [ProtoContract, TypeAlias]
        public class MakePair_Invoke : IInvokable
        {
            [ProtoMember(1)] public System.Int64 gameId;
            [ProtoMember(2)] public System.String opponentName;

            public void Invoke(object target)
            {
                ((IUserEventObserver)target).MakePair(gameId, opponentName);
            }
        }
    }
}

#endregion
