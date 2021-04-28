using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Teleporter : MonoBehaviour
{

    private GameObject toGo;

    void Start()
    {
        toGo = GameObject.Find("Teleporter");
    }

    private void OnTriggerEnter(Collider other)
    {
        if (null != toGo)
        {
            other.gameObject.GetComponent<Rigidbody>().velocity = Vector3.zero;
            other.gameObject.GetComponent<Rigidbody>().angularVelocity = Vector3.zero;
            other.transform.position = toGo.transform.position + new Vector3(18, 1, -18);
        }

        Debug.Log("##### DMT Trigger Animation Teleporter: " + this.gameObject.name);
    }
}
