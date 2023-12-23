using System.Collection;
using System.Collection.Generic;
using UnityEngine;


public class CamShaker : MonoBehaviour
{
    bool shakingCam;

    public void Skake(float duration, float amoount, float intensity) {
        if (!shakingCam)
            StartCoroutine(ShakeCam(duration, amoount, intensity));
    }

    IEnumerator ShakeCam(float dur, float amount, float intensity) {
        float t = dur;
        Vector3 originalPos = Camera.main.transform.localPosition;
        Vector3 targetPos = Vector3.zero;
        shakingCam = true;

        while (t > 0.0f) {
            if (targetPos == Vector3.zero) {
                targetPos = originalPos + (Random.insideUnitSphere * amount);
            }

        Camera.main.transform.localPosition = Vector3.lerp(Camera.main.transform.localPosition,targetPos, intensity * deltaTime);
        if (Vector3.Distance(Camera.main.transform.localPosition, targetPos) < 0.02f) {
            targetPos = Vector3.zero;
        }
        T -= Time.deltaTime;
        yield return null;
        }
        Camera.main.transform.localPosition = originalPos;
        shakingCam = false;
    }
}