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
    public partial class frmcustomerinfo : MaterialSkin.Controls.MaterialForm
    {
        public frmcustomerinfo()
        {
            InitializeComponent();
        }
        Model.jnLLPEntities model = new Model.jnLLPEntities();
        Model.Customer objModel = new Model.Customer();
        private void bunifuMaterialTextbox1_OnValueChanged(object sender, EventArgs e)
        {
            
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void frmcustomerinfo_Load(object sender, EventArgs e)
        {

        }

        //private void button1_Click(object sender, EventArgs e)
        //{
        //    try
        //    {
        //        objModel.Name = txtName.Text;
        //        objModel.Mobile  = txtmobile.Text;
        //        objModel.Address = Convert.ToInt32(txtAddress.Text);
        //        objModel.AdharNo = txtAdharNo.Text;
        //        objModel.Date = dateStart.Value.ToString();
        //        model.ItemInfoes.Add(objModel);
        //        model.SaveChanges();

        //    }
        //    catch (Exception)
        //    {

        //        throw;
        //    }

        //}

        private void button1_Click_1(object sender, EventArgs e)
        {

            try
            {
                objModel.Name = txtName.Text;
                objModel.Mobile = txtMobile.Text;
                objModel.Address = txtAddress.Text;
                objModel.AdharNo = txtAdharNo.Text;
                objModel.Date = DateStart.Value.ToString();
                model.Customers.Add(objModel);
                model.SaveChanges();
            }
            catch (Exception EX)
            {

                throw EX;
            }
        }

        private void frmcustomerinfo_Load_1(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
