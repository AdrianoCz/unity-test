using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using System.Threading.Tasks;

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
    public TMP_Text victoryText;
    private int counter = 0;
    
    IEnumerator SpawnRoutine()
    {

        while (points < MaxPoints)
        {
            
            Instantiate(Lixo, new Vector3(Random.Range(-maximumX, maximumX + 1), fixedY, fixedZ), Quaternion.identity);
            yield return new WaitForSeconds(timer);
            
        }
        victoryText.gameObject.SetActive(true);
    }
    public void AddToPoints(int x)
    {
        points += x;
        pointsText.text = "Pontuação: " + points.ToString();
    }
    public void StartGame()
    {
        
    }
    // Start is called before the first frame update
    void Start()
    {
    
        StartCoroutine(SpawnRoutine());
        pointsText.text = "Pontuação: 0";
        victoryText.gameObject.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {

    }
}
