using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LLProject
{
    public partial class frmstockinfo : Form
    {
        public frmstockinfo()
        {
            InitializeComponent();
        }
        Model.jnLLPEntities model = new Model.jnLLPEntities();
        Model.StockIN objmodel = new Model.StockIN();

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                objmodel.ItemName = txtItemname.Text;
                objmodel.Quantity = cbQuantity.Text;
                objmodel.Quality = txtQuality.Text;
                objmodel.Price = txtPrice.Text;
                objmodel.Balance = txtBalance.Text;
                objmodel.Paid = txtPaid.Text;
                objmodel.Date = dateStart.Value.ToString();
                model.StockINs.Add(objmodel);
                model.SaveChanges();
            }
            catch (Exception)
            {

                throw;
            }

       
        }

        private void bunifuMaterialTextbox6_OnValueChanged(object sender, EventArgs e)
        {

        }
    }
}
