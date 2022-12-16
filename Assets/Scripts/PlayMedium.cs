using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayMedium : MonoBehaviour
{
    // Start is called before the first frame update
    public void MediumMode()
    {
        SceneManager.LoadScene("MEDIUM");// loading the "medium" mode
    }
}
