using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerManager : MonoBehaviour
{
  public GameObject turret;

  // Use this for initialization
  void Start()
  {

  }

  // Update is called once per frame
  void Update()
  {
    PlaceTurret();
  }

  protected void PlaceTurret()
  {
    var ray = Camera.main.ScreenPointToRay(Input.mousePosition);
    RaycastHit hit;
    var forward = transform.TransformDirection(Vector3.forward);

    Debug.DrawRay(ray.origin, forward, Color.red);

    if (Input.GetMouseButtonDown(0))
    {
      
      if (Physics.Raycast(ray, out hit))
      {
        var tile = hit.collider.GetComponent<TileManager>();

        Instantiate(turret, new Vector3(tile.transform.position.x, tile.transform.position.y +  0.081f, tile.transform.position.z), Quaternion.identity, tile.gameObject.transform);
      }
    }
  }
}
