using UnityEngine;
using System.Collections;

public class SceneClearScript : MonoBehaviour
{
    void Start()
    {
        MaouController.ClearSceneCallback();
        Destroy(this.gameObject);
    }
}
