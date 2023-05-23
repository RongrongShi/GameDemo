using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class videoControll : MonoBehaviour
{
    // Start is called before the first frame update
    public float wait_time = 7f; 

    void Start()
    {
        StartCoroutine(load_scene());
    }

    IEnumerator load_scene(){
        yield return new WaitForSeconds(wait_time); // 7 seconden wachten en load scene name als mainmenu
        SceneManager.LoadScene("mainmenu");
    }
}
