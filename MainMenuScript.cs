using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    public void PlayGame()
    {
        SceneManager.LoadScene(1); // Oyunun ba�layaca�� sahne (index 1)
    }

    public void ExitGame()
    {
        Application.Quit(); // Oyunu kapat�r
        Debug.Log("Oyun Kapand�!"); // Edit�r i�inde �al��maz ama build al�nd���nda �al���r
    }
}
