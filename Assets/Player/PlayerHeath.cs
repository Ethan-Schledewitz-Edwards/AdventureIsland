using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerHeath : MonoBehaviour
{
	private void OnTriggerEnter(Collider other)
	{
		if (other.CompareTag("Enemy"))
			Die();
	}

	private void Die()
	{
		GameManager.Instance.ConsumeLife();
	}
}
