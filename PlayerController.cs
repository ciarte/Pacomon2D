using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Random = UnityEngine.Random;



[RequireComponent(typeof(Animator))]
public class PlayerController : MonoBehaviour
{
    private bool isMoving;
    private Vector2 input;
    private Animator _animator;

    public float speed;
    public LayerMask solidObjectsLayer, pacomonLayer;




    private void Awake()
    {
        _animator = GetComponent<Animator>();
    }
    private void Update()
    {
        if (!isMoving)
        {
            input.x = Input.GetAxisRaw("Horizontal");
            input.y = Input.GetAxisRaw("Vertical");

            if (input.x != 0)
            {
                input.y = 0;
            }

            if (input != Vector2.zero)
            {
                _animator.SetFloat("MoveX", input.x);
                _animator.SetFloat("MoveY", input.y);

                var targetPosition = transform.position;
                targetPosition.x += input.x;
                targetPosition.y += input.y;
                if (IsAvailable(targetPosition))
                {
                    StartCoroutine(MoveTowards(targetPosition));
                }
            }
        }
    }

    private void LateUpdate()
    {
        _animator.SetBool("Is Moving", isMoving);
    }



    IEnumerator MoveTowards (Vector3 destination)
    {
        isMoving = true;

        while(Vector3.Distance(transform.position, destination) > Mathf.Epsilon)
        {
            transform.position = Vector3.MoveTowards(transform.position, destination, speed * Time.deltaTime);
            yield return null;
        }

        transform.position = destination;
        isMoving = false;

        CheckForPacomon();
    }
    /// <summary>
    /// El metodo comprueba la zona a la q se quiere acceder este disponible
    /// </summary>
    /// <param name="target"></param>
    /// <returns>true si el target esta disponible. y false en caso contrario</returns>
    private bool IsAvailable(Vector3 target)
    {
        if (Physics2D.OverlapCircle(target, 0.15f, solidObjectsLayer) != null)
        {
            return false;
        }
        return true;
    }
    private void CheckForPacomon()
    {
        if(Physics2D.OverlapCircle(transform.position, 0.2f, pacomonLayer) !=null)
        {
            if (Random.Range(0, 100) < 10)
            {
                Debug.Log("Empieza la batalla");
            }
        }
    }
}
