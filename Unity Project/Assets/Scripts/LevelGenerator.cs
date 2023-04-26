using UnityEngine;
using UnityEngine.AI;

public class LevelGenerator : MonoBehaviour
{
	public NavMeshSurface surface;
	public int width = 30;
	public int height = 30;

	public GameObject wall;
	public GameObject enemy;

	private int waveCount = 1;
	private int enemyCount = 0;

	// Use this for initialization
	void Start()
	{
		GenerateLevel(); 
		surface.BuildNavMesh();
	}

	// Create a grid based level
	void GenerateLevel()
	{
		// Loop over the grid
		for (int x = 0; x <= width; x += 2)
		{
			for (int y = 0; y <= height; y += 2)
			{
				// Should we place a wall?
				if (Random.value > .7f)
				{
					// Spawn a wall
					Vector3 pos = new Vector3(x - width / 2f, 0, y - height / 2f);
					Instantiate(wall, pos, Quaternion.identity, transform);
				}
				else if (waveCount != 0) // Should we spawn a player?
				{
					// Spawn the player
					Vector3 pos = new Vector3(x - width / 2f, 1f, y - height / 2f);
					Instantiate(enemy, pos, Quaternion.identity);
					waveCount --;
					enemyCount ++;
				}
			}
		}
	}

    void Update()
    {
		while (enemyCount == 0)
		{
			waveCount += 2;
		}
    }
}
