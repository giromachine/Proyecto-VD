using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollectObjects : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Object")
        {
            other.GetComponent("ManipulateObjects").SendMessage("Detection");
        }

        if (other.tag == "Camera")
        {
            other.GetComponent("CameraObject").SendMessage("Detection");
        }
    }


    void OnTriggerExit(Collider other)
    {
        if (other.tag == "Object")
        {
            other.GetComponent("ManipulateObjects").SendMessage("NoDetection");
        }

        if (other.tag == "Çamera")
        {
            other.GetComponent("CameraObject").SendMessage("NoDetection");
        }
    }
}
