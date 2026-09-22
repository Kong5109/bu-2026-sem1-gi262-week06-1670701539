using System.Collections.Generic;
using Unity.GraphToolkit.Editor;
using UnityEngine;

namespace MidtermExam.Prob02
{
    public class LinkedListSorter
    {
        /// <summary>
        /// เรียงลำดับตัวเลขใน LinkedList จากน้อยไปมาก (Ascending Order)
        /// </summary>
        /// <param name="list">LinkedList ของตัวเลข integer</param>
        /// <returns>LinkedList ที่ได้รับการเรียงลำดับจากน้อยไปมากแล้ว</returns>
        public LinkedList<int> SortAscending(LinkedList<int> list)
        {
            // TODO: Implement sorting algorithm for LinkedList<int> (Ascending)
            if (list == null)
            {
                return null;
            }
            if (list.Count == 1)
            {
                return list;
            }

            LinkedListNode<int> currentNode = list.First;
            for (int i = 0; i < list.Count - 1; i++)
            {
                LinkedListNode<int> minNode = currentNode;
                LinkedListNode<int> checkNode = currentNode;
                while (checkNode.Next != null)
                {
                    checkNode = checkNode.Next;
                    if (checkNode.Value < minNode.Value)
                    {
                        minNode = checkNode;
                    }
                }

                int temp = currentNode.Value;
                currentNode.Value = minNode.Value;
                minNode.Value = temp;

                currentNode = currentNode.Next;
            }
            return list;
        }

        /// <summary>
        /// เรียงลำดับตัวเลขใน LinkedList จากมากไปน้อย (Descending Order)
        /// </summary>
        /// <param name="list">LinkedList ของตัวเลข integer</param>
        /// <returns>LinkedList ที่ได้รับการเรียงลำดับจากมากไปน้อยแล้ว</returns>
        public LinkedList<int> SortDescending(LinkedList<int> list)
        {
            // TODO: Implement sorting algorithm for LinkedList<int> (Descending)
            if (list == null)
            {
                return null;
            }
            if (list.Count == 1)
            {
                return list;
            }

            LinkedListNode<int> currentNode = list.First;
            for (int i = 0; i < list.Count - 1; i++)
            {
                LinkedListNode<int> maxNode = currentNode;
                LinkedListNode<int> checkNode = maxNode;
                while (checkNode.Next != null)
                {
                    checkNode = checkNode.Next;
                    if (maxNode.Value < checkNode.Value)
                    {
                        maxNode = checkNode;
                    }
                }

                int temp = currentNode.Value;
                currentNode.Value = maxNode.Value;
                maxNode.Value = temp;

                currentNode = currentNode.Next;
            }
            return list;
        }
    }
}
