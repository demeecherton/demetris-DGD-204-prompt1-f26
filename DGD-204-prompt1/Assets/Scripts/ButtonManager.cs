using UnityEngine;
using UnityEngine.SceneManagement;

public class ButtonManager : MonoBehaviour
{
    //Variables

    public void StartGame()
    {
        SceneManager.LoadScene("SampleScene");
    }
}
