using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowCamera : MonoBehaviour
{
    
    [SerializeField] GameObject ogettoDaSeguire;
    [SerializeField] float distanzaCamera= -10f;

    // setta la telecamera sul protagonista

    void LateUpdate()
    {
        transform.position = ogettoDaSeguire.transform.position + new Vector3 (0,0,distanzaCamera) ;
    }
}
