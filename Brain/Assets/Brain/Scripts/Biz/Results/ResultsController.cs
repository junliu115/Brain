using UnityEngine;
using System.Collections;

public class ResultsController : MaouController {
	
	public void OnShowResultsCommand(ShowResultsCommand command)
	{
		ResultsUI resultsUI = GetView<ResultsUI>("Biz/Results/ResultsPanel",true);
		if(resultsUI != null){
			resultsUI.Show();
		}
	}

	public void OnHideResultsCommand(HideResultsCommand command)
	{
		ResultsUI resultsUI = GetView<ResultsUI>("Biz/Results/ResultsPanel",false);
		if(resultsUI != null)
		{
			resultsUI.Hide();
		}
	}
}