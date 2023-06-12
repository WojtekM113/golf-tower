using UnityEngine;
using UnityEngine.SceneManagement;

public class ButtonStartAgainScript : MonoBehaviour
{
    public void OnClick()
    {
        SceneManager.LoadScene("MainScene");
    }
}
