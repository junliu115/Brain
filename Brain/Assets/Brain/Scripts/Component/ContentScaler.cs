using UnityEngine;
using System.Collections;

public class ContentScaler : MonoBehaviour 
{
    static float UI_WIDTH = 1280f;
    static float UI_HEIGHT = 720f;



    public ScaleType scaleType = ScaleType.None;

    private float scale = 1f;
    public float Scale
    {
        get
        {
            return scale;
        }
    }

    void Start()
    {
        FixScale();
    }

    public void FixScale()
    {
        float rootScale = (float)Screen.height / UI_HEIGHT;
        float widthScale = (float)Screen.width / UI_WIDTH;

        switch(scaleType)
        {
            case ScaleType.WidthFix:
                this.scale = widthScale/rootScale;
                break;
            default:
                this.scale = 1;
                break;
        }
        GetComponent<RectTransform>().localScale = new Vector3(Scale, Scale, 1);
    }
}