using UnityEngine;
using UnityEngine.SceneManagement;

public class Title : MonoBehaviour
{

    private AudioSource se01;

    void Start() {
        AudioSource[] audioSources = GetComponents<AudioSource>();

        se01 = audioSources[0];
    }

    void Update()
    {
        if (Input.GetMouseButtonDown(0)) {

            se01.PlayOneShot(se01.clip);
            SceneManager.LoadScene("DescriptionScene");
        }
    }
}