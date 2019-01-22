using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class Count : MonoBehaviour {
    public GameObject score_object = null; // Textオブジェクト
    public int scoreNum;
    public static int scoreCount;
	// Use this for initialization
	void Start () {
        scoreNum = 0;
	}
	
	// Update is called once per frame
	void Update () {
        // オブジェクトからTextコンポーネントを取得
        Text score_text = score_object.GetComponent<Text>();
        // テキストの表示を入れ替える
        score_text.text = "" + scoreNum;
        scoreCount = scoreNum;
    }
    public static int getCoke()
    {
        return scoreCount;
    }
}
