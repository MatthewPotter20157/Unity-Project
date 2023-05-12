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
	public static int enemyCount = 0;
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
		enemySpawn = waveCount;
		// Loop over the grid
		for (int x = 0; x <= width; x += 2)
		{
			for (int y = 0; y <= height; y += 2)
			{
				//Debug.Log(enemySpawn);
				// Should we place a wall?
				if (Random.value > .7f)
				{
					// Spawn a wall
					Vector3 pos = new Vector3(x - width / 2f, 0, y - height / 2f);
					Instantiate(wall, pos, Quaternion.identity, transform);
				}
				if (enemySpawn != 0) // Should we spawn a enemy?
				{
					//Debug.Log("Spawn");
					// Spawn the enemy
					Vector3 pos = new Vector3(x - width / Random.Range(2f, 8f), 1f, y - height / Random.Range(2f,8f));
					Debug.Log(pos);
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
			// destory all the walls to regenrte them because if the wall are not destroyed they will spawn over each other maing the game unplayable
			walls = GameObject.FindGameObjectsWithTag("Wall");
			waveCount += 2;
			foreach (GameObject wall in walls)
            {
				Destroy(wall);
            }
			GenerateLevel();
			Debug.Log("anything");
		}
    }
}
