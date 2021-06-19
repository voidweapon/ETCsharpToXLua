
using System;
using System.Threading;
using System.Threading.Tasks;
using ETCold;

namespace ET
{
	public static class Init
	{
		public static void Start()
		{
			try
			{
				TypeHelper.Init();
				Game.EventSystem.Init();

				Log.Info("开始热更");
              
				// 注册热更层回调
				GameLoop.onUpdate += Update;
				GameLoop.onLateUpdate += LateUpdate;
				GameLoop.onApplicationQuit += OnApplicationQuit;
				
				ProtobufHelper.Init();

				Game.Options = new Options();

				Game.EventSystem.Publish(new EventType.AppStart());
				
            }
			catch (Exception _e)
			{
				Log.Error(_e);
			}
		}

		public static void Update()
		{
			Game.Update(); 
		}

		public static void LateUpdate()
		{
			Game.LateUpdate();
		}

		public static void OnApplicationQuit()
		{
			GameLoop.onUpdate -= Update;
			GameLoop.onLateUpdate -= LateUpdate;
			GameLoop.onApplicationQuit -= OnApplicationQuit;
			Game.Close();
		}
	}
}