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
    public partial class frmiteminfo : MaterialSkin.Controls.MaterialForm
    {
        public frmiteminfo()
        {
            InitializeComponent();
        }
        Model.jnLLPEntities model = new Model.jnLLPEntities();
        Model.ItemInfo objModel = new Model.ItemInfo();
        private void frmiteminfo_Load(object sender, EventArgs e)
        {
            //TODO: This line of code loads data into the 'lLProjectDataSet.ItemInfo' table.You can move, or remove it, as needed.
            // this.itemInfoTableAdapter.Fill(this.lLProjectDataSet.ItemInfo);
            var data = model.ItemInfoes.ToList();
            if (data != null)
            {
                gvItemInfo.DataSource = data;
            }


        }

        private void bunifuMaterialTextbox1_OnValueChanged(object sender, EventArgs e)
        {

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                objModel.ItemName = txtName.Text;
                objModel.Quality = txtQulity.Text;
                objModel.Quantity = Convert.ToInt32(txtqQty.Text);
                objModel.Price = txtPrice.Text;
                objModel.Date = dateStart.Value.ToString();
                model.ItemInfoes.Add(objModel);
                model.SaveChanges();
                
            }
            catch (Exception)
            {

                throw;
            }
           
        }

        
        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void gvItemInfo_MouseClick(object sender, MouseEventArgs e)
        {

        }
    }
}
