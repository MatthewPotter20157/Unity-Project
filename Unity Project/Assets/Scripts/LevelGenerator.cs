using UnityEngine;
using UnityEngine.AI;

public class LevelGenerator : MonoBehaviour
{
	public NavMeshSurface surface;
	public int width = 30;
	public int height = 30;

	public GameObject wall;
	public GameObject enemy;
	public GameObject[] walls;

	private int waveCount = 1;
	private int enemyCount = 0;
	private int enemySpawn = 0;

	// Use this for initialization
	void Start()
	{
		GenerateLevel(); 
		surface.BuildNavMesh();
	}

	// Create a grid based level
	void GenerateLevel()
	{
		waveCount = enemySpawn;
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
				else if (enemySpawn != 0) // Should we spawn a enemy?
				{
					// Spawn the enemy
					Vector3 pos = new Vector3(x - width / 2f, 1f, y - height / 2f);
					Instantiate(enemy, pos, Quaternion.identity);
					enemySpawn --;
					enemyCount ++;
				}
			}
		}
		surface.BuildNavMesh();
	}

    void Update()
    {
		if (enemyCount == 0)
		{
			walls = GameObject.FindGameObjectsWithTag("Wall");
			waveCount += 2;
			foreach (GameObject wall in walls)
            {
				Destroy(wall);
            }
			GenerateLevel();
		}
    }
}
