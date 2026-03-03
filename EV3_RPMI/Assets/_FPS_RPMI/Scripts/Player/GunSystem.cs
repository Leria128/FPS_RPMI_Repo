using UnityEditor.ShaderGraph.Internal;
using UnityEngine;
using UnityEngine.InputSystem;

public class GunSystem : MonoBehaviour
{
    #region General Variables
    [Header("General References")]
    [SerializeField] Camera fpsCam; //Ref si disparamos desde el centro de la cam 
    [SerializeField] Transform shootPoint; //Ref si queremos disparar desde la punta del cañon
    [SerializeField] LayerMask impactLayer; //Layer con la que el Raycast interactúa
    RaycastHit hit; //Almacén de la información de los objetos a los que el Rayxasr puede impactar

    [Header("Weapon Parameters")]
    [SerializeField] int damage = 10 ;
    [SerializeField] float range = 100f;
    [SerializeField] float spread = 0;
    [SerializeField] float shootingCooldown = 0.2f;
    [SerializeField] float reloadTime = 1.5f;
    [SerializeField] bool allowaButtonHold = false;

    [Header("Bullet Manager")]
    [SerializeField] int ammoSize = 30;
    [SerializeField] int bulletsPerTap = 1;
    int bulletsLeft;

    [Header("Feedback References")]
    [SerializeField] GameObject impactEffect;

    [Header("Dev- Gun State Bools")]
    [SerializeField] bool shooting;
    [SerializeField] bool canShoot;
    [SerializeField] bool reloading;

    #endregion

    private void Awake()
    {
        bulletsLeft = ammoSize;
        canShoot = true;
    }

 

    // Update is called once per frame
    void Update()
    {
        
    }


    void Shoot() 
    { 
    Vector3 direction = fpsCam.transform.forward;
        direction.x += Random.Range(-spread, spread);    
        direction.y += Random.Range(-spread, spread);   
        
        if (Physics.Raycast(fpsCam.transform.position, direction, out hit,range,impactLayer)) 
        {
            Debug.Log(hit.collider.name);
        }
    }

    #region Input Methods
    public void OnShoot(InputAction.CallbackContext context) 
    { 
    
    }
    public void Reload (InputAction.CallbackContext context) 
    { 
    
    }

    #endregion
}
