using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LightController : MonoBehaviour
{
    public GameObject lightObject;

    private Rigidbody rb;
    private Light lampLight;
    private bool hit = false;

    // Start is called before the first frame update
    void Start()
    {
        lampLight = lightObject.GetComponent<Light>();
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnCollisionEnter(Collision collision) {
        if (collision.gameObject.tag == "Player") {
            rb.isKinematic = false; // enable gravity and physics
            if (!hit){
                hit = true;
                StartCoroutine(BreakLight()); // break the light
            }
        }
    }

    private IEnumerator BreakLight() {
        StartCoroutine(FlashLight());
        yield return new WaitForSeconds(1.0f);
        StartCoroutine(FlashLight());
    }
    private IEnumerator FlashLight() {
        lightObject.SetActive(false);
        yield return new WaitForSeconds(0.2f);
        lightObject.SetActive(true);
        yield return new WaitForSeconds(0.5f);
        lightObject.SetActive(false);
        yield return new WaitForSeconds(0.1f);
        lightObject.SetActive(true);
        yield return new WaitForSeconds(0.2f);
        lightObject.SetActive(false);
        yield return new WaitForSeconds(0.3f);
        lightObject.SetActive(true);
        yield return new WaitForSeconds(0.15f);
        lightObject.SetActive(false);
        yield return new WaitForSeconds(0.1f);
        lightObject.SetActive(true);
        yield return new WaitForSeconds(0.05f);
        lightObject.SetActive(false);
        yield return new WaitForSeconds(0.15f);
        lightObject.SetActive(true);
        yield return new WaitForSeconds(0.05f);
        lightObject.SetActive(false);
        yield return new WaitForSeconds(0.1f);
        lightObject.SetActive(true);
        yield return new WaitForSeconds(0.07f);

        lightObject.SetActive(false);
    }
}
