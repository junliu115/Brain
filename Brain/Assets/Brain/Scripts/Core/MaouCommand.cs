using UnityEngine;
using System;
using System.Collections;

public class MaouCommand
{
    public virtual Type GetController()
    {
        throw new Exception("GetController need override!!!");
    }
    public virtual bool NeedShowLoading()
    {
        return false;
    }
    public virtual bool AutoCloseLoading()
    {
        return true;
    }
    public virtual string[] GetResources()
    {
        return new string[0];
    }
}