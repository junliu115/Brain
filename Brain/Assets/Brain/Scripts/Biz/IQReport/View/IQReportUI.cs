using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class IQReportUI : MaouView {
	public Text iqScore;
	public Text dialogue;
	public Image icon;
	public Image indexBtn;
	// Use this for initialization
	void Start () {
		//System.IO.File.WriteAllText(Application.temporaryCachePath+"/config.txt",Index.GameScore.ToString);
		//System.IO.File.ReadAllText ();
	}

	public void ptjs(){
		showMsg(Index.GameScore);
		int GetGAMESCORE = PlayerPrefs.GetInt("_GAMESCORE");
		if (GetGAMESCORE < Index.GameScore) {
			PlayerPrefs.SetInt("_GAMESCORE",Index.GameScore);
		}
	}

	private void showMsg(int scoreNum){
		iqScore.text = scoreNum.ToString ();
		if(scoreNum >= 160){
			dialogue.text = "外星人!";
			setIcon ("GraphicResult6");
		}else if(scoreNum >= 150){
			dialogue.text = "你根本不是人类!";
			setIcon ("GraphicResult6");
		}else if(scoreNum >= 140){
			dialogue.text = "很好,难以置信的厉害!";
			setIcon ("GraphicResult6");
		}else if(scoreNum >= 130){
			dialogue.text = "你相当出色,棒极了!";
			setIcon ("GraphicResult5");
		}else if(scoreNum >= 120){
			dialogue.text = "小朋友,要自己思考,不要老叫父母帮你!";
			setIcon ("GraphicResult4");
		}else if(scoreNum >= 110){
			dialogue.text = "你很少使用你的大脑吧!";
			setIcon ("GraphicResult3");
		}else if(scoreNum >= 100){
			dialogue.text = "你确定你是认真的嘛?";
			setIcon ("GraphicResult2");
		}else if(scoreNum >= 90){
			dialogue.text = "为什么把大脑丢了?";
			setIcon ("GraphicResult2");
		}else if(scoreNum >= 80){
			dialogue.text = "太可惜了你是如此愚蠢!";
			setIcon ("GraphicResult1");
		}else if(scoreNum < 80){
			dialogue.text = "太可怕了你竟然没有大脑!";
			setIcon ("GraphicResult1");
		}
	}

	public void OldGameScore()
	{
		int GetGAMESCORE = PlayerPrefs.GetInt("_GAMESCORE");
		showMsg(GetGAMESCORE);
	}

	private void setIcon(string name){
		//string path = "Icon/Commodity";
		string path = "Icon/"+name;
		Sprite sprite = Resources.Load<Sprite>(path);
		Debug.Log (sprite);
		icon.sprite = sprite;
		//icon.GetComponent<Image>().sprite= sprites[0];
	}
	public void returnIndex()
	{
		Index.GameScore = 0;
		Index.typearry = new ArrayList ();//清空list;
		Index.step = 0f;
		Maou.Core.MaouCore.Call(new HideIQReportCommand());
		Call(new ShowIndexViewCommand());
	}
	// Update is called once per frame
	void Update () {
	
	}
}
