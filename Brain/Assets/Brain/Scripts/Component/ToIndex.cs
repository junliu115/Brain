using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class ToIndex : MonoBehaviour
{
    void Start()
    {
        Application.LoadLevel("Index");
        //UnityEngine.SceneManagement.SceneManager.LoadScene("Index");
    }
}
