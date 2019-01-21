using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Menu_Controller : MonoBehaviour {

    public Button Play_Button;
    public Button Quit_Button;

    public void Play_Game()
    {
        SceneManager.LoadScene(1);
    }

    public void Quit_Game()
    {

        Application.Quit();
    }
}
