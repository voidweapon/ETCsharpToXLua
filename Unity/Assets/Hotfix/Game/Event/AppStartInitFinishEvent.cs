using System;
using ET.EventType;

namespace ET
{
    public class AppStartInitFinishEvent : AEvent<AppStartInitFinish>
    {
        protected override async ETTask Run(AppStartInitFinish args)
        {
            Log.Info($"yes");
            await Login(args.ZoneScene,"127.0.0.1:10002","test");
        }

        private async ETTask Login(Scene zoneScene,string address,string account)
        {
            try
            {
                // 创建一个ETModel层的Session
                R2C_Login r2CLogin;
                using (var session = zoneScene.GetComponent<NetKcpComponent>().Create(NetworkHelper.ToIPEndPoint(address)))
                {
                    r2CLogin = (R2C_Login) await session.Call(new C2R_Login() { Account = account, Password = "111111" });
                }

                // 创建一个gate Session,并且保存到SessionComponent中
                Session gateSession = zoneScene.GetComponent<NetKcpComponent>().Create(NetworkHelper.ToIPEndPoint(r2CLogin.Address));
                gateSession.AddComponent<PingComponent>();
                zoneScene.AddComponent<SessionComponent>().Session = gateSession;
				
                G2C_LoginGate g2CLoginGate = (G2C_LoginGate)await gateSession.Call(
                    new C2G_LoginGate() { Key = r2CLogin.Key, GateId = r2CLogin.GateId});

                Log.Info("登陆gate成功!");

                await Game.EventSystem.Publish(new EventType.LoginFinish() {ZoneScene = zoneScene});
                
                
                G2C_PlayerInfo dG2CPlayerInfo = (G2C_PlayerInfo)await gateSession.Call(
                    new C2G_PlayerInfo() {});
                Log.Info(dG2CPlayerInfo.PlayerInfos[0].RpcId.ToString());
                Log.Info(dG2CPlayerInfo.TestRepeatedString[0]);
                
                
                G2C_EnterMap enterMap = (G2C_EnterMap)await gateSession.Call(
                    new C2G_EnterMap() {});
                Log.Info($"playerId = {enterMap.UnitId}");
                
                 gateSession.Send(
                    new C2M_Stop() {});
                 gateSession.Send(
                    new C2M_StopTest() {});
            }
            catch (Exception e)
            {
                Log.Error(e);
            }
        }
    }
}