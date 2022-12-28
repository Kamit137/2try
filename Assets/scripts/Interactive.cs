using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Interactive : MonoBehaviour
{
    [SerializeField] private Camera _fpcCamera;
    private Ray _ray;
    private RaycastHit _hit = new RaycastHit();
    public bool player_key = false;

    [SerializeField] private float _maxDistanceRay;

    void Update()
    {
        Ray();
        DrawRay();
    }

    private void Ray()
    {
        _ray = _fpcCamera.ScreenPointToRay(new Vector2(Screen.width / 2, Screen.height / 2));
    }

    private void DrawRay()
    {
        if (Physics.Raycast(_ray, out _hit, _maxDistanceRay))
        {
            Debug.DrawRay(_ray.origin, _ray.direction * _maxDistanceRay, Color.blue);
            if (_hit.transform.TryGetComponent<Item_Key>(out Item_Key item))
            {
                if (Input.GetKeyDown(KeyCode.E))
                {
                   item.Item();
                    player_key = true;

                }
            }
            //---------------------------------------------
            if (_hit.transform.TryGetComponent<Door>(out Door door))
            {
                if (Input.GetKeyDown(KeyCode.E) & (player_key == true))
                {
                   door.Open();
                }
            }
        }

        if (_hit.transform == null)
        {
            Debug.DrawRay(_ray.origin, _ray.direction * _maxDistanceRay, Color.red);
        }
    }


}