using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
   
    private GameManager gm;
    private int puntos=10;
    private void Awake()
    {
        gm = GameManager.instance;
    }

    private void OnCollisionEnter(Collision other)
    {
        Debug.Log(other.gameObject.layer);
        if (other.collider.CompareTag("lata"))
            gm.UpdateScore(puntos);

    }

}
