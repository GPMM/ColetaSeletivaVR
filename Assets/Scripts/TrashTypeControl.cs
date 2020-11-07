using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public enum TrashTypes { Glass, Metal }

public class TrashTypeControl : MonoBehaviour
{

    
    [SerializeField]
    private TrashTypes trashID;

    public TrashTypes TrashID{
        get { return this.trashID; }
    }


    [SerializeField]
    private MeshRenderer[] meshes;

	[SerializeField]
	private Material glassMaterial;

	[SerializeField]
	private Material metalMaterial;

    private void Start() {
        switch(trashID){
            case TrashTypes.Glass:
                SetMeshes(glassMaterial);
                break;

            case TrashTypes.Metal:
				SetMeshes(metalMaterial);
                break;

            default:
                Destroy(gameObject);
                Debug.Log("This trash object doesn't have a valid trash material id.");
                break;
        }
    }

    private void SetMeshes(Material material){
        foreach( MeshRenderer mesh in meshes){
            mesh.material = material;
        }
    }
}
