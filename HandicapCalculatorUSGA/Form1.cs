using static System.Formats.Asn1.AsnWriter;

namespace GHINHandicap
{
    public partial class HDCP_Golf : Form
    {
        List<Player> playerList;
        public List<Player> playerListDisplay;
        List<ScoreCard> scoreCardList;
        List<int> playerDifferentials;
        public List<ScoreCard> golfCourseNameList;
        public List<ScoreCard> courseScoreCardData;
        public string golfCourses = "golf_courses.txt";
        public string players = "player_list.txt";
        public int recCount = 0;
        public HDCP_Golf()
        {
            InitializeComponent();
        }

        private void HDCP_Golf_Load(object sender, EventArgs e)
        {
            LoadCourseNameOnlyData();
            LoadAllCourseDetails();
            PopulateCourseList();
            PopulatePlayerList();
        }

        private void holeOneText_TextChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(holeOneText.Text) && !int.TryParse(holeOneText.Text, out int result))
            {
                MessageBox.Show("Please enter a valid integer for hole 1.", "Invalid Input");
            }
        }

        private void holeTwoText_TextChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(holeTwoText.Text) && !int.TryParse(holeTwoText.Text, out int result))
            {
                MessageBox.Show("Please enter a valid integer for hole 2.", "Invalid Input");
            }
        }

        private void holeThreeText_TextChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(holeThreeText.Text) && !int.TryParse(holeThreeText.Text, out int result))
            {
                MessageBox.Show("Please enter a valid integer for hole 3.", "Invalid Input");
            }
        }

        private void holeFourText_TextChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(holeFourText.Text) && !int.TryParse(holeFourText.Text, out int result))
            {
                MessageBox.Show("Please enter a valid integer for hole 4.", "Invalid Input");
            }
        }

        private void holeFiveText_TextChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(holeFiveText.Text) && !int.TryParse(holeFiveText.Text, out int result))
            {
                MessageBox.Show("Please enter a valid integer for hole 5.", "Invalid Input");
            }
        }

        private void holeSixText_TextChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(holeSixText.Text) && !int.TryParse(holeSixText.Text, out int result))
            {
                MessageBox.Show("Please enter a valid integer for hole 6.", "Invalid Input");
            }
        }

        private void holeSevenText_TextChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(holeSevenText.Text) && !int.TryParse(holeSevenText.Text, out int result))
            {
                MessageBox.Show("Please enter a valid integer for hole 7.", "Invalid Input");
            }
        }

        private void holeEightText_TextChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(holeEightText.Text) && !int.TryParse(holeEightText.Text, out int result))
            {
                MessageBox.Show("Please enter a valid integer for hole 8.", "Invalid Input");
            }
        }

        private void holeNineText_TextChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(holeNineText.Text) && !int.TryParse(holeNineText.Text, out int result))
            {
                MessageBox.Show("Please enter a valid integer for hole 9.", "Invalid Input");
            }
        }

        private void holeTenText_TextChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(holeTenText.Text) && !int.TryParse(holeTenText.Text, out int result))
            {
                MessageBox.Show("Please enter a valid integer for hole 10.", "Invalid Input");
            }
        }

        private void holeElevenText_TextChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(holeElevenText.Text) && !int.TryParse(holeElevenText.Text, out int result))
            {
                MessageBox.Show("Please enter a valid integer for hole 11.", "Invalid Input");
            }
        }

        private void holeTwelveText_TextChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(holeTwelveText.Text) && !int.TryParse(holeTwelveText.Text, out int result))
            {
                MessageBox.Show("Please enter a valid integer for hole 12.", "Invalid Input");
            }
        }

        private void holeThirteenText_TextChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(holeThirteenText.Text) && !int.TryParse(holeThirteenText.Text, out int result))
            {
                MessageBox.Show("Please enter a valid integer for hole 13.", "Invalid Input");
            }
        }

        private void holeFourteenText_TextChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(holeFourteenText.Text) && !int.TryParse(holeFourteenText.Text, out int result))
            {
                MessageBox.Show("Please enter a valid integer for hole 14.", "Invalid Input");
            }
        }

        private void holeFifteenText_TextChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(holeFifteenText.Text) && !int.TryParse(holeFifteenText.Text, out int result))
            {
                MessageBox.Show("Please enter a valid integer for hole 15.", "Invalid Input");
            }
        }

        private void holeSixteenText_TextChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(holeSixteenText.Text) && !int.TryParse(holeSixteenText.Text, out int result))
            {
                MessageBox.Show("Please enter a valid integer for hole 16.", "Invalid Input");
            }
        }

        private void holeSeventeenText_TextChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(holeSeventeenText.Text) && !int.TryParse(holeSevenText.Text, out int result))
            {
                MessageBox.Show("Please enter a valid integer for hole 17.", "Invalid Input");
            }
        }

        private void holeEighteenText_TextChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(holeEighteenText.Text) && !int.TryParse(holeEighteenText.Text, out int result))
            {
                MessageBox.Show("Please enter a valid integer for hole 18.", "Invalid Input");
            }
        }

        private void frontNineText_TextChanged(object sender, EventArgs e)
        {
            try
            {
                int hOne = int.Parse(holeOneText.Text);
                int hTwo = int.Parse(holeTwoText.Text);
                int hThree = int.Parse(holeThreeText.Text);
                int hFour = int.Parse(holeFourText.Text);
                int hFive = int.Parse(holeFiveText.Text);
                int hSix = int.Parse(holeSixText.Text);
                int hSeven = int.Parse(holeSevenText.Text);
                int hEight = int.Parse(holeEightText.Text);
                int hNine = int.Parse(holeNineText.Text);

                int frontNineTotal = (hOne + hTwo + hThree + hFour + hFive + hSix + hSeven + hEight + hNine);
                frontNineText.Text = frontNineTotal.ToString();
                frontNineText.ReadOnly = true;
            }
            catch
            {
                MessageBox.Show("Please enter front 9 scores", "Not all scores entered");
            }
        }

        private void backNineText_TextChanged(object sender, EventArgs e)
        {
            try
            {
                int hTen = int.Parse(holeTenText.Text);
                int hEleven = int.Parse(holeElevenText.Text);
                int hTwelve = int.Parse(holeTwelveText.Text);
                int hThirteen = int.Parse(holeThirteenText.Text);
                int hFourteen = int.Parse(holeFourteenText.Text);
                int hFifteen = int.Parse(holeFifteenText.Text);
                int hSixteen = int.Parse(holeSixteenText.Text);
                int hSeventeen = int.Parse(holeSeventeenText.Text);
                int hEighteen = int.Parse(holeEighteenText.Text);

                int backNineTotal = (hTen + hEleven + hTwelve + hThirteen + hFourteen + hFifteen + hSixteen + hSeventeen + hEighteen);
                backNineText.Text = backNineTotal.ToString();
                backNineText.ReadOnly = true;
            }
            catch
            {
                MessageBox.Show("Please enter back 9 scores", "Not all scores entered");
            }
        }

        private void totalScoreText_TextChanged(object sender, EventArgs e)
        {
            try
            {
                int bNine = int.Parse(backNineText.Text);
                int fNine = int.Parse(frontNineText.Text);
                int total = (bNine + fNine);

                totalScoreText.Text = total.ToString();
                totalScoreText.ReadOnly = true;
            }
            catch
            {
                MessageBox.Show("Please enter all 18 scores", "Not all scores entered");
            }
        }

        // clear text methods

        private void ClearScoreCard()
        {
            TextBox[] front9ParTextboxes = { parOneTxt, parTwoTxt, parThreeTxt, parFourTxt, parFiveTxt, parSixTxt, parSevenTxt, parEightTxt, parNineTxt };
            TextBox[] front9YdsTextboxes = { yds1Txt, yds2Txt, yds3Txt, yds4Txt, yds5Txt, yds6Txt, yds7Txt, yds8Txt, yds9Txt };

            TextBox[] back9ParTextboxes = { parTenTxt, parElevenTxt, parTwelveTxt, parThirteenTxt, parFourteenTxt, parFifteenTxt, parSixteenTxt, parSeventeenTxt, parEighteenTxt };
            TextBox[] back9YdsTextboxes = { yds10Txt, yds11Txt, yds12Txt, yds13Txt, yds14Txt, yds15Txt, yds16Txt, yds17Txt, yds18Txt };

            clubNameTxt.Text = string.Empty;
            courseRatingTxt.Text = string.Empty;
            slopeRatingTxt.Text = string.Empty;

            foreach (var textBox in front9ParTextboxes)
            {
                textBox.Text = string.Empty;
            }
            foreach (var textBox in front9YdsTextboxes)
            {
                textBox.Text = string.Empty;
            }

            foreach (var textBox in back9ParTextboxes)
            {
                textBox.Text = string.Empty;
            }
            foreach (var textBox in back9YdsTextboxes)
            {
                textBox.Text = string.Empty;
            }
        }

        private void ClearRoundScoreCard()
        {
            // detaching event handlers to avoid errors when clearing the total text boxes (front 9, back 9 and total)
            frontNineText.TextChanged -= frontNineText_TextChanged;
            backNineText.TextChanged -= backNineText_TextChanged;
            totalScoreText.TextChanged -= totalScoreText_TextChanged;

            TextBox[] txtScores = {holeOneText, holeTwoText, holeThreeText, holeFourText, holeFiveText, holeSixText, holeSevenText, holeSevenText,
                                   holeEightText, holeNineText,holeTenText,holeElevenText,holeTwelveText,holeThirteenText,holeFourteenText,
                                   holeFifteenText,holeSixteenText,holeSeventeenText,holeEighteenText,frontNineText,backNineText,totalScoreText};

            for (int i = 0; i < txtScores.Length; i++) //total text boxes are clearing oddly(need to fix)
            {
                txtScores[i].Text = string.Empty;
            }

            frontNineText.TextChanged += frontNineText_TextChanged;
            backNineText.TextChanged += backNineText_TextChanged;
            totalScoreText.TextChanged += totalScoreText_TextChanged;
        }

        private void ClearPlayerForm()
        {
            pFnameTxtBox.Text = string.Empty;
            pLnameTxtBox.Text = string.Empty;
        }


        // saving and uploading files

        private void LoadCourseNameOnlyData()
        {
            golfCourseNameList = new List<ScoreCard>();

            try
            {
                using (StreamReader sr = File.OpenText(golfCourses))
                {
                    recCount = File.ReadLines(golfCourses).Count() - 1;
                    int i = 0;
                    while (sr.Peek() != -1 && i <= recCount)
                    {
                        string[] courseTemp = sr.ReadLine().Split(",");
                        ScoreCard scInfo = new ScoreCard(courseTemp[0]); // (only name is being read here)
                        golfCourseNameList.Add(scInfo);
                        i++;
                    }
                }
            }
            catch
            {
                MessageBox.Show("Could not read data", "Data Error");
            }
        }

        // Displaying only names for players
        private void LoadPlayerNameOnlyData()
        {
            playerListDisplay = new List<Player>();

            try
            {
                using (StreamReader sr = File.OpenText(players))
                {
                    while (sr.Peek() != -1)
                    {
                        string[] playerTemp = sr.ReadLine().Split(",");
                        if (playerTemp.Length >= 2)
                        {
                            string firstName = playerTemp[0];
                            string lastName = playerTemp[1];
                            Player player = new Player(firstName, lastName);
                            playerListDisplay.Add(player);
                        }
                        else
                        {
                            MessageBox.Show("Invalid player data: " + string.Join(",", playerTemp), "Data Error");
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Could not read Player Data: " + ex.Message, "Data Error");
            }
        }

        // all course data for scorecard lbls
        private void LoadAllCourseDetails()
        {
            courseScoreCardData = new List<ScoreCard>();

            try
            {
                using (StreamReader sr = File.OpenText(golfCourses))
                {
                    int lineCount = 0;
                    while (!sr.EndOfStream)
                    {
                        string line = sr.ReadLine();
                        string[] courseTemp = line.Split(",");

                        // Log the line and its fields
                        Console.WriteLine($"Reading line {lineCount + 1}: {line}");
                        Console.WriteLine($"Number of fields: {courseTemp.Length}");

                        if (courseTemp.Length < 39)
                        {
                            MessageBox.Show($"Error: Line {lineCount + 1} does not contain enough fields.", "Data Error");
                            continue;
                        }

                        // grabbing all course details from file.
                        ScoreCard scInfo = new ScoreCard(courseTemp[0], double.Parse(courseTemp[1]), int.Parse(courseTemp[2]), int.Parse(courseTemp[3]), int.Parse(courseTemp[4]), int.Parse(courseTemp[5]),
                                                         int.Parse(courseTemp[6]), int.Parse(courseTemp[7]), int.Parse(courseTemp[8]), int.Parse(courseTemp[9]), int.Parse(courseTemp[10]),
                                                         int.Parse(courseTemp[11]), int.Parse(courseTemp[12]), int.Parse(courseTemp[13]), int.Parse(courseTemp[14]), int.Parse(courseTemp[15]),
                                                         int.Parse(courseTemp[16]), int.Parse(courseTemp[17]), int.Parse(courseTemp[18]), int.Parse(courseTemp[19]), int.Parse(courseTemp[20]),
                                                         int.Parse(courseTemp[21]), int.Parse(courseTemp[22]), int.Parse(courseTemp[23]), int.Parse(courseTemp[24]), int.Parse(courseTemp[25]),
                                                         int.Parse(courseTemp[26]), int.Parse(courseTemp[27]), int.Parse(courseTemp[28]), int.Parse(courseTemp[29]), int.Parse(courseTemp[30]),
                                                         int.Parse(courseTemp[31]), int.Parse(courseTemp[32]), int.Parse(courseTemp[33]), int.Parse(courseTemp[34]), int.Parse(courseTemp[35]),
                                                         int.Parse(courseTemp[36]), int.Parse(courseTemp[37]), int.Parse(courseTemp[38])
                                                         );
                        courseScoreCardData.Add(scInfo);

                        lineCount++;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error reading data: {ex.Message}", "Data Error");
            }
        }

        // save diff list by player; file is their full name
        private void SaveDifferentialsToFile(Player player)
        {
            try
            {
                string fileName = $"{player.FirstName}_{player.LastName}_Differentials.txt";

                using (StreamWriter writer = new StreamWriter(fileName, true))
                {
                    foreach (double diff in player.Differentials)
                    {
                        writer.WriteLine(diff);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error saving differentials to file: " + ex.Message, "Error");
            }
        }



        // button methods
        private void btnAddCourse_Click(object sender, EventArgs e)
        {
            string courseName = clubNameTxt.Text;
            string courseRating = courseRatingTxt.Text;
            string slopeRating = slopeRatingTxt.Text;
            // writing hole details (front 9)
            string h1Par = parOneTxt.Text;
            string h1Yds = yds1Txt.Text;
            string h2Par = parTwoTxt.Text;
            string h2Yds = yds2Txt.Text;
            string h3Par = parThreeTxt.Text;
            string h3Yds = yds2Txt.Text;
            string h4Par = parFourTxt.Text;
            string h4Yds = yds4Txt.Text;
            string h5Par = parFiveTxt.Text;
            string h5Yds = yds5Txt.Text;
            string h6Par = parSixTxt.Text;
            string h6Yds = yds6Txt.Text;
            string h7Par = parSevenTxt.Text;
            string h7Yds = yds7Txt.Text;
            string h8Par = parEightTxt.Text;
            string h8Yds = yds8Txt.Text;
            string h9Par = parNineTxt.Text;
            string h9Yds = yds9Txt.Text;
            // back 9
            string h10Par = parTenTxt.Text;
            string h10Yds = yds10Txt.Text;
            string h11Par = parElevenTxt.Text;
            string h11Yds = yds11Txt.Text;
            string h12Par = parTwelveTxt.Text;
            string h12Yds = yds12Txt.Text;
            string h13Par = parThirteenTxt.Text;
            string h13Yds = yds13Txt.Text;
            string h14Par = parFourteenTxt.Text;
            string h14Yds = yds14Txt.Text;
            string h15Par = parFifteenTxt.Text;
            string h15Yds = yds15Txt.Text;
            string h16Par = parSixteenTxt.Text;
            string h16Yds = yds16Txt.Text;
            string h17Par = parSeventeenTxt.Text;
            string h17Yds = yds17Txt.Text;
            string h18Par = parEighteenTxt.Text;
            string h18Yds = yds18Txt.Text;

            if (string.IsNullOrWhiteSpace(courseName) || string.IsNullOrWhiteSpace(courseRating) || string.IsNullOrWhiteSpace(slopeRating) ||
                string.IsNullOrWhiteSpace(h1Par) || string.IsNullOrWhiteSpace(h1Yds) || string.IsNullOrWhiteSpace(h2Par) || string.IsNullOrWhiteSpace(h2Yds) ||
                string.IsNullOrWhiteSpace(h3Par) || string.IsNullOrWhiteSpace(h3Yds) || string.IsNullOrWhiteSpace(h4Par) || string.IsNullOrWhiteSpace(h4Yds) ||
                string.IsNullOrWhiteSpace(h5Par) || string.IsNullOrWhiteSpace(h5Yds) || string.IsNullOrWhiteSpace(h6Par) || string.IsNullOrWhiteSpace(h6Yds) ||
                string.IsNullOrWhiteSpace(h7Par) || string.IsNullOrWhiteSpace(h7Yds) || string.IsNullOrWhiteSpace(h8Par) || string.IsNullOrWhiteSpace(h8Yds) ||
                string.IsNullOrWhiteSpace(h9Par) || string.IsNullOrWhiteSpace(h9Yds) || string.IsNullOrWhiteSpace(h10Par) || string.IsNullOrWhiteSpace(h10Yds) ||
                string.IsNullOrWhiteSpace(h11Par) || string.IsNullOrWhiteSpace(h11Yds) || string.IsNullOrWhiteSpace(h12Par) || string.IsNullOrWhiteSpace(h12Yds) ||
                string.IsNullOrWhiteSpace(h13Par) || string.IsNullOrWhiteSpace(h13Yds) || string.IsNullOrWhiteSpace(h14Par) || string.IsNullOrWhiteSpace(h14Yds) ||
                string.IsNullOrWhiteSpace(h15Par) || string.IsNullOrWhiteSpace(h15Yds) || string.IsNullOrWhiteSpace(h16Par) || string.IsNullOrWhiteSpace(h16Yds) ||
                string.IsNullOrWhiteSpace(h17Par) || string.IsNullOrWhiteSpace(h17Yds) || string.IsNullOrWhiteSpace(h18Par) || string.IsNullOrWhiteSpace(h18Yds))
            {
                MessageBox.Show("Please enter all course details", "Enter all details");
            }
            else
            {
                try
                {

                    // mainly using to load file with golf course data

                    using (StreamWriter sw = File.AppendText(golfCourses))
                    {
                        sw.WriteLine($"{courseName},{courseRating},{slopeRating}," +
                                     $"{h1Par},{h1Yds},{h2Par},{h2Yds}," +
                                     $"{h3Par},{h3Yds},{h4Par},{h4Yds}," +
                                     $"{h5Par},{h5Yds},{h6Par},{h6Yds}," +
                                     $"{h7Par},{h7Yds},{h8Par},{h8Yds}," +
                                     $"{h9Par},{h9Yds},{h10Par},{h10Yds}," +
                                     $"{h11Par},{h11Yds},{h12Par},{h12Yds}," +
                                     $"{h13Par},{h13Yds},{h14Par},{h14Yds}," +
                                     $"{h15Par},{h15Yds},{h16Par},{h16Yds}," +
                                     $"{h17Par},{h17Yds},{h18Par},{h18Yds}");
                    }
                    MessageBox.Show("New Course has been saved!", "Course Added");
                    // call clearing method here
                    ClearScoreCard();
                    LoadCourseNameOnlyData();
                    PopulateCourseList();
                }
                catch
                {
                    MessageBox.Show("Error adding new course!", "Course not added");
                }
            }
        }

        private void btnAddPlayerToList_Click(object sender, EventArgs e)
        {
            string firstName = pFnameTxtBox.Text;
            string lastName = pLnameTxtBox.Text;

            if (string.IsNullOrWhiteSpace(firstName) || string.IsNullOrWhiteSpace(lastName))
            {
                MessageBox.Show("Please enter all player details", "Missing Player Data");
            }
            else
            {
                try
                {
                    using (StreamWriter sw = File.AppendText(players))
                    {
                        sw.WriteLine($"{firstName},{lastName}");
                    }
                    MessageBox.Show("Player has been added!", "Success");
                    ClearPlayerForm();
                    LoadPlayerNameOnlyData();
                    PopulatePlayerList();
                }
                catch
                {
                    MessageBox.Show("Error adding new player", "Could not save player");
                }
            }
        }

        private void btnAddRoundToPlayer_Click(object sender, EventArgs e)
        {
            try
            {
                // getting player details from labels
                string playerName = lblCurrentPlayer.Text;
                string[] names = playerName.Split(' ');

                string firstName = names[0];
                string lastName = names[1];

                // creating player object
                Player player = new Player(firstName, lastName);

                // parsing score, rating, and slope from labels
                int totalScore = int.Parse(totalScoreText.Text);
                double courseRating = double.Parse(lblRating.Text.Split(' ')[1]);
                int slopeRating = int.Parse(lblSlope.Text.Split(' ')[1]);

                // calculating differential and adding it to the player's list
                double differential = player.CalculateHandicapDifferential(totalScore, courseRating, slopeRating);
                player.AddDifferential(differential);
                SaveDifferentialsToFile(player);

                MessageBox.Show($"Round saved for, {firstName}!", "Success");

                ClearRoundScoreCard();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Unable to add diffs to player, Please ensure you are selecting a course!: " + ex.Message, "Error");
            }
        }



        private void lblSlope_Click(object sender, EventArgs e)
        {

        }



        // Display Data methods
        private void PopulateCourseList()
        {
            if (golfCourseNameList != null)
            {
                coursesLstBox.Items.Clear();

                // using linq to call display method from scorecard obj
                var courses = from course in golfCourseNameList
                              select course.DisplayCourseName();

                coursesLstBox.Items.AddRange(courses.ToArray());
            }
            else
            {
                MessageBox.Show("No courses are saved at this time.", "No Course Data");
            }
        }

        private void PopulatePlayerList()
        {
            LoadPlayerNameOnlyData(); // load the file

            if (playerListDisplay != null)
            {
                playerGrpList.Items.Clear();

                // using linq to call display method from player obj
                var playerList = from player in playerListDisplay
                                 select player.DisplayPlayerName();

                playerGrpList.Items.AddRange(playerList.ToArray());
            }
            else
            {
                MessageBox.Show("No players are saved at this time.", "No Player Data");
            }
        }

        private void coursesLstBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Declare holeParLabels and yardLabels arrays outside of the if block
            Label[] holeParLabels = { lblHoleOnePar, lblHoleTwoPar, lblHoleThreePar, lblHoleFourPar, lblHoleFivePar, lblHoleSixPar,
                              lblHoleSevenPar, lblHoleEightPar, llblHoleNinePar, lblHoleTenPar, lblHoleElevenPar, lblHoleTwelvePar,
                              lblHoleThirteenPar, lblHoleFourteenPar, lblHoleFifteenPar, lblHoleSixteenPar, lblHoleSeventeenPar, lblHoleEighteenPar };

            Label[] yardLabels = { lblH1Yds, lblH2Yds, lblH3Yds, lblH4Yds, lblH5Yds, lblH6Yds, lblH7Yds, lblH8Yds, lblH9Yds,
                           lblH10Yds, lblH11Yds, lblH12Yds, lblH13Yds, lblH14Yds, lblH15Yds, lblH16Yds, lblH17Yds, lblH18Yds };

            // Display course info if selected from coursesLstBox
            if (coursesLstBox.SelectedItem != null)
            {
                // Clear scorecard here
                string selectedCourseName = coursesLstBox.SelectedItem.ToString();
                // Display selected course name
                lblSelectedCourse.Text = selectedCourseName;

                // Find the corresponding ScoreCard object based on the selected course name
                ScoreCard selectedCourse = courseScoreCardData.FirstOrDefault(course => course.DisplayCourseName() == selectedCourseName);

                if (selectedCourse != null)
                {
                    // Display course details
                    lblName.Text = "Course: " + selectedCourse.DisplayCourseName();
                    lblRating.Text = "Rating: " + selectedCourse.CourseRating;
                    lblSlope.Text = "Slope: " + selectedCourse.SlopeRating;

                    // Update holeParLabels and yardLabels text
                    int[] holeParValues = { selectedCourse.Hole1Par, selectedCourse.Hole2Par, selectedCourse.Hole3Par, selectedCourse.Hole4Par, selectedCourse.Hole5Par,
                                    selectedCourse.Hole6Par, selectedCourse.Hole7Par, selectedCourse.Hole8Par, selectedCourse.Hole9Par, selectedCourse.Hole10Par,
                                    selectedCourse.Hole11Par, selectedCourse.Hole12Par, selectedCourse.Hole13Par, selectedCourse.Hole14Par, selectedCourse.Hole15Par,
                                    selectedCourse.Hole16Par, selectedCourse.Hole17Par, selectedCourse.Hole18Par };

                    int[] yardLabelValues = { selectedCourse.Hole1Yds, selectedCourse.Hole2Yds, selectedCourse.Hole3Yds, selectedCourse.Hole4Yds, selectedCourse.Hole5Yds,
                                      selectedCourse.Hole6Yds, selectedCourse.Hole7Yds, selectedCourse.Hole8Yds, selectedCourse.Hole9Yds, selectedCourse.Hole10Yds,
                                      selectedCourse.Hole11Yds, selectedCourse.Hole12Yds, selectedCourse.Hole13Yds, selectedCourse.Hole14Yds, selectedCourse.Hole15Yds,
                                      selectedCourse.Hole16Yds, selectedCourse.Hole17Yds, selectedCourse.Hole18Yds };

                    for (int i = 0; i < holeParLabels.Length && i < yardLabels.Length; i++)
                    {
                        holeParLabels[i].Text = "Par: " + holeParValues[i];
                        yardLabels[i].Text = "Yd: " + yardLabelValues[i];
                    }
                }
                else
                {
                    // Clear course details if no corresponding ScoreCard object is found
                    lblName.Text = "";
                    lblRating.Text = "";
                    lblSlope.Text = "";
                    lblSelectedCourse.Text = "";

                    // Clear holeParLabels and yardLabels text
                    foreach (var label in holeParLabels)
                    {
                        label.Text = "";
                    }
                    foreach (var label in yardLabels)
                    {
                        label.Text = "";
                    }
                }
            }
        }



        private void playerGrpList_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (playerGrpList.SelectedIndex != -1)
            {
                // Get the selected player name after sorting
                string selectedPlayerName = playerGrpList.SelectedItem.ToString();

                // Find the corresponding Player object in the list
                Player selectedPlayer = playerListDisplay.FirstOrDefault(player => player.DisplayPlayerName() == selectedPlayerName);

                // Display player info
                lblCurrentPlayer.Text = selectedPlayer.DisplayPlayerName();

                // showing total number of rounds per selected player (20 needed to calc index)
                int diffCount = selectedPlayer.PlayerDiffCount(selectedPlayer);
                lblDiffCount.Text = diffCount.ToString();

                // display indexes here (Call when player has)
                double index = selectedPlayer.OpenDiffFile(selectedPlayer);
                lblCurrIndex.Text = index.ToString();

                if (lblCurrIndex.Text == "0")
                {
                    lblCurrIndex.Text = "Not enough rounds";
                }
            }
        }


        private void btnSortPlayerList_Click(object sender, EventArgs e)
        {
            // Store the index of the selected item
            int selectedIndex = playerGrpList.SelectedIndex;

            // Extract player names from the ListBox into a List<string>
            List<string> playerNames = new List<string>();
            foreach (var item in playerGrpList.Items)
            {
                playerNames.Add(item.ToString());
            }

            // Sort the player names
            playerNames.Sort();

            // Clear the ListBox and add the sorted player names back
            playerGrpList.Items.Clear();
            foreach (var playerName in playerNames)
            {
                playerGrpList.Items.Add(playerName);
            }

            // Set the selected index back to its original value after sorting
            if (selectedIndex >= 0 && selectedIndex < playerGrpList.Items.Count)
            {
                playerGrpList.SelectedIndex = selectedIndex;
            }
        }

        private void btnSortCourses_Click(object sender, EventArgs e)
        {
            int selectedCourseIndex = coursesLstBox.SelectedIndex;

            List<string> courseNames = new List<string>();
            foreach (var item in coursesLstBox.Items)
            {
                courseNames.Add(item.ToString());
            }

            // Sort the course names
            courseNames.Sort();

            // Clear the ListBox and add the sorted course names back
            coursesLstBox.Items.Clear();

            foreach (var courseName in courseNames)
            {
                coursesLstBox.Items.Add(courseName);
            }

            // Set the selected index back to its original value after sorting
            if (selectedCourseIndex >= 0 && selectedCourseIndex < coursesLstBox.Items.Count)
            {
                coursesLstBox.SelectedIndex = selectedCourseIndex;
            }
        }

    }
}

// Do tomorrow: check for bugs, add filtering for courses such as abc, difficulty search?