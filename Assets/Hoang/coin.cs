using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class coin : MonoBehaviour
{
    public CarController carController;
    private void OnTriggerEnter2D( Collider2D collision){
        count.coinAmount += 1;
        Destroy(gameObject);
    }
}

