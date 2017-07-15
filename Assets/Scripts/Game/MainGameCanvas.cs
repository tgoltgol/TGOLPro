using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MainGameCanvas : MonoBehaviour
{

	/// <summary>mapオブジェクトリスト</summary>
	[SerializeField]
	private List<GameObject> mapList;
	/// <summary>使用するSpriteのList</summary>
	[SerializeField]
	private List<Sprite> spriteList;

	void Start ()
	{
		//生成されたマップリストにspriteを設定
		//後々ここでマップ情報セット
		for (int i = 0; i < mapList.Count; i++) {
			this.mapList [i].GetComponent<SpriteRenderer> ().sprite = this.spriteList [Random.Range (0, 10)];
		}
	}
}
