using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

public class MovingAverage
{
	Queue<int> q = new Queue<int>();
	int size = 0;
	double sum = 0;
	/** Initialize your data structure here. */
	public MovingAverage(int size)
	{
		this.size = size;
	}

	public double Next(int val)
	{
		if (q.Count >= this.size)
			sum -= q.Dequeue();
		q.Enqueue(val);
		sum += val;
		return sum / q.Count;
	}
}

/**
 * Your MovingAverage object will be instantiated and called as such:
 * MovingAverage obj = new MovingAverage(size);
 * double param_1 = obj.Next(val);
 */
