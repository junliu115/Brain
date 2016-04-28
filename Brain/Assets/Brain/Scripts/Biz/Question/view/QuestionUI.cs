using UnityEngine;
using System.Collections;
using UnityEngine.UI;//
using System.Collections.Generic;
using System.Xml;

public class QuestionUI : MaouView {
	public Image[] images;
	public Text[] texts;
	public Image yesImage;
	public Image noImage;
    public Image chooseImage;
	public Text resulttxt;
	public Text txt;
	private Icon imageicon;
	public Text timeTxt;
	private int rightAnswer;
	private Dictionary<int,Image> imageDic;
	private int time;
	private int score;
	void Start () {
		reStart ();
	}
	IEnumerator TimeDown()
	{
		while (time > 0) {
			yield return new WaitForSeconds(1);//函数内部等待1秒
			time -= 1000;
		}
	}

	void Update (){
		if (time == int.MaxValue) 
		{
			return;
		}
		time -= (int)(Time.deltaTime * 100);
		timeTxt.text = "时间:" + time;
		if (time < 0) {
			time = int.MaxValue;
			Maou.Core.MaouCore.Call(new ShowResultsCommand());//时间到切入下个画面
		}
	}

	private bool waitCheak;
	private int nowQuestion;
	public void CheakAnswer(int num){
		if(waitCheak){
			return;
		}
        Image tmpImage = images[num];
        chooseImage.gameObject.SetActive(true);
        chooseImage.transform.position = tmpImage.transform.position;
        if (num == rightAnswer){
			score ++;
			Index.totalScore = score;
			resulttxt.text = "正确:"+score.ToString();
			yesImage.gameObject.SetActive (true);
        }
        else{
			noImage.gameObject.SetActive (true);
			Index.worryScore ++; 
		}
		nowQuestion ++;
		waitCheak = true;
		StartCoroutine (next ());//携程
	}

	IEnumerator next()
	{
		yield return new WaitForSeconds(0.3f);//函数内部等待
		if(nowQuestion > 20){//答多少题
			Maou.Core.MaouCore.Call(new ShowResultsCommand());
		}else{
			NextQuestion ();
		}
	}

	private void reset()
	{
        chooseImage.gameObject.SetActive(false);
        yesImage.gameObject.SetActive (false);
		noImage.gameObject.SetActive (false);
		waitCheak = false;
		for (int i=0; i<4; i++) {
			Image tmpImage = images [i];
			tmpImage.gameObject.transform.localScale = new Vector3 (1, 1, 1);
			tmpImage.gameObject.transform.eulerAngles = new Vector3(0,0,0);
			Text tmpText = texts[i];
			tmpText.text = "";
			txt.fontSize = 60;
		}
        
	}


	public void reStart(){
		time = 2000;
		score = 0;
		resulttxt.text = "正确:"+score.ToString();
		nowQuestion = 0;
		NextQuestion ();
	}

