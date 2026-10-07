using UnityEngine;
using UnityEngine.UI;

public class Main : MonoBehaviour
{
    public GameObject basicCoin;
    public GameObject goodCoin;
    public Text text;
    public int currentScore = 0;
    public Menu menu;
    
    void Start()
    {
        for (int i = 0; i < 10; i++) // Create 20  at random locations within the bounds of the map
        {
            Instantiate(goodCoin, new Vector3(Random.Range(-45, 45), 0.5f, Random.Range(-45, 45)), Quaternion.identity);
        }
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
            menu.Win();
        }
    }
}
