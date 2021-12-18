using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuPage : MonoBehaviour
{
    // Start is called before the first frame update
    public void LoadLevel(string name)
    {
        SceneManager.LoadScene(name);
    }

    // Update is called once per frame
    public void Quit()
    {
        Application.Quit();
    }
}