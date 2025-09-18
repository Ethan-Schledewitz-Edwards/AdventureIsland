using UnityEngine;

public class GameManager : MonoBehaviour
{
	public static GameManager Instance;
	private void Awake()
	{
		if(Instance == null)
		{

			Instance = this;
			DontDestroyOnLoad(Instance);
		}
	}

	int lives = 3;

	public void ConsumeLife()
	{
		lives -= 1;
		Mathf.Clamp(lives, 0, 3);
		Debug.Log("Lives remaining: " + lives);

		GameObject player = FindObjectOfType<PlayerHeath>().gameObject;
		player.transform.position = new Vector3(-12, 0, 0);


		if (lives <= 0)
			Debug.Log("You loose");

	}
}