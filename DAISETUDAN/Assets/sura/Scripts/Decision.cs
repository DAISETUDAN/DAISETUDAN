using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Decision : MonoBehaviour {

    /// <summary>
    /// 手
    /// </summary>
    public GameObject hand;

    /// <summary>
    /// いいぞ判定の個数
    /// </summary>
    public int num = 5;

    /// <summary>
    /// 切った材料の個数
    /// </summary>
    public int food;

    /// <summary>
    /// できた料理の個数
    /// </summary>
    public int cuisine;

    /// <summary>
    /// ダメ判定
    /// </summary>
    public bool bad = false;

    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        Good();

        Bad();
	}

    void Good() {
        if(FindObjectOfType<drawPhysicsLine>().ok >= num) {

            food++;

            FindObjectOfType<FoodDestroy>().trg = true;

            FindObjectOfType<drawPhysicsLine>().ok = 0;
        }

        if(food >= 3) {

            cuisine++;
            FindObjectOfType<Cock>().cookTrg = true;
            food = 0;
        }

    }

    void Bad() {

        if (bad) {
            Instantiate(hand , new Vector3(0 , 0 , 0) , Quaternion.identity);
            FindObjectOfType<drawPhysicsLine>().ok = 0;
            FindObjectOfType<Timer>().timeCounter -= 5;
            Debug.Log("ダメ");
            bad = false;
        }
    }
}
