using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ResetScene : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Invoke("ResetAnimation", 12.0f);
    }

    void ResetAnimation()
    {
        SceneManager.LoadScene("Project2");
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
