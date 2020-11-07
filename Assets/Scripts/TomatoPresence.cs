using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit;

public class TomatoPresence : MonoBehaviour
{
    [SerializeField]
    private GameObject handModel;

    public void HideHands(){
        handModel.SetActive(false);
	}
    
	public void ShowHands()
	{
		handModel.SetActive(true);
	}
}
