using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectCollision : MonoBehaviour
{
    public virtual void onObjectEncounter()
    {
        ;
    }
    private void OnTriggerEnter(Collider other)
    {
        onObjectEncounter();
        Destroy(gameObject);
    }
}
