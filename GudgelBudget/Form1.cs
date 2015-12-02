using System;
using System.IO;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GudgelBudget
{
    public partial class BudgetAid : Form
    {
        const string HINTY = "yyyy";
        const string HINTM = "mm";
        const string HINTD = "dd";
        const string HINTCATI = "Food, Housing, Other...";
        const string HINTVAL = "8.05, 750, 3.99...";
        const string HINTCATA = "All, Food, Housing...";
        const string HINTTAR = "2788, 436, 900...";
        const string EMPTY = "";
        
        ExcelWriter ew = null;
        string categoryI = "";
        string dateI = "";
        double valueI = 0;

        bool emptyE_I;
        bool formatE_I;
        bool dateE;

        string currentDate = DateTime.Now.Year.ToString() + DateTime.Now.Month.ToString() +
                        DateTime.Now.ToString("dd");
        bool emptyE_A = false, formatE_A = false;
        string dateInit = "";
        string dateFin = "";
        string categoryA = "";
        double estimate, toSpend;
        int timeSpanFin, timeSpanRemain;

        public BudgetAid()
        {
            InitializeComponent();

            #region Input events/initialization
            DateTextY_I.Text = DateTime.Now.ToString("yyyy");
            DateTextM_I.Text = DateTime.Now.ToString("MM");
            DateTextD_I.Text = DateTime.Now.ToString("dd");
            DateTextY_I.ForeColor = SystemColors.WindowText;
            DateTextM_I.ForeColor = SystemColors.WindowText;
            DateTextD_I.ForeColor = SystemColors.WindowText;

            CategoryTextBox_I.Enter += new System.EventHandler(CategoryTextBox_I_EnterHint);
            ValueTextBox_I.Enter += new System.EventHandler(ValueTextBox_EnterHint);
            DateTextY_I.Enter += new System.EventHandler(DateTextBoxY_EnterHint);
            DateTextM_I.Enter += new System.EventHandler(DateTextBoxM_EnterHint);
            DateTextD_I.Enter += new System.EventHandler(DateTextBoxD_EnterHint);

            CategoryTextBox_I.Leave += new System.EventHandler(CategoryTextBox_LeaveEmpty);
            ValueTextBox_I.Leave += new System.EventHandler(ValueTextBox_LeaveEmpty);
            DateTextY_I.Leave += new System.EventHandler(DateTextBoxY_LeaveEmpty);
            DateTextM_I.Leave += new System.EventHandler(DateTextBoxM_LeaveEmpty);
            DateTextD_I.Leave += new System.EventHandler(DateTextBoxD_LeaveEmpty);
            #endregion

            #region Analyze events/initialization

            DateITextY.Text = DateTime.Now.Year.ToString();
            DateITextM.Text = DateTime.Now.ToString("MM");
            DateITextD.Text = "01";
            DateFTextY.Text = DateTime.Now.Year.ToString();
            DateFTextM.Text = DateTime.Now.ToString("MM");
            DateFTextD.Text = DateTime.DaysInMonth(DateTime.Now.Year,
                                            DateTime.Now.Month).ToString();
            DateITextY.ForeColor = SystemColors.WindowText;
            DateITextM.ForeColor = SystemColors.WindowText;
            DateITextD.ForeColor = SystemColors.WindowText;
            DateFTextY.ForeColor = SystemColors.WindowText;
            DateFTextM.ForeColor = SystemColors.WindowText;
            DateFTextD.ForeColor = SystemColors.WindowText;

            DateITextY.Enter += new System.EventHandler(DateITextY_EnterHint);
            DateITextM.Enter += new System.EventHandler(DateITextM_EnterHint);
            DateITextD.Enter += new System.EventHandler(DateITextD_EnterHint);
            DateFTextY.Enter += new System.EventHandler(DateFTextY_EnterHint);
            DateFTextM.Enter += new System.EventHandler(DateFTextM_EnterHint);
            DateFTextD.Enter += new System.EventHandler(DateFTextD_EnterHint);
            CategoryTextBox_A.Enter += new System.EventHandler(CategoryTextBox_A_EnterHint);
            TargetTextBox.Enter += new System.EventHandler(TargetTextBox_EnterHint);

            DateITextY.Leave += new System.EventHandler(DateITextY_A_LeaveEmpty);
            DateITextM.Leave += new System.EventHandler(DateITextM_LeaveEmpty);
            DateITextD.Leave += new System.EventHandler(DateITextD_LeaveEmpty);
            DateFTextY.Leave += new System.EventHandler(DateFTextY_LeaveEmpty);
            DateFTextM.Leave += new System.EventHandler(DateFTextM_LeaveEmpty);
            DateFTextD.Leave += new System.EventHandler(DateFTextD_LeaveEmpty);
            CategoryTextBox_A.Leave += new System.EventHandler(CategoryTextBox_A_LeaveEmpty);
            TargetTextBox.Leave += new System.EventHandler(TargetTextBox_LeaveEmpty);
            #endregion

            TabCon.SelectedIndexChanged += new System.EventHandler(TabIndexed);

            this.FormClosing += Form_Closing;

            //TODO: handle no budget.xls exception
            ew = new ExcelWriter();
            if(File.Exists(ew.getDocPath())){
                AddressLabel.Text = ew.getDocPath();
            }
        }

        #region Input Textbox Hints
        // Entering textbox with hints
        private void CategoryTextBox_I_EnterHint(object sender, EventArgs e)
        {
            if (CategoryTextBox_I.Text == HINTCATI)
            {
                CategoryTextBox_I.Text = EMPTY;
                CategoryTextBox_I.ForeColor = SystemColors.WindowText;
            }
        }

        private void ValueTextBox_EnterHint(object sender, EventArgs e)
        {
            if (ValueTextBox_I.Text == HINTVAL)
            {
                ValueTextBox_I.Text = EMPTY;
                ValueTextBox_I.ForeColor = SystemColors.WindowText;
            }
        }

        private void DateTextBoxY_EnterHint(object sender, EventArgs e)
        {
            if (DateTextY_I.Text == HINTY)
            {
                DateTextY_I.Text = EMPTY;
                DateTextY_I.ForeColor = SystemColors.WindowText;
            }
        }

        private void DateTextBoxM_EnterHint(object sender, EventArgs e)
        {
            if (DateTextM_I.Text == HINTM)
            {
                DateTextM_I.Text = EMPTY;
                DateTextM_I.ForeColor = SystemColors.WindowText;
            }
        }

        private void DateTextBoxD_EnterHint(object sender, EventArgs e)
        {
            if (DateTextD_I.Text == HINTD)
            {
                DateTextD_I.Text = EMPTY;
                DateTextD_I.ForeColor = SystemColors.WindowText;
            }
        }

        // Leaving blank text box shows hints
        private void CategoryTextBox_LeaveEmpty(object sender, EventArgs e)
        {
            if (CategoryTextBox_I.Text == EMPTY)
            {
                CategoryTextBox_I.Text = HINTCATI;
                CategoryTextBox_I.ForeColor = SystemColors.GrayText;
            }
        }

        private void ValueTextBox_LeaveEmpty(object sender, EventArgs e)
        {
            if (ValueTextBox_I.Text == EMPTY)
            {
                ValueTextBox_I.Text = HINTVAL;
                ValueTextBox_I.ForeColor = SystemColors.GrayText;
            }
        }

        private void DateTextBoxY_LeaveEmpty(object sender, EventArgs e)
        {
            if (DateTextY_I.Text == EMPTY)
            {
                DateTextY_I.Text = HINTY;
                DateTextY_I.ForeColor = SystemColors.GrayText;
            }
        }

        private void DateTextBoxM_LeaveEmpty(object sender, EventArgs e)
        {
            if (DateTextM_I.Text == EMPTY)
            {
                DateTextM_I.Text = HINTM;
                DateTextM_I.ForeColor = SystemColors.GrayText;
            }
        }

        private void DateTextBoxD_LeaveEmpty(object sender, EventArgs e)
        {
            if (DateTextD_I.Text == EMPTY)
            {
                DateTextD_I.Text = HINTD;
                DateTextD_I.ForeColor = SystemColors.GrayText;
            }
        }
        #endregion

        #region Analyze Textbox Hints
        //Entering textbox with hint erases text
        private void CategoryTextBox_A_EnterHint(object sender, EventArgs e)
        {
            if (CategoryTextBox_A.Text == HINTCATA)
            {
                CategoryTextBox_A.Text = EMPTY;
                CategoryTextBox_A.ForeColor = SystemColors.WindowText;
            }
        }

        private void TargetTextBox_EnterHint(object sender, EventArgs e)
        {
            if (TargetTextBox.Text == HINTTAR)
            {
                TargetTextBox.Text = EMPTY;
                TargetTextBox.ForeColor = SystemColors.WindowText;
            }
        }

        private void DateITextY_EnterHint(object sender, EventArgs e)
        {
            if (DateITextY.Text == HINTY)
            {
                DateITextY.Text = EMPTY;
                DateITextY.ForeColor = SystemColors.WindowText;
            }
        }

        private void DateITextM_EnterHint(object sender, EventArgs e)
        {
            if (DateITextM.Text == HINTM)
            {
                DateITextM.Text = EMPTY;
                DateITextM.ForeColor = SystemColors.WindowText;
            }
        }

        private void DateITextD_EnterHint(object sender, EventArgs e)
        {
            if (DateITextD.Text == HINTD)
            {
                DateITextD.Text = EMPTY;
                DateITextD.ForeColor = SystemColors.WindowText;
            }
        }

        private void DateFTextY_EnterHint(object sender, EventArgs e)
        {
            if (DateFTextY.Text == HINTY)
            {
                DateFTextY.Text = EMPTY;
                DateFTextY.ForeColor = SystemColors.WindowText;
            }
        }

        private void DateFTextM_EnterHint(object sender, EventArgs e)
        {
            if (DateFTextM.Text == HINTM)
            {
                DateFTextM.Text = EMPTY;
                DateFTextM.ForeColor = SystemColors.WindowText;
            }
        }

        private void DateFTextD_EnterHint(object sender, EventArgs e)
        {
            if (DateFTextD.Text == HINTD)
            {
                DateFTextD.Text = EMPTY;
                DateFTextD.ForeColor = SystemColors.WindowText;
            }
        }

        //Leaving textbox empty writes hints
        private void CategoryTextBox_A_LeaveEmpty(object sender, EventArgs e)
        {
            if (CategoryTextBox_A.Text == EMPTY)
            {
                CategoryTextBox_A.Text = HINTCATA;
                CategoryTextBox_A.ForeColor = SystemColors.GrayText;
            }
        }

        private void TargetTextBox_LeaveEmpty(object sender, EventArgs e)
        {
            if (TargetTextBox.Text == EMPTY)
            {
                TargetTextBox.Text = HINTTAR;
                TargetTextBox.ForeColor = SystemColors.GrayText;
            }
        }

        private void DateITextY_A_LeaveEmpty(object sender, EventArgs e)
        {
            if (DateITextY.Text == EMPTY)
            {
                DateITextY.Text = HINTY;
                DateITextY.ForeColor = SystemColors.GrayText;
            }
        }

        private void DateITextM_LeaveEmpty(object sender, EventArgs e)
        {
            if (DateITextM.Text == EMPTY)
            {
                DateITextM.Text = HINTM;
                DateITextM.ForeColor = SystemColors.GrayText;
            }
        }

        private void DateITextD_LeaveEmpty(object sender, EventArgs e)
        {
            if (DateITextD.Text == EMPTY)
            {
                DateITextD.Text = HINTD;
                DateITextD.ForeColor = SystemColors.GrayText;
            }
        }

        private void DateFTextY_LeaveEmpty(object sender, EventArgs e)
        {
            if (DateFTextY.Text == EMPTY)
            {
                DateFTextY.Text = HINTY;
                DateFTextY.ForeColor = SystemColors.GrayText;
            }
        }

        private void DateFTextM_LeaveEmpty(object sender, EventArgs e)
        {
            if (DateFTextM.Text == EMPTY)
            {
                DateFTextM.Text = HINTM;
                DateFTextM.ForeColor = SystemColors.GrayText;
            }
        }

        private void DateFTextD_LeaveEmpty(object sender, EventArgs e)
        {
            if (DateFTextD.Text == EMPTY)
            {
                DateFTextD.Text = HINTD;
                DateFTextD.ForeColor = SystemColors.GrayText;
            }
        }
        #endregion

        #region button events
        private void SubmitButton_Click(object sender, EventArgs e)
        {
            
            categoryI = CategoryTextBox_I.Text;
            dateI = DateTextY_I.Text + DateTextM_I.Text + DateTextD_I.Text;
            
            // Date must be actual date
            dateE = !ew.isDate(dateI);


            // All fields must have entry other than hint
            emptyE_I = (DateTextY_I.Text == HINTY || DateTextM_I.Text == HINTM || 
                        DateTextD_I.Text == HINTD || CategoryTextBox_I.Text == HINTCATI ||
                        ValueTextBox_I.Text == HINTVAL) ? true : false;
            
            // Cannot enter a nonnumber value
            try
            {
                valueI = Convert.ToDouble(ValueTextBox_I.Text);
                formatE_I = false;
            }
            catch (FormatException)
            {
                formatE_I = true;
            }

            // So user knows what they did wrong ...or right
            if (emptyE_I)
            {
                MessageBox.Show("Please fill in all fields.");
            }
            else if (formatE_I)
            {
                MessageBox.Show("Invalid number entry, please try again.");
            }
            else if (dateE)
            {
                MessageBox.Show("Invalid date, please try again.");
            }
            else if (ew.WriteToExcel(categoryI, valueI, dateI))
            {
                MessageBox.Show("Purchase Logger has written \"" + dateI + ", " + categoryI + ", "
                                + valueI + "\" to " + ew.getDocPath() + "... \n"
                                + "Please submit another entry or close the app.");
            }
            else
            {
                MessageBox.Show("A fatal error occured. Please close this app and try again.");
                Application.Exit();
            }
        }

        private void CalcButton_Click(object sender, EventArgs e)
        {
            dateInit = DateITextY.Text + DateITextM.Text + DateITextD.Text;
            dateFin = DateFTextY.Text + DateFTextM.Text + DateFTextD.Text;
            categoryA = CategoryTextBox_A.Text;

            // All fields must have entry
            emptyE_A = (CategoryTextBox_A.Text == HINTCATA || TargetTextBox.Text == HINTTAR ||
                DateITextY.Text == HINTY || DateITextM.Text == HINTM || DateITextD.Text == HINTD ||
                DateFTextY.Text == HINTY || DateFTextM.Text == HINTM || DateFTextD.Text == HINTD)
                ? true : false;

            // Estimate must be a numeric value
            // Dates must have format yyyy mm and dd 
            formatE_A = formatCheck(dateInit, dateFin, TargetTextBox.Text);

            if (emptyE_A)
            {
                MessageBox.Show("Please enter a value in all fields.");
            }
            else if (formatE_A)
            {
                MessageBox.Show("Invalid entry, please double check each field.");
            }
            else
            {
                estimate = Convert.ToDouble(TargetTextBox.Text);
                timeSpanFin = ew.calcDateRange(dateInit, dateFin);
                timeSpanRemain = ew.calcDateRange(currentDate, dateFin);
                toSpend = ew.calculateProg(categoryA, dateInit, dateFin, estimate);

                MessageBox.Show("$" + Math.Round(toSpend, 2).ToString() + " left to spend over\n"
                    + timeSpanRemain.ToString() + " days in your\n"
                    + categoryA + " budget.");
            }
        }
        #endregion

        private void TabIndexed(object sender, EventArgs e)
        {
            switch (TabCon.SelectedIndex)
            {
                case 0:
                    AcceptButton = SubmitButton;
                    break;
                case 1:
                    AcceptButton = CalcButton;
                    break;
            }
        }

        private void Form_Closing(object sender, System.ComponentModel.CancelEventArgs e)
        {
            ew.Close();
        }

        #region helper methods
        bool formatCheck(string dateInit, string dateFin, string estimate)
        {
            bool convertE = false, lengthE = false;

            try
            {
                int dateInitInt = Convert.ToInt32(dateInit);
                int dateFinInt = Convert.ToInt32(dateFin);
                Convert.ToDouble(estimate);

                DateTime initDate = new DateTime(dateInitInt / 10000,
                                                (dateInitInt / 100) % 100,
                                                dateInitInt % 100);
                DateTime finDate = new DateTime(dateFinInt / 10000,
                                                (dateFinInt / 100) % 100,
                                                dateFinInt % 100);
            }
            catch (FormatException)
            {
                convertE = true;
            }
            catch (ArgumentOutOfRangeException)
            {
                convertE = true;
            }

            if (dateInit.Length != 8 && dateInit.Length != 8)
            {
                lengthE = true;
            }

            return convertE || lengthE;
        }
        #endregion
    }
}
