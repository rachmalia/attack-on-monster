using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class ButtonFunction : MonoBehaviour {

    public void PindahScene(string scenename)
    {
        SceneManager.LoadScene(scenename);
    }
}
