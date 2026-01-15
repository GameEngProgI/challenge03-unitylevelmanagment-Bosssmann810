using UnityEngine;

public class LevelManager : MonoBehaviour
{
    public GameObject currentlevel;
    public GameObject nextlevel;

    public void levelchange()
    {
        currentlevel.SetActive(false);
        nextlevel.SetActive(true);
        // Start is called once before the first execution of Update after the MonoBehaviour is created
        void Start()
        {

        }

        // Update is called once per frame
        void Update()
        {

        }
    }
}
