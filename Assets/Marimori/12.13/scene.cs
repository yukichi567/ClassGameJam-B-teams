using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class scene : MonoBehaviour
{
    // Start is called before the first frame update
    /// <summary>変えたいシーンの名前</summary>
    [SerializeField] string _changeScene;

    public void LoadScenes()
    {
        Debug.Log("クリック");
        SceneManager.LoadScene(_changeScene);
    }
}
