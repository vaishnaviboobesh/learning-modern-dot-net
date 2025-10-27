using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodewarsKata;

public class NumberWithoutFives
{
	private long count;

	public long Count(long startIndex, long end)
	{
		for (var start = startIndex; start <= end; start++)
			if (!HasFives(start))
				count++;
		return count;
	}

	private static bool HasFives(long currentNumber) => currentNumber.ToString().Contains('5');
}
