using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using Maou.Core;
using System.Xml;
using System;

public class AssetUtil
{
	    
	static Dictionary<string, UnityEngine.Object> preObjs = new Dictionary<string, UnityEngine.Object>();
    static XmlNodeList xmlNodeList;

    static public Dictionary<string, ArrayList> questionDataList = new Dictionary<string, ArrayList>();

    static public GameObject Create(string path)
    {
        GameObject prefab = Load<GameObject>(path);
        if(prefab != null)
        {
            return GameObject.Instantiate(prefab);
        }
        return null;
    }

    static public void LoadXmlData(string path) {
        TextAsset textAssets = (TextAsset)Resources.Load(path, typeof(TextAsset));
        XmlDocument xmlData = new XmlDocument();
        xmlData.LoadXml(textAssets.text);
        xmlNodeList = xmlData.SelectSingleNode("QuestionData").ChildNodes;
        foreach (XmlElement xmlNode in xmlNodeList)
        {
            ArrayList arrayList = new ArrayList();
            foreach (XmlElement xmlNodeChild in xmlNode.ChildNodes)
            {
                QuestionData questionData = new QuestionData();
                questionData.num = int.Parse(xmlNodeChild.GetAttribute("answer"));
                questionData.str = xmlNodeChild.InnerText;
                arrayList.Add(questionData);
            }
            questionDataList.Add(xmlNode.GetAttribute("id"), arrayList);
        }
    }

    static public XmlNodeList GetxmlNodeList() {

        
        return xmlNodeList;
    }
    
    static public UnityEngine.Object Load(string path)
    {
        return Load<UnityEngine.Object>(path);
    }

    static public T Load<T>(string path)
        where T : UnityEngine.Object
    {

        if(preObjs.ContainsKey(path))
        {
            Debug.LogWarning("[AssetUtil][Cache(path="+path+")");
            return (T) preObjs[path];
        }
        T obj = Resources.Load<T>(path);
        if(obj != null)
        {
            preObjs[path] = obj;
        }
        return obj;
    }
	
	static public Sprite LoadSprtie(string path,string spritename)
	{
		Sprite[] sprites = Resources.LoadAll<Sprite> (path);
		for(int i = 0;i<sprites.Length;i++)
		{
			Sprite sprite = (Sprite)sprites[i];
			preObjs[sprite.name] = sprite;
		}
		return (Sprite)preObjs[spritename];
	}

	static public void LoadAllSprtie(string path)
	{
		Sprite[] sprites = Resources.LoadAll<Sprite> (path);
		for(int i = 0;i<sprites.Length;i++)
		{
			Sprite sprite = (Sprite)sprites[i];
			preObjs[sprite.name] = sprite;
		}
	}

	static public Sprite getSprtie(string spritename)
	{
		Sprite sprite = null;
		if (preObjs.ContainsKey (spritename)) {
			sprite = (Sprite)preObjs [spritename];
		} else {
			//Debug.Log("找不到图片:"+spritename);
		}
		return sprite;
	}

	static public void ClearPreObject()
    {
        preObjs.Clear();
        UnloadUnusedAssets();
    }

	static public AsyncOperation UnloadUnusedAssets()
	{
		return Resources.UnloadUnusedAssets();
	}
}