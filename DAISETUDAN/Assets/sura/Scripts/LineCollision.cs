using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LineCollision : MonoBehaviour {

    public GameObject hand;

    public bool trg = true;

    // Use this for initialization
    void Start () {
		
	}

    // Update is called once per frame
    void Update() {

        if (Input.GetMouseButtonUp(0)) {
            Destroy(gameObject);
        }
    }

        private void OnCollisionEnter(Collision other) {
        //ラインとの当たり判定
        if (other.gameObject.tag == "Block") {
            if (trg) {           
                Instantiate(hand, transform.position, Quaternion.identity);
                FindObjectOfType<drawPhysicsLine>().ok = 0;
                //時間マイナス
                Debug.Log("ダメ");
            }
            trg = false;
        }
    }
}