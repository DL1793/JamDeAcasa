using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Hitbox_Masa : MonoBehaviour
{
    private bool atinge = false;

    GameObject cube;

    int scor;

    float raza = 2f;

    void Start()
    {
        cube = GameObject.Find("cub");
    }

    void Update()
    {

    }

    private void OnCollisionEnter(Collision col)
    {
        atinge = true;
        if (col.gameObject.name == "cub")
        {
            if (Physics.CheckSphere(new Vector3(-14.31f, 2.759f, 6.072f), raza))
            {
                cube.transform.position = new Vector3(-17.057f, 1.28f, 11.55f);
            }
            else
            {
                cube.transform.position = new Vector3(-14.31f, 2.759f, 6.072f);
                cube.GetComponent<Rigidbody>().useGravity = true;
                cube.GetComponent<Rigidbody>().detectCollisions = true;
                cube.GetComponent<Rigidbody>().constraints = RigidbodyConstraints.FreezePosition;
                cube.GetComponent<Rigidbody>().constraints = RigidbodyConstraints.FreezeRotation;
            }
        }

    }


}
