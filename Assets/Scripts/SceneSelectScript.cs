using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneSelectScript : MonoBehaviour
{
    public void SelectScene()
    {
        switch (this.gameObject.name)
        {
            case "PenguinButton": SceneManager.LoadScene("Penguins");
                break;
            
            case "HummingbirdButton": SceneManager.LoadScene("FlowerIsland");
                break;
            
        }
    }
}
