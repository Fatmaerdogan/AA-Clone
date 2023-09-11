using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class PinControl : MonoBehaviour
{
    [SerializeField] private GameObject pinPoint;

    [SerializeField] private TMP_Text SpawnSizeText;

    PinMovement PinMovement;

    private void Start()
    {
        PinMovement = GetComponent<PinMovement>();
    }
    public int SpawnSize
    {
        get { return int.Parse(SpawnSizeText.ToString()); }
        set { SpawnSizeText.text = value.ToString(); }
    }

    public bool PinPointActive
    {
        get { return pinPoint.activeSelf; }
        set { pinPoint.SetActive(value); }
    }
    public void WasSpawned()
    {
        PinMovement.UpMoveSpeed = 50;
    }
}
