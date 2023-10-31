using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class MenuController : MonoBehaviour
{
    public Button btnPlay;
    AudioManager _audioManager;
    // Start is called before the first frame update
    void Start()
    {
        _audioManager.AudioSoucerManagerment.Play();
        btnPlay.onClick.AddListener(() => Play());
    }

    void Play()
    {
        SceneManager.LoadScene("Game");
    }
}
