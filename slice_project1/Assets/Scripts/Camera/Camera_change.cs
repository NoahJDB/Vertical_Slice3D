using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Camera_change : MonoBehaviour {
    [SerializeField]
    public GameObject CameraPoint;
    public GameObject CameraPoint1;

    private int Rotation = 57;

    private void OnTriggerExit(Collider other)
    {
        if (other.gameObject.tag == "Player" && this.gameObject.transform.position.z > other.gameObject.transform.position.z)
        {
            Camera.main.transform.position = CameraPoint.transform.position;
            Camera.main.transform.rotation = Quaternion.Euler(Rotation, 0, 0);
        }
        else if (other.gameObject.tag == "Player" && this.gameObject.transform.position.z < other.gameObject.transform.position.z)
        {
            Camera.main.transform.position = CameraPoint1.transform.position;
            Camera.main.transform.rotation = Quaternion.Euler(0, 0, 0);
        }
    }
}
