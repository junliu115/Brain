using UnityEngine;
using System.Collections;

public class IndexView : MaouView
{
    public void OnStartBtnClick()
    {
        Close();
		Call(new ShowProgressCommand());
    }
    public void OnProfileBtnClick()
    {
        Close();
		Call(new ShowOldIQReportCommand());
    }
	public void OnTopBtnClick()
	{
        Close();
        Call(new ShowOldIQReportCommand());
    }
}
