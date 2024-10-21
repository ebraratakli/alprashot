using System.Collections;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Monster : MonoBehaviour
{
    public float moveSpeed = 25f;
    public float detectRange = 25f;
    public float attackRange = 3f;
    public Transform target;
    public GameObject zombi;

    [SerializeField] private Animator animator;
    private bool isAttacking = false;
    private bool isChasing = false;

    public int Saldiri;
    public GameObject EkranFlas;
    public AudioSource monsterSound, attackSound;


    // public int soncan = KalanCan.OyuncuCan; // Baþlangýçta 3 can
    private float attackCooldown = 1.5f; // Saldýrý aralýðý
    private float currentCooldown = 0f;

    void Start()
    {
        
        zombi.GetComponent<Animator>().SetBool("walk", false);
        zombi.GetComponent<Animator>().SetBool("attack", false);
        zombi.GetComponent<Animator>().SetBool("Dying", false);
        zombi.GetComponent<Animator>().SetBool("Hit", false);
    }

    void Update()
    {
       
        if (target != null && zombi.GetComponent<Animator>().GetBool("Hit") == false && mon.DusmanSagligi > 0)
        {
            float distanceToTarget = Vector3.Distance(transform.position, target.position);

            if (distanceToTarget <= attackRange)
            {
                Attack();
            }
            else if (distanceToTarget <= detectRange)
            {
                MoveTowardsTarget();
                isChasing = true;
            }
            else
            {
                isChasing = false;
                animator.SetBool("walk", false);
                animator.SetBool("attack", false);
            }
        }

        // Saldýrý aralýðýný kontrol et
        if (currentCooldown > 0)
        {
            currentCooldown -= Time.deltaTime;
        }
        else
        {
            isAttacking = false; // Saldýrý süresi bittiðinde izin ver
        }
    }

   

    void MoveTowardsTarget()
    {
        Vector3 targetPosition = new Vector3(target.position.x, transform.position.y, target.position.z);
        transform.LookAt(targetPosition);
        transform.position += transform.forward * moveSpeed * Time.deltaTime;
        animator.SetBool("walk", true);
        animator.SetBool("attack", false);
        monsterSound.Play();

        transform.eulerAngles = new Vector3(0, transform.eulerAngles.y, 0);
    }


    void Attack()
    {
        animator.SetBool("walk", false);
        animator.SetBool("attack", true);

        if (!isAttacking && KalanCan.OyuncuCan > 0) // Saldýrý yapabilir ve caný varsa
        {
            isAttacking = true;
            KalanCan.OyuncuCan -= 5; // Caný azalt
            currentCooldown = attackCooldown; // Saldýrý aralýðýný baþlat

            if (KalanCan.OyuncuCan > 0)
            {
                // bir ses çal

                attackSound.Play();

                // Ekran flaþýný hýzlý bir þekilde aktif et ve pasifleþtir
                StartCoroutine(ActivateAndDeactivateFlash());
            }
        }
    }

    IEnumerator ActivateAndDeactivateFlash()
    {
        EkranFlas.SetActive(true); // Ekran flaþýný aktif et
        yield return new WaitForSeconds(0.1f); // Kýsa bir süre beklet
        EkranFlas.SetActive(false); // Ekran flaþýný pasifleþtir
    }
}
