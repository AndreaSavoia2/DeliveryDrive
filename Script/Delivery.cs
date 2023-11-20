using System;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class Delivery : MonoBehaviour
{   

     [SerializeField] Color32 conPachetto = new Color32(1,1,1,1);
     [SerializeField] Color32 senzaPachetto = new Color32(1,1,0,1);
     [SerializeField] float tempoDiDistruzione = 0.5f;
     bool presoPacchetto;
     SpriteRenderer spriteRenderer;

     void Start() {
          spriteRenderer = GetComponent<SpriteRenderer>();
     }

     void OnCollisionEnter2D(Collision2D other) {
        Debug.Log("Ahia!");
     }

     void OnTriggerEnter2D(Collider2D other) {
          if (other.tag == "Pacchetto" && !presoPacchetto){
               Destroy(other.gameObject,tempoDiDistruzione);
               Debug.Log("Ho preso il pacco!");
               presoPacchetto = true;
               spriteRenderer.color = conPachetto;
          }
          if (other.tag == "Cliente" && presoPacchetto){
               Debug.Log("Pacco consegnato!");
               presoPacchetto = false;
               spriteRenderer.color = senzaPachetto;
          }
     }

}