using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class SpawnControl : MonoBehaviour
{
    [SerializeField] private PinControl PinPrefab;
    [SerializeField] private PinControl OldPinObject;
    [SerializeField] private TMP_Text RemainText;
    [SerializeField] private int SmallCircleSpawnSize;

    bool SpawnTemp;
    private void Start()
    {
        OldPinObject.SpawnSize = SmallCircleSpawnSize;
        remainSize = SmallCircleSpawnSize;
    }
   
    public IEnumerator Spawn()
    {
        if (SpawnTemp) yield break;
        SpawnTemp = true;
        OldPinObject.WasSpawned();
        yield return new WaitForSeconds(0.5f);
        if (SmallCircleSpawnSize > 1)
        {
            PinControl smallCircle = Instantiate(PinPrefab, transform.position, Quaternion.identity);
            OldPinObject = smallCircle;
            SmallCircleSpawnSize--;
            OldPinObject.SpawnSize = SmallCircleSpawnSize;
        }
        else
        {
            GameManager.instance.GameEndActive(true);
        }
        SpawnTemp = false;
    }

    public int remainSize
    {
        get { return int.Parse(RemainText.ToString()); }
        set { RemainText.text = value.ToString(); }
    }
}
