using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenuScript : MonoBehaviour
{
    public void onClickVS()
    {
        SceneManager.LoadScene("Start");
    }
    public void onClickZombies()
    {
        SceneManager.LoadScene("RealZombieMap");
    }
}
