using UnityEngine;
using UnityEngine.UI;

public class MaouView: MaouObject
{
	/// <summary>
	/// 创建时自动填充
	/// </summary>
	[HideInInspector]
	public string viewName;
	
	/// <summary>
	/// 是否正在显示,自动填充
	/// </summary>
	[HideInInspector]
	public bool isShowing;
	
	[HideInInspector]
	public bool destroyed;
	
	public bool isWidget;
	
	public LayerTarget layerType = LayerTarget.View;
	public virtual void OnShow()
	{
		gameObject.SetActive(true);
	}
	
	public virtual void OnHide()
	{
		gameObject.SetActive(false);
	}
	
	public virtual void Show()
	{
		ShowView(viewName);
	}
	
	public virtual void Hide()
	{
		HideView(viewName);
	}
	
	public virtual void Close()
	{
		CloseView(viewName);
	}
	
	public virtual void OnDestroy()
	{
		
	}
}