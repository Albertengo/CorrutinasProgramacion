using System.Collections;
using UnityEngine;

public class SegundoSpawn : MonoBehaviour
{
    //Actividad 2: hacer spawn random y tiempo random con instantiate.
    public GameObject enemy2;
    int xPos;
    int yPos;
    int tiempo;

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
            tiempo = Random.Range(1, 4);
            Instantiate(enemy2, new Vector3(xPos, yPos, 0), Quaternion.identity);
            yield return new WaitForSeconds(tiempo);
        }
    }
}
