using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Assignment2._1
{
    public partial class MainFormL2P : Form
    {
        public MainFormL2P()
        {
            InitializeComponent();
        }

        // Constant Variablee used in this application
        const string
            Courses1 = "C# Fundamentals", Courses2 = "C# Basics for Beginners", Courses3 = "C# Intermidiate",
            Courses4 = "C# Advance Topics", Courses5 = "ASP.NET with C# Part A", Courses6 = "ASP.NET with C# Part B";

        const string
            Location1 = "Be Im ullet", Location2 = "Clifden", Location3 = "Cork", Location4 = "Dublin",
            Location5 = "Killamey", Location6 = "LetterKenny", Location7 = "Sigo";

        const int
            TrainDays1 = 2, TrainDays2 = 4, TrainDays3 = 4, TrainDays4 = 2,
            TrainDays5 = 5, TrainDays6 = 5;


        const int
            EnrolFees1 = 900, EnrolFees2 = 1500, EnrolFees3 = 1800, EnrolFees4 = 2300,
            EnrolFees5 = 1250, EnrolFees6 = 1250;

        const decimal
            AccFeePerDay1 = 219.99m, AccFeePerDay2 = 119.99m, AccFeePerDay3 = 149.99m,
            AccFeePerDay4 = 179.99m, AccFeePerDay5 = 149.99m, AccFeePerDay6 = 89.99m, AccFeePerDay7 = 119.99m;

        const decimal
            MasterSuite = 99.99m, ExecutiveSuite = 69.99m, JuniorSuite = 49.99m, DigitalCertificate = 39.99m, DiscountGroup = 0.925m;

        // Variable require for Summary Button
        int
            CountOrder = 0, SumTotalGroupDiscount = 0 ;

        decimal
            SumTotalvalueBooking  = 0 , SumTotalEnrolFees = 0, SumTotalLodgingFees = 0, SumTotalOptionFees = 0;


        decimal
            OrdSumTotalvalueBooking = 0, OrdSumTotalEnrolFees = 0, OrdSumTotalLodgingFees = 0, OrdSumTotalOptionFees = 0;

        // Variable that will require for Book button
        string BookButtonCourse = "", BookButtonLocation = "";
        decimal BookBtnOverCost = 0;




        private void ExitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ClearButton_Click(object sender, EventArgs e)
        {
            DisplayTextBox.Text = "";
            CoursesListBox.ClearSelected();
            LocationFeesListBox.ClearSelected();
            ParticipantTextBox.Text = "";
            MasterRadioButton.Checked = false;
            ExecutiveRadioButton.Checked = false;
            JuniorRadioButton.Checked = false;
            DigCertCheckBox.Checked = false;
            MainFormGroupBox.Enabled = true;
            DisplayButton.Enabled = true;
            BookButton.Enabled = false;
            NoupgradeRadioButton.Checked = true;

            //MainFormL2P_Load(sender,e);
        }
        private void DisplayButton_Click(object sender, EventArgs e)
        {
            try
            {
                int SelectedCourseIndex = 0, SelectedAccLoactionIndex = 0, SelectedTrainDays = 0;
                string SelectedCourse = "", SelectedLocation = "";
                decimal SelectedEnrolFees = 0, SelectedAccFees = 0, CostForSingleBook = 0, AdditionalCost = 0;
                int SumTotalGroupDiscount = 0; 

                // List box conditions 
                if ((CoursesListBox.SelectedIndex != -1))
                {
                    if ((LocationFeesListBox.SelectedIndex != -1))
                    {
                        SelectedCourseIndex = CoursesListBox.SelectedIndex;
                        SelectedAccLoactionIndex = LocationFeesListBox.SelectedIndex;


                        switch (SelectedCourseIndex)
                        {
                            case 0:
                                SelectedCourse = Courses1; SelectedTrainDays = TrainDays1; SelectedEnrolFees = EnrolFees1;
                                break;
                            case 1:
                                SelectedCourse = Courses2; SelectedTrainDays = TrainDays2; SelectedEnrolFees = EnrolFees2;
                                break;
                            case 2:
                                SelectedCourse = Courses3; SelectedTrainDays = TrainDays3; SelectedEnrolFees = EnrolFees3;
                                break;
                            case 3:
                                SelectedCourse = Courses4; SelectedTrainDays = TrainDays4; SelectedEnrolFees = EnrolFees4;
                                break;
                            case 4:
                                SelectedCourse = Courses5; SelectedTrainDays = TrainDays5; SelectedEnrolFees = EnrolFees5;
                                break;
                            case 5:
                                SelectedCourse = Courses6; SelectedTrainDays = TrainDays6; SelectedEnrolFees = EnrolFees6;
                                break;
                        }

                        switch (SelectedAccLoactionIndex)
                        {
                            case 0:
                                SelectedLocation = Location1; SelectedAccFees = AccFeePerDay1;
                                break;
                            case 1:
                                SelectedLocation = Location2; SelectedAccFees = AccFeePerDay2;
                                break;
                            case 2:
                                SelectedLocation = Location3; SelectedAccFees = AccFeePerDay3;
                                break;
                            case 3:
                                SelectedLocation = Location4; SelectedAccFees = AccFeePerDay4;
                                break;
                            case 4:
                                SelectedLocation = Location5; SelectedAccFees = AccFeePerDay5;
                                break;
                            case 5:
                                SelectedLocation = Location6; SelectedAccFees = AccFeePerDay6;
                                break;
                            case 6:
                                SelectedLocation = Location7; SelectedAccFees = AccFeePerDay7;
                                break;
                        }

                        // TryParse Int
                        /*int TryParticipants;
                        String Participants = (ParticipantTextBox.Text);
                        bool PartBool = int.TryParse(Participants, out TryParticipants);
                        if (PartBool == false)
                        {
                            MessageBox.Show("PLease enter Numeric Values", "Info", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }*/

                        try
                        {
                            CostForSingleBook = SelectedEnrolFees * (int.Parse(ParticipantTextBox.Text)) +
                                                (SelectedAccFees * SelectedTrainDays) * (int.Parse(ParticipantTextBox.Text));

                            // Checking for wheather their are more than three participants


                                // Checking for click on upgrade radiobutton
                                if (MasterRadioButton.Checked)
                                {
                                    CostForSingleBook = CostForSingleBook + SelectedTrainDays * MasterSuite * (int.Parse(ParticipantTextBox.Text));
                                    AdditionalCost = AdditionalCost + SelectedTrainDays * MasterSuite * (int.Parse(ParticipantTextBox.Text));
                                }
                                else if (ExecutiveRadioButton.Checked)
                                {
                                    CostForSingleBook = CostForSingleBook + SelectedTrainDays * ExecutiveSuite * (int.Parse(ParticipantTextBox.Text));
                                    AdditionalCost = AdditionalCost + SelectedTrainDays * ExecutiveSuite * (int.Parse(ParticipantTextBox.Text));
                                }
                                else if (JuniorRadioButton.Checked)
                                {
                                    CostForSingleBook = CostForSingleBook + SelectedTrainDays * JuniorSuite * (int.Parse(ParticipantTextBox.Text));
                                    AdditionalCost = AdditionalCost + SelectedTrainDays * JuniorSuite * (int.Parse(ParticipantTextBox.Text));
                                }
                                else if (NoupgradeRadioButton.Checked)
                                {
                                    ;
                                }

                                // Check for digital certificate
                                if (DigCertCheckBox.Checked == true)
                                {
                                    CostForSingleBook = CostForSingleBook + DigitalCertificate * (int.Parse(ParticipantTextBox.Text));
                                    AdditionalCost = AdditionalCost + DigitalCertificate * (int.Parse(ParticipantTextBox.Text));
                                }



                            if ((int.Parse(ParticipantTextBox.Text) < 0))
                            {
                                throw new Exception("");
                            }

                            else
                            {
                                if ((int.Parse(ParticipantTextBox.Text) > 0 && ((int.Parse(ParticipantTextBox.Text) < 3))))
                                {
                                    ;
                                }
                                else
                                {
                                    if (NoupgradeRadioButton.Checked == true)
                                    {
                                    }
                                    else
                                    {
                                        CostForSingleBook = CostForSingleBook * DiscountGroup;
                                    }
                                }
                            }
                            
                            SelectedEnrolFees = Math.Round(SelectedEnrolFees * (int.Parse(ParticipantTextBox.Text)), 2);
                                SelectedAccFees = Math.Round(SelectedAccFees * (int.Parse(ParticipantTextBox.Text)) * SelectedTrainDays , 2);
                                CostForSingleBook = Math.Round(CostForSingleBook, 2);
                                decimal DisplayBook = SelectedEnrolFees + SelectedAccFees + AdditionalCost;

                                //Transfering Values to Book Variables
                                BookButtonCourse = SelectedCourse;
                                BookButtonLocation = SelectedLocation;
                                BookBtnOverCost = CostForSingleBook;

                                //Display Text Box
                                DisplayTextBox.Text =
                                       "\t" + "\t" + " Want to make Booking for  " + (int.Parse(ParticipantTextBox.Text)).ToString() + " Participant" + "\n" +"\n" +
                                       "\t" + "\t" + "Selected Course    :       " + "\t" +   SelectedCourse + "\n" +
                                       "\n" + "\t" + "Enrollment Cost     :       " + "\t"  + SelectedEnrolFees.ToString("C", new CultureInfo("en-GB")) + "\n" +
                                       "\n" + "\t" + "Lodging Costs       :       " + "\t" +  SelectedAccFees.ToString("C", new CultureInfo("en-GB")) + "\n" +
                                       "\n" + "\t" + "Optional Costs       :       " + "\t" + AdditionalCost.ToString("C", new CultureInfo("en-GB")) + "\n" +
                                       "\n" + "\t" + "Overall Costs         :       " + "\t" +DisplayBook.ToString("C", new CultureInfo("en-GB"));

                                // Enabling the Book  buttons and 
                                if (CountOrder == 0)
                                {
                                    SummaryButton.Enabled = false;
                                }
                                else
                                {
                                    SummaryButton.Enabled = true;
                                }
                                BookButton.Enabled = true;

                                SumTotalvalueBooking = CostForSingleBook;
                                SumTotalEnrolFees =  SelectedEnrolFees;
                                SumTotalLodgingFees =  SelectedAccFees;
                                SumTotalOptionFees =  AdditionalCost;

                        }
                        catch
                        {
                            MessageBox.Show("PLease Enter Positive Numeric Values", "Info", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            ParticipantTextBox.Focus();
                        }

                    }
                    else
                    {
                        MessageBox.Show("Please Choose Accommodation Fees Fields", "Info", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        LocationFeesListBox.Focus();
                    }
                }
                else
                {
                    MessageBox.Show("Please Choose appropriate Course Option Fields", "Info", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    CoursesListBox.Focus();
                }

            }
            catch
            {
                MessageBox.Show("Please Enter appropriate Fields", "Info", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void BookButton_Click(object sender, EventArgs e)
        {
            // checking for confirmation from user 
            DialogResult BookConfYesNo = MessageBox.Show(
                "Following are the Booking Information" + "\n" +
                    "Course Name         :  " + BookButtonCourse + "\n" +
                    "Course Location    :  " + BookButtonLocation + "\n" +
                    "Course Total Cost  :  " + BookBtnOverCost.ToString("C", new CultureInfo("en-GB")) + "\n"
                   + "Press Yes To Confirm Booking OR Press No to go back" 
                    , "Boking Information Confrimation" , MessageBoxButtons.YesNo);
            if (BookConfYesNo == DialogResult.Yes)
            {
                if ((int.Parse(ParticipantTextBox.Text) > 2 && (MasterRadioButton.Checked == true || ExecutiveRadioButton.Checked == true || JuniorRadioButton.Checked == true)))
                {
                    SumTotalGroupDiscount = SumTotalGroupDiscount + 1;
                }
                CountOrder = CountOrder + 1;
                MessageBox.Show("Following are the Booking Information" + "\n" +
                    "Course Name         :  " + BookButtonCourse + "\n" +
                    "Course Location    :  " + BookButtonLocation + "\n" +
                    "Course Total Cost  :  " + BookBtnOverCost.ToString("C", new CultureInfo("en-GB")) + "\n"
                    , "Boking Information Confrimation", MessageBoxButtons.OK, MessageBoxIcon.Information);
                BookButton.Enabled = false;
                SummaryButton.Enabled = true;

                MainFormGroupBox.Enabled = false;
                DisplayButton.Enabled = false;
                CoursesListBox.ClearSelected();
                LocationFeesListBox.ClearSelected();
                ParticipantTextBox.Text = "";
                MasterRadioButton.Checked = false;
                ExecutiveRadioButton.Checked = false;
                JuniorRadioButton.Checked = false;
                DigCertCheckBox.Checked = false;

                // Transfering Values for Summary
                SumTotalvalueBooking = SumTotalvalueBooking + OrdSumTotalvalueBooking;
                SumTotalEnrolFees = SumTotalEnrolFees + OrdSumTotalEnrolFees;
                SumTotalLodgingFees = SumTotalLodgingFees + OrdSumTotalLodgingFees;
                SumTotalOptionFees = SumTotalOptionFees + OrdSumTotalOptionFees;


            }
            else if (BookConfYesNo == DialogResult.No)
            {
                ;
            }

        }

        private void MainFormL2P_Load(object sender, EventArgs e)
        {
            BookButton.Enabled = false;
            if (CountOrder == 0)
            {
                SummaryButton.Enabled = false;
            }
            else
            {
                SummaryButton.Enabled = false;
            }
        }

        private void SummaryButton_Click(object sender, EventArgs e)
        {
            // functionality for Summary button
            MainFormGroupBox.Enabled = false;
            BookButton.Enabled = false;
            DisplayButton.Enabled = false;
            CoursesListBox.ClearSelected();
            LocationFeesListBox.ClearSelected();
            ParticipantTextBox.Text = "";
            MasterRadioButton.Checked = false;
            ExecutiveRadioButton.Checked = false;
            JuniorRadioButton.Checked = false;
            DigCertCheckBox.Checked = false;
            decimal AverageRevenue = SumTotalvalueBooking / CountOrder;
            DisplayTextBox.Text =
                "\n" + "Total value of bookings processed   : "  +  SumTotalvalueBooking.ToString("C", new CultureInfo("en-GB")) + "\n" +
                "\n" + "Total enrollment fees                       : "  +  SumTotalEnrolFees.ToString("C", new CultureInfo("en-GB")) + "\n" +
                "\n" + "Total lodging fees                              : "  +  SumTotalLodgingFees.ToString("C", new CultureInfo("en-GB")) + "\n" +
                "\n" + "Total value of any options chosen   : "  +  SumTotalOptionFees.ToString("C", new CultureInfo("en-GB")) + "\n" +
                "\n" + "Total Number of Group discount      : "  + "" + SumTotalGroupDiscount + "\n" +
                "\n" + "Average revenue achieved per booking: "  + (Math.Round(AverageRevenue,2)).ToString("C",new CultureInfo("en-GB"));
        }
    }
}
