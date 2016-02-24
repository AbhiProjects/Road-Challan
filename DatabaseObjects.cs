using System;
using System.Configuration;
using System.Data;
using MySql.Data.MySqlClient;

namespace RoadChallanApplication
{
    class DatabaseObjects
    {
        private string ConnectionString = ConfigurationManager.ConnectionStrings["RoadChallanApplication.Properties.Settings.ConnectionString"].ConnectionString;

        public DatabaseObjects()
        {

        }

        public DataTable FillAndReturnDataTable(string Query)
        {
            DataTable dt = new DataTable();

            MySqlConnection conn = new MySqlConnection(ConnectionString);
            MySqlCommand cmd = new MySqlCommand(Query, conn);
            conn.Open();

            MySqlDataAdapter da = new MySqlDataAdapter(cmd);

            da.Fill(dt);
            conn.Close();
            da.Dispose();

            return dt;
        }

        public void DatabaseEntry(Challan t)
        {

            MySqlConnection conn = new MySqlConnection(ConnectionString);
            MySqlCommand cmd = conn.CreateCommand();

            cmd.CommandText = "INSERT INTO tblChallan " +
                              "VALUES(@Invoice,@IDate,@Qty,@Amount,@Cartoons,@DDate,@DId,@CId)";
            cmd.Parameters.AddWithValue("@Invoice", t.getInvoice().ToString());
            cmd.Parameters.AddWithValue("@IDate", t.getIDate());
            cmd.Parameters.AddWithValue("@Qty", t.getQty().ToString());
            cmd.Parameters.AddWithValue("@Amount", t.getAmount().ToString());
            cmd.Parameters.AddWithValue("@Cartoons", t.getCartoons().ToString());
            cmd.Parameters.AddWithValue("@DDate", t.getDDate());
            cmd.Parameters.AddWithValue("@DId", t.getDId().ToString());
            cmd.Parameters.AddWithValue("@CId", t.getCId().ToString());

            conn.Open();
            cmd.ExecuteNonQuery();
            conn.Close();
        }
    }

    class Company
    {
        #region Data Members

        private int Id;
        private string CName;
        private string cst;
        private string vat;

        #endregion

        #region Constructor

        public Company(int tId, string tCName, string tcst, string tvat)
        {
            Id = tId;
            CName = tCName;
            cst = tcst;
            vat = tvat;
        }

        #endregion

        #region Set Functions

        public void setId(int tId)
        {
            Id = tId;
        }

        public void setCName(string tCName)
        {
            CName = tCName;
        }

        public void setcst(string tcst)
        {
            cst = tcst;
        }

        public void setId(string tvat)
        {
            vat = tvat;
        }

        #endregion 

        #region Get Functions

        public int getId()
        {
            return Id;
        }

        public string getCname()
        {
            return CName;
        }

        public string getcst()
        {
            return cst;
        }

        public string getvat()
        {
            return vat;
        }

        #endregion

    }

    class Distributor
    {
        #region Data Members

        private int Id;
        private string DistributorName;
        private string CO;
        private string Address1;
        private string Address2;
        private string Address3;
        private string DispatcherName;
        private string DAddress1;
        private string DAddress2;
        private string DAddress3;

        #endregion

        #region Constructor

        public Distributor(int tId, string tDistributorName, string tCO,
                            string tAddress1, string tAddress2, string tAddress3,
                            string tDispatcherName, string tDAddress1, string tDAddress2,
                            string tDAddress3)
        {
            Id = tId;
            DistributorName = tDistributorName;
            CO = tCO;
            Address1 = tAddress1;
            Address2 = tAddress2;
            Address3 = tAddress3;
            DispatcherName = tDispatcherName;
            DAddress1 = tDAddress1;
            DAddress2 = tDAddress2;
            DAddress3 = tDAddress3;

        }

        #endregion

        #region Set Functions

        public void setId(int tId)
        {
            Id = tId;
        }

        public void setDistributorName(string tDistributorName)
        {
            DistributorName = tDistributorName;
        }

        public void setCO(string tCO)
        {
            CO = tCO;
        }

        public void setAddress1(string tAddress1)
        {
            Address1 = tAddress1;
        }

        public void setAddress2(string tAddress2)
        {
            Address2 = tAddress2;
        }

        public void setAddress3(string tAddress3)
        {
            Address3 = tAddress3;
        }

        public void setDispatcherName(string tDispatcherName)
        {
            DispatcherName = tDispatcherName;
        }

        public void setDAddress1(string tDAddress1)
        {
            DAddress1 = tDAddress1;
        }

        public void setDAddress2(string tDAddress2)
        {
            DAddress2 = tDAddress2;
        }
        
        public void setDAddress3(string tDAddress3)
        {
            DAddress3 = tDAddress3;
        }

        #endregion

        #region Get Functions

        public int getId()
        {
            return Id;
        }

        public string getDistributorName()
        {
            return DistributorName;
        }

        public string getAddress1()
        {
            return Address1;
        }


        public string getAddress2()
        {
            return Address2;
        }


        public string getAddress3()
        {
            return Address3;
        }

        public string getDispatcherName()
        {
            return DispatcherName;
        }

        public string getDAddress1()
        {
            return DAddress1;
        }

        public string getDAddress2()
        {
            return DAddress2;
        }

        public string getDAddress3()
        {
            return DAddress3;
        }

        #endregion
    }

    class Challan
    {
        #region Data Members

        private int Invoice;
        private string IDate;
        private int Qty;
        private double Amount;
        private int Cartoons;
        private string DDate;
        private int DId;
        private int CId;

        #endregion

        #region Constructor

        public Challan(int tInvoice, string tIDate, int tQty, double tAmount, 
                        int tCartoons,string tDDate, int tDId, int tCId)
        {
            Invoice = tInvoice;
            IDate = tIDate;
            Qty = tQty;
            Amount = tAmount;
            Cartoons = tCartoons;
            DDate = tDDate;
            DId = tDId;
            CId = tCId;
        }

        #endregion

        #region Set Functions

        public void setInvoice(int tInvoice)
        {
            Invoice = tInvoice;
        }

        public void setIDate(string tIDate)
        {
            IDate = tIDate;
        }

        public void setQty(int tQty)
        {
            Qty = tQty;
        }

        public void setAmount(double tAmount)
        {
            Amount = tAmount;
        }

        public void setCartoons(int tCartoons)
        {
            Cartoons = tCartoons;
        }

        public void setDDate(string tDDate)
        {
            DDate = tDDate;
        }

        public void setDId(int tDId)
        {
            DId = tDId;
        }

        public void setCId(int tCId)
        {
            CId = tCId;
        }

        #endregion

        #region Get Function

        public int getInvoice()
        {
            return Invoice;
        }

        public string getIDate()
        {
            return IDate;
        }

        public int getQty()
        {
            return Qty;
        }

        public double getAmount()
        {
            return Amount;
        }

        public int getCartoons()
        {
            return Cartoons;
        }

        public string getDDate()
        {
            return DDate;
        }

        public int getDId()
        {
            return DId;
        }

        public int getCId()
        {
            return CId;
        }

        #endregion
    }
}
