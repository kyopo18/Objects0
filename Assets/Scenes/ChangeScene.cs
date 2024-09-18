using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class ChangeScene : MonoBehaviour
{

    [SerializeField] private Slider volumeSlider;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void ButtonCommandStart()
    {
        SceneManager.LoadScene(1);
    }

    public void ButtonCommandExit()
    {
        #if UNITY_EDITOR
            UnityEditor.EditorApplication.isPlaying = false;
        #else
            Application.Quit();
        #endif
    }

    
    public void OnVolumeChanged()
    {
        AudioListener.volume = volumeSlider.value;
        Debug.Log("Value working!");
    }

    //public void ButtonCommandRestart()
    //{
    //    SceneManager.LoadScene(SceneManager.GetActiveScene());
    //}


}
