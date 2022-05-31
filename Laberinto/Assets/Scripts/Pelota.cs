using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pelota : MonoBehaviour
{

    private Rigidbody rig;
    private float velocidad = 600;
    private GameManager gameManager;



    private void Awake()
    {
        rig = GetComponent<Rigidbody>();
        gameManager = FindObjectOfType<GameManager>();


    }

    void Update()
    {
        Vector3 orientation = Input.acceleration;
        orientation = Quaternion.Euler(90, 0, 0) * orientation;
        rig.AddForce(orientation * velocidad * Time.deltaTime);
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Exit"))
        {

        }
        else if (collision.gameObject.CompareTag("Wood"))
        {
            gameManager.RestaPuntos();
        }

    }


}
