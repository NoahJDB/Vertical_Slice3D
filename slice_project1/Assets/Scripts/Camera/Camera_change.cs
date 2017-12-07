using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Camera_change : MonoBehaviour
{
    [SerializeField]
    public GameObject CameraPoint;
    public GameObject CameraPoint1;

    private const int Rotation = 57;

    private void OnTriggerExit(Collider other)
    {
        if (other.gameObject.tag == "Player" && this.gameObject.transform.position.z > other.gameObject.transform.position.z)
        {
            MoveCamera(CameraPoint.transform.position, new Vector3(Rotation, 0, 0));
        }
        else if (other.gameObject.tag == "Player" && this.gameObject.transform.position.z < other.gameObject.transform.position.z)
        {
            MoveCamera(CameraPoint1.transform.position, new Vector3(0, 0, 0));
        }
    }

    private void MoveCamera(Vector3 position, Vector3 rotation)
    {
        Camera.main.transform.position = position;
        Camera.main.transform.rotation = Quaternion.Euler(rotation);
    }
}