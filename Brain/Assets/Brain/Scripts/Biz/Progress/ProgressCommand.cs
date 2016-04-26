using UnityEngine;
using System.Collections;

public class ProgressCommand: MaouCommand {
	public override System.Type GetController()
	{
		return typeof(ProgressController);
	}
}

public class ShowProgressCommand:ProgressCommand{
		
}

public class HideProgressCommand:ProgressCommand{

}