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
    class deletion
    {
        public void delete(Object id, string proc, string param)
        {
            try
            {
                SqlCommand cmd = new SqlCommand("st_deleteUser", MainClass.con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue(param, id);
                MainClass.con.Open();
                cmd.ExecuteNonQuery();
                MainClass.con.Close();
                MessageBox.Show("Data deleted successfully...", "Success...", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MainClass.con.Close();
                MainClass.showMSG(ex.Message, "Error...", "Error");
            }
        }
        public void deleteCat(Object id, string proc, string param)
        {
            try
            {
                SqlCommand cmd = new SqlCommand("st_deleteCategory", MainClass.con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue(param, id);
                MainClass.con.Open();
                cmd.ExecuteNonQuery();
                MainClass.con.Close();
                MessageBox.Show("Data deleted successfully...", "Success...", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MainClass.con.Close();
                MainClass.showMSG(ex.Message, "Error...", "Error");
            }
        }
        public void deleteProduct(Object id, string proc, string param)
        {
            try
            {
                SqlCommand cmd = new SqlCommand("st_deleteProduct", MainClass.con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue(param, id);
                MainClass.con.Open();
                cmd.ExecuteNonQuery(); 
                MainClass.con.Close();
                MessageBox.Show("Data deleted successfully...", "Success...", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MainClass.con.Close();
                MainClass.showMSG(ex.Message, "Error...", "Error");
            }
        }
        public void deleteSupplier(Object id, string proc, string param)
        {
            try
            {
                SqlCommand cmd = new SqlCommand("st_deleteSupplier", MainClass.con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue(param, id);
                MainClass.con.Open();
                cmd.ExecuteNonQuery();
                MainClass.con.Close();
                MessageBox.Show("Data deleted successfully...", "Success...", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MainClass.con.Close();
                MainClass.showMSG(ex.Message, "Error...", "Error");
            }
        }
        public void deleteProductFromPID(Object id, string proc, string param)
        {
            try
            {
                SqlCommand cmd = new SqlCommand("st_deleteProductFromPID", MainClass.con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue(param, id);
                MainClass.con.Open();
                cmd.ExecuteNonQuery();
                MainClass.con.Close();
                MessageBox.Show("Data deleted successfully...", "Success...", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MainClass.con.Close();
                MainClass.showMSG(ex.Message, "Error...", "Error");
            }
        }
    }
}
