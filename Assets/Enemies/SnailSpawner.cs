using System.Collections.Generic;
using UnityEngine;

public class SnailSpawner : EnemySpawner
{
	public Enemy snailPrefab;

	[SerializeField] private List<Vector3> enemyPositions;

	private void Start()
	{
		foreach (Vector3 pos in enemyPositions) 
		{
			SpawnEnemy(snailPrefab, pos);
		}
	}

	public override void SpawnEnemy(Enemy enemy, Vector3 pos)
	{
		Instantiate(enemy, pos, Quaternion.identity);
	}
}
