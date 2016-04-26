using UnityEngine;
using System.Collections;

public class IQReportCommand: MaouCommand {
	public override System.Type GetController()
	{
		return typeof(IQReportController);
	}
}

public class ShowOldIQReportCommand:IQReportCommand{
		
}

public class ShowIQReportCommand:IQReportCommand{
	
}

public class HideIQReportCommand:IQReportCommand{
	
}