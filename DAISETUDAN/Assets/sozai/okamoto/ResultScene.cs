using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ResultScene : MonoBehaviour {

    private AudioSource se01;

    void Start() {
        AudioSource[] audioSources = GetComponents<AudioSource>();
        se01 = audioSources[0];
    }

    // Update is called once per frame
    void Update() {
        if (Input.GetMouseButtonDown(0)) {

            se01.PlayOneShot(se01.clip);
            SceneManager.LoadScene("Titlescene");
        }
    }
}
