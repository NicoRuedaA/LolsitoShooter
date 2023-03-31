using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Cinemachine;
using StarterAssets;
using Unity.Mathematics;
using Unity.Netcode;
using UnityEngine.InputSystem;

/*public class ThirdPersonShooterController : MonoBehaviour{
    private PlayerManager _data;
    
    [SerializeField] private CinemachineVirtualCamera aimVirtualCamera;
    [SerializeField] private float normalsensitivity;
    [SerializeField] private float pointsensitivity;
    [SerializeField] private LayerMask pointColliderMask = new LayerMask();
    [SerializeField] private Transform debugTransform;
    [SerializeField] private Transform pfBulletProjectile;
    [SerializeField] private Transform spawnBulletPosition;
    [SerializeField] private Transform vfxHitGreen;
    [SerializeField] private Transform vfxHitRed;

    [SerializeField] private Animator _animator;

    private ThirdPersonController _thirdPersonController;
    private StarterAssetsInputs _starterAssetsInputs;

    private void Awake(){


        
        _starterAssetsInputs = GetComponent<StarterAssetsInputs>();
        _thirdPersonController = GetComponent<ThirdPersonController>();
        _data = GetComponent<PlayerManager>();
        
        _animator = transform.Find("Geometry").transform.Find("jax").GetComponent<Animator>();
        //_animator = GetComponent<Animator>();

    }

    private void Start(){
        Debug.Log(transform.Find("Geometry").transform.Find("jax").GetComponent<pruebaparaborrar>().imprimir);
    }


    private void Update(){
        Vector3 mouseWorldPosition = Vector3.zero;

        Vector2 screenCenterPoint = new Vector2(Screen.width / 2f, Screen.height/2f);
        Ray ray = Camera.main.ScreenPointToRay(screenCenterPoint);
        Transform hitTransform = null;
        if (Physics.Raycast(ray, out RaycastHit raycastHit, 999f, pointColliderMask)){
            debugTransform.position = raycastHit.point;
            mouseWorldPosition = raycastHit.point;
            hitTransform = raycastHit.transform;
        }
        
        
        if (_starterAssetsInputs.point){
            aimVirtualCamera.gameObject.SetActive(true);
            _thirdPersonController.SetSensitivity(pointsensitivity);
            _thirdPersonController.SetRotateOnMove(false);
            _animator.SetLayerWeight(1, Mathf.Lerp(_animator.GetLayerWeight(1), 1f, Time.deltaTime*10f));

            Vector3 worldAimTarget = mouseWorldPosition;
            worldAimTarget.y = transform.position.y;
            Vector3 aimDirection = (worldAimTarget - transform.position).normalized;

            transform.forward = Vector3.Lerp(transform.forward, aimDirection, Time.deltaTime * 20f);

        }
        else{
            aimVirtualCamera.gameObject.SetActive(false);
            _thirdPersonController.SetSensitivity(normalsensitivity);
            _thirdPersonController.SetRotateOnMove(true);
            _animator.SetLayerWeight(1, Mathf.Lerp(_animator.GetLayerWeight(1), 0f, Time.deltaTime*10f));
        }

        if (_starterAssetsInputs.shoot){
            if (hitTransform != null){
                if (hitTransform.GetComponent<hitTarget>() != null){

                    float distance = Vector3.Distance (gameObject.transform.position, hitTransform.position);
                    //hit target
                    //Instantiate(vfxHitGreen, transform.position, Quaternion.identity);
                    if(distance<_data.get_attack_range())Debug.Log("hiteado");
                    else Debug.Log("muy lejos");

                }
                else{
                    //no hit
                    //Instantiate(vfxHitRed, transform.position, Quaternion.identity);
                    Debug.Log("no hiteado");
                }
            }
            //Vector3 aimDir = (mouseWorldPosition - spawnBulletPosition.position).normalized;
            //Instantiate(pfBulletProjectile, spawnBulletPosition.position, Quaternion.LookRotation(aimDir, Vector3.up));
            _starterAssetsInputs.shoot = false;
        }

    }
}*/

