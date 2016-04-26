using UnityEngine;
using UnityEngine.UI;
using System;
using System.Collections;
using System.Collections.Generic;
using Maou.Core;

public enum LayerTarget 
{
    View,//普通UI
    Dialog,//弹出UI
    Loading,//loading
    Alert,//Alert
    Tip,//弱提示UI
    System,//系统级UI(fps显示,debug界面)
    Mutex//禁止操作层
}
public enum ScaleType
{
    None,
    WidthFix
}
public class MaouObject:MonoBehaviour
{  
    public ScaleType scaleType = ScaleType.WidthFix;
    protected void Call(MaouCommand command)
    {
        MaouCore.Call(command);
    }
	
    private static Dictionary<string,MaouView> viewDic = new Dictionary<string, MaouView>();
    private static List<string> viewHistory = new List<string>();
    private static string currentViewName;
    private static Canvas root;
    private static Dictionary<LayerTarget,Transform> layerDic = new Dictionary<LayerTarget, Transform>();

           
    public static MaouView GetView(string name, bool create)
    {
        if(string.IsNullOrEmpty(name) && !string.IsNullOrEmpty(currentViewName))
        {
            return GetView(currentViewName,false);
        }
        if (!HasView(name))
        {
            if (!create)
            {
                return null;
            }
            CheckRoot();
            GameObject prefab = AssetUtil.Load<GameObject>(name);
            MaouView viewObj = ((GameObject)GameObject.Instantiate(prefab)).GetComponent<MaouView>();
            viewObj.gameObject.SetActive(false);
            viewObj.transform.SetParent(layerDic[viewObj.layerType],false);
            viewDic [name] = viewObj;
            viewObj.viewName = name;
            ContentScaler scaler = viewObj.gameObject.GetComponent<ContentScaler>();
            if(scaler == null)
            {
                scaler = viewObj.gameObject.AddComponent<ContentScaler>();
            }
            scaler.scaleType = viewObj.scaleType;
        }
        return viewDic [name];
    }
    
    protected static bool HasView(string name)
    {
        return viewDic.ContainsKey(name);
    }
    
    protected static MaouView ShowView(string name)
    {
        //LogUtil.Log("[ShowView(name=" + name + ")]");
        //显示窗口
        MaouView viewObj = GetView(name, false);
        if(viewObj.isShowing)
        {
            return viewObj;
        }
        if(!viewObj.isWidget)
        {
            if(currentViewName != null)
            {
                HideView(currentViewName);
                AddHistory(currentViewName);
            }
            currentViewName = name;
        }
        viewObj.isShowing = true;
        viewObj.OnShow();
        return viewObj;
    }
    
    protected static void HideView(string name)
    {
        if (!HasView(name))
        {
            return;
        }
        //LogUtil.Log("[HideView(name=" + name + ")]");
        MaouView viewObj = GetView(name, false);
        if(viewObj != null)
        {
            if(!viewObj.isShowing)
            {
                return;
            }
            viewObj.isShowing = false;
            viewObj.OnHide();
        }
    }
    
    protected static void CloseView(string name)
    {
        if (!HasView(name))
        {
            return;
        }
        HideView(name);
        //LogUtil.Log("[CloseView(name=" + name + ")]");
        MaouView viewObj = GetView(name, false);
        bool isWidget = false;
        if(viewObj != null)
        {
            isWidget = viewObj.isWidget;
            viewObj.OnDestroy();
            viewObj.destroyed = true;
            GameObject.Destroy(viewObj.gameObject);
        }
        viewDic.Remove(name);
        if(!isWidget)
        {
            RemoveHistory(name);
            if(name == currentViewName)
            {
                currentViewName = null;
                OpenPreView();
            }
        }
    }
    protected static void OpenPreView()
    {
        if(viewHistory.Count > 0)
        {
            string name = viewHistory[viewHistory.Count-1];
            RemoveHistory(name);
            ShowView(name);
        }
    }
    protected static void AddHistory(string name)
    {
        RemoveHistory(name);
        viewHistory.Add(name);
    }
    protected static void RemoveHistory(string name)
    {
        while(viewHistory.Contains(name))
        {
            viewHistory.Remove(name);
        }
    }
    
    
    public static void RemoveAll()
    {
		Debug.Log("[RemoveAll()]");
        RemoveAllView();
    }
    
    /// <summary>
    /// 删除所以root/camera下的子对象
    /// </summary>
    static void RemoveAllView()
    {
        currentViewName = null;
        viewHistory.Clear();
        viewDic.Clear();
    }
    
    /// <summary>
    /// 检查Root是否存在，不存在即创建
    /// </summary>
    protected static void CheckRoot()
    {
        if (root == null || (root as UnityEngine.Object) == null || (root.gameObject as UnityEngine.Object) == null)
        {
            GameObject rootPrefab = AssetUtil.Load<GameObject>("Common/UI");
            GameObject layerPrefab = AssetUtil.Load<GameObject>("Common/Layer");
            root = GameObject.Instantiate(rootPrefab).GetComponent<Canvas>();
            DontDestroyOnLoad(root);
            layerDic.Clear();
            LayerTarget[] layers = new LayerTarget[]{LayerTarget.View,LayerTarget.Dialog,LayerTarget.Loading,LayerTarget.Alert,LayerTarget.Tip,LayerTarget.System,LayerTarget.Mutex};
            foreach(LayerTarget layer in layers)
            {
                GameObject layerObj = GameObject.Instantiate(layerPrefab);
                layerObj.transform.SetParent(root.transform,false);
                layerObj.name = layer.ToString();
                layerDic[layer] = layerObj.transform;
            }
            GetView("Biz/Index/VersionView",true).Show();
        }
    }
}