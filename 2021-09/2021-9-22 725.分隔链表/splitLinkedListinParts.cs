public class Solution
{
    public ListNode[] SplitListToParts(ListNode head, int k)
    {
        ListNode p = head;

        int length = 0;
        while (p != null)
        {
            length++;
            p = p.next;
        }

        int smalldividelength = length / k;
        int bigdividelength = smalldividelength + 1;
        int bigdividecount = length % k;
        ListNode[] listarray = new ListNode[k];

        int i = 0;
        int j = 0;
        p = head;
        ListNode q = head;

        while (p != null)
        {
            if (smalldividelength == 0)
            {
                listarray[j] = p;
                q = p;
                p = p.next;
                q.next = null;
                j++;
            }
            else if (bigdividecount > 0)
            {
                if (i % bigdividelength == 0)
                {
                    listarray[j] = p;
                    if (j != 0)
                    {
                        q.next = null;
                    }
                    j++;
                }
                if (i == bigdividelength - 1)
                {
                    bigdividecount--;
                    i = -1;
                }
                q = p;
                p = p.next;
            }
            else if (bigdividecount == 0)
            {
                if (i % smalldividelength == 0)
                {
                    if (j != 0)
                    {
                        q.next = null;
                    }
                    listarray[j] = p;
                    if (j < listarray.Length - 1)
                        j++;
                }
                q = p;
                p = p.next;
            }
            i++;
        }
        return listarray;
    }
}
