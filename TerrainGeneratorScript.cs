using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TerrainGeneratorScript : MonoBehaviour
{
    [SerializeField] private GameObject world;
    [SerializeField] private GameObject treePrefab;
    [SerializeField] private float distanceFromCenter;

    private Vector3 worldCenter;

    private void Start()
    {
        worldCenter = world.transform.position;
        GameObject tempObj;
        for(int i = 0; i < 100; ++i)
        {
            tempObj = Instantiate(treePrefab);
            Vector3 randomVector = new Vector3(UnityEngine.Random.Range(-180, 180), UnityEngine.Random.Range(-180, 180), UnityEngine.Random.Range(-180, 180)).normalized;
            tempObj.transform.position = randomVector * distanceFromCenter - worldCenter;
            Quaternion rotation = Quaternion.LookRotation(tempObj.transform.position - worldCenter);
            tempObj.transform.rotation = rotation;
        }
    }
}
