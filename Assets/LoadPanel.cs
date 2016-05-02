using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using DG.Tweening;

public class LoadPanel : MonoBehaviour {

	public RectTransform panel;
	bool isOut = false;

	// Use this for initialization
	void Start () {
	
		transform.DOLocalMoveY (70f, 0.5f).SetEase(Ease.InOutSine).SetLoops(-1, LoopType.Yoyo);
	}
	
	// Update is called once per frame
	void Update () {
	}

	public void MoveDown(){
		if (!isOut) {
			panel.DOLocalMoveY (0f, 0.5f).SetEase (Ease.OutQuart);
			transform.DOLocalRotate (new Vector3 (0, 0, 180), 0.5f).SetEase (Ease.OutQuart);
			isOut = true;
		} else {
			panel.DOLocalMoveY (200f, 0.5f).SetEase (Ease.OutQuart);
			transform.DOLocalRotate (new Vector3 (0, 0, 0), 0.5f).SetEase (Ease.OutQuart);
			isOut = false;
		}
	}
}
