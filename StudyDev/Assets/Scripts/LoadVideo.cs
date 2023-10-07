using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LoadVideo : MonoBehaviour, IObserver
{
    public void OnNotify()
    {
        SceneManager.LoadScene("Video");
    }
}
