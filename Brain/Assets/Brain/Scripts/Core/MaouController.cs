using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using System;
using System.Reflection;
using Maou.Core;

public class MaouController
{   
    protected T GetView<T>(string name, bool create = true)
        where T : MaouView
    {
        return (T)MaouObject.GetView(name, create);
    }
    protected MaouView GetView(string name, bool create = true)
    {
        return MaouObject.GetView(name, create);
    }
    public static void ClearSceneCallback()
    {
        Debug.Log("[ClearSceneFinish()]");
        AssetUtil.UnloadUnusedAssets();
        if(clearSceneCallback != null)
        {
            clearSceneCallback();
        }
        clearSceneCallback = null;
    }

    static Action clearSceneCallback;
    protected void ClearScene(Action callback)
    {
        if(clearSceneCallback != null)
        {
            return;
        }
		Debug.Log("[ClearSceneStart()]");
        clearSceneCallback = callback;
        Application.LoadLevel("Empty");
        //UnityEngine.SceneManagement.SceneManager.LoadScene("Empty");
    }
	
    protected virtual void Call(MaouCommand command)
    {
        MaouCore.Call(command);
    }

    public virtual void OnDestroy()
    {
        
    }
}
