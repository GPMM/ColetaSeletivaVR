using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TeleportSelection : MonoBehaviour
{

	[SerializeField]
    private bool isRotating = false; 

    [SerializeField]
    private GameObject[] activeWhenSelect;

	[SerializeField]
	private GameObject[] rotateWhenSelect;

	[SerializeField]
	private float[] speed;

    public void SelectTarget(){
        foreach(GameObject part in activeWhenSelect){
			part.SetActive(true);
        }

        isRotating = true;
    }

    public void DeselectTarget(){
        foreach(GameObject part in activeWhenSelect){
			part.SetActive(false);
		}

		isRotating = false;
    }

    private void Update() {
        if(isRotating){
            for(int i = 0; i < rotateWhenSelect.Length; i++){
                rotateWhenSelect[i].transform.Rotate(Vector3.up * speed[i] * Time.deltaTime, Space.World);
            }
        }
    }

}
