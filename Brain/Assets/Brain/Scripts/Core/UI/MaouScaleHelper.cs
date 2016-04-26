using UnityEngine;
using System.Collections;

public class MaouScaleHelper : MonoBehaviour
{
    private int width;
    private int height;
    void Start()
    {
        this.width = Screen.width;
        this.height = Screen.height;
    }

    void Update()
    {
        if(this.width != Screen.width || this.height != Screen.height)
        {
            this.width = Screen.width;
            this.height = Screen.height;
			Debug.Log("[MaouScale(width="+this.width+",height="+this.height+")]");
            ContentScaler[] scalers = GetComponentsInChildren<ContentScaler>();
            foreach(ContentScaler scaler in scalers)
            {
                scaler.FixScale();
            }
        }
    
    }
}
