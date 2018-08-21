using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Levelmanager : MonoBehaviour {

	public void ldnxtlvl()
    {
        int indx = SceneManager.GetActiveScene().buildIndex;
        SceneManager.LoadScene(indx + 1);
    }
}
