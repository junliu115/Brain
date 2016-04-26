using UnityEngine;
using System.Collections;
using System;

public class MaouModel
{
    public delegate void DataUpdateEventHandler();

    private event DataUpdateEventHandler _onDataUpdate;
    public event DataUpdateEventHandler OnDataUpdate
    {
        add
        {
            //no multi-thread, no need to consider thread-safe
            _onDataUpdate -= value;
            _onDataUpdate += value;
        }
        remove
        {
            _onDataUpdate -= value;
        }
    }

    public void RaiseDataUpdateEvent()
    {
        if (_onDataUpdate != null)
        {
            Delegate[] list = _onDataUpdate.GetInvocationList();
            foreach (Delegate d in list)
            {
                //UnityEngine.Debug.Log((d.Target as ShareMenuView).name);
                //if(d.Target != null && d.Target.ToString() == "null")
                if((d.Target is UnityEngine.Object) && (d.Target as UnityEngine.Object) == null)
                {
                    //Debug.Log("OnDataUpdate-=");
                    //Debug.Log((DataUpdateEventHandler)d);
                    OnDataUpdate -= (DataUpdateEventHandler)d;
                }
            }
            if (_onDataUpdate != null)
            {
                _onDataUpdate();
            }
        }
    }
}