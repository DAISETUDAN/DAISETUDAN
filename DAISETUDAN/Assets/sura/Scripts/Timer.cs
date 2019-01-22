using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class Timer : MonoBehaviour {

    //カウントダウンの開始値
    public int MAX_TIME = 120;
    public float timeCounter = 120;


    // Use this for initialization
    void Start() {
        GetComponent<UnityEngine.UI.Text>().text = MAX_TIME.ToString();
    }


    // Update is called once per frame
    void Update() {
        timeCounter -= Time.deltaTime;
        if (timeCounter <= 0) {
            //SceneManager.LoadScene("rGameover");
        }
        //マイナス値にならないようにする
        timeCounter = Mathf.Max(timeCounter , 0.0f);
        GetComponent<UnityEngine.UI.Text>().text = ((int)timeCounter).ToString();

    }
}
