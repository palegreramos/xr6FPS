using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.XR;

public class ShootController : MonoBehaviour
{
    [Header("Disparo")]
    [SerializeField] private GameObject prefabBullet;
    [SerializeField] private float shootForce;
    [SerializeField] private Transform shootPoint;
    [SerializeField] private GameObject particulasHumo;

    private GameObject currentBullet;

    public void OnShoot(InputAction.CallbackContext context)
    {
        if (context.performed)
        {
           Disparar();
        }
    }
    void Disparar()
    {
        StartCoroutine(VibrateForSeconds(0.5f, 1f, 0.3f, OVRInput.Controller.RTouch));
        currentBullet = Instantiate(prefabBullet, shootPoint.position, shootPoint.rotation);
        currentBullet.GetComponent<Rigidbody>().AddForce(shootPoint.forward * shootForce);
        Destroy(currentBullet, 3f);
        GameObject particulas = Instantiate(particulasHumo, shootPoint.position, shootPoint.rotation);
        Destroy(particulas, 3f);

    }

    IEnumerator VibrateForSeconds(float duration, float frequency, float amplitude, OVRInput.Controller controller)
    {
        OVRInput.SetControllerVibration(frequency, amplitude, controller);
        yield return new WaitForSeconds(duration);
        OVRInput.SetControllerVibration(0, 0, controller);
    }

}
