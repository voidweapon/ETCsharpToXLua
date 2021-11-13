using System;
using System.Globalization;

namespace ET
{
    public static class TimeHelper
    {
        public const long OneDay = 86400000;
        public const long Hour = 3600000;
        public const long Minute = 60000;
        
        /// <summary>
        /// 客户端时间
        /// </summary>
        /// <returns></returns>
        public static long ClientNow()
        {
#if __CSharpLua__
            return ETCold.LocalTimeHelper.CurrentMilliseconds();
#else
            return Game.TimeInfo.ClientNow();
#endif
        }

        public static long ClientNowSeconds()
        {
            return ClientNow() / 1000;
        }

        public static DateTime DateTimeNow()
        {
            return DateTime.Now;
        }

        public static long ServerNow()
        {
#if __CSharpLua__
            return ETCold.LocalTimeHelper.CurrentMilliseconds();
#else
            return Game.TimeInfo.ServerNow(); 
#endif
        }

        public static long ClientFrameTime()
        {
#if __CSharpLua__
            return ETCold.LocalTimeHelper.CurrentMilliseconds();
#else
            return Game.TimeInfo.ClientFrameTime(); 
#endif
        }

        public static long ServerFrameTime()
        {
#if __CSharpLua__
            return ETCold.LocalTimeHelper.CurrentMilliseconds();
#else
            return Game.TimeInfo.ServerFrameTime(); 
#endif
        }
    }
}