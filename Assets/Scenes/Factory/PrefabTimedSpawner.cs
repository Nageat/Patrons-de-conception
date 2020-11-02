using UnityEngine;

public class PrefabTimedSpawner : MonoBehaviour
{
    [SerializeField]
    private float spawnparminute = 30;//Nombre de carré a spawn en une minutes
    private int currentCount = 0;//Nombre de carré actuel 
    [SerializeField]
    private TimedObjectFactory factory;

    private void Update()
    {
        var targetCount = Time.time * (spawnparminute / 60);
        while (targetCount > currentCount)
        {
            var inst = factory.GetNewInstance();
            inst.transform.position = new Vector3(Random.Range(-7.0f, 7.0f), Random.Range(-5.0f, 5.0f), 0);
            currentCount++;
        }
    }
}