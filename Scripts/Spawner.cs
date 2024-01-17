using UnityEngine;

public class Spawner : MonoBehaviour
{
    //Fill this line to add a reference to the pipes prefab
    public GameObject prefab;
    public float spawnRate = 1f;
    public float minHeight = -1f;
    public float maxHeight = 2f;

    private void OnEnable()
    {
        InvokeRepeating(nameof(Spawn), spawnRate, spawnRate);
    }

    private void OnDisable()
    {
        CancelInvoke(nameof(Spawn));
    }

    private void Spawn()
    {
        //Fill this line to Instantiate the pipes gameObject
        // GameObject pipes = ?;
        //Uncoment the following line when done
        // pipes.transform.position += Vector3.up * Random.Range(minHeight, maxHeight);
    }
}
