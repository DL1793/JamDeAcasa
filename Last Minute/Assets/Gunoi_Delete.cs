using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Gunoi_Delete : MonoBehaviour
{
    private bool atinge = false;

    GameObject cub, doza, lampa;
    int scor;

    void Start()
    {
        cub = GameObject.Find("Cube");
        doza = GameObject.Find("doza");
        lampa = GameObject.Find("lampa");

    }

    void Update()
    {
        //Debug.Log("Scorul este de: " + scor);
    }

    private void OnCollisionEnter(Collision col)
    {
        atinge = true;
        if (col.gameObject.name == "Cube")
        {
            Destroy(cub.gameObject);
            scor++;
        }

        else if(col.gameObject.name == "doza")
        {
            Destroy(doza.gameObject);
            scor++;

        }

        else if (col.gameObject.name == "lampa")
        {
            Destroy(lampa.gameObject);
            scor--;
        }
    }

    private void Contor()
    {
        
    }
}
