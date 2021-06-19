using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using ETCold;
using UnityEngine;

namespace ET
{
    public static class LoadConfigHelper
    {
        public static void LoadAllConfigBytes(HashSet<Type> types,Dictionary<string, byte[]> output)
        {
            if (Application.isEditor)
            {
                string dirPath = "Assets/Bundles/Config/";
                foreach (var _type in types)
                {
                    string name = _type.Name;
                    string path = dirPath+name+".bytes";
                    TextAsset asset =  LoadHelper.LoadTextAsset(path); // ResourceHelper.LoadAsset<TextAsset>(path);
                    output[name] = asset.bytes;
                }
            }
            else
            {
                Dictionary<string, UnityEngine.Object> keys = ResourcesComponent.Instance.GetBundleAll("config.unity3d");
                
                var keysList = keys.Keys.ToList();
                for (int i = 0; i < keysList.Count; i++)
                {
                    TextAsset v = (TextAsset) keys[keysList[i]];
                    string key = keysList[i];
                    output[key] = v.bytes;
                }
            }
        }
    }
}