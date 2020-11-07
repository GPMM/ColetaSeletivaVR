using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TrashBehaviour : MonoBehaviour
{

    [SerializeField]
    private TrashTypeControl trashTypeControl;


    private void Start() {
        Debug.Log("ID: " + trashTypeControl);
    }


    void OnTriggerEnter(Collider other) {
        Debug.Log("Trigger");

        if(other.gameObject.tag == "TrashDestroyer"){
            Debug.Log("No Destroyer");
            if(other.gameObject.GetComponent<TrashTypeControl>().TrashID == trashTypeControl.TrashID){
				Debug.Log("No lixo certo");
                Destroy(gameObject);
            }
        }
    }

    void OnCollisionEnter(Collision other) {
		Debug.Log("COLLISION");
		if (other.gameObject.tag == "TrashDestroyer")
		{
			Debug.Log("No Destroyer");
			if (other.gameObject.GetComponent<TrashTypeControl>().TrashID == trashTypeControl.TrashID)
			{
				Debug.Log("No lixo certo");
				Destroy(gameObject);
			}
		}
    }
}
