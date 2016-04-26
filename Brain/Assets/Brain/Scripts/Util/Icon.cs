using UnityEngine;
using System.Collections;
using System.Net.Mime;
using UnityEngine.UI;
using System.Collections.Generic;

public class Icon : MonoBehaviour
{
     public void Load(string atlasPath, string spriteName)
	{
		GetComponent<Image>().sprite = AssetUtil.LoadSprtie (atlasPath,spriteName);
		Button button = GetComponent<Button>();
        if(button != null)
        {
			Sprite buttonImage = GetComponent<Sprite>();
			buttonImage = AssetUtil.LoadSprtie (atlasPath,spriteName);
		}
	}
	public void setSprite(string spriteName)
	{
		GetComponent<Image>().sprite = AssetUtil.getSprtie (spriteName);
        if (GetComponent<Image>().sprite == null) {
            print("判断后设置的图片为null,"+ spriteName);
        }
        //GetComponent<Image>().SetNativeSize();

    }
}
