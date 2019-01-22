using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Decision : MonoBehaviour {

    /// <summary>
    /// いいぞ判定の個数
    /// </summary>
    public int num;

    /// <summary>
    /// 切った材料の個数
    /// </summary>
    public int food;

    /// <summary>
    /// できた料理の個数
    /// </summary>
    public int cuisine;

    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        Good();
	}

    void Good() {
        if(FindObjectOfType<drawPhysicsLine>().ok >= num) {

            food++;
            FindObjectOfType<drawPhysicsLine>().ok = 0;
        }

        if(food >= 3) {

            cuisine++;
            food = 0;
        }

    }
}
