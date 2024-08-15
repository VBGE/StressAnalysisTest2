using System;
using System.Windows.Forms;

namespace MyCAD.EntryForms
{
    public partial class Input_Values : Form
    {
        public Input_Values()
        {
            InitializeComponent();
        }

        private double _parentMaterialThickness = 0.0;
        private double _weldLegSize = 0.0;

        private void Input_Values_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'materialsDBDataSet.Materials' table. You can move, or remove it, as needed.
            this.materialsTableAdapter.Fill(this.materialsDBDataSet.Materials);
        }

        private void BindingNavigatorAddNewItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.materialsBindingSource.AddNew();
        }

        private void MaterialsBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            if (!(double.TryParse(tensileStrengthTextBox.Text, out double _tensileStrength) &&
            (_tensileStrength > 0)))
            {
                MessageBox.Show("Incorrect Tensile Strength input.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            DialogResult result;
            result = MessageBox.Show("Are you sure you want to save changes?", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (result == System.Windows.Forms.DialogResult.Yes)
            {
                this.Validate();
                this.materialsBindingSource.EndEdit();
                this.materialsTableAdapter.Update(materialsDBDataSet.Materials);
            }
        }

        private void BindingNavigatorDeleteItem_Click(object sender, EventArgs e)
        {
            if (int.TryParse(idTextBox.Text, out int _idMaterial) &&
            (_idMaterial >= 1) && (_idMaterial <= 14))
            {
                MessageBox.Show("Can not delete a standard material.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            this.Validate();
            this.materialsBindingSource.RemoveCurrent();
        }

        private void TextBox_Course_Leave(object sender, EventArgs e)
        {
            TextBox AnyTextBox = sender as TextBox;
            if (double.TryParse(AnyTextBox.Text, out double value))
            {
                return;
            }
            MessageBox.Show("Please, enter a VALID number.");
            AnyTextBox.Text = "0";
        }

        private void Ok_btn_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(tensileStrengthTextBox.Text))
            {
                MessageBox.Show("Select material, please.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                tensileStrengthTextBox.Focus();
                return;
            }
            if (string.IsNullOrEmpty(parent_material_thickness_textBox.Text) || (Convert.ToDouble(parent_material_thickness_textBox.Text) <= 0))
            {
                MessageBox.Show("Parent material thickness is not correct.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (PassInputValuesToGraphicsForm())
            {
                double.TryParse(tensileStrengthTextBox.Text, out double TensileStrength_su);
                GraphicsForm.instance.TensileStrengthUltimate = TensileStrength_su;
                GraphicsForm.instance.ExecuteCalculation();
                AllowableForceLabel.Text = Convert.ToString(GraphicsForm.instance.AllowableForcePerInchOfWeld);
                ResultantForceLabel.Text = Convert.ToString(GraphicsForm.instance.ALLRF);
                FoSLabel.Text = Convert.ToString(GraphicsForm.instance.FoS);
                MessageBox.Show("Calculation completed.");
            }
        }

        private bool PassInputValuesToGraphicsForm()
        {
            try
            {
                GraphicsForm.instance.Fx = Convert.ToDouble(Fx_textBox.Text);
                GraphicsForm.instance.Fy = Convert.ToDouble(Fy_textBox.Text);
                GraphicsForm.instance.Fz = Convert.ToDouble(Fz_textBox.Text);
                GraphicsForm.instance.Mx = Convert.ToDouble(Mx_textBox.Text);
                GraphicsForm.instance.My = Convert.ToDouble(My_textBox.Text);
                GraphicsForm.instance.Mz = Convert.ToDouble(Mz_textBox.Text);
                GraphicsForm.instance.ParentMaterialThickness = Convert.ToDouble(parent_material_thickness_textBox.Text);
                GraphicsForm.instance.WeldLegSize = Convert.ToDouble(weld_size_textBox.Text);
                return true;
            }
            catch (Exception)
            {
                MessageBox.Show("Error. Check inputs and try again.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
        }

        private void Cancel_btn_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void Weld_size_textBox_TextChanged(object sender, EventArgs e)
        {
            if ((!string.IsNullOrEmpty(weld_size_textBox.Text)) && double.TryParse(weld_size_textBox.Text, out _weldLegSize))
            {
                _parentMaterialThickness = _weldLegSize * 4 / 3;
                parent_material_thickness_textBox.Text = Convert.ToString(_parentMaterialThickness);
            }
            else
                MessageBox.Show("Parenet material thickness is not correct", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }
    }
}
