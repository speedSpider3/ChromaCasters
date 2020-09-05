﻿using UnityEngine;

public class GameHandler : MonoBehaviour {
	[SerializeField] private GolemGrid grid = null;
	[SerializeField] private GameObject[] golemPrefabs = null;

	public void CreateGolem() {
		GameObject golem = Instantiate(golemPrefabs[Random.Range(0, golemPrefabs.Length)]);

		bool added = grid.AddEntity(golem.GetComponent<GridEntity>(), Vector2.zero);

		if (!added) {
			Destroy(golem);
		}
	}

	public void Step() {
		grid.Step();
	}
}