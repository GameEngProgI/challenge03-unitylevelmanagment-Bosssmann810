using UnityEngine;

public class LevelManager : MonoBehaviour
{
    public Transform _playerlocation;
    public GameObject _startlevel;
    public GameObject _level2;

    private GameObject currentlevel;

    private void Start()
    {
        _startlevel.SetActive(true);
        _level2.SetActive(false);

        currentlevel = _startlevel;
    }

    public void levelchange(GameObject leveltoload, Transform spawn)
    {
        currentlevel.SetActive(false);
        leveltoload.SetActive(true);
        currentlevel = leveltoload;
        _playerlocation.position = spawn.position;
    }
}
