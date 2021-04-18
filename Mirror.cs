using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mirror : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        print(other.tag);
        if(other.tag == "OBJ")
        {
            other.gameObject.SetActive(false);
        }
    }
}