	private ArrayList arry;
	private int rightLei;
	private ArrayList arryNumList;
	public void NextQuestion(){
        reset ();
		Index.type = 4;
        if (Index.type == 1) {
			txt.text = "选出不同类型的物品?";
			rightAnswer = Random.Range (0, 4);
			rightLei = Random.Range (1, 9);
			arry = new ArrayList ();//存着目前有的答案；
			for (int i=0; i<4; i++) {
				Image tmpImage = images [i];
				imageicon = tmpImage.GetComponent<Icon> ();
				if (rightAnswer == i) {
					imageicon.setSprite (wrongItem(rightLei));
				} else {
                    int num;
                    string itemName;
                    do
                    {
                        num = Random.Range(0, 13);
                        itemName = "GraphicItem" + rightLei + "_" + num;
                    } while (arry.IndexOf(num) != -1 || AssetUtil.getSprtie(itemName) == null);
                    arry.Add (num);
					imageicon.setSprite (itemName);
                }
			}
		} else if (Index.type == 2) {
			txt.text = "选出方向不同的物品?";
			rightAnswer = Random.Range (0, 4);
			rightLei = Random.Range (0, 4);
			arryNumList = new ArrayList ();
			arryNumList.Add ("4");
            arryNumList.Add ("6");
            arryNumList.Add ("7");
			arryNumList.Add ("8");
            string itemName;
            int num;
            do
            {
                num = Random.Range(0, 13);
                itemName = "GraphicItem" + arryNumList[rightLei] + "_" + num;
            } while (AssetUtil.getSprtie(itemName) == null);
            for (int i=0; i<4; i++) {
				Image tmpImage = images [i];
				imageicon = tmpImage.GetComponent<Icon> ();
                imageicon.setSprite (itemName);
                if (rightAnswer == i) {
					tmpImage.gameObject.transform.localScale = new Vector3 (-1, 1, 1);
				} else {
					tmpImage.gameObject.transform.localScale = new Vector3 (1, 1, 1);
					int numAngles = Random.Range (-15, 15);
					tmpImage.gameObject.transform.eulerAngles = new Vector3 (0, 0, numAngles);
				}
			}
		} else if (Index.type == 3) {
			txt.text = "选出骰子数最大的?";
			int num;
			int oldnum = 0;
			rightLei = Random.Range (1, 3);
			arry = new ArrayList ();
			for (int i=0; i<4; i++) {
				num = Random.Range (1, 12);	
				while (arry.IndexOf(num)!=-1) {
					num = Random.Range (1, 12);
				}
				arry.Add (num);
				Image tmpImage = images [i];
				imageicon = tmpImage.GetComponent<Icon> ();
				string str = "GraphicDice" + rightLei + "_" + num;
				imageicon.setSprite (str);
				if (num > oldnum) {
					oldnum = num;
					rightAnswer = i;
				}
			}
		} else if (Index.type == 4) {
            int num;
			arry = new ArrayList ();
            ArrayList questionList = AssetUtil.questionDataList["1"];
            int questionNum = Random.Range (0, questionList.Count);
			QuestionData questionData = (QuestionData)questionList [questionNum];
			txt.text = questionData.str;
			arry.Add (questionData.num);
			rightAnswer = Random.Range (0, 4);
			for (int i=0; i<4; i++) {
				Image tmpImage = images [i];
				Text tmpText = texts [i];
				imageicon = tmpImage.GetComponent<Icon> ();
				imageicon.setSprite ("nullnum");
				if (i == rightAnswer) {
					tmpText.text = questionData.num.ToString ();
				} else {
					num = Random.Range (1, 99);
					while (arry.IndexOf(num)!=-1) {
						num = Random.Range (1, 99);
					}
					tmpText.text = num.ToString ();
					arry.Add (num);
				}
			}
		} else if (Index.type == 5) {
            
           // AssetUtil.xmlData;

            txt.text = "选择正确的数字符号?";
			int num;
			arry = new ArrayList ();
            ArrayList questionList = AssetUtil.questionDataList["2"];
            int questionNum = Random.Range (0, questionList.Count);
			QuestionData questionData = (QuestionData)questionList[questionNum];
			txt.text = questionData.str;
			arry.Add (questionData.num);
			rightAnswer = Random.Range (0, 4);
			for (int i=0; i<4; i++) {
				Image tmpImage = images [i];
				imageicon = tmpImage.GetComponent<Icon> ();
				if (i == rightAnswer) {
					imageicon.setSprite ("ButtonAnswer" + questionData.num.ToString ());
				} else {
					num = Random.Range (1, 5);
					while (arry.IndexOf(num)!= -1) {
						num = Random.Range (1, 5);
					}
					imageicon.setSprite ("ButtonAnswer" + num.ToString ());
					arry.Add (num);
				}
			}
		} else if (Index.type == 6) {
			arry = new ArrayList ();
			rightAnswer = Random.Range (0, 4); //随机一个正确的答案
			int showcolor = Random.Range (0, 4);//随机一个颜色文字,用于干扰
			string[] textArr = new string[] {"红","黄","蓝","绿"};//所有的颜色文字
			int rightColor = Random.Range (0, 4);//随机一个正确颜色
			Color[] textColor = new Color[] {Color.red,Color.yellow,Color.blue,Color.green};//所有颜色
			txt.text = textArr[showcolor];
			txt.fontSize = 120;
			txt.color = textColor[rightColor];
			ArrayList tmpArr = new ArrayList(textArr);
			tmpArr.Remove(textArr[rightColor]);
			for (int i=0; i<4; i++) {
				Image tmpImage = images [i];
				imageicon = tmpImage.GetComponent<Icon> ();
				Text tmpText = texts [i];
				if (i == rightAnswer) {
					tmpText.text = textArr[rightColor];
				} else {
					tmpText.text = tmpArr[0] as string;
					tmpArr.RemoveAt(0);
				}
				imageicon.setSprite ("nullnum");
			}
		}
	}

	private string wrongItem(int rightType){
        int num;
        int type;
        string str;
        do
        {
          num = Random.Range(0, 13);
          type = Random.Range(1, 9);
          str = "GraphicItem" + type + "_" + num;
        }
        while (type == rightType || AssetUtil.getSprtie(str) == null);
		return str;
	}
}
