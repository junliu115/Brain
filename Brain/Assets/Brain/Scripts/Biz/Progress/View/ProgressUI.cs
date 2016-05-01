using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class ProgressUI : MaouView {
	public Text infoTxt;
	public Image icon;
	public Image nextBtn;
	public Image progressImage;

	// Use this for initialization
	void Start () {

	}

	public void initProgressUI()
	{
		setProgressImage ();
		Index.type = Random.Range(1,6);
		while(Index.typearry.IndexOf(Index.type)!=-1)
		{
			Index.type = Random.Range(1,6);
		}
		Index.typearry.Add (Index.type);
		if(Index.type == 1){
			infoTxt.text = "选出不同类型的物品?";
			setIcon ("ButtonStage1");
		}else if(Index.type == 2){
			infoTxt.text = "选出方向不同的物品?";
			setIcon ("ButtonStage2");
		}else if(Index.type == 3){
			infoTxt.text = "选出骰子数最大的?";
			setIcon ("ButtonStage3");
		}else if(Index.type == 4){
			infoTxt.text = "选出接下去应该出现的数字?";
			setIcon ("ButtonStage4");	
		}else if(Index.type == 5){
			infoTxt.text = "选择正确的数字符号?";
			setIcon ("ButtonStage5");	
		}else if(Index.type == 6){
			infoTxt.text = "文字是什么颜色?";
			setIcon ("ButtonStage6");	
		}
	}

	private void setProgressImage()
	{
		Index.step = Index.step +0.25f;
		progressImage.fillAmount = Index.step;
	}

	private void setIcon(string name){
		//string path = "Icon/Commodity";
		string path = "Icon/"+name;
		Sprite sprite = Resources.Load<Sprite>(path);
		//Debug.Log (sprite);
		icon.sprite = sprite;
		//icon.GetComponent<Image>().sprite= sprites[0];
	}
	public void nextSence()
	{
		Maou.Core.MaouCore.Call(new HideProgressCommand());
		Maou.Core.MaouCore.Call (new ShowQuestiionCommand ());
		Maou.Core.MaouCore.Call (new RestStartCommand());
	}
	// Update is called once per frame
	void Update () {
	
	}
}
