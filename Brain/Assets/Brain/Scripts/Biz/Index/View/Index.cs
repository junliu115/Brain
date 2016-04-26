using UnityEngine;
using System.Collections;

public class Index : MonoBehaviour
{
	public static int totalScore;
	public static int worryScore;
	public static int GameScore;
	public static float step;
	public static int type = 1;
	public static ArrayList typearry = new ArrayList ();
	void Start()
    {	
		//设置帧率
        Application.targetFrameRate = 30;
		//初始化游戏数据
		initGameData ();
        //首次启动框架
        Maou.Core.MaouCore.Call(new ShowIndexViewCommand());
    }
	public void initGameData()
	{
		totalScore = 0;
		worryScore = 0;
		step = 0f;
		LoadAllItem ();
	}

	public void LoadAllItem()
	{
		AssetUtil.LoadAllSprtie ("Icon/GraphicItem1");
        AssetUtil.LoadAllSprtie ("Icon/GraphicItem2");
        AssetUtil.LoadAllSprtie ("Icon/GraphicItem3");
        AssetUtil.LoadAllSprtie ("Icon/GraphicItem4");
		AssetUtil.LoadAllSprtie ("Icon/GraphicItem5");
		AssetUtil.LoadAllSprtie ("Icon/GraphicItem6");
		AssetUtil.LoadAllSprtie ("Icon/GraphicItem7");
        AssetUtil.LoadAllSprtie ("Icon/GraphicItem8");

        AssetUtil.LoadAllSprtie ("Icon/GraphicDice1");

		AssetUtil.LoadAllSprtie ("Icon/num");
		AssetUtil.LoadAllSprtie ("Icon/nullnum");
		AssetUtil.LoadAllSprtie ("Icon/answer");

		AssetUtil.LoadAllSprtie ("Icon/ButtonAnswer1");
		AssetUtil.LoadAllSprtie ("Icon/ButtonAnswer2");
		AssetUtil.LoadAllSprtie ("Icon/ButtonAnswer3");
		AssetUtil.LoadAllSprtie ("Icon/ButtonAnswer4");
	}
}