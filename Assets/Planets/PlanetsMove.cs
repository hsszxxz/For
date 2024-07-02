using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;
namespace ns
{
    ///<summary>
    ///
    ///<summary>
    public class PlanetsMove: MonoBehaviour
    {
        public PlanetsBasic PlanetsBasic;
        private float x, y;
        private float speed;
        private void Start()
        {
            x= transform.localScale.x;
            y= transform.localScale.y;
            speed = PlanetsBasic.planetsMoveSpeed;
        }
        private void Move()
        {
            float horizontalInput = Input.GetAxis("Horizontal");
            if (horizontalInput < 0)
            {
                transform.localScale = new Vector3(-x, y, 1);
            }
            else if (horizontalInput > 0)
            {
                transform.localScale = new Vector3(x, y, 1);
            }
            float verticalInput = Input.GetAxis("Vertical");
            if (verticalInput < 0)
            {
                transform.localScale = new Vector3(x, -y, 1);
            }
            else if (verticalInput > 0)
            {
                transform.localScale = new Vector3(x, y, 1);
            }
            transform.Translate(speed * Time.deltaTime * horizontalInput, speed* Time.deltaTime * verticalInput, 0);
        }



        private void Update()
        {
            if (IsOutsideCircle(transform.position) )
            {
                transform.position=GetPositionOnCircleBoundary(transform.position, PlanetsBasic.boundarPosition.position, PlanetsBasic.boundarRadius);
            }
            Move();
        }


        private bool IsOutsideCircle(Vector3 position)
        {
            return (position - PlanetsBasic.boundarPosition.position).magnitude > PlanetsBasic.boundarRadius;
        }
        private Vector3 GetPositionOnCircleBoundary(Vector3 position, Vector3 center, float radius)
        {
            Vector3 direction = position - center;
            float distance = direction.magnitude;
            if (distance > radius) 
            { 
                direction.Normalize(); 
                return center + (direction * radius);
            }
            return position;
        }
    }
}

