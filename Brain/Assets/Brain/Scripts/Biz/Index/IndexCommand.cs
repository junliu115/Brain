using UnityEngine;
using System.Collections;

public class IndexCommand : MaouCommand
{
    public override System.Type GetController()
    {
        return typeof(IndexController);
    }
}
public class ShowIndexViewCommand : IndexCommand
{

}

public class HideIndexViewCommand : IndexCommand
{
	
}

public class InitGameDataCommand : IndexCommand
{
	
}