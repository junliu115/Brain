using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class ResultsUI : MaouView {
	public Text iqTxt;
	public Text resultTxt;
	public Image icon;
	public Image nextBtn;

    public void showSorce() {
        resultTxt.text = "问题正确个数:" + Index.totalScore.ToString();
        if (Index.type == 1)
        {
            sorceNum(9);
            setIcon("ButtonStage1");
        }
        else if (Index.type == 2)
        {
            sorceNum(6);
            setIcon("ButtonStage2");
        }
        else if (Index.type == 3)
        {
            sorceNum(6);
            setIcon("ButtonStage3");
        }
        else if (Index.type == 4)
        {
            sorceNum(9);
            setIcon("ButtonStage4");
        }
        else if (Index.type == 5)
        {
            sorceNum(6);
            setIcon("ButtonStage5");
        }
        else if (Index.type == 6)
        {
            sorceNum(7);
            setIcon("ButtonStage6");
        }
    }

	private void sorceNum(int setpSorceNum){
		int sorceNum;
		if(Index.totalScore < 10){
			sorceNum = setpSorceNum * Index.totalScore - Index.worryScore;
			iqTxt.text = "IQ:"+sorceNum.ToString();
		}else{
			sorceNum = setpSorceNum * (Index.totalScore - 1) - Index.worryScore;
			iqTxt.text = "IQ:"+sorceNum.ToString();
		}
		Index.GameScore += sorceNum;
	}

	private void setIcon(string name){
		string path = "Icon/"+name;
		Sprite sprite = Resources.Load<Sprite>(path);
		icon.sprite = sprite;
		//icon.GetComponent<Image>().sprite= sprites[0];
	}

	public void nextSence()
	{
		if (Index.step == 1f) {
			Maou.Core.MaouCore.Call (new HideResultsCommand());
			Maou.Core.MaouCore.Call (new ShowIQReportCommand ());
		} else {
			Maou.Core.MaouCore.Call(new HideResultsCommand());
			Maou.Core.MaouCore.Call (new ShowProgressCommand());
		}
	}
}