public class ThirdPersonShooterController : NetworkBehaviour{
    private PlayerManager _data;
    
    [SerializeField] private CinemachineVirtualCamera aimVirtualCamera;
    [SerializeField] private float normalsensitivity;
    [SerializeField] private float pointsensitivity;
    [SerializeField] private LayerMask pointColliderMask = new LayerMask();
    [SerializeField] private Transform debugTransform;
    [SerializeField] private Transform pfBulletProjectile;
    [SerializeField] private Transform spawnBulletPosition;
    [SerializeField] private Transform vfxHitGreen;
    [SerializeField] private Transform vfxHitRed;

    [SerializeField] private Animator _animator;

    private ThirdPersonController _thirdPersonController;
    private StarterAssetsInputs _starterAssetsInputs;

    private void Awake(){


        
        _starterAssetsInputs = GetComponent<StarterAssetsInputs>();
        _thirdPersonController = GetComponent<ThirdPersonController>();
        _data = GetComponent<PlayerManager>();
        
        _animator = transform.Find("Geometry").transform.Find("jax").GetComponent<Animator>();
        //_animator = GetComponent<Animator>();

    }

    private void Start(){
        Debug.Log(transform.Find("Geometry").transform.Find("jax").GetComponent<pruebaparaborrar>().imprimir);
    }


    private void Update(){
        Vector3 mouseWorldPosition = Vector3.zero;

        Vector2 screenCenterPoint = new Vector2(Screen.width / 2f, Screen.height/2f);
        Ray ray = Camera.main.ScreenPointToRay(screenCenterPoint);
        Transform hitTransform = null;
        if (Physics.Raycast(ray, out RaycastHit raycastHit, 999f, pointColliderMask)){
            debugTransform.position = raycastHit.point;
            mouseWorldPosition = raycastHit.point;
            hitTransform = raycastHit.transform;
        }
        
        
        if (_starterAssetsInputs.point){
            aimVirtualCamera.gameObject.SetActive(true);
            _thirdPersonController.SetSensitivity(pointsensitivity);
            _thirdPersonController.SetRotateOnMove(false);
            _animator.SetLayerWeight(1, Mathf.Lerp(_animator.GetLayerWeight(1), 1f, Time.deltaTime*10f));

            Vector3 worldAimTarget = mouseWorldPosition;
            worldAimTarget.y = transform.position.y;
            Vector3 aimDirection = (worldAimTarget - transform.position).normalized;

            transform.forward = Vector3.Lerp(transform.forward, aimDirection, Time.deltaTime * 20f);

        }
        else{
            aimVirtualCamera.gameObject.SetActive(false);
            _thirdPersonController.SetSensitivity(normalsensitivity);
            _thirdPersonController.SetRotateOnMove(true);
            _animator.SetLayerWeight(1, Mathf.Lerp(_animator.GetLayerWeight(1), 0f, Time.deltaTime*10f));
        }

        if (_starterAssetsInputs.shoot){
            if (hitTransform != null){
                if (hitTransform.GetComponent<hitTarget>() != null){

                    float distance = Vector3.Distance (gameObject.transform.position, hitTransform.position);
                    //hit target
                    //Instantiate(vfxHitGreen, transform.position, Quaternion.identity);
                    if(distance<_data.get_attack_range())Debug.Log("hiteado");
                    else Debug.Log("muy lejos");

                }
                else{
                    //no hit
                    //Instantiate(vfxHitRed, transform.position, Quaternion.identity);
                    Debug.Log("no hiteado");
                }
            }
            //Vector3 aimDir = (mouseWorldPosition - spawnBulletPosition.position).normalized;
            //Instantiate(pfBulletProjectile, spawnBulletPosition.position, Quaternion.LookRotation(aimDir, Vector3.up));
            _starterAssetsInputs.shoot = false;
        }

    }
}
