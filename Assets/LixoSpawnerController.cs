using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using System.Threading.Tasks;
using UnityEngine.UI;
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
    public TMP_Text defeatText;
    public AudioSource victorySound;
    public AudioSource music;
    public AudioSource defeatSound;
    public Button button;
    IEnumerator SpawnRoutine()
    {

        while (points < MaxPoints && points >= 0)
        {

            Instantiate(Lixo, new Vector3(Random.Range(-maximumX, maximumX + 1), fixedY, fixedZ), Quaternion.identity);
            yield return new WaitForSeconds(timer);

        }
        if (points < 0)
        {
            button.gameObject.SetActive(true);
            defeatText.gameObject.SetActive(true);
            music.Stop();
            defeatSound.Play();
        }
        else
        {
            button.gameObject.SetActive(true);
            victoryText.gameObject.SetActive(true);
            music.Stop();
            victorySound.Play();
        }
    }
    public void AddToPoints(int x)
    {
        points += x;
        pointsText.text = "Pontuacao: " + points.ToString();
    }
    public void StartGame()
    {

    }
    // Start is called before the first frame update
    void Start()
    {

        StartCoroutine(SpawnRoutine());
        pointsText.text = "Pontuacao: 0";
        victoryText.gameObject.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {

    }
}
