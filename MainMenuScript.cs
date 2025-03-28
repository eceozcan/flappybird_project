using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    public void PlayGame()
    {
        SceneManager.LoadScene(1); // Oyunun baþlayacaðý sahne (index 1)
    }

    public void ExitGame()
    {
        Application.Quit(); // Oyunu kapatýr
        Debug.Log("Oyun Kapandý!"); // Editör içinde çalýþmaz ama build alýndýðýnda çalýþýr
    }
}
