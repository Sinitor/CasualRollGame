using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    public GameObject[] _prefabs;

    private void Start()
    {
        StartCoroutine(SpawnEnemy());
    } 

    private void Repeat()
    {
        StartCoroutine(SpawnEnemy());
    } 

    IEnumerator SpawnEnemy()
    {
        yield return new WaitForSeconds(3);

        Instantiate(_prefabs[Random.Range(0, 2)], new Vector2(-10, Random.Range(-1.4f, 1.4f)), Quaternion.identity);
        Repeat();
    }
}
