using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace GHINHandicap
{
	public class Player
	{
        public string FirstName { get; set; }
		public string LastName { get; set; }
		public List<double> Differentials { get; set; }

		// scorecard constructor
		public Player()
		{
			Differentials = new List<double>();
		}
		public Player(string fn, string ln)
		{
			FirstName = fn;
			LastName = ln;
			Differentials = new List<double>();
		}

		public string DisplayPlayerName()
		{
			StringBuilder sb = new StringBuilder();
			sb.Append(FirstName + " " + LastName);
			return sb.ToString();
		}

		public double CalculateHandicapIndex(List<double> differentials)
		{
			try
			{
				if (differentials.Count < 20)
				{
					MessageBox.Show("At least 20 rounds are needed to calculate the index", "More rounds needed");
					return 0;
				}

				differentials.Sort();
				int count = Math.Min(differentials.Count, 20);

				double handicapIndexSum = 0;
				for (int i = 0; i < 8; i++)
				{
					handicapIndexSum += differentials[i];
				}

				return Math.Round(handicapIndexSum / 8, 1); // getting avg of the 8 best rounds from the most recent 20
			}
			catch (Exception ex)
			{
				MessageBox.Show("Could not calculate index: " + ex.Message, "Error");
				return 0;
			}
		}

		// get diff for each round by player, append to a text file or player text file
		public double CalculateHandicapDifferential(int score, double courseRating, int slopeRating)
		{
			double differential = (score - courseRating) * 113 / slopeRating;
			return Math.Round(differential, 1);
		}

		public void AddDifferential(double newDifferential)
		{
			Differentials.Add(newDifferential);
		}

		public int PlayerDiffCount(Player player)
		{
			string filePath = $"{player.FirstName}_{player.LastName}_Differentials.txt";
			int diffCount = 0;

			try
			{
				if (File.Exists(filePath))
				{
					using (StreamReader sr = new StreamReader(filePath))
					{
						while (sr.Peek() != -1)
						{
							sr.ReadLine();
							diffCount++;
						}
					}
				}
			}
			catch (FileNotFoundException)
			{
				MessageBox.Show($"File {filePath} not found.");
			}
			catch (IOException e)
			{
				MessageBox.Show($"An error occurred while reading the file {filePath}: {e.Message}");
			}

			return diffCount;
		}

		public double OpenDiffFile(Player player)
		{
			string filePath = $"{player.FirstName}_{player.LastName}_Differentials.txt";
			List<double> diff = new List<double>();
			int c = 0;
			try
			{
				if (File.Exists(filePath))
				{
					using (StreamReader sr = new StreamReader(filePath))
					{
						while (sr.Peek() != -1)
						{
							c++;
							sr.ReadLine();
						}
					}
				}

				if (c < 20)
				{
					MessageBox.Show("Not enough rounds entered", "Missing Data");
				}

				else
				{
					using (StreamReader sr = new StreamReader(filePath))
					{
						for (int i = 0; i < Math.Max(0, c - 20); i++)
						{
							sr.ReadLine();
						}

						while (!sr.EndOfStream)
						{
							string line = sr.ReadLine();
							if (double.TryParse(line, out double differential))
							{
								diff.Add(differential);
							}
						}
					}
					double hdcpIndex = CalculateHandicapIndex(diff);
					return hdcpIndex;
				}
			}
			catch (FileNotFoundException)
			{
				MessageBox.Show($"File {filePath} not found.");
			}
			catch (IOException ex)
			{
				MessageBox.Show($"An error occurred while reading the file {filePath}: {ex.Message}");
			}
			return 0;
		}
	}
}
