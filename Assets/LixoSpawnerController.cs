using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class LixoSpawnerController : MonoBehaviour
{
    public float maximumX;
    public float fixedY;
    public float fixedZ;
    public float timer;
    public GameObject Lixo;
    public int MaxPoints;
    public int points = 0;

    public TMP_Text pointsText;

    IEnumerator SpawnRoutine() {
        while(points<MaxPoints){
            Instantiate(Lixo, new Vector3(Random.Range(-maximumX, maximumX+1), fixedY, fixedZ), Quaternion.identity);
            yield return new WaitForSeconds(timer);
        }

    }
    public void AddToPoints(int x)
    {
        points += x;
        pointsText.text = points.ToString();
    }
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(SpawnRoutine());
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
