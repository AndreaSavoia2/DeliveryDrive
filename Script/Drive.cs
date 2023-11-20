using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class Drive : MonoBehaviour
{
    
[SerializeField] float velocitaDiSvolta = 250;
[SerializeField] float velocitaDiMovimento = 10;
[SerializeField] float rallentamento = 5f;
[SerializeField] float accelerazione = 20f;

    void Start()
    {
        // ruota lo prite (x,y,z)
        //transform.Rotate(0, 0, 45);
    }
    
    private void OnTriggerEnter2D(Collider2D other) {
        if(other.tag == "Accelerazione"){
            velocitaDiMovimento = accelerazione;
            Debug.Log("accellerato");
        }
    }

    void OnCollisionEnter2D(Collision2D other) {
            velocitaDiMovimento = rallentamento;
            Debug.Log("rallentato");
     }

    void Update()
    {
        float modificatoreSvolta = Input.GetAxis("Horizontal") * velocitaDiSvolta * Time.deltaTime;
        float modificatoreVelocita = Input.GetAxis("Vertical") * velocitaDiMovimento * Time.deltaTime;
        transform.Rotate(0, 0, -modificatoreSvolta);
        transform.Translate(0, modificatoreVelocita, 0);
    }

    
}