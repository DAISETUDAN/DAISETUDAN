using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LineCollision : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        if (Input.GetMouseButtonUp(0)) {
            Destroy(gameObject);
        }
    }

    private void OnCollisionEnter(Collision other) {
        //ラインとの当たり判定
        if (other.gameObject.tag == "Block") {

            FindObjectOfType<drawPhysicsLine>().pena++;
            Debug.Log("ダメ");
            Destroy(other.gameObject);
        }

        if (other.gameObject.tag == "Good") {
            FindObjectOfType<drawPhysicsLine>().ok++;
            Debug.Log("いいぞ。");
            Destroy(other.gameObject);
        }
    }
}
