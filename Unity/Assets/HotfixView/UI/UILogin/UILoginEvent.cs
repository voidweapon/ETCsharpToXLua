﻿using System;
using UnityEngine;

namespace ET
{
    [UIEvent(UIType.UILogin)]
    public class UILoginEvent: AUIEvent
    {
        public override async ETTask<UI> OnCreate(UIComponent uiComponent)
        {
            await ETTask.CompletedTask;
           
            ResourcesComponent.Instance.LoadBundle(UIType.UILogin.StringToAB());
           
            UnityEngine.Object bundleGameObject = ResourcesComponent.Instance.GetAsset(UIType.UILogin.StringToAB(), UIType.UILogin);
           
            GameObject gameObject = UnityEngine.Object.Instantiate(bundleGameObject) as GameObject;
            
            UI ui = EntityFactory.CreateWithParent<UI, string, GameObject>(uiComponent, UIType.UILogin, gameObject);
           
            ui.AddComponent<UILoginComponent>();
           
            return ui;
        }

        public override void OnRemove(UIComponent uiComponent)
        {
            ResourcesComponent.Instance.UnloadBundle(UIType.UILogin.StringToAB());
        }
    }
}