using UnityEngine;
using UnityEngine.UI;

public class Main : MonoBehaviour
{
    public GameObject basicCoin;
    public Text text;
    public int currentScore = 0;
    
    void Start()
    {
        for (int i = 0; i < 20; i++) // Create 20  at random locations within the bounds of the map
        {
            Instantiate(basicCoin, new Vector3(Random.Range(-45, 45), 0.5f, Random.Range(-45, 45)), Quaternion.identity);
        }
    }

    // Update is called once per frame
    public void Update()
    {
        text.text = "Score: " + currentScore;
        if (currentScore == 20)
        {
            Menu.Win();
        }
    }
}
