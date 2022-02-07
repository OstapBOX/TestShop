using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneControll : MonoBehaviour
{
    public void LoadGame() {
        SceneManager.LoadScene("Game");
    }

    public void LoadShop() {
        SceneManager.LoadScene("Shop");
    }

    public void ClearPrefabs() {
        PlayerPrefs.DeleteAll();
    }
}
