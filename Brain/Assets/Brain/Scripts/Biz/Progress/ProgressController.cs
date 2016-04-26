using UnityEngine;
using System.Collections;

public class ProgressController : MaouController {
	
	public void OnShowProgressCommand(ShowProgressCommand command)
	{
		ProgressUI progressUI = GetView<ProgressUI>("Biz/Progress/ProgressPanel",true);
		if(progressUI != null){
			progressUI.Show();
			progressUI.initProgressUI();
		}
	}

	public void OnHideProgressCommand(HideProgressCommand command)
	{
		ProgressUI progressUI = GetView<ProgressUI>("Biz/Progress/ProgressPanel",false);
		if(progressUI != null)
		{
			progressUI.Hide();

		}
	}
}