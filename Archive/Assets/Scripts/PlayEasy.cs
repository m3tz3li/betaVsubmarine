using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayEasy : MonoBehaviour
{
    // Start is called before the first frame update
    public void EasyMode()
    {
        SceneManager.LoadScene("EASY"); // loading the "easy" mode
    }
}
