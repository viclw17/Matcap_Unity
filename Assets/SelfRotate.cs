using UnityEngine;
using System.Collections;

public class SelfRotate : MonoBehaviour
{
	public float speed = 30f;
	public GameObject obj;
	bool isRotate = false;

	// Use this for initialization
	void Start ()
	{
	
	}
	
	// Update is called once per frame
	void Update ()
	{
		if(isRotate)
			obj.transform.Rotate (Vector3.up * Time.deltaTime * speed, Space.World);
	}

	public void Rotate(){
		isRotate = !isRotate;
	}
}
