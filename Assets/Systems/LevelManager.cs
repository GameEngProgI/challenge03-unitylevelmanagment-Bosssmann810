using UnityEngine;

public class LevelManager : MonoBehaviour
{
    private GameObject player;
    public GameObject _startlevel;
    public GameObject _level2;

    private GameObject currentlevel;

    private void Start()
    {
        player = SurviceHub.Instance.playerController.gameObject;
        _startlevel.SetActive(true);
        _level2.SetActive(false);

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
