using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollisionHandler : MonoBehaviour
{

    void OnCollisionEnter(Collision collisionInfo) {
        GameObject cellulo = collisionInfo.collider.transform.parent.gameObject;
        if (cellulo.CompareTag("Player")) {
            cellulo.GetComponent<ScoreHandler>().substract();
        }
    }

}
