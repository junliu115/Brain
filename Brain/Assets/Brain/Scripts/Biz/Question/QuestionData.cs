using UnityEngine;
using System.Collections;


public class QuestionList
{
	public ArrayList arry = new ArrayList();
	public QuestionList ()
	{
		QuestionData question1 = new QuestionData ();
		question1.num = 7;
		question1.str = "15,13,11,9,_下一个数是什么?";

		QuestionData question2 = new QuestionData ();
		question2.num = 6;
		question2.str = "4,4,5,5,_下一个数是什么?";

		QuestionData question3 = new QuestionData ();
		question3.num = 4;
		question3.str = "2,2,3,3,_下一个数是什么?";

		QuestionData question4 = new QuestionData ();
		question4.num = 10;
		question4.str = "2,4,6,8,_下一个数是什么?";

		QuestionData question5 = new QuestionData ();
		question5.num = 60;
		question5.str = "80,75,70,65,_下一个数是什么?";

		QuestionData question6 = new QuestionData ();
		question6.num = 88;
		question6.str = "11,33,55,77,_下一个数是什么?";

		QuestionData question7 = new QuestionData ();
		question7.num = 15;
		question7.str = "3,6,9,12,_下一个数是什么?";

		QuestionData question8 = new QuestionData ();
		question8.num = 11;
		question8.str = "51,41,31,21,_下一个数是什么?";

		QuestionData question9 = new QuestionData ();
		question9.num = 0;
		question9.str = "0,2,0,2,_下一个数是什么?";

		QuestionData question10 = new QuestionData ();
		question10.num = 20;
		question10.str = "4,8,12,16,_下一个数是什么?";

		QuestionData question11 = new QuestionData ();
		question11.num = 28;
		question11.str = "12,16,20,24,_下一个数是什么?";

		QuestionData question12 = new QuestionData ();
		question12.num = 12;
		question12.str = "20,18,16,14,_下一个数是什么?";

		QuestionData question13 = new QuestionData ();
		question13.num = 23;
		question13.str = "3,8,13,18,_下一个数是什么?";
		
		QuestionData question14 = new QuestionData ();
		question14.num = 17;
		question14.str = "1,5,9,13,_下一个数是什么?";

		QuestionData question15 = new QuestionData ();
		question15.num = 21;
		question15.str = "1,6,11,16,_下一个数是什么?";

		QuestionData question16 = new QuestionData ();
		question16.num = 25;
		question16.str = "1,7,13,19,_下一个数是什么?";

		QuestionData question17 = new QuestionData ();
		question17.num = 61;
		question17.str = "21,31,41,51,_下一个数是什么?";

		QuestionData question18 = new QuestionData ();
		question18.num = 20;
		question18.str = "4,8,12,16,_下一个数是什么?";

		QuestionData question19 = new QuestionData ();
		question19.num = 25;
		question19.str = "5,10,15,20,_下一个数是什么?";

		QuestionData question20 = new QuestionData ();
		question20.num = 20;
		question20.str = "40,35,30,25,_下一个数是什么?";

		QuestionData question21 = new QuestionData ();
		question21.num = 9;
		question21.str = "15,3,12,3,_下一个数是什么?";

		QuestionData question22 = new QuestionData ();
		question22.num = 71;
		question22.str = "1,3,9,27,_下一个数是什么?";

		QuestionData question23 = new QuestionData ();
		question23.num = 1;
		question23.str = "16,8,4,2,_下一个数是什么?";

		QuestionData question24 = new QuestionData ();
		question24.num = 11;
		question24.str = "1,2,4,7,_下一个数是什么?";

		QuestionData question25 = new QuestionData ();
		question25.num = 11;
		question25.str = "1,2,4,7,_下一个数是什么?";

		QuestionData question26 = new QuestionData ();
		question26.num = 25;
		question26.str = "1,7,13,19,_下一个数是什么?";

		QuestionData question27 = new QuestionData ();
		question27.num = 16;
		question27.str = "4,7,10,13,_下一个数是什么?";

		QuestionData question28 = new QuestionData ();
		question28.num = 75;
		question28.str = "35, 45,55,65,_下一个数是什么?";

		QuestionData question29 = new QuestionData ();
		question29.num = 32;
		question29.str = "1, 2,4,8,16,_下一个数是什么?";

		QuestionData question30 = new QuestionData ();
		question30.num = 2;
		question30.str = "15,2,12,2,9,_下一个数是什么?";

		QuestionData question31 = new QuestionData ();
		question31.num = 50;
		question31.str = "10,20,30,40,_下一个数是什么?";

		QuestionData question32 = new QuestionData ();
		question32.num = 18;
		question32.str = "10,12,14,16,_下一个数是什么?";

		QuestionData question33 = new QuestionData ();
		question33.num = 15;
		question33.str = "3,6,9,12,_下一个数是什么?";

		QuestionData question34 = new QuestionData ();
		question34.num = 8;
		question34.str = "0,2,4,6,_下一个数是什么?";

		QuestionData question35 = new QuestionData ();
		question35.num = 55;
		question35.str = "11,22,33,44,_下一个数是什么?";

		QuestionData question36 = new QuestionData ();
		question36.num = 12;
		question36.str = "2,3,5,8,_下一个数是什么?";

		QuestionData question37 = new QuestionData ();
		question37.num = 27;
		question37.str = "7,10,17,20,_下一个数是什么?";

		QuestionData question38 = new QuestionData ();
		question38.num = 36;
		question38.str = "4,9,16,25,_下一个数是什么?";

		QuestionData question39 = new QuestionData ();
		question39.num = 27;
		question39.str = "11,15,19,23,_下一个数是什么?";

		QuestionData question40 = new QuestionData ();
		question40.num = 48;
		question40.str = "3,6,12,24,_下一个数是什么?";

		QuestionData question41 = new QuestionData ();
		question41.num = 25;
		question41.str = "5,10,15,20,_下一个数是什么?";

		QuestionData question42 = new QuestionData ();
		question42.num = 2;
		question42.str = "10,8,6,4,_下一个数是什么?";

		QuestionData question43 = new QuestionData ();
		question43.num = 1;
		question43.str = "9,7,5,3,_下一个数是什么?";

		QuestionData question44 = new QuestionData ();
		question44.num = 2;
		question44.str = "10,8,6,4,_下一个数是什么?";

		QuestionData question45 = new QuestionData ();
		question45.num = 40;
		question45.str = "8,16,24,32,_下一个数是什么?";

		QuestionData question46 = new QuestionData ();
		question46.num = 11;
		question46.str = "15,14,13,12,_下一个数是什么?";

		QuestionData question47 = new QuestionData ();
		question47.num = 26;
		question47.str = "38,35,32,29,_下一个数是什么?";
		
		QuestionData question48 = new QuestionData ();
		question48.num = 25;
		question48.str = "1,4,9,16,_下一个数是什么?";

		QuestionData question49 = new QuestionData ();
		question49.num = 16;
		question49.str = "4,7,10,13,_下一个数是什么?";

		QuestionData question50 = new QuestionData ();
		question50.num = 16;
		question50.str = "4,14,24,34,_下一个数是什么?";
		
		QuestionData question51 = new QuestionData ();
		question51.num = 16;
		question51.str = "4,14,24,34,_下一个数是什么?";

		QuestionData question52 = new QuestionData ();
		question52.num = 11;
		question52.str = "51,41,31,21,_下一个数是什么?";

		QuestionData question53 = new QuestionData ();
		question53.num = 0;
		question53.str = "0,2,0,4,_下一个数是什么?";

		QuestionData question54 = new QuestionData ();
		question54.num = 28;
		question54.str = "1,7,14,21,_下一个数是什么?";

		QuestionData question55 = new QuestionData ();
		question55.num = 2;
		question55.str = "2,6,2,6,_下一个数是什么?";


		arry.Add (question1);
		arry.Add (question2);
		arry.Add (question3);
		arry.Add (question4);
		arry.Add (question5);
		arry.Add (question6);
		arry.Add (question7);
		arry.Add (question8);
		arry.Add (question9);
		arry.Add (question10);
		arry.Add (question11);
		arry.Add (question12);
		arry.Add (question13);
		arry.Add (question14);
		arry.Add (question15);
		arry.Add (question16);
		arry.Add (question17);
		arry.Add (question18);
		arry.Add (question19);
		arry.Add (question20);
		arry.Add (question21);
		arry.Add (question22);
		arry.Add (question23);
		arry.Add (question24);
		arry.Add (question25);
		arry.Add (question26);
		arry.Add (question27);
		arry.Add (question28);
		arry.Add (question29);
		arry.Add (question30);
		arry.Add (question31);
		arry.Add (question32);
		arry.Add (question33);
		arry.Add (question34);
		arry.Add (question35);
		arry.Add (question36);
		arry.Add (question37);
		arry.Add (question38);
		arry.Add (question39);
		arry.Add (question40);
		arry.Add (question41);
		arry.Add (question42);
		arry.Add (question43);
		arry.Add (question44);
		arry.Add (question45);
		arry.Add (question46);
		arry.Add (question47);
		arry.Add (question48);
		arry.Add (question49);
		arry.Add (question50);
		arry.Add (question51);
		arry.Add (question52);
		arry.Add (question53);
		arry.Add (question54);
		arry.Add (question55);
	}
}

