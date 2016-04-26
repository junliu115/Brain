using UnityEngine;
using System.Collections;

public class QuestiionCommand : MaouCommand {
	public override System.Type GetController()
	{
		return typeof(QuestionController);
	}
}

public class ShowQuestiionCommand : QuestiionCommand {
	
}

public class HideQuestiionCommand : QuestiionCommand {

}

public class NextQuestionCommand : QuestiionCommand {
	
}

public class RestStartCommand : QuestiionCommand{
		

}