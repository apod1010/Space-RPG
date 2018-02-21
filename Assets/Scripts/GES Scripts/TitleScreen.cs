using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class TitleScreen : MonoBehaviour {
    public void StartbuttonClick()
    {
        SceneManager.LoadScene("3Dlevel");
    }

    public void CreditsButtonClick()
    {
        SceneManager.LoadScene("Credits");
    }
}
