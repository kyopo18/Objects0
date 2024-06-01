using UnityEngine;

public class Nuke : PickUp
{
    public override void ActivateNuke()
    {
        base.ActivateNuke();
        DestroyAllExceptPlayer();
    }

    private void DestroyAllExceptPlayer()
    {
        // Find all objects of type Enemy and PickUp and destroy them
        DestroyObjectsByTag("Enemy");
        DestroyObjectsByTag("PickUp");
    }

    private void DestroyObjectsByTag(string tag)
    {
        GameObject[] objects = GameObject.FindGameObjectsWithTag(tag);
        foreach (GameObject obj in objects)
        {
            if (obj != gameObject) // Ensure the nuke itself is not destroyed immediately
            {
                Destroy(obj);
            }
        }
    }
}

