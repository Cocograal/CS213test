using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class RingTrigger : MonoBehaviour {

    // Start is called before the first frame update
    void Start() {
    }

    // Update is called once per frame
    void Update()
    {


    }
     void OnTriggerEnter(Collider other){
        GameObject[] sheep = GameObject.FindGameObjectsWithTag("sheep");
        GameObject[] players = GameObject.FindGameObjectsWithTag("Player");
        GameObject closest = players[0];

        if (!other.transform.parent.gameObject.CompareTag("Player")) {
            Debug.Log(other.transform.parent.gameObject.name + " triggers.");

            float minDist = 10000;
            for (int i = 0; i < players.Length; i++) {
                float distance = Vector3.Distance(sheep[0].transform.position, players[i].transform.position);
                if (distance < minDist) {
                    minDist = distance;
                    closest = players[i];
                }
            }
            closest.GetComponent<ScoreHandler>().add();
        }
    }

}
