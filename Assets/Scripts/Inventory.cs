using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Inventory : MonoBehaviour
{
    public void GoBack()
    {
        SceneManager.LoadScene("LevelSelection");
    }
}
