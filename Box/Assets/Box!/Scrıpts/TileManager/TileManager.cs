using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TileManager : MonoBehaviour
{
    public GameObject[] TilePrefabs;
    private Transform playerTransform;
    private float spawnZ = 99.0f;
    private float tileLength = 180;
    private int AmountTilesOnScreen = 2;
    private List<GameObject> activeTiles ;
    private float safeZone = 100.0f;
    private int lastPrefabIndex = 0;
    private void Start()
    {
        activeTiles = new List<GameObject>();
        playerTransform = GameObject.FindGameObjectWithTag("Player").transform;
        for (int i=0;i<AmountTilesOnScreen;i++)
        { SpawnTile(); }
        
        
    }

    
    private void Update()
    {
        if(playerTransform.position.z-safeZone>(spawnZ-AmountTilesOnScreen*tileLength))
        {
            SpawnTile();
            DeleteTile();
        }
    }
    private void SpawnTile(int prefabIndex=-1)
    {
        GameObject go;
        go = Instantiate(TilePrefabs[RandomPrefabIndex()]) as GameObject;
        go.transform.SetParent(transform);
        go.transform.position = Vector3.forward * spawnZ;
        spawnZ += tileLength;
        activeTiles.Add(go);


    }
    private void DeleteTile() 
    {
        Destroy(activeTiles[0]);
        activeTiles.RemoveAt(0);
    }
    private int RandomPrefabIndex() 
    {
        if (TilePrefabs.Length <= 1)
            return 0;
        int RandomIndex = lastPrefabIndex;
        while(RandomIndex==lastPrefabIndex)
        {
            RandomIndex = Random.Range(0,TilePrefabs.Length);

        }
        lastPrefabIndex = RandomIndex;
        return RandomIndex;
    
    }
    
}
