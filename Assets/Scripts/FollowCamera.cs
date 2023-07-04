using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowCamera : MonoBehaviour
{
    [SerializeField] GameObject objetoToFollow;

    // Update is called once per frame 
    // agregado
    void LateUpdate()
    {
        transform.position = objetoToFollow.transform.position + new Vector3(0,0,-10);
    }
}
