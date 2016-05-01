using UnityEngine;
using System.Collections;

public class QuestionController : MaouController {
	
	public void OnShowQuestiionCommand(ShowQuestiionCommand command)
	{
		//GetView ("Biz/Question/QuestionPanel").Show ();
		QuestionUI questionUI = GetView<QuestionUI>("Biz/Question/QuestionPanel",true);
		if(questionUI != null){
			questionUI.Show();
		}
	}

	public void OnHideQuestiionCommand(HideQuestiionCommand command)
	{
		QuestionUI questionUI = GetView<QuestionUI>("Biz/Question/QuestionPanel",false);
		if(questionUI != null)
		{
			questionUI.Hide();
		}
	}

	public void OnNextQuestionCommand(NextQuestionCommand command)
	{
		QuestionUI questionUI = GetView<QuestionUI>("Biz/Question/QuestionPanel",false);
		if(questionUI != null)
		{
			questionUI.NextQuestion();
		}
	}

	public void OnRestStartCommand(RestStartCommand command)
	{
		QuestionUI questionUI = GetView<QuestionUI>("Biz/Question/QuestionPanel",false);
		if(questionUI != null)
		{
			questionUI.reStart();
		}
	}
}
