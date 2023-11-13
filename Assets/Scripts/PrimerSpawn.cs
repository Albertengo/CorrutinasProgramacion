using System.Collections;
using UnityEngine;

public class PrimerSpawn : MonoBehaviour
{
    //Actividad 1: hacer spawn random con instantiate.
    public GameObject enemy;
    int xPos;
    int yPos;
    
    void Start()
    {
        StartCoroutine(Spawn());
    }

    IEnumerator Spawn()
    {
        yield return new WaitForSeconds(3f);
        while (true)
        {
            xPos = Random.Range(-8, 8);
            yPos = Random.Range(-4, 4);
            Instantiate(enemy, new Vector3(xPos, yPos, 0), Quaternion.identity);
            yield return new WaitForSeconds(2f);
        }
    }
}
