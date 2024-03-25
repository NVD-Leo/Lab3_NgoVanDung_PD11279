using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CircleSpamn : MonoBehaviour
{
    public GameObject prefrabToSpamn;
    public GameObject Player;
    // Start is called before the first frame update

    // Update is called once per frame
    void Update()
    {
       
    }
    IEnumerator Start()
    {
        while (true)
        {
                
            GameObject circleSpamn = Instantiate(prefrabToSpamn, transform.position, Quaternion.identity);
            Vector3 direction = (Player.transform.position - circleSpamn.transform.position).normalized;
            Rigidbody rb = circleSpamn.GetComponent<Rigidbody>();
            if (rb != null)
            {
                rb.velocity = direction * 2f; // Đặt tốc độ là 2 đơn vị mỗi giây
            }
            else
            {
                Debug.LogWarning("Circle spamn không có Rigidbody.");
            }
        }
    }
}
