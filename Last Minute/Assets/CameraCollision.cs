using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraCollision : MonoBehaviour
{
    
	public Transform c_camera;

	private Quaternion camRotation;
	private RaycastHit hit;
	private Vector3 camera_offset;

    void Start()
    {
        camera_offset = c_camera.localPosition;
    }

    // Update is called once per frame
    void Update()
    {
        if(Physics.Linecast(transform.position, c_camera.position, out hit))
	{
	c_camera.localPosition = new Vector3(0, 0, -Vector3.Distance(transform.position, hit.point));
	}
        else
	{
	c_camera.localPosition = Vector3.Lerp(c_camera.localPosition, camera_offset, Time.deltaTime);
	}
    }
}
