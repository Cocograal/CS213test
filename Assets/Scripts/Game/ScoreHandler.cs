using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScoreHandler : MonoBehaviour
{
    // Start is called before the first frame update
    int score;
    void Start()
    {
        int score = 0;
        
    }

    // Update is called once per frame
    void Update()
    {
    
    }

    public void add() {
        score = score + 1;
        Debug.Log(gameObject.name + " a gagné 1 point et a " + score + " pts.");
        
    }

    public void substract() {
        if (score > 0) {
            score = score - 1;
            Debug.Log(gameObject.name + " a perdu 1 point et a " + score + " pts.");
        } else {
            Debug.Log(gameObject.name + " ne peut pas perdre d'autre point. Il a "  + score + "point");
        }
    }
}
