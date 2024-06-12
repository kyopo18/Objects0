using JetBrains.Annotations;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.Rendering.Universal;
using static UnityEngine.RuleTile.TilingRuleOutput;

public class Spike : MonoBehaviour
{
    [SerializeField] private float timeToExtend;
    [SerializeField] private float timeToRetract;
    private string targetTag;
    private int damage;
    private bool attacking = false;
    private float spikesIn = 0.8f , spikesOut = 1.63f;  

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag(targetTag))
        {
            //DO Damage to enemy
            collision.gameObject.GetComponent<IDamageable>().ReceiveDamage(damage);
            Debug.Log("Its hitting!");
        }
    }
    public void SetupSpike(string target, int dmg)
    {
        Debug.Log("Spike setup");
        targetTag = target;
        damage = dmg;   
    }
    IEnumerator Retract()
    {
        float time = 0;
        Vector3 startPos = new Vector3(spikesOut, gameObject.transform.localScale.y, gameObject.transform.localScale.z);
        Vector3 endPos = new Vector3(spikesIn, gameObject.transform.localScale.y, gameObject.transform.localScale.z);
        while (time < timeToRetract)
        {
            float t = time / timeToRetract;
            t = Mathf.Sin(t * Mathf.PI * 0.5f);
            transform.localScale = Vector3.Lerp(startPos, endPos, t);
            time += Time.deltaTime;
            yield return null;
        }
        transform.localScale = endPos;
    }
    IEnumerator Extend()
    {
        float time = 0;
        Vector3 startPos = new Vector3(spikesIn, gameObject.transform.localScale.y, gameObject.transform.localScale.z);
        Vector3 endPos = new Vector3(spikesOut, gameObject.transform.localScale.y, gameObject.transform.localScale.z);
        while (time < timeToExtend)
        {
            transform.localScale = Vector3.Lerp(startPos, endPos, time / timeToExtend);
            time += Time.deltaTime;
            yield return null;
        }
        transform.localScale = endPos;
        if (attacking)
        {
            StartCoroutine(Retract());
        }
    }
    public void PassiveMode()
    {
        attacking = false;
    }
    public void AttackMode()
    {
        if (!attacking)
        {
            StartCoroutine(Extend());
            attacking = true;
        }
        else return;
        
    }
}
