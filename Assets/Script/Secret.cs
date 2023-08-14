using UnityEngine;

public class Secret : MonoBehaviour
{
	private string pass = "";

	void Start()
	{
		if(pass == "S3Cr37")
		{
			Debug.Log("you have access");
		}
	}
}
