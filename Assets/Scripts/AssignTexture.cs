using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class AssignTexture : MonoBehaviour {

	Material mat;
	MeshRenderer ren;
	Texture tex;

	// Use this for initialization
	void Start () {
		ren = GameObject.Find ("Material_Shortcut").GetComponent<MeshRenderer> ();
		tex = gameObject.GetComponent<RawImage> ().texture;
//		print (tex.name);
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	public void ChangeMat(){
		ren.sharedMaterial.SetTexture ("_MatCap", tex);
//		print ("pressed");
	}
}
