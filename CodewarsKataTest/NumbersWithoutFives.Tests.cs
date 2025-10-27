using System.Runtime.InteropServices;
using CodewarsKata;
using FluentAssertions;

namespace CodewarsKataTest;

public class NumbersWithoutFivesTest
{
	[Theory]
	[InlineData(4, 17, 12)]
	[InlineData(4, 18, 13)]
	[InlineData(-5, 5, 9)]
	public void CountNumbersWithoutFives(long start, long end, long expected) =>
	new NumberWithoutFives().Count(start, end).Should().Be(expected);

	[Fact]
	public void CountWithSameStartAndEnd_ShouldReturnOne() =>
		new NumberWithoutFives().Count(0, 0).Should().Be(1);
}
