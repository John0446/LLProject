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
    public partial class frmsalesinfo : MaterialSkin.Controls.MaterialForm
    {
        public frmsalesinfo()
        {
            InitializeComponent();
        }
        Model.jnLLPEntities model = new Model.jnLLPEntities();
        Model.Sale objmodel = new Model.Sale();
        private void bunifuMaterialTextbox1_OnValueChanged(object sender, EventArgs e)
        {

        }

        private void bunifuMaterialTextbox3_OnValueChanged(object sender, EventArgs e)
        {

        }

        private void bunifuMaterialTextbox4_OnValueChanged(object sender, EventArgs e)
        {

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                objmodel.CusName = Convert.ToInt32(cbCustomerName.Text);
                objmodel.ItemID = Convert.ToInt32(cbItem.Text);
                objmodel.Qutantity = txtQuantity.Text;
                objmodel.Price = txtPrice.Text;
                objmodel.TotalAmount = txtTotalAmount.Text;
                objmodel.Paid = txtpaid.Text;
                objmodel.Balance = txtBalance.Text;
                objmodel.Date = dateStart.Value.ToString();
                model.Sales.Add(objmodel);
                model.SaveChanges();
                           

            }
            catch (Exception ex)

            {
                throw ex;
            }

            
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void bunifuDropdown1_onItemSelected(object sender, EventArgs e)
        {

        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
