using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(LineRenderer))] // Зависимый хы-хы-хы
public class RaycastGun : MonoBehaviour
{
    public Camera playerCamera;
    public Transform laserOrigin;
    public ParticleSystem bloodPrefab;
    //float bloodDuration;
    [Space]
    public float gunRange = 50f;
    public float ReloadTime = 1f;
    public float laserDuration = 5f;

    LineRenderer laserLine;
    float fireTimer;

    void Awake()
    {
        laserLine = GetComponent<LineRenderer>();
        //bloodDuration = bloodPrefab.main.duration;
    }

    void Update()
    {
        fireTimer += Time.deltaTime;
        if (Input.GetMouseButton(0) && fireTimer > ReloadTime)
        {
            fireTimer = 0;
            laserLine.SetPosition(0, laserOrigin.position);
            Vector3 rayOrigin = playerCamera.ViewportToWorldPoint(new Vector3(0.5f, 0.5f, 0));
            RaycastHit hit;
            if (Physics.Raycast(rayOrigin, playerCamera.transform.forward, out hit, gunRange)) {
                laserLine.SetPosition(1, hit.point);
                //Debug.Log($"Попадание в: {hit.transform.gameObject}, {hit.point}"); - - - Пусть пока побудет тут, вдруг еще пригодится
                if (hit.collider.gameObject.CompareTag("NPC")) { StartCoroutine(Bleeding(hit)); print("Кровотечение"); }
            }
            else {
                laserLine.SetPosition(1, rayOrigin + (playerCamera.transform.forward * gunRange));
            }
            StartCoroutine(ShootLaser());
        }
    }

    IEnumerator ShootLaser()
    {
        laserLine.enabled = true;
        yield return new WaitForSeconds(laserDuration);
        laserLine.enabled = false;
    }

    IEnumerator Bleeding(RaycastHit hit) {
        ParticleSystem bloodSplatter = Instantiate(bloodPrefab, hit.point, Quaternion.identity);
        bloodSplatter.Play();
        yield return new WaitForSeconds(bloodPrefab.main.duration - 0.1f);
        Destroy(bloodSplatter.gameObject);
    }
}