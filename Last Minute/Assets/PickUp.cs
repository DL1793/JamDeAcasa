using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PickUp : MonoBehaviour
{
	float throwForce = 600;
	Vector3 pozitie;
	float distanta;

	public bool poateInMana = true;
	public GameObject item;
	public GameObject ParinteAuxiliar;
	public bool inMana = false;

	void Update()
	{
		distanta = Vector3.Distance(item.transform.position, ParinteAuxiliar.transform.position);
		if(distanta >= 10f)
        {
			inMana = false;
        }

		// Verifica daca tine in mana
		if (inMana == true)
		{
			item.GetComponent<Rigidbody>().velocity = Vector3.zero;
			item.GetComponent<Rigidbody>().angularVelocity = Vector3.zero;
			item.transform.SetParent(ParinteAuxiliar.transform);

			if (Input.GetMouseButtonDown(1))
			{
				//arunca
				item.GetComponent<Rigidbody>().AddForce(ParinteAuxiliar.transform.forward * throwForce);
				inMana = false;
			}

			press1();
			press2();
		}

		else
		{
			pozitie = item.transform.position;
			item.transform.SetParent(null);
			item.GetComponent<Rigidbody>().useGravity = true;
			item.transform.position = pozitie;
		}

		
	}
	void press1()
	{
		if (Input.GetKey("e"))
		{
			if (distanta <= 10f)
			{
				inMana = true;
				item.GetComponent<Rigidbody>().useGravity = false;
				item.GetComponent<Rigidbody>().detectCollisions = true;
			}
		}
	}

		
	void press2()
    {
		if (Input.GetKey("f"))
		inMana = false;
    }
	

}