public class QuestionList5
{
	//+,-,*,/(1,2,3,4)
	public ArrayList arry5 = new ArrayList();
	public QuestionList5 ()
	{
		QuestionData question1 = new QuestionData ();
		question1.num = 1;
		question1.str = "15_13=28空格需要填什么符号?";
		
		QuestionData question2 = new QuestionData ();
		question2.num = 3;
		question2.str = "88_1=88空格需要填什么符号?";
		
		QuestionData question3 = new QuestionData ();
		question3.num = 3;
		question3.str = "22_1=22空格需要填什么符号?";
		
		QuestionData question4 = new QuestionData ();
		question4.num = 1;
		question4.str = "22_27=49空格需要填什么符号?";
		
		QuestionData question5 = new QuestionData ();
		question5.num = 3;
		question5.str = "7_8=56空格需要填什么符号?";
		
		QuestionData question6 = new QuestionData ();
		question6.num = 4;
		question6.str = "40_10=4空格需要填什么符号?";
		
		QuestionData question7 = new QuestionData ();
		question7.num = 4;
		question7.str = "35_7=5空格需要填什么符号?";
		
		QuestionData question8 = new QuestionData ();
		question8.num = 4;
		question8.str = "42_7=6空格需要填什么符号?";
		
		QuestionData question9 = new QuestionData ();
		question9.num = 3;
		question9.str = "9_9=81空格需要填什么符号?";
		
		QuestionData question10 = new QuestionData ();
		question10.num = 3;
		question10.str = "6_7=42空格需要填什么符号?";
		
		QuestionData question11 = new QuestionData ();
		question11.num = 4;
		question11.str = "35_35=1空格需要填什么符号?";
		
		QuestionData question12 = new QuestionData ();
		question12.num = 1;
		question12.str = "101_1=102空格需要填什么符号?";
		
		QuestionData question13 = new QuestionData ();
		question13.num = 1;
		question13.str = "8_9=17空格需要填什么符号?";
		
		QuestionData question14 = new QuestionData ();
		question14.num = 2;
		question14.str = "13_8=5空格需要填什么符号?";
		
		QuestionData question15 = new QuestionData ();
		question15.num = 2;
		question15.str = "23_18=5空格需要填什么符号?";
		
		QuestionData question16 = new QuestionData ();
		question16.num = 2;
		question16.str = "27_15=12空格需要填什么符号?";
		
		QuestionData question17 = new QuestionData ();
		question17.num = 2;
		question17.str = "13_7=6空格需要填什么符号?";
		
		QuestionData question18 = new QuestionData ();
		question18.num = 1;
		question18.str = "13_13=26空格需要填什么符号?";
		
		QuestionData question19 = new QuestionData ();
		question19.num = 1;
		question19.str = "33_7=40空格需要填什么符号?";
		
		arry5.Add (question1);
		arry5.Add (question2);
		arry5.Add (question3);
		arry5.Add (question4);
		arry5.Add (question5);
		arry5.Add (question6);
		arry5.Add (question7);
		arry5.Add (question8);
		arry5.Add (question9);
		arry5.Add (question10);
		arry5.Add (question11);
		arry5.Add (question12);
		arry5.Add (question13);
		arry5.Add (question14);
		arry5.Add (question15);
		arry5.Add (question16);
		arry5.Add (question17);
		arry5.Add (question18);
		arry5.Add (question19);
	}
}

