using CrystalDecisions.CrystalReports.Engine;
using CrystalDecisions.Windows.Forms;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Inventory_Management_System
{
    class retrieval
    {
        public void showUsers(DataGridView gv, DataGridViewColumn userIDGV, DataGridViewColumn NameGV, DataGridViewColumn UsernameGV, DataGridViewColumn PassGV, DataGridViewColumn PhoneGV, DataGridViewColumn EmailGV, DataGridViewColumn StatusGV, string data = null )
        {
            try
            {
                SqlCommand cmd;
                if (data == null)
                {

                    cmd = new SqlCommand("st_getUsersData", MainClass.con);
                }
                else
                {
                    cmd = new SqlCommand("st_getUsersDataLike", MainClass.con);
                    cmd.Parameters.AddWithValue("@data",data);
                }         

                cmd.CommandType = CommandType.StoredProcedure;
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                userIDGV.DataPropertyName = dt.Columns["ID"].ToString();
                NameGV.DataPropertyName = dt.Columns["Name"].ToString();
                UsernameGV.DataPropertyName = dt.Columns["Username"].ToString();
                PassGV.DataPropertyName = dt.Columns["Password"].ToString();
                PhoneGV.DataPropertyName = dt.Columns["Phone"].ToString();
                EmailGV.DataPropertyName = dt.Columns["Email"].ToString();
                StatusGV.DataPropertyName = dt.Columns["Status"].ToString();

                gv.DataSource = dt;
            } 
            catch (Exception)
            {
                throw;
            }
            
        }
        public void showCategories(DataGridView gv, DataGridViewColumn catIDGV, DataGridViewColumn catNameGV, DataGridViewColumn statGV)
        {
            try
            {
                SqlCommand cmd = new SqlCommand("st_getCategoriesData", MainClass.con);
          
                cmd.CommandType = CommandType.StoredProcedure;
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                catIDGV.DataPropertyName = dt.Columns["ID"].ToString();
                catNameGV.DataPropertyName = dt.Columns["Category"].ToString();
                statGV.DataPropertyName = dt.Columns["Status"].ToString();        
                gv.DataSource = dt;
            }
            catch (Exception)
            {
                MainClass.showMSG("Unable to load categories data", "Error...", "Error");
            }

        }
        public void getList(string proc, ComboBox cb, string displayMember, string valueMember)
        {
            try
            {     
                cb.DataSource = null;            
                SqlCommand cmd = new SqlCommand(proc, MainClass.con);
                cmd.CommandType = CommandType.StoredProcedure;
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                DataRow dr = dt.NewRow();
                dr.ItemArray = new object[] { 0, "Select..." };
                dt.Rows.InsertAt(dr, 0);
                cb.DisplayMember = displayMember;
                cb.ValueMember = valueMember;
                cb.DataSource = dt;
            }
            catch (Exception)
            {

                throw;
            }
        }
        public void getListWithTwoParameters(string proc, ComboBox cb, string displayMember, string valueMember,
            string param1, object val1, string param2, object val2)
        {
            try
            {   
                cb.DataSource = null;
                SqlCommand cmd = new SqlCommand(proc, MainClass.con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue(param1, val1);
                cmd.Parameters.AddWithValue(param2, val2);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                DataRow dr = dt.NewRow();
                dr.ItemArray = new object[] { 0, "Select..." };
                dt.Rows.InsertAt(dr, 0);
                cb.DisplayMember = displayMember;
                cb.ValueMember = valueMember;
                cb.DataSource = dt;
            }
            catch (Exception)
            {

                throw;
            }
        }
        public void showProducts(DataGridView gv, DataGridViewColumn proIDGV, DataGridViewColumn proNameGV, DataGridViewColumn expiryGV, DataGridViewColumn catGV, DataGridViewColumn barcodeGV, DataGridViewColumn catIDGV)
        {
            try
            {
                SqlCommand cmd = new SqlCommand("st_getProductsData", MainClass.con);

                cmd.CommandType = CommandType.StoredProcedure;
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                proIDGV.DataPropertyName = dt.Columns["Product ID"].ToString();
                proNameGV.DataPropertyName = dt.Columns["Product"].ToString();
                barcodeGV.DataPropertyName = dt.Columns["Barcode"].ToString();
                expiryGV.DataPropertyName = dt.Columns["Expiry"].ToString();
                catGV.DataPropertyName = dt.Columns["Category"].ToString();
                catIDGV.DataPropertyName = dt.Columns["Category ID"].ToString();
                gv.DataSource = dt;
            }
            catch (Exception)
            {
                MainClass.showMSG("Unable to load categories data", "Error...", "Error");
            }

        }
        public void showSalesDataViaID(Int64 salesID, DataGridView gv, DataGridViewColumn salesIDGV, DataGridViewColumn barcordeGV, 
            DataGridViewColumn productGV, DataGridViewColumn quantityGV, DataGridViewColumn priceGV,
            DataGridViewColumn perProTotalGV, DataGridViewColumn totDiscGV, DataGridViewColumn totAmountGV,
            DataGridViewColumn amountGivenGV, DataGridViewColumn amountReturnedGV, DataGridViewColumn dateGV, 
             DataGridViewColumn userGV, DataGridViewColumn paymentMethodGV, DataGridViewColumn proIDGV)
        {
            try
            {
                SqlCommand cmd = new SqlCommand("st_getSalesReceiptWRTSalesID", MainClass.con);

                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@salesID", salesID);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                salesIDGV.DataPropertyName         = dt.Columns["Sales ID"].ToString();
                barcordeGV.DataPropertyName        = dt.Columns["Barcode"].ToString();
                productGV.DataPropertyName         = dt.Columns["Product"].ToString();
                quantityGV.DataPropertyName        = dt.Columns["Quantity"].ToString();
                priceGV.DataPropertyName           = dt.Columns["Product Price"].ToString();
                //perProDiscGV.DataPropertyName      = dt.Columns["Per Product Discount"].ToString();
                perProTotalGV.DataPropertyName     = dt.Columns["Per Product Total"].ToString();
                totDiscGV.DataPropertyName         = dt.Columns["Total Discount"].ToString();
                totAmountGV.DataPropertyName       = dt.Columns["Total Amount"].ToString();
                amountGivenGV.DataPropertyName     = dt.Columns["Amount Given"].ToString();
                amountReturnedGV.DataPropertyName  = dt.Columns["Amount Returned"].ToString();
                dateGV.DataPropertyName            = dt.Columns["Date"].ToString();
                userGV.DataPropertyName            = dt.Columns["User"].ToString();
                paymentMethodGV.DataPropertyName   = dt.Columns["Pay Type"].ToString();
                proIDGV.DataPropertyName           = dt.Columns["Product ID"].ToString();              
                gv.DataSource = dt;
            }
            catch (Exception)
            {
                MainClass.showMSG("Unable to load categories data", "Error...", "Error");
            }

        }

        public void showPurchaseInvoiceDetails(Int64 pid, DataGridView gv, DataGridViewColumn mPIDGV, DataGridViewColumn proIDGV, DataGridViewColumn proNameGV, DataGridViewColumn quantGV, DataGridViewColumn pupGV, DataGridViewColumn totGV)
        {
            try
            {
                SqlCommand cmd = new SqlCommand("st_getPurchaceInvoiceDetails", MainClass.con);
                cmd.Parameters.AddWithValue("@pid", pid);
                cmd.CommandType = CommandType.StoredProcedure;
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                mPIDGV.DataPropertyName = dt.Columns["mPID"].ToString();
                proIDGV.DataPropertyName = dt.Columns["Product ID"].ToString();
                proNameGV.DataPropertyName = dt.Columns["Product"].ToString();
                quantGV.DataPropertyName = dt.Columns["Quantity"].ToString();
                pupGV.DataPropertyName = dt.Columns["Per Unit Price"].ToString();
                totGV.DataPropertyName = dt.Columns["Total Price"].ToString();
                   
                gv.DataSource = dt;
            }
            catch (Exception)
            {
                MainClass.showMSG("Unable to load categories data", "Error...", "Error");
            }

        }
        public void showProductsWRTCategory(int catID, DataGridView gv, DataGridViewColumn proIDGV, DataGridViewColumn proNameGV,
            DataGridViewColumn bpGV, DataGridViewColumn spGV, DataGridViewColumn disGV, DataGridViewColumn profitPerGV)
        {
            try
            {
                SqlCommand cmd = new SqlCommand("st_getProductsWRTcategory", MainClass.con);
                cmd.Parameters.AddWithValue("@catID", catID);
                cmd.CommandType = CommandType.StoredProcedure;
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);               
                proIDGV.DataPropertyName = dt.Columns["Product ID"].ToString();
                proNameGV.DataPropertyName = dt.Columns["Product"].ToString();
                bpGV.DataPropertyName = dt.Columns["Buying Price"].ToString();
                spGV.DataPropertyName = dt.Columns["Selling Price"].ToString();
                disGV.DataPropertyName = dt.Columns["Discount"].ToString();
                profitPerGV.DataPropertyName = dt.Columns["Profit Percentage"].ToString();

                gv.DataSource = dt;
            }
            catch (Exception)
            {
                MainClass.showMSG("Unable to load products data", "Error...", "Error");
            }

        }

        public static int USER_ID
        {
            get;
            private set;
        }
        public static string  EMP_NAME
        {
            get;
            private set;
        }   
        private string[] productsData = new string[6];     
        public string[] getProductsWRTBarcode(string barcode)
        {
            try
            {
                SqlCommand cmd = new SqlCommand("st_getProductByBarcode", MainClass.con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("barcode", barcode);
                MainClass.con.Open();
                SqlDataReader dr = cmd.ExecuteReader();
                if (dr.HasRows)
                {
                    while (dr.Read())
                    {
                        productsData[0] = dr[0].ToString(); //proID
                        productsData[1] = dr[1].ToString(); //product
                        productsData[2] = dr[2].ToString(); //barcode
                        productsData[3] = dr[3].ToString(); //sellingPrice
                        productsData[4] = dr[4].ToString(); //Discount
                        productsData[5] = dr[5].ToString(); //Final Selling Price
                    }
                }
                else
                {
                   
                }
                MainClass.con.Close();

            }
            catch (Exception)
            {
                MainClass.con.Close();
                throw;
            }
            return productsData;
        }
       
        private static string user_name=null, pass_word=null;
        private static bool checkLogin;
        public static bool getUserDetails(string username, string password)
        {
            try
            {
                SqlCommand cmd = new SqlCommand("st_getUserDetails", MainClass.con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@user",username);
                cmd.Parameters.AddWithValue("@pass",password);
                MainClass.con.Open();
                SqlDataReader dr = cmd.ExecuteReader();
                if (dr.HasRows)
                {
                    checkLogin = true;
                    while (dr.Read())
                    {
                        USER_ID = Convert.ToInt32(dr["ID"].ToString());
                        EMP_NAME = dr["Name"].ToString();
                        user_name = dr["Username"].ToString();
                        pass_word = dr["Password"].ToString();
                    }
                }
                else
                {
                    checkLogin = false;
                    if (username != null && password != null)
                    {
                        if(user_name != username && pass_word == password)
                        {
                            MainClass.showMSG("Invalid Username", "Error", "Error");
                        }
                        else if (user_name == username && pass_word != password)
                        {
                            MainClass.showMSG("Invalid Password", "Error", "Error");
                        }
                        else if (user_name != username && pass_word != password)
                        {
                            MainClass.showMSG("Invalid Username and Password", "Error", "Error");
                        }
                    }
                }
                MainClass.con.Close();
            }
            catch (Exception)
            {
                MainClass.con.Close();
                MainClass.showMSG("Unable to login...", "Error", "Error");
            }
            return checkLogin;
        }
        public void showSuppliers(DataGridView gv, DataGridViewColumn suppIDGV, DataGridViewColumn conNameGV, DataGridViewColumn personGV, DataGridViewColumn phone1GV, DataGridViewColumn phone2GV, DataGridViewColumn addressGV, DataGridViewColumn ntnGV, DataGridViewColumn statusGV)
        {
            try
            {
                SqlCommand cmd = new SqlCommand("st_getSupplierData", MainClass.con);

                cmd.CommandType = CommandType.StoredProcedure;
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                suppIDGV.DataPropertyName  = dt.Columns["ID"].ToString();
                conNameGV.DataPropertyName = dt.Columns["Company"].ToString();
                personGV.DataPropertyName  = dt.Columns["Contact Person"].ToString();
                phone1GV.DataPropertyName  = dt.Columns["Phone 1"].ToString();
                phone2GV.DataPropertyName  = dt.Columns["Phone 2"].ToString();
                addressGV.DataPropertyName = dt.Columns["Address"].ToString();
                statusGV.DataPropertyName  = dt.Columns["Status"].ToString();
                ntnGV.DataPropertyName     = dt.Columns["NTN #"].ToString();
                gv.DataSource = dt;
            }
            catch (Exception)
            {
                MainClass.showMSG("Unable to load suppliers data", "Error...", "Error");
            }

        }
        private bool checkPPExistance;
        public bool checkProductPriceExistance(Int64 proID)
        {
            try
            {
                SqlCommand cmd = new SqlCommand("st_checkProductPriceExist", MainClass.con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@proID", proID);
                MainClass.con.Open();
                SqlDataReader dr = cmd.ExecuteReader();
                if (dr.HasRows)
                {
                    checkPPExistance = true;
                }
                else
                {
                    checkPPExistance = false;
                }
                MainClass.con.Close();
            }
            catch (Exception)
            {

            }
            return checkPPExistance;
        }
        public void showStockDetails(DataGridView gv, DataGridViewColumn proIDGV, DataGridViewColumn proGV, DataGridViewColumn barcodeGV,
            DataGridViewColumn expiryGV, DataGridViewColumn bpGV, DataGridViewColumn spGV, DataGridViewColumn catGV, DataGridViewColumn availablestockGV, DataGridViewColumn statusGV, DataGridViewColumn totGV)
        {
            try
            {
                SqlCommand cmd = new SqlCommand("st_getAllStock", MainClass.con);

                cmd.CommandType = CommandType.StoredProcedure;
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                proIDGV.DataPropertyName = dt.Columns["Product ID"].ToString();
                proGV.DataPropertyName = dt.Columns["Product"].ToString();
                barcodeGV.DataPropertyName = dt.Columns["Barcode"].ToString();
                expiryGV.DataPropertyName = dt.Columns["Expiry Date"].ToString();
                bpGV.DataPropertyName = dt.Columns["Buying Price"].ToString();
                spGV.DataPropertyName = dt.Columns["Selling Price"].ToString();
                catGV.DataPropertyName = dt.Columns["Category"].ToString();
                availablestockGV.DataPropertyName = dt.Columns["Available Stock"].ToString();
                statusGV.DataPropertyName = dt.Columns["Status"].ToString();
                totGV.DataPropertyName = dt.Columns["Total Amount"].ToString();
                gv.DataSource = dt;
              
            }
            catch (Exception)
            {
                MainClass.showMSG("Unable to load stock data", "Error...", "Error");
            }
        }
        
        private object productStockCount;
        public object  getProductQuantity(Int64 proID)
        {
            try
            {
                SqlCommand cmd = new SqlCommand("st_getProductQuantity", MainClass.con);
                cmd.CommandType = CommandType.StoredProcedure;       
                cmd.Parameters.AddWithValue("@proID", proID);
                MainClass.con.Open();
                productStockCount = cmd.ExecuteScalar();
                MainClass.con.Close();
            }
            catch (Exception)
            {     
            }
            return productStockCount;
        }
        public object getProductQuantityWithoutConnection(Int64 proID)
        {
            try
            {
                SqlCommand cmd = new SqlCommand("[st_getProductQuantity]", MainClass.con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@proID", proID);
              
                productStockCount = cmd.ExecuteScalar();

            }
            catch (Exception)
            {
            }
            return productStockCount;
        }
        
        public void showReport(ReportDocument rd, CrystalReportViewer crv, string proc, string param1, object val1) 
        {
            try
            {
                SqlCommand cmd = new SqlCommand(proc, MainClass.con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue(param1, val1);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                rd.Load(Application.StartupPath + "\\Reports\\salesReciept.rpt");
                rd.SetDataSource(dt);
                crv.ReportSource = rd;
                crv.RefreshReport();
            }
            catch (Exception ex)
            {

                MainClass.showMSG(ex.Message, "Error", "Error");
            }
        }

        public void showDailySales(DateTime date ,DataGridView gv, DataGridViewColumn salIDGV, DataGridViewColumn userGV, 
            DataGridViewColumn totAmountGV, DataGridViewColumn totDisGV, DataGridViewColumn amountGivenGV,
            DataGridViewColumn amountReturnedGV, DataGridViewColumn userIDGV)
        {
            try
            {
                SqlCommand cmd = new SqlCommand("st_getDailySales", MainClass.con);

                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@date", date);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                salIDGV.DataPropertyName = dt.Columns["Sales ID"].ToString();
                userGV.DataPropertyName = dt.Columns["User"].ToString();
                totAmountGV.DataPropertyName = dt.Columns["Total Amoint"].ToString();
                totDisGV.DataPropertyName = dt.Columns["Total Discount"].ToString();
                amountGivenGV.DataPropertyName = dt.Columns["Amount Given"].ToString();
                amountReturnedGV.DataPropertyName = dt.Columns["Amount Returned"].ToString();
                userIDGV.DataPropertyName = dt.Columns["User ID"].ToString();
                gv.DataSource = dt;
            }
            catch (Exception)
            {
                MainClass.showMSG("Unable to load categories data", "Error...", "Error");
            }

        }
        //public void showCompleteSalesReport(ReportDocument rd, CrystalReportViewer crv, string proc, string param1, object val1)
        //{
        //    try
        //    {
        //        SqlCommand cmd = new SqlCommand(proc, MainClass.con);
        //        cmd.CommandType = CommandType.StoredProcedure;
        //        cmd.Parameters.AddWithValue(param1, val1);
        //        SqlDataAdapter da = new SqlDataAdapter(cmd);
        //        DataTable dt = new DataTable();
        //        da.Fill(dt);
        //        rd.Load(Application.StartupPath + "\\Reports\\salesDataReport.rpt");
        //        rd.SetDataSource(dt);
        //        crv.ReportSource = rd;
        //        crv.RefreshReport();
        //    }
        //    catch (Exception ex)
        //    {

        //        MainClass.showMSG(ex.Message, "Error", "Error");
        //    }
        //}
        public string[] getProductsWRTBarcode_pi(string barcode)
        {
            try
            {
                SqlCommand cmd = new SqlCommand("st_getProductByBarcode_pi", MainClass.con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("barcode", barcode);
                MainClass.con.Open();
                SqlDataReader dr = cmd.ExecuteReader();
                if (dr.HasRows)
                {
                    while (dr.Read())
                    {
                        productsData[0] = dr[0].ToString(); //proID
                        productsData[1] = dr[1].ToString(); //product
                        productsData[2] = dr[2].ToString(); //barcode
                      
                    }
                }
                else
                {

                }
                MainClass.con.Close();

            }
            catch (Exception)
            {
                MainClass.con.Close();
                throw;
            }
            return productsData;
        }
    }
}