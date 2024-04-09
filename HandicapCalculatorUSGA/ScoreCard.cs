using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GHINHandicap
{
	public class ScoreCard
	{
		// update equation to get a better handicap score since we are getting all score data
		public string CourseName { get; set; }
		public double CourseRating { get; set; }
		public int SlopeRating { get; set; }
		public int Hole1Par { get; set; }
		public int Hole1Yds { get; set; }
		public int Hole2Par { get; set; }
		public int Hole2Yds { get; set; }
        public int Hole3Par { get; set; }
		public int Hole3Yds { get; set; }
		public int Hole4Par { get; set; }
		public int Hole4Yds { get; set; }
		public int Hole5Par { get; set; }
		public int Hole5Yds { get; set; }
		public int Hole6Par { get; set; }
		public int Hole6Yds { get; set; }
		public int Hole7Par { get; set; }
		public int Hole7Yds { get; set; }
		public int Hole8Par { get; set; }
		public int Hole8Yds { get; set; }
		public int Hole9Par { get; set; }
		public int Hole9Yds { get; set; }
		public int Hole10Par { get; set; }
		public int Hole10Yds { get; set; }
		public int Hole11Par { get; set; }
		public int Hole11Yds { get; set; }
		public int Hole12Par { get; set; }
		public int Hole12Yds { get; set; }
		public int Hole13Par { get; set; }
		public int Hole13Yds { get; set; }
		public int Hole14Par { get; set; }
		public int Hole14Yds { get; set; }
		public int Hole15Par { get; set; }
		public int Hole15Yds { get; set; }
		public int Hole16Par { get; set; }
		public int Hole16Yds { get; set; }
		public int Hole17Par { get; set; }
		public int Hole17Yds { get; set; }
		public int Hole18Par { get; set; }
		public int Hole18Yds { get; set; }

		// Saving course info constructor.
		public ScoreCard( string courseName, double courseRating, int slopeRating,
						  int hOnePar, int hOneYds,
						  int hTwoPar, int hTwoYds,
						  int hThreePar, int hThreeYds,
						  int hFourPar, int hFourYds,
						  int hFivePar, int hFiveYds,
						  int hSixPar, int hSixYds,
						  int hSevenPar, int hSevenYds,
						  int hEightPar, int hEightYds,
						  int hNinePar, int hNineYds,
						  int hTenPar, int hTenYds,
						  int hElevenPar, int hElevenYds,
						  int hTwelvePar, int hTwelveYds,
						  int hThirteenPar, int hThirteenYds,
						  int hFourteenPar, int hFourteenYds,
						  int hFifteenPar, int hFifteenYds,
						  int hSixteenPar, int hSixteenYds,
						  int hSeventeenPar, int hSeventeenYds,
						  int hEighteenPar, int hEighteenYds)
		{
			CourseName = courseName;
			CourseRating = courseRating;
			SlopeRating = slopeRating;

			Hole1Par = hOnePar;
			Hole1Yds = hOneYds;
			Hole2Par = hTwoPar;
			Hole2Yds = hTwoYds;
			Hole3Par = hThreePar;
			Hole3Yds = hThreeYds;
			Hole4Par = hFourPar;
			Hole4Yds = hFourYds;
			Hole5Par = hFivePar;
			Hole5Yds = hFiveYds;
			Hole6Par = hSixPar;
			Hole6Yds = hSixYds;
			Hole7Par = hSevenPar;
			Hole7Yds = hSevenYds;
			Hole8Par = hEightPar;
			Hole8Yds = hEightYds;
			Hole9Par = hNinePar;
			Hole9Yds = hNineYds;
			Hole10Par = hTenPar;
			Hole10Yds = hTenYds;
			Hole11Par = hElevenPar;
			Hole11Yds = hElevenYds;
			Hole12Par = hTwelvePar;
			Hole12Yds = hTwelveYds;
			Hole13Par = hThirteenPar;
			Hole13Yds = hThirteenYds;
			Hole14Par = hFourteenPar;
			Hole14Yds = hFourteenYds;
			Hole15Par = hFifteenPar;
			Hole15Yds = hFifteenYds;
			Hole16Par = hSixteenPar;
			Hole16Yds = hSixteenYds;
			Hole17Par = hSeventeenPar;
			Hole17Yds = hSeventeenYds;
			Hole18Par = hEighteenPar;
			Hole18Yds = hEighteenYds;
		}

		
		// courseName constructor for listbox
		public ScoreCard(string courseName)
		{
			CourseName = courseName;
		}

		public string DisplayCourseName()
		{
			StringBuilder sb = new StringBuilder();
			sb.Append(CourseName);
			return sb.ToString();
		}
	}
}
