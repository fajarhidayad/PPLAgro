using UnityEngine;
using System.Collections;

public class PlaceMonster : MonoBehaviour
{

    public GameObject monsterPrefab;
    public GameObject monsterPrefab2;
    private GameObject monster;
    private GameObject monster2;
    private GameManagerBehavior gameManager;
    Shop shop;

    //public static int turets = Shop.getTurret();

    // Use this for initialization
    void Start()
    {
        gameManager = GameObject.Find("GameManager").GetComponent<GameManagerBehavior>();
        //turets = 1;
    }

    // Update is called once per frame
    void Update()
    {

    }

    private bool CanPlaceMonster()
    {

        int cost = monsterPrefab.GetComponent<MonsterData>().levels[0].cost;
        return monster == null && gameManager.Gold >= cost;
    }

    private bool CanPlaceMonster2()
    {

        int cost = monsterPrefab2.GetComponent<MonsterData>().levels[0].cost;
        return monster2 == null && gameManager.Gold >= cost;
    }

    //1
    void OnMouseUp()
    {
        //2
       // Debug.Log(turets);
        if (Shop.getTurret()== 1)
        {
            if (CanPlaceMonster())
            {
                //3
                monster = (GameObject)Instantiate(monsterPrefab, transform.position, Quaternion.identity);
                //4
                AudioSource audioSource = gameObject.GetComponent<AudioSource>();
                audioSource.PlayOneShot(audioSource.clip);

                gameManager.Gold -= monster.GetComponent<MonsterData>().CurrentLevel.cost;
            }
            else if (CanUpgradeMonster())
            {
                monster.GetComponent<MonsterData>().IncreaseLevel();
                AudioSource audioSource = gameObject.GetComponent<AudioSource>();
                audioSource.PlayOneShot(audioSource.clip);

                gameManager.Gold -= monster.GetComponent<MonsterData>().CurrentLevel.cost;
            }
        }
        else if (Shop.getTurret() == 2)
        {
            if (CanPlaceMonster2())
            {
                //3
                monster2 = (GameObject)Instantiate(monsterPrefab2, transform.position, Quaternion.identity);
                //4
                AudioSource audioSource = gameObject.GetComponent<AudioSource>();
                audioSource.PlayOneShot(audioSource.clip);

                gameManager.Gold -= monster2.GetComponent<MonsterData>().CurrentLevel.cost;
            }
            else if (CanUpgradeMonster2())
            {
                monster2.GetComponent<MonsterData>().IncreaseLevel();
                AudioSource audioSource = gameObject.GetComponent<AudioSource>();
                audioSource.PlayOneShot(audioSource.clip);

                gameManager.Gold -= monster2.GetComponent<MonsterData>().CurrentLevel.cost;
            }
        }
    }

    private bool CanUpgradeMonster()
    {
        if (monster != null)
        {
            MonsterData monsterData = monster.GetComponent<MonsterData>();
            MonsterLevel nextLevel = monsterData.GetNextLevel();
            if (nextLevel != null)
            {
                return gameManager.Gold >= nextLevel.cost;
            }
        }
        return false;
    }

    private bool CanUpgradeMonster2()
    {
        if (monster2 != null)
        {
            MonsterData monsterData = monster2.GetComponent<MonsterData>();
            MonsterLevel nextLevel = monsterData.GetNextLevel();
            if (nextLevel != null)
            {
                return gameManager.Gold >= nextLevel.cost;
            }
        }
        return false;
    }

}
