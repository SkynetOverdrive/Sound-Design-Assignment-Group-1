using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyNote : MonoBehaviour
{
    

    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Note")
        {
            Destroy(other.gameObject);
        }
    }
    


}
