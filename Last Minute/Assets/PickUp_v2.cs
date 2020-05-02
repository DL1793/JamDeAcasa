using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PickUp_v2 : MonoBehaviour
{
    GameObject empty, parinte, mana;
    Vector3 pos;
    public bool inMana = false;
    float throwForce = 600;
    public Vector3 coordonate_mana;
    public RectTransform panelRectTransform;

    void Start()
    {
        empty = GameObject.Find("Cub Test");
        parinte = GameObject.Find("Player");
        mana = GameObject.Find("Mana");
        mana.GetComponent<Rigidbody>().constraints = RigidbodyConstraints.FreezePosition;
    }

    void press()
    {
        if (Input.GetKey("q") && inMana == false)
        {
            inMana = true;
            empty.transform.position = Vector3.MoveTowards(mana.transform.position, mana.transform.position, 10 * Time.deltaTime);
            //transform.parent = empty.transform;
            empty.transform.parent = parinte.transform;
            this.GetComponent<Rigidbody>().useGravity = false;
            this.GetComponent<Rigidbody>().detectCollisions = true;
            this.GetComponent<Rigidbody>().isKinematic = false;
            this.GetComponent<Rigidbody>().angularDrag = 0f;
            this.GetComponent<Rigidbody>().constraints = RigidbodyConstraints.FreezePosition;
            this.GetComponent<Rigidbody>().constraints = RigidbodyConstraints.FreezeRotation;

            mana.GetComponent<Rigidbody>().useGravity = false;
            mana.GetComponent<Rigidbody>().detectCollisions = true;
            mana.GetComponent<Rigidbody>().isKinematic = false;
            mana.GetComponent<Rigidbody>().angularDrag = 0f;
            mana.GetComponent<Rigidbody>().constraints = RigidbodyConstraints.FreezePosition;
            mana.GetComponent<Rigidbody>().constraints = RigidbodyConstraints.FreezeRotation;
            //this.transfom.LookAt()

        }

        else if (inMana == true && Input.GetMouseButtonDown(0))
        {
            //arunca
            transform.parent = null;
            this.GetComponent<Rigidbody>().useGravity = true;
            this.GetComponent<Rigidbody>().detectCollisions = true;
            this.GetComponent<Rigidbody>().constraints = RigidbodyConstraints.None;
            this.GetComponent<Rigidbody>().AddForce(empty.transform.forward * throwForce);
            inMana = false;
        }

        else if (Input.GetKey("e"))
        {
            inMana = false;
            transform.parent = null;
            this.GetComponent<Rigidbody>().useGravity = true;
            this.GetComponent<Rigidbody>().detectCollisions = true;
            this.GetComponent<Rigidbody>().constraints = RigidbodyConstraints.None;
        }

        else if (Input.GetKey("f"))
        {
            inMana = false;
            transform.parent = null;
            this.GetComponent<Rigidbody>().useGravity = true;
            this.GetComponent<Rigidbody>().detectCollisions = true;
            this.GetComponent<Rigidbody>().constraints = RigidbodyConstraints.FreezePosition;
            this.GetComponent<Rigidbody>().constraints = RigidbodyConstraints.FreezeRotation;

        }
    }

    void Update()
    {
        press();
    }
}
