using FluentAssertions;
using YandexTasks.Easy;

namespace YandexTasksTests;

[TestFixture]
public class MaxCostTests
{
	[Test]
	public void MaxCost_Parse_Test()
	{

		var table = new int[5, 5]
		{
			{9, 9, 9, 9, 9},
			{3, 0, 0, 0, 0},
			{9, 9, 9, 9, 9},
			{6, 6, 6, 6, 8},
			{9, 9, 9, 9, 9}
		};
		MaxCost.Solve(table).Should().Be(74);
		MaxCost.FindPath(table).Should().Be("D D R R R R D D");
	}

	[Test]
	public void MaxCost_SingleCell()
	{
		var table = new int[1, 1] { { 7 } };
		var copy = (int[,])table.Clone();
		MaxCost.Solve(table).Should().Be(7);
		MaxCost.FindPath(copy).Should().Be("");
	}

	[Test]
	public void MaxCost_SingleRow()
	{
		var table = new int[1, 5]
		{
		{ 1, 2, 3, 4, 5 }
		};
		var copy = (int[,])table.Clone();
		MaxCost.Solve(table).Should().Be(15);
		MaxCost.FindPath(copy).Should().Be("R R R R");
	}

	[Test]
	public void MaxCost_SingleColumn()
	{
		var table = new int[5, 1]
		{
		{ 1 },
		{ 2 },
		{ 3 },
		{ 4 },
		{ 5 }
		};
		var copy = (int[,])table.Clone();
		MaxCost.Solve(table).Should().Be(15);
		MaxCost.FindPath(copy).Should().Be("D D D D");
	}

	[Test]
	public void MaxCost_AllEqual()
	{
		var table = new int[3, 3]
		{
		{ 1, 1, 1 },
		{ 1, 1, 1 },
		{ 1, 1, 1 }
		};
		var copy = (int[,])table.Clone();
		MaxCost.Solve(table).Should().Be(5);   // 1 + 4 шага по 1
											   // путь при равенстве — все R, потом все D (зависит от правила)
		MaxCost.FindPath(copy).Should().BeOneOf("R R D D", "D D R R");
	}

	[Test]
	public void MaxCost_TrapInMiddle()
	{
		// ловушка: спуск в нули, но верхняя строка всё компенсирует
		var table = new int[3, 3]
		{
		{ 9, 9, 9 },
		{ 0, 0, 0 },
		{ 9, 9, 9 }
		};
		var copy = (int[,])table.Clone();
		// путь: R R D D → 9+9+9+0+9 = 36, либо D D R R → 9+0+9+9+9 = 36
		MaxCost.Solve(table).Should().Be(36);
		// при равенстве Solve выбирает влево (шаг R), значит путь R R D D
		MaxCost.FindPath(copy).Should().BeOneOf("R R D D", "D D R R");
	}

	[Test]
	public void MaxCost_BigMatrix()
	{
		var table = new int[7, 7]
		{
		{ 4, 9, 9, 9, 9, 9, 2 },
		{ 1, 1, 1, 1, 1, 9, 1 },
		{ 9, 9, 9, 9, 9, 9, 1 },
		{ 1, 1, 1, 1, 1, 1, 1 },
		{ 9, 9, 9, 9, 9, 9, 9 },
		{ 8, 8, 8, 8, 8, 8, 8 },
		{ 9, 9, 9, 9, 9, 9, 9 }
		};
		MaxCost.Solve(table).Should().Be(103);
		MaxCost.FindPath(table).Should().BeOneOf("R R R R R D D D D R D D", "R R R R R D D D D D D R");
	}
}