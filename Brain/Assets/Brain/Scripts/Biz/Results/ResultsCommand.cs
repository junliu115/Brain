using UnityEngine;
using System.Collections;

public class ResultsCommand: MaouCommand {
	public override System.Type GetController()
	{
		return typeof(ResultsController);
	}
}

public class ShowResultsCommand:ResultsCommand{
	
}

public class HideResultsCommand:ResultsCommand{
	
}