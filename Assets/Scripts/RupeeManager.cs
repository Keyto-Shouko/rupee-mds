using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RupeeManager : MonoBehaviour
{

    public Transform container;
    public Transform spawner;
    public Rupee rupeePrefab;
    private List<Rupee> _rupees = new List<Rupee>();
    public float delay = 1.5f;
    private Coroutine _spawnCoroutine;

    // Start is called before the first frame update
    void Start()
    {
        StartSpawning();
    }

    private void Spawn(){
        Rupee rupee = Instantiate(rupeePrefab, spawner.position, Quaternion.identity, container);
        _rupees.Add(rupee);
    }

    private void StartSpawning(){
        _spawnCoroutine = StartCoroutine(SpawnCoroutine());
    }

    private void StopSpawning(){
        if(_spawnCoroutine != null){
            StopCoroutine(_spawnCoroutine);
            _spawnCoroutine = null;
        }
    }

    private IEnumerator SpawnCoroutine(){
        Spawn();
        yield return new WaitForSeconds(delay);
        StartSpawning();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
