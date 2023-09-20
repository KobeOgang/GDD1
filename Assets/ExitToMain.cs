using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ExitToMain : MonoBehaviour
{
    // Start is called before the first frame update
    public void toMain()
    {
        SceneManager.LoadSceneAsync(0);

    }
}
