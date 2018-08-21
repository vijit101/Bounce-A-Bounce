using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class Utils
{
    public static void  reloadcurrentscene()
    {
        int index;
        index = SceneManager.GetActiveScene().buildIndex;
        SceneManager.LoadScene(index);
    }
    public static void loadnextscene()
    {
        int cindex;
        cindex = SceneManager.GetActiveScene().buildIndex;
        SceneManager.LoadScene((cindex +1) % (SceneManager.sceneCountInBuildSettings));
    }

}