public class QuestionList6
{
	//红黄蓝绿,1234
	public ArrayList arry6 = new ArrayList();
	public QuestionList6 ()
	{
		QuestionData question1 = new QuestionData ();
		question1.num = 1;
		question1.str = "红";
		
		QuestionData question2 = new QuestionData ();
		question2.num = 2;
		question2.str = "红";
		
		QuestionData question3 = new QuestionData ();
		question3.num = 3;
		question3.str = "绿";
		
		QuestionData question4 = new QuestionData ();
		question4.num = 4;
		question4.str = "蓝";
		
		QuestionData question5 = new QuestionData ();
		question5.num = 3;
		question5.str = "白";
		
		QuestionData question6 = new QuestionData ();
		question6.num = 4;
		question6.str = "白";
		
		QuestionData question7 = new QuestionData ();
		question7.num = 4;
		question7.str = "<color='red'>白</font>这个文字是什么颜色?";
		
		QuestionData question8 = new QuestionData ();
		question8.num = 4;
		question8.str = "<color='red'>白</font>这个文字是什么颜色?";
		
		QuestionData question9 = new QuestionData ();
		question9.num = 3;
		question9.str = "<color='red'>白</font>这个文字是什么颜色?";
		
		QuestionData question10 = new QuestionData ();
		question10.num = 3;
		question10.str = "<color='red'>白</font>这个文字是什么颜色?";
		
		QuestionData question11 = new QuestionData ();
		question11.num = 4;
		question11.str = "<color='red'>白</font>这个文字是什么颜色?";
		
		QuestionData question12 = new QuestionData ();
		question12.num = 1;
		question12.str = "<color='red'>白</font>这个文字是什么颜色?";
		
		QuestionData question13 = new QuestionData ();
		question13.num = 1;
		question13.str = "<color='red'>白</font>这个文字是什么颜色?";
		
		QuestionData question14 = new QuestionData ();
		question14.num = 2;
		question14.str = "<color='red'>白</font>这个文字是什么颜色?";
		
		QuestionData question15 = new QuestionData ();
		question15.num = 2;
		question15.str = "<color='red'>白</font>这个文字是什么颜色?";
		
		QuestionData question16 = new QuestionData ();
		question16.num = 2;
		question16.str = "<color='red'>白</font>这个文字是什么颜色?";
		
		QuestionData question17 = new QuestionData ();
		question17.num = 2;
		question17.str = "<color='red'>白</font>这个文字是什么颜色?";
		
		QuestionData question18 = new QuestionData ();
		question18.num = 1;
		question18.str = "<color='red'>白</font>这个文字是什么颜色?";
		
		QuestionData question19 = new QuestionData ();
		question19.num = 1;
		question19.str = "<color='red'>白</font>这个文字是什么颜色?";
		
		arry6.Add (question1);
		arry6.Add (question2);
		arry6.Add (question3);
		arry6.Add (question4);
		arry6.Add (question5);
		arry6.Add (question6);
		arry6.Add (question7);
		arry6.Add (question8);
		arry6.Add (question9);
		arry6.Add (question10);
		arry6.Add (question11);
		arry6.Add (question12);
		arry6.Add (question13);
		arry6.Add (question14);
		arry6.Add (question15);
		arry6.Add (question16);
		arry6.Add (question17);
		arry6.Add (question18);
		arry6.Add (question19);
	}
}


public class QuestionData
{
	public int num;
	public string str;
	public QuestionData ()
	{

	}
}


