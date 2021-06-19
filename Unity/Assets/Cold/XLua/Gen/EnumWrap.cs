#if USE_UNI_LUA
using LuaAPI = UniLua.Lua;
using RealStatePtr = UniLua.ILuaState;
using LuaCSFunction = UniLua.CSharpFunctionDelegate;
#else
using LuaAPI = XLua.LuaDLL.Lua;
using RealStatePtr = System.IntPtr;
using LuaCSFunction = XLua.LuaDLL.lua_CSFunction;
#endif

using XLua;
using System.Collections.Generic;


namespace XLua.CSObjectWrap
{
    using Utils = XLua.Utils;
    
    public class SystemNetSocketsAddressFamilyWrap
    {
		public static void __Register(RealStatePtr L)
        {
		    ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
		    Utils.BeginObjectRegister(typeof(System.Net.Sockets.AddressFamily), L, translator, 0, 0, 0, 0);
			Utils.EndObjectRegister(typeof(System.Net.Sockets.AddressFamily), L, translator, null, null, null, null, null);
			
			Utils.BeginClassRegister(typeof(System.Net.Sockets.AddressFamily), L, null, 32, 0, 0);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "Unknown", System.Net.Sockets.AddressFamily.Unknown);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "Unspecified", System.Net.Sockets.AddressFamily.Unspecified);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "Unix", System.Net.Sockets.AddressFamily.Unix);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "InterNetwork", System.Net.Sockets.AddressFamily.InterNetwork);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "ImpLink", System.Net.Sockets.AddressFamily.ImpLink);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "Pup", System.Net.Sockets.AddressFamily.Pup);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "Chaos", System.Net.Sockets.AddressFamily.Chaos);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "NS", System.Net.Sockets.AddressFamily.NS);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "Ipx", System.Net.Sockets.AddressFamily.Ipx);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "Iso", System.Net.Sockets.AddressFamily.Iso);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "Osi", System.Net.Sockets.AddressFamily.Osi);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "Ecma", System.Net.Sockets.AddressFamily.Ecma);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "DataKit", System.Net.Sockets.AddressFamily.DataKit);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "Ccitt", System.Net.Sockets.AddressFamily.Ccitt);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "Sna", System.Net.Sockets.AddressFamily.Sna);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "DecNet", System.Net.Sockets.AddressFamily.DecNet);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "DataLink", System.Net.Sockets.AddressFamily.DataLink);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "Lat", System.Net.Sockets.AddressFamily.Lat);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "HyperChannel", System.Net.Sockets.AddressFamily.HyperChannel);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "AppleTalk", System.Net.Sockets.AddressFamily.AppleTalk);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "NetBios", System.Net.Sockets.AddressFamily.NetBios);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "VoiceView", System.Net.Sockets.AddressFamily.VoiceView);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "FireFox", System.Net.Sockets.AddressFamily.FireFox);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "Banyan", System.Net.Sockets.AddressFamily.Banyan);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "Atm", System.Net.Sockets.AddressFamily.Atm);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "InterNetworkV6", System.Net.Sockets.AddressFamily.InterNetworkV6);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "Cluster", System.Net.Sockets.AddressFamily.Cluster);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "Ieee12844", System.Net.Sockets.AddressFamily.Ieee12844);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "Irda", System.Net.Sockets.AddressFamily.Irda);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "NetworkDesigners", System.Net.Sockets.AddressFamily.NetworkDesigners);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "Max", System.Net.Sockets.AddressFamily.Max);
            
			Utils.RegisterFunc(L, Utils.CLS_IDX, "__CastFrom", __CastFrom);
            
            Utils.EndClassRegister(typeof(System.Net.Sockets.AddressFamily), L, translator);
        }
		
		[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int __CastFrom(RealStatePtr L)
		{
			ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			LuaTypes lua_type = LuaAPI.lua_type(L, 1);
            if (lua_type == LuaTypes.LUA_TNUMBER)
            {
                translator.PushSystemNetSocketsAddressFamily(L, (System.Net.Sockets.AddressFamily)LuaAPI.xlua_tointeger(L, 1));
            }
			
            else if(lua_type == LuaTypes.LUA_TSTRING)
            {
			    if (LuaAPI.xlua_is_eq_str(L, 1, "Unknown"))
                {
                    translator.PushSystemNetSocketsAddressFamily(L, System.Net.Sockets.AddressFamily.Unknown);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "Unspecified"))
                {
                    translator.PushSystemNetSocketsAddressFamily(L, System.Net.Sockets.AddressFamily.Unspecified);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "Unix"))
                {
                    translator.PushSystemNetSocketsAddressFamily(L, System.Net.Sockets.AddressFamily.Unix);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "InterNetwork"))
                {
                    translator.PushSystemNetSocketsAddressFamily(L, System.Net.Sockets.AddressFamily.InterNetwork);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "ImpLink"))
                {
                    translator.PushSystemNetSocketsAddressFamily(L, System.Net.Sockets.AddressFamily.ImpLink);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "Pup"))
                {
                    translator.PushSystemNetSocketsAddressFamily(L, System.Net.Sockets.AddressFamily.Pup);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "Chaos"))
                {
                    translator.PushSystemNetSocketsAddressFamily(L, System.Net.Sockets.AddressFamily.Chaos);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "NS"))
                {
                    translator.PushSystemNetSocketsAddressFamily(L, System.Net.Sockets.AddressFamily.NS);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "Ipx"))
                {
                    translator.PushSystemNetSocketsAddressFamily(L, System.Net.Sockets.AddressFamily.Ipx);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "Iso"))
                {
                    translator.PushSystemNetSocketsAddressFamily(L, System.Net.Sockets.AddressFamily.Iso);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "Osi"))
                {
                    translator.PushSystemNetSocketsAddressFamily(L, System.Net.Sockets.AddressFamily.Osi);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "Ecma"))
                {
                    translator.PushSystemNetSocketsAddressFamily(L, System.Net.Sockets.AddressFamily.Ecma);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "DataKit"))
                {
                    translator.PushSystemNetSocketsAddressFamily(L, System.Net.Sockets.AddressFamily.DataKit);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "Ccitt"))
                {
                    translator.PushSystemNetSocketsAddressFamily(L, System.Net.Sockets.AddressFamily.Ccitt);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "Sna"))
                {
                    translator.PushSystemNetSocketsAddressFamily(L, System.Net.Sockets.AddressFamily.Sna);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "DecNet"))
                {
                    translator.PushSystemNetSocketsAddressFamily(L, System.Net.Sockets.AddressFamily.DecNet);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "DataLink"))
                {
                    translator.PushSystemNetSocketsAddressFamily(L, System.Net.Sockets.AddressFamily.DataLink);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "Lat"))
                {
                    translator.PushSystemNetSocketsAddressFamily(L, System.Net.Sockets.AddressFamily.Lat);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "HyperChannel"))
                {
                    translator.PushSystemNetSocketsAddressFamily(L, System.Net.Sockets.AddressFamily.HyperChannel);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "AppleTalk"))
                {
                    translator.PushSystemNetSocketsAddressFamily(L, System.Net.Sockets.AddressFamily.AppleTalk);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "NetBios"))
                {
                    translator.PushSystemNetSocketsAddressFamily(L, System.Net.Sockets.AddressFamily.NetBios);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "VoiceView"))
                {
                    translator.PushSystemNetSocketsAddressFamily(L, System.Net.Sockets.AddressFamily.VoiceView);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "FireFox"))
                {
                    translator.PushSystemNetSocketsAddressFamily(L, System.Net.Sockets.AddressFamily.FireFox);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "Banyan"))
                {
                    translator.PushSystemNetSocketsAddressFamily(L, System.Net.Sockets.AddressFamily.Banyan);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "Atm"))
                {
                    translator.PushSystemNetSocketsAddressFamily(L, System.Net.Sockets.AddressFamily.Atm);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "InterNetworkV6"))
                {
                    translator.PushSystemNetSocketsAddressFamily(L, System.Net.Sockets.AddressFamily.InterNetworkV6);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "Cluster"))
                {
                    translator.PushSystemNetSocketsAddressFamily(L, System.Net.Sockets.AddressFamily.Cluster);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "Ieee12844"))
                {
                    translator.PushSystemNetSocketsAddressFamily(L, System.Net.Sockets.AddressFamily.Ieee12844);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "Irda"))
                {
                    translator.PushSystemNetSocketsAddressFamily(L, System.Net.Sockets.AddressFamily.Irda);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "NetworkDesigners"))
                {
                    translator.PushSystemNetSocketsAddressFamily(L, System.Net.Sockets.AddressFamily.NetworkDesigners);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "Max"))
                {
                    translator.PushSystemNetSocketsAddressFamily(L, System.Net.Sockets.AddressFamily.Max);
                }
				else
                {
                    return LuaAPI.luaL_error(L, "invalid string for System.Net.Sockets.AddressFamily!");
                }
            }
			
            else
            {
                return LuaAPI.luaL_error(L, "invalid lua type for System.Net.Sockets.AddressFamily! Expect number or string, got + " + lua_type);
            }

            return 1;
		}
	}
    
    public class SystemNetSocketsSocketTypeWrap
    {
		public static void __Register(RealStatePtr L)
        {
		    ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
		    Utils.BeginObjectRegister(typeof(System.Net.Sockets.SocketType), L, translator, 0, 0, 0, 0);
			Utils.EndObjectRegister(typeof(System.Net.Sockets.SocketType), L, translator, null, null, null, null, null);
			
			Utils.BeginClassRegister(typeof(System.Net.Sockets.SocketType), L, null, 7, 0, 0);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "Stream", System.Net.Sockets.SocketType.Stream);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "Dgram", System.Net.Sockets.SocketType.Dgram);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "Raw", System.Net.Sockets.SocketType.Raw);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "Rdm", System.Net.Sockets.SocketType.Rdm);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "Seqpacket", System.Net.Sockets.SocketType.Seqpacket);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "Unknown", System.Net.Sockets.SocketType.Unknown);
            
			Utils.RegisterFunc(L, Utils.CLS_IDX, "__CastFrom", __CastFrom);
            
            Utils.EndClassRegister(typeof(System.Net.Sockets.SocketType), L, translator);
        }
		
		[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int __CastFrom(RealStatePtr L)
		{
			ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			LuaTypes lua_type = LuaAPI.lua_type(L, 1);
            if (lua_type == LuaTypes.LUA_TNUMBER)
            {
                translator.PushSystemNetSocketsSocketType(L, (System.Net.Sockets.SocketType)LuaAPI.xlua_tointeger(L, 1));
            }
			
            else if(lua_type == LuaTypes.LUA_TSTRING)
            {
			    if (LuaAPI.xlua_is_eq_str(L, 1, "Stream"))
                {
                    translator.PushSystemNetSocketsSocketType(L, System.Net.Sockets.SocketType.Stream);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "Dgram"))
                {
                    translator.PushSystemNetSocketsSocketType(L, System.Net.Sockets.SocketType.Dgram);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "Raw"))
                {
                    translator.PushSystemNetSocketsSocketType(L, System.Net.Sockets.SocketType.Raw);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "Rdm"))
                {
                    translator.PushSystemNetSocketsSocketType(L, System.Net.Sockets.SocketType.Rdm);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "Seqpacket"))
                {
                    translator.PushSystemNetSocketsSocketType(L, System.Net.Sockets.SocketType.Seqpacket);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "Unknown"))
                {
                    translator.PushSystemNetSocketsSocketType(L, System.Net.Sockets.SocketType.Unknown);
                }
				else
                {
                    return LuaAPI.luaL_error(L, "invalid string for System.Net.Sockets.SocketType!");
                }
            }
			
            else
            {
                return LuaAPI.luaL_error(L, "invalid lua type for System.Net.Sockets.SocketType! Expect number or string, got + " + lua_type);
            }

            return 1;
		}
	}
    
    public class SystemNetSocketsProtocolTypeWrap
    {
		public static void __Register(RealStatePtr L)
        {
		    ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
		    Utils.BeginObjectRegister(typeof(System.Net.Sockets.ProtocolType), L, translator, 0, 0, 0, 0);
			Utils.EndObjectRegister(typeof(System.Net.Sockets.ProtocolType), L, translator, null, null, null, null, null);
			
			Utils.BeginClassRegister(typeof(System.Net.Sockets.ProtocolType), L, null, 26, 0, 0);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "IP", System.Net.Sockets.ProtocolType.IP);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "IPv6HopByHopOptions", System.Net.Sockets.ProtocolType.IPv6HopByHopOptions);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "Icmp", System.Net.Sockets.ProtocolType.Icmp);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "Igmp", System.Net.Sockets.ProtocolType.Igmp);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "Ggp", System.Net.Sockets.ProtocolType.Ggp);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "IPv4", System.Net.Sockets.ProtocolType.IPv4);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "Tcp", System.Net.Sockets.ProtocolType.Tcp);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "Pup", System.Net.Sockets.ProtocolType.Pup);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "Udp", System.Net.Sockets.ProtocolType.Udp);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "Idp", System.Net.Sockets.ProtocolType.Idp);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "IPv6", System.Net.Sockets.ProtocolType.IPv6);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "IPv6RoutingHeader", System.Net.Sockets.ProtocolType.IPv6RoutingHeader);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "IPv6FragmentHeader", System.Net.Sockets.ProtocolType.IPv6FragmentHeader);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "IPSecEncapsulatingSecurityPayload", System.Net.Sockets.ProtocolType.IPSecEncapsulatingSecurityPayload);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "IPSecAuthenticationHeader", System.Net.Sockets.ProtocolType.IPSecAuthenticationHeader);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "IcmpV6", System.Net.Sockets.ProtocolType.IcmpV6);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "IPv6NoNextHeader", System.Net.Sockets.ProtocolType.IPv6NoNextHeader);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "IPv6DestinationOptions", System.Net.Sockets.ProtocolType.IPv6DestinationOptions);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "ND", System.Net.Sockets.ProtocolType.ND);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "Raw", System.Net.Sockets.ProtocolType.Raw);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "Unspecified", System.Net.Sockets.ProtocolType.Unspecified);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "Ipx", System.Net.Sockets.ProtocolType.Ipx);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "Spx", System.Net.Sockets.ProtocolType.Spx);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "SpxII", System.Net.Sockets.ProtocolType.SpxII);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "Unknown", System.Net.Sockets.ProtocolType.Unknown);
            
			Utils.RegisterFunc(L, Utils.CLS_IDX, "__CastFrom", __CastFrom);
            
            Utils.EndClassRegister(typeof(System.Net.Sockets.ProtocolType), L, translator);
        }
		
		[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int __CastFrom(RealStatePtr L)
		{
			ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			LuaTypes lua_type = LuaAPI.lua_type(L, 1);
            if (lua_type == LuaTypes.LUA_TNUMBER)
            {
                translator.PushSystemNetSocketsProtocolType(L, (System.Net.Sockets.ProtocolType)LuaAPI.xlua_tointeger(L, 1));
            }
			
            else if(lua_type == LuaTypes.LUA_TSTRING)
            {
			    if (LuaAPI.xlua_is_eq_str(L, 1, "IP"))
                {
                    translator.PushSystemNetSocketsProtocolType(L, System.Net.Sockets.ProtocolType.IP);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "IPv6HopByHopOptions"))
                {
                    translator.PushSystemNetSocketsProtocolType(L, System.Net.Sockets.ProtocolType.IPv6HopByHopOptions);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "Icmp"))
                {
                    translator.PushSystemNetSocketsProtocolType(L, System.Net.Sockets.ProtocolType.Icmp);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "Igmp"))
                {
                    translator.PushSystemNetSocketsProtocolType(L, System.Net.Sockets.ProtocolType.Igmp);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "Ggp"))
                {
                    translator.PushSystemNetSocketsProtocolType(L, System.Net.Sockets.ProtocolType.Ggp);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "IPv4"))
                {
                    translator.PushSystemNetSocketsProtocolType(L, System.Net.Sockets.ProtocolType.IPv4);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "Tcp"))
                {
                    translator.PushSystemNetSocketsProtocolType(L, System.Net.Sockets.ProtocolType.Tcp);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "Pup"))
                {
                    translator.PushSystemNetSocketsProtocolType(L, System.Net.Sockets.ProtocolType.Pup);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "Udp"))
                {
                    translator.PushSystemNetSocketsProtocolType(L, System.Net.Sockets.ProtocolType.Udp);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "Idp"))
                {
                    translator.PushSystemNetSocketsProtocolType(L, System.Net.Sockets.ProtocolType.Idp);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "IPv6"))
                {
                    translator.PushSystemNetSocketsProtocolType(L, System.Net.Sockets.ProtocolType.IPv6);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "IPv6RoutingHeader"))
                {
                    translator.PushSystemNetSocketsProtocolType(L, System.Net.Sockets.ProtocolType.IPv6RoutingHeader);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "IPv6FragmentHeader"))
                {
                    translator.PushSystemNetSocketsProtocolType(L, System.Net.Sockets.ProtocolType.IPv6FragmentHeader);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "IPSecEncapsulatingSecurityPayload"))
                {
                    translator.PushSystemNetSocketsProtocolType(L, System.Net.Sockets.ProtocolType.IPSecEncapsulatingSecurityPayload);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "IPSecAuthenticationHeader"))
                {
                    translator.PushSystemNetSocketsProtocolType(L, System.Net.Sockets.ProtocolType.IPSecAuthenticationHeader);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "IcmpV6"))
                {
                    translator.PushSystemNetSocketsProtocolType(L, System.Net.Sockets.ProtocolType.IcmpV6);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "IPv6NoNextHeader"))
                {
                    translator.PushSystemNetSocketsProtocolType(L, System.Net.Sockets.ProtocolType.IPv6NoNextHeader);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "IPv6DestinationOptions"))
                {
                    translator.PushSystemNetSocketsProtocolType(L, System.Net.Sockets.ProtocolType.IPv6DestinationOptions);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "ND"))
                {
                    translator.PushSystemNetSocketsProtocolType(L, System.Net.Sockets.ProtocolType.ND);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "Raw"))
                {
                    translator.PushSystemNetSocketsProtocolType(L, System.Net.Sockets.ProtocolType.Raw);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "Unspecified"))
                {
                    translator.PushSystemNetSocketsProtocolType(L, System.Net.Sockets.ProtocolType.Unspecified);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "Ipx"))
                {
                    translator.PushSystemNetSocketsProtocolType(L, System.Net.Sockets.ProtocolType.Ipx);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "Spx"))
                {
                    translator.PushSystemNetSocketsProtocolType(L, System.Net.Sockets.ProtocolType.Spx);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "SpxII"))
                {
                    translator.PushSystemNetSocketsProtocolType(L, System.Net.Sockets.ProtocolType.SpxII);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "Unknown"))
                {
                    translator.PushSystemNetSocketsProtocolType(L, System.Net.Sockets.ProtocolType.Unknown);
                }
				else
                {
                    return LuaAPI.luaL_error(L, "invalid string for System.Net.Sockets.ProtocolType!");
                }
            }
			
            else
            {
                return LuaAPI.luaL_error(L, "invalid lua type for System.Net.Sockets.ProtocolType! Expect number or string, got + " + lua_type);
            }

            return 1;
		}
	}
    
}