using UnityEngine;
using System.Collections;

public class IQReportController : MaouController {
	
	public void OnShowIQReportCommand(ShowIQReportCommand command)
	{
		IQReportUI iQReportUI = GetView<IQReportUI>("Biz/IQReport/IQReportPanel",true);
		if(iQReportUI != null){
			iQReportUI.Show();
			iQReportUI.ptjs();
		}
	}

	public void OnShowOldIQReportCommand(ShowOldIQReportCommand command)
	{
		IQReportUI iQReportUI = GetView<IQReportUI>("Biz/IQReport/IQReportPanel",true);
		if(iQReportUI != null){
			iQReportUI.Show();
			iQReportUI.OldGameScore();
		}
	}

	public void OnHideIQReportCommand(HideIQReportCommand command)
	{
		IQReportUI iQReportUI = GetView<IQReportUI>("Biz/IQReport/IQReportPanel",false);
		if(iQReportUI != null)
		{
			iQReportUI.Hide();
		}
	}
}