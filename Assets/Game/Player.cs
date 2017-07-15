using UnityEngine;
using System.Collections;

public class Player : MonoBehaviour {

	static readonly int MaxMoney = 1000000000; //10億0000万0000

	[SerializeField]
	int _Money;

	[SerializeField]
	string _Name;



	public string Name { 
		get {
			return _Name;
		}
		set {
			_Name = value;
		}
	}
	public int Money {
		get {
			return _Money;
		}
		set {
			_Money = value;
			if (_Money > MaxMoney) {
				_Money = MaxMoney;
			}
		}
	}
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
