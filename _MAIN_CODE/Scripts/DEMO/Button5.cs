using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Button5 : MonoBehaviour
{
    public void changeScene()
    {
        SceneManager.LoadScene("Map");
    }
}
