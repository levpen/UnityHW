using System.Collections;
using UnityEngine;

public class WanderingAI : MonoBehaviour
{
    public float speed = 10.0f;
    public float obstacleRange = 0.3f;
    [SerializeField] GameObject fireballPrefab;
    private GameObject fireball;
    [SerializeField] private float _rotationTime = 1f;


    private bool _rotating;

    private void Start()
    {
        _rotating = false;
    }

    void Update()
    {
        if (!_rotating)
        {
            transform.Translate(0, 0, speed * Time.deltaTime);
        }

        Ray ray = new Ray(transform.position, transform.forward);
        RaycastHit hit;

        if (Physics.SphereCast(ray, 0.75f, out hit))
        {
            GameObject hitObject = hit.transform.gameObject;
            if (hitObject.GetComponent<PlayerCharacter>())
            {
                if (fireball == null)
                {
                    fireball = Instantiate(fireballPrefab) as GameObject;
                    fireball.transform.position = transform.TransformPoint(Vector3.forward * 1.5f);
                    fireball.transform.rotation = transform.rotation;
                }
            }
            else if (hit.distance < obstacleRange && !_rotating)
            {
                _rotating = true;

                StartCoroutine(Rotate(_rotationTime));
            }
        }
    }

    private IEnumerator Rotate(float rotateTime)
    {
        var qTo = Quaternion.Euler(new Vector3(0, Random.Range(-110f, 110f), 0));

        var startRot = transform.rotation;
        var time = 0f;

        while (time <= 1f)
        {
            transform.rotation = Quaternion.Lerp(startRot, qTo, time);
            time += Time.deltaTime / rotateTime;
            yield return null;
        }

        _rotating = false;
    }
}