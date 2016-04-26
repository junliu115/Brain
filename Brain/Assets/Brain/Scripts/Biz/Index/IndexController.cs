using UnityEngine;
using System.Collections;

public class IndexController : MaouController
{
    public void OnShowIndexViewCommand(ShowIndexViewCommand command)
    {
        GetView<IndexView>("Biz/Index/IndexView",true).Show();
	}
}
