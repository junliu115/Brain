using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class VersionView : MaouView 
{
    Text text;
    string verStr = "";
    string fpsStr = "";

    float deltaTime = 0.0f;
	void Start ()
    {
        text = transform.GetComponentInChildren<Text>();
    }
    void Update()
    {
        deltaTime += (Time.deltaTime - deltaTime) * 0.1f;
        float msec = deltaTime * 1000.0f;
        float fps = 1.0f / deltaTime;
        fpsStr = string.Format("[{0:0.0} ms ({1:0.} fps)]", msec, fps);
        text.text = verStr+fpsStr;
    }
}
