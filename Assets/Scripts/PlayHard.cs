using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayHard : MonoBehaviour
{
    // Start is called before the first frame update
    public void HardMode()
    {
        SceneManager.LoadScene("HARD");// loading the "hard" mode
    }
}
