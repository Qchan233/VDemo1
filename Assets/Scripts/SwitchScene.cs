using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SwitchScene : MonoBehaviour
{
    public void Restart()
    {
        SceneManager.LoadScene(0);
    }

    public void GotoStore()
    {
        SceneManager.LoadScene(1);
    }

    public void GotoInitialLevel()
    {
        SceneManager.LoadScene(2);
    }
}
