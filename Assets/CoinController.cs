﻿using UnityEngine;
using System.Collections;

public class CoinController : MonoBehaviour {

	// Use this for initialization
	void Start () {
		//回転を開始する角度を設定
		this.transform.Rotate (0, Random.Range (0, 360), 0);
	}

	// Update is called once per frame
	void Update () {
		//回転
		this.transform.Rotate (0, 3, 0);
	}
}