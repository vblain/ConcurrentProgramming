﻿using System.Numerics;
using System.Threading.Tasks;

namespace PlayingWithActors
{
	public sealed class CollatzGrain
		: ICollatzGrain
	{
		public Task<BigInteger> CalculateIterationCountAsync(BigInteger value)
		{
			var iterations = BigInteger.Zero;

			while(value > 1)
			{
				value = value % 2 == 0 ?
					value / 2 : ((3 * value) + 1) / 2;
				iterations++;
			}

			return Task.FromResult(iterations);
		}
	}
}
