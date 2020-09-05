﻿using System.Collections;
using UnityEngine;

public class GameHandler : MonoBehaviour {
	[SerializeField] private EntityGrid grid = null;
	[SerializeField] private GameObject[] golemPrefabs = null;

	public void CreateGolem(Vector2 pos) {
		if (grid.MovingEntities > 0) {
			return;
		}

		GameObject golem = Instantiate(golemPrefabs[Random.Range(0, golemPrefabs.Length)]);

		bool added = grid.AddEntity(golem.GetComponent<GridEntity>(), pos);

		if (!added) {
			Destroy(golem);
		} else {
			Step();
		}
	}

	public void Step() {
		grid.Step();
	}
}
