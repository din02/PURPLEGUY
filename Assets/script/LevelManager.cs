using UnityEngine;
using UnityEngine.UI;
using System.Collections;
using UnityEngine.SceneManagement;
public class LevelManager : MonoBehaviour
{
    public void LoadLevel(string lose)
    {
        SceneManager.LoadScene(lose);
    }
}