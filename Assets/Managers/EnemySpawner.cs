using UnityEngine;

public abstract class EnemySpawner : MonoBehaviour
{

	public abstract void SpawnEnemy(Enemy enemy, Vector3 pos);
}
