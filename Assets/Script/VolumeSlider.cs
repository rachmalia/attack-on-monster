using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class VolumeSlider : MonoBehaviour {

    public Slider Volume;
    public AudioSource myMusic;
    void Start()
    {
        DontDestroyOnLoad(gameObject);
    }
	// Update is called once per frame
	void Update () {
        myMusic.volume = Volume.value;
	}
}
