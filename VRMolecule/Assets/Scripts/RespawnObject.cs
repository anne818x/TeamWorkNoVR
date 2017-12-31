using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RespawnObject : MonoBehaviour {

    public GameObject grabbableobj;

    // Use this for initialization
    void Start () {
        

    }
	
	// Update is called once per frame
	void Update ()
    {
        positionCheck();
    }

    void positionCheck()
    {
        Vector3 currentpos = grabbableobj.GetComponent<Rigidbody>().transform.position;
        if (float.Parse(currentpos.ToString()) > float.Parse(getSpawnPoint().ToString()) + 10 || float.Parse(currentpos.ToString()) < float.Parse(getSpawnPoint().ToString()) - 10)
        {
            grabbableobj.GetComponent<Rigidbody>().transform.position = getSpawnPoint();
        }
        else
        {

        }

    }

    Vector3 getSpawnPoint()
    {
        Vector3 initialposition = grabbableobj.GetComponent<Rigidbody>().transform.position;
        return initialposition;
    }

}
