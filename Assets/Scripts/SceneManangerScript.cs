using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneManangerScript : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        SceneSwitch();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void SceneSwitch()
    {
        SceneManager.LoadScene("TestScene");
    }
}
