using UnityEngine;

public class LevelManager : MonoBehaviour
{
    private GameObject player;
    public GameObject _startlevel;
    public GameObject _level2;
    public GameObject _level3;
    public GameObject _level4;

    private GameObject currentlevel;

    private void Start()
    {
        player = SurviceHub.Instance.playerController.gameObject;
        _startlevel.SetActive(true);
        _level2.SetActive(false);
        _level3.SetActive(false);
        _level4.SetActive(false);   

        currentlevel = _startlevel;
    }

    public void levelchange(GameObject leveltoload, Transform spawn)
    {
        currentlevel.SetActive(false);
        leveltoload.SetActive(true);
        currentlevel = leveltoload;
        player.transform.position = spawn.position;
    }
}
