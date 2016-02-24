using System;
using System.Configuration;
using System.Windows.Forms;
using System.Data;
using System.Drawing;
using System.Drawing.Printing;

namespace RoadChallanApplication
{
    public partial class frmRoadChallan : Form
    {     
        DatabaseObjects D = new DatabaseObjects();

        public frmRoadChallan()
        {
            InitializeComponent();
        }

        #region Key Press Events Of Text Boxes

        private void frmRoadChallan_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == System.Windows.Forms.Keys.Enter)
            {
                SendKeys.Send("{TAB}");
            }
        }
        
        private void txtInvoice_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void txtQuantity_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void txtCartoons_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void txtAmount_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && (e.KeyChar != '.') && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }

            // only allow one decimal point
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
        }

        private void txtDDate_Leave(object sender, EventArgs e)
        {

            DateTime value;
            if (!DateTime.TryParse(txtDDate.Text, out value))
            {
                txtDDate.Text = "";
                MessageBox.Show("Inavlid Date Input");
                //txtDDate.Focus();
            }
        }

        private void txtIDate_Leave(object sender, EventArgs e)
        {
            DateTime value;
            if (!DateTime.TryParse(txtIDate.Text, out value))
            {
                txtIDate.Text = "";
                MessageBox.Show("Inavlid Date Input");
                //txtIDate.Focus();
            }
        }

        #endregion

        public void CreateDocument(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            
            #region Data

            #region Database Data Retrieval

            string QueryChallan = "SELECT * FROM tblChallan WHERE Invoice=" + txtInvoice.Text + " AND CId=" + int.Parse(cmbCompanyName.SelectedValue.ToString()) + "";
            DataTable dtChallan = D.FillAndReturnDataTable(QueryChallan);

            string QueryDistributor = "SELECT * FROM tblDistributor WHERE Id=" + dtChallan.Rows[0][6].ToString() + "";
            DataTable dtDistributor = D.FillAndReturnDataTable(QueryDistributor);

            string QueryCompnay = "SELECT * FROM tblCompany WHERE Id=" + dtChallan.Rows[0][7].ToString() + "";
            DataTable dtCompany = D.FillAndReturnDataTable(QueryCompnay);

            #endregion

            #region Header Data

            string strCompanyName = dtCompany.Rows[0][1].ToString();
            string strcst = dtCompany.Rows[0][2].ToString();
            string strvat = dtCompany.Rows[0][3].ToString();
            string strCompanyAddress = "27/1 Ahiripukur Road Kolkata - 700019";
            string strCompanyPhone = "033-2287-1260";

            #endregion

            #region Distributor Data

            string strDistributorName = dtDistributor.Rows[0][1].ToString() ;
            string strCO = dtDistributor.Rows[0][2].ToString();
            string strAdress1 = dtDistributor.Rows[0][3].ToString();
            string strAdress2 = dtDistributor.Rows[0][4].ToString();
            string strAdress3 = dtDistributor.Rows[0][5].ToString();
            string strDispatcher = dtDistributor.Rows[0][6].ToString();
            string strDAdress1 = dtDistributor.Rows[0][7].ToString();
            string strDAdress2 = dtDistributor.Rows[0][8].ToString();
            string strDAdress3 = dtDistributor.Rows[0][9].ToString();

            #endregion

            #region Body Data

            string strChallanNo = dtChallan.Rows[0][0].ToString();
            string strChallanDate = dtChallan.Rows[0][1].ToString();
            string strDispatchDate = dtChallan.Rows[0][5].ToString();
            string strQty = dtChallan.Rows[0][2].ToString();
            string strAmount = dtChallan.Rows[0][3].ToString(); ;
            string strCartoons=NumberToWord(int.Parse(dtChallan.Rows[0][4].ToString()));
            string strChallanType = "ROAD CHALLAN";
            string strChallanDash = "-----------------------------";

            #endregion

            #endregion

            #region Fonts

            Font HeaderFont = new Font("Times New Roman", 28, FontStyle.Bold);
            Font HeaderDataFont = new Font("Times New Roman", 16);
            Font BodyHeaderFont = new Font("Times New Roman", 18, FontStyle.Bold);
            Font BodyFont = new Font("Times New Roman", 14);
            Font FotterFont = new Font("Times New Roman", 14,FontStyle.Bold);
            Brush ColorBrush = new SolidBrush(Color.Black);
            Pen BlackPen = new Pen(Color.Black, 3);

            #endregion

            #region X - Y Cordinate Intiliazation

            int startX = 20;
            int startY = 10;

            int currX = startX + 150;
            int currY = startY + 20;

            int offset = 30;
            int bodyoffset = 22;

            #endregion

            #region Mita Marketing X Cordinate Offset Adjusments

            int mitamarketingoffset = 0;

            if (strCompanyName == "MITA MARKETING")
            {
                mitamarketingoffset = 40;

            }

            #endregion

            #region Local Delievery Challan

            if (strDispatcher == "LOCAL")
            {
                strChallanType = "LOCAL DELIVERY CHALLAN";
                strChallanDash = "-----------------------------------------------";
            }

            #endregion

            Graphics graphic = e.Graphics;

            #region Header

            graphic.DrawString(strCompanyName, HeaderFont, ColorBrush, currX+mitamarketingoffset, currY);

            currY += offset+10;
            graphic.DrawString(strCompanyAddress, HeaderDataFont, ColorBrush, currX + 50, currY);
            currY += offset;
            graphic.DrawString("Phone Number: " + strCompanyPhone, HeaderDataFont, ColorBrush, currX + 80, currY);
            currY += offset;
            graphic.DrawString("VAT:" + strvat.PadRight(20) + "CST:" + strcst, HeaderDataFont, ColorBrush, currX + 50, currY);
            currY += offset;
            graphic.DrawLine(BlackPen, 20, currY, 810, currY);

            #endregion

            #region Body

            if (strDispatcher == "LOCAL")
            
            {
                currY += offset+10;
                graphic.DrawString(strChallanType, BodyHeaderFont, ColorBrush, currX + 90, currY);
                currY += offset-10;
                graphic.DrawString(strChallanDash, BodyHeaderFont, ColorBrush, currX + 90 - 15, currY);
            }

            else
            {

                currY += offset+10;
                graphic.DrawString(strChallanType, BodyHeaderFont, ColorBrush, currX + 150, currY);
                currY += offset-10;
                graphic.DrawString(strChallanDash, BodyHeaderFont, ColorBrush, currX + 150 - 15, currY);
            }
            
            currY += 2*offset;
            graphic.DrawString("To,", BodyFont, ColorBrush, startX, currY);
            graphic.DrawString("Challan No: " + strChallanNo, BodyFont, ColorBrush, startX + 500, currY);
            currY += bodyoffset;
            graphic.DrawString("M/s. "+strDistributorName, BodyFont, ColorBrush, startX, currY);
            graphic.DrawString("Challan Date: " + strChallanDate, BodyFont, ColorBrush, startX + 500, currY);
            currY += bodyoffset;
            graphic.DrawString("C/O " + strCO, BodyFont, ColorBrush, startX, currY);
            currY += bodyoffset;
            graphic.DrawString(strAdress1, BodyFont, ColorBrush, startX, currY);
            currY += bodyoffset;
            graphic.DrawString(strAdress2, BodyFont, ColorBrush, startX, currY);
            graphic.DrawString("Invoice No: " + strChallanNo, BodyFont, ColorBrush, startX + 500, currY);
            currY += bodyoffset;
            graphic.DrawString(strAdress3, BodyFont, ColorBrush, startX, currY);
            graphic.DrawString("Invoice Date: " + strChallanDate, BodyFont, ColorBrush, startX + 500, currY);
            currY += bodyoffset+15;
            graphic.DrawString("Dispatch: " + strDispatcher, BodyFont, ColorBrush, startX, currY);
            currY += bodyoffset;
            graphic.DrawString(strDAdress1, BodyFont, ColorBrush, startX, currY);
            graphic.DrawString("Dispatch Date: " + strDispatchDate, BodyFont, ColorBrush, startX + 500, currY);
            currY += bodyoffset;
            graphic.DrawString(strDAdress2, BodyFont, ColorBrush, startX, currY);
            currY += bodyoffset;
            graphic.DrawString(strDAdress3, BodyFont, ColorBrush, startX, currY);

            currY += 2 * offset;
            graphic.DrawString("PARTICULARS".PadRight(20) + "QUANTITY(PCS)".PadRight(20) + "NO OF CARTOONS".PadRight(20) + "INVOICE VALUE", FotterFont, ColorBrush, startX + 10, currY);
            currY += offset - 10;
            graphic.DrawString("----------------------------------------------------------------------------------------------------------------------", FotterFont, ColorBrush, startX, currY);
            currY += offset;
            graphic.DrawString("LADIES".PadRight(40) + strQty.PadRight(35) + strCartoons.PadRight(35) + "₹ " + strAmount, BodyFont, ColorBrush, startX + 10, currY);
            currY += bodyoffset;
            graphic.DrawString("UNDERGARMENTS", BodyFont, ColorBrush, startX + 10, currY);

            #endregion

            #region Fotter

            if (strDispatcher == "LOCAL")
            {
                currY += 14 * offset;
                graphic.DrawString("---------------------------------------------------------", FotterFont, ColorBrush, startX + 20 - 15, currY);
                currY += bodyoffset;
                graphic.DrawString("RECEIVER SIGNATURE WITH DATE", FotterFont, ColorBrush, startX+20, currY);
            
            }

            else
            {
                currY += 14 * offset;
                graphic.DrawString("FROM", FotterFont, ColorBrush, startX + 500, currY);
                currY += bodyoffset;
                graphic.DrawString(strCompanyName, FotterFont, ColorBrush, startX + 500, currY);
            }

            #endregion

        }

        public void DocumentPrint(System.Drawing.Printing.PrintPageEventHandler Document)
        {
            PrintDialog printDialog = new PrintDialog();
           
            PrintDocument printDocument = new PrintDocument();

            printDialog.Document = printDocument;         

            printDocument.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(Document); 

            DialogResult result = printDialog.ShowDialog();

            if (result == DialogResult.OK)
            {
                printDocument.Print();

            }
        }

        public string NumberToWord(int n)
        {
            #region Number To Word Array Mapping

            string[] words = new string[] { "Zero", 
                                            "One", "Two", "Three", "Four", "Five", 
                                            "Six", "Seven", "Eight", "Nine", "Ten", 
                                            "Eleven", "Tweleve", "Thirteen", "Fourteen", "Fifteen", 
                                            "Sixteen", "Seventeen", "Eighteen", "Nineteen", "Twenty",
                                            "Twenty One", "Twenty Two", "Twenty Three", "Twenty Four", "Twenty Five",
                                            "Twenty Six", "Twenty Seven", "Twenty Eight", "Twenty Nine", "Thirty"
                                         };

            #endregion

            return n.ToString() + " (" + words[n] + ")";
        }

        public void ComboBoxUpdate(ComboBox cmb,string Query,string Data)
        {
            DataTable dt = D.FillAndReturnDataTable(Query);

            DataRow dr = dt.NewRow();
            dr[0] = -1;
            dr[1] = Data;
            dt.Rows.InsertAt(dr,0);

            cmb.DataSource = dt;
            cmb.ValueMember=dt.Columns[0].ColumnName;
            cmb.DisplayMember=dt.Columns[1].ColumnName;
        }

        public bool CheckInvoiceExist(string Invoice,int CId)
        {
            string QueryChallan = "SELECT * FROM tblChallan WHERE Invoice=" + Invoice + " AND CId="+CId+"";
            DataTable dt = D.FillAndReturnDataTable(QueryChallan);

            if (dt.Rows.Count == 0)
            {
                return false;
            }

            return true;
        }
        
        public bool ValidateForm()
        {

            #region Removing Leading And Trailing White Spaces

            txtInvoice.Text.Trim();
            txtIDate.Text.Trim();
            txtQuantity.Text.Trim();
            txtAmount.Text.Trim();
            txtCartoons.Text.Trim();
            txtDDate.Text.Trim();

            #endregion

            #region Checking Mandatory Combo Box

            if (cmbCompanyName.SelectedIndex == 0)
            {
                MessageBox.Show("Please Select A Company");
                cmbCompanyName.Focus();
                return false;
            }

            if (cmbDistributorName.SelectedIndex==0)
            {
                MessageBox.Show("Please Select A Distributor");
                cmbDistributorName.Focus();
                return false;
            }

            #endregion

            #region Checking Empty TextBoxes

            if (txtInvoice.TextLength == 0)
            {
                MessageBox.Show("Invoice Number Cannot Be Empty");
                txtInvoice.Focus();
                return false;
            }


            if (txtIDate.TextLength == 0)
            {
                MessageBox.Show("Invoice Date Cannot Be Empty");
                txtIDate.Focus();
                return false;
            }

            if (txtQuantity.TextLength == 0)
            {
                MessageBox.Show("Invoice Quantity Cannot Be Empty");
                txtQuantity.Focus();
                return false;
            }

            if (txtAmount.TextLength == 0)
            {
                MessageBox.Show("Invoice Amount Cannot Be Empty");
                txtAmount.Focus();
                return false;
            }

            if (txtCartoons.TextLength == 0)
            {
                MessageBox.Show("No Of Cartoons Cannot Be Empty");
                txtCartoons.Focus();
                return false;
            }

            if (txtDDate.TextLength == 0)
            {
                MessageBox.Show("Dispatch Date Cannot Be Empty");
                txtDDate.Focus();
                return false;
            }

            #endregion

            #region Duplicate Invoice Check

            if (CheckInvoiceExist(txtInvoice.Text, int.Parse(cmbCompanyName.SelectedValue.ToString())) == true)
            {
                MessageBox.Show("This Invoice Number Already Exists");
               
                txtInvoice.Focus();
                
                return false;
            }
           
            #endregion

            #region Dispatch And Invoice Date Check

            DateTime InvoiceDate;
            DateTime DispatchDate;

            if ((DateTime.TryParse(txtIDate.Text, out InvoiceDate))&&(DateTime.TryParse(txtDDate.Text, out DispatchDate)))
            {
                if (DispatchDate < InvoiceDate)
                {
                    MessageBox.Show("Dispatch Date Cannot Be Less Than Invoice Date");
                    txtDDate.Text = "";
                    txtDDate.Focus();
                    return false;
                }

            }

            #endregion

            return true;
        }

        private void frmRoadChallan_Load(object sender, EventArgs e)
        {
            #region Combo Box Intial Setup

            string QueryDistributor = "SELECT Id,DistributorName FROM tblDistributor";
            string DataDistributor = "Select The Distributor";
            ComboBoxUpdate(cmbDistributorName, QueryDistributor, DataDistributor);

            string QueryCompany = "SELECT Id,CName FROM tblCompany";
            string DataCompany = "Select The Company";
            ComboBoxUpdate(cmbCompanyName, QueryCompany, DataCompany);

            #endregion
        }

        private void btnGenerate_Click(object sender, EventArgs e)
        {
            #region New Challan Button

            if (btnGenerate.Text == "New Challan")
            {
                #region Enabling All Controls

                cmbDistributorName.Enabled = true;
                txtIDate.Enabled = true; 
                txtQuantity.Enabled = true; 
                txtAmount.Enabled = true;
                txtCartoons.Enabled = true;
                txtDDate.Enabled = true;

                #endregion

                #region Setting All Controls To Default Values

                cmbCompanyName.SelectedValue = -1;
                cmbDistributorName.SelectedValue = -1;
                txtInvoice.Text = "";
                txtIDate.Text = "";
                txtQuantity.Text = "";
                txtAmount.Text = "";
                txtCartoons.Text = "";
                txtDDate.Text = "";

                #endregion

                btnGenerate.Text = "Generate";

                return;
            }

            #endregion

            #region Validation Check

            if (!ValidateForm())
            {
                return;
            }

            #endregion

            #region Object Creation

            Challan t = new Challan(int.Parse(txtInvoice.Text), txtIDate.Text,
                                   int.Parse(txtQuantity.Text), double.Parse(txtAmount.Text),
                                   int.Parse(txtCartoons.Text), txtDDate.Text,
                                   int.Parse(cmbDistributorName.SelectedValue.ToString()),
                                   int.Parse(cmbCompanyName.SelectedValue.ToString())
                                   );

            #endregion

            D.DatabaseEntry(t);
            
            DocumentPrint(CreateDocument);

        }

        private void btnView_Click(object sender, EventArgs e)
        {
            if (int.Parse(cmbCompanyName.SelectedValue.ToString()) == -1)
            {
                MessageBox.Show("Please Select A Company");

                #region Setting All Controls To Default Values

                cmbCompanyName.SelectedValue = -1;
                cmbDistributorName.SelectedValue = -1;
                txtInvoice.Text = "";
                txtIDate.Text = "";
                txtQuantity.Text = "";
                txtAmount.Text = "";
                txtCartoons.Text = "";
                txtDDate.Text = "";

                #endregion

                cmbCompanyName.Focus();

                return;
            }

            if (txtInvoice.TextLength == 0 || CheckInvoiceExist(txtInvoice.Text, int.Parse(cmbCompanyName.SelectedValue.ToString())) == false)
            {
                MessageBox.Show("This Invoice Number Does Not Exist");

                #region Setting All Controls To Default Values

                cmbDistributorName.SelectedValue = -1;
                txtInvoice.Text = "";
                txtIDate.Text = "";
                txtQuantity.Text = "";
                txtAmount.Text = "";
                txtCartoons.Text = "";
                txtDDate.Text = "";

                #endregion

                return;
            }

            #region Disabling All Controls

            cmbDistributorName.Enabled = false;
            txtIDate.Enabled = false;
            txtQuantity.Enabled = false;
            txtAmount.Enabled = false;
            txtCartoons.Enabled = false;
            txtDDate.Enabled = false;

            #endregion

            string QueryChallan = "SELECT * FROM tblChallan WHERE Invoice=" + txtInvoice.Text + " AND CId=" + int.Parse(cmbCompanyName.SelectedValue.ToString()) + "";
            DataTable dt = D.FillAndReturnDataTable(QueryChallan);

            #region Setting Up Values In Controls

            cmbCompanyName.SelectedValue = dt.Rows[0][7].ToString();
            cmbDistributorName.SelectedValue = dt.Rows[0][6].ToString();
            txtIDate.Text = dt.Rows[0][1].ToString();
            txtQuantity.Text = dt.Rows[0][2].ToString();
            txtAmount.Text = dt.Rows[0][3].ToString();
            txtCartoons.Text = dt.Rows[0][4].ToString();
            txtDDate.Text = dt.Rows[0][5].ToString();

            #endregion

            btnGenerate.Text = "New Challan";

        }

        private void btnPrint_Click(object sender, EventArgs e)
        {
            if ( txtInvoice.TextLength!=0 &&
                 int.Parse(cmbCompanyName.SelectedValue.ToString()) != -1 &&
                 cmbDistributorName.Enabled==false &&
                 CheckInvoiceExist(txtInvoice.Text, int.Parse(cmbCompanyName.SelectedValue.ToString())) == true
                )
            {   
                DocumentPrint(CreateDocument);
            }
        }

    }
}