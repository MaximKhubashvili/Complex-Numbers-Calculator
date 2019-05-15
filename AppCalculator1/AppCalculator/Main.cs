using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AppCalculator
{
    public partial class Main : Form
    {
        ControllerManager _cm;
        const string Zero = "0";
//        Manager manager;
        public Main()
        {
            InitializeComponent();
            _cm = new ControllerManager();
            txtHistory.Text = _cm.strHistory;
            txtCalculate.Text = _cm.strCalculate;
            lblType.Text = _cm.GetStringType();
            Clipboard.SetText(txtCalculate.Text);
            _cm.MC();
            //CorrectInput(trackBar1.Value);
            //_cm._base = trackBar1.Value;
        }
        private void btnNumeric_Click(object sender, EventArgs e)
        {
            if (((Button)sender).Enabled == false)
                return;
            try
            {
                _cm.AddNum(((Button)sender).Text.ToString());
                txtCalculate.Text = _cm.strCalculate;
                txtHistory.Text = _cm.strHistory;
                lblType.Text = _cm.GetStringType();
            }
            catch (DivideByZeroException)
            {
                MessageBox.Show("Попытка деления на ноль", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void btnSeparator_Click(object sender, EventArgs e)
        {
            _cm.SetSeparator();
            txtCalculate.Text = _cm.strCalculate;
            txtHistory.Text = _cm.strHistory;
            lblType.Text = _cm.GetStringType();
        }
        private void btnBackSpace_Click(object sender, EventArgs e)
        {
            _cm.BackSpace();
            txtCalculate.Text = _cm.strCalculate;
            //txtHistory.Text = _cm.strHistory;
            //lblType.Text = _cm.GetStringType();
        }
        private void btnDivide_Click(object sender, EventArgs e)
        {
            try
            {
                _cm.Compute(Operation.Division);
                txtCalculate.Text = _cm.strCalculate;
                txtHistory.Text = _cm.strHistory;
                lblType.Text = _cm.GetStringType();
            }
            catch (DivideByZeroException)
            {
                MessageBox.Show("Попытка деления на ноль", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (FormatException)
            {
                MessageBox.Show("Число не комплексное!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void btnCalculate_Click(object sender, EventArgs e)
        {
            try
            {
                _cm.Total();
                txtCalculate.Text = _cm.strCalculate;
                txtHistory.Text = _cm.strHistory;
                lblType.Text = _cm.GetStringType();
            }
            catch (DivideByZeroException)
            {
                MessageBox.Show("Попытка деления на ноль", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (FormatException)
            {
                MessageBox.Show("Число не комплексное!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void btnDeduct_Click(object sender, EventArgs e)
        {
            try
            {
                _cm.Compute(Operation.Deduct);
                txtCalculate.Text = _cm.strCalculate;
                txtHistory.Text = _cm.strHistory;
                lblType.Text = _cm.GetStringType();
            }
            catch (FormatException)
            {
                MessageBox.Show("Число не комплексное!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (DivideByZeroException)
            {
                MessageBox.Show("Попытка деления на ноль", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                _cm.Compute(Operation.Add);
                txtCalculate.Text = _cm.strCalculate;
                txtHistory.Text = _cm.strHistory;
                lblType.Text = _cm.GetStringType();
            }
            catch (FormatException)
            {
                MessageBox.Show("Число не комплексное!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (DivideByZeroException)
            {
                MessageBox.Show("Попытка деления на ноль", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void btnMul_Click(object sender, EventArgs e)
        {
            try
            {
                _cm.Compute(Operation.Mul);
                txtCalculate.Text = _cm.strCalculate;
                txtHistory.Text = _cm.strHistory;
                lblType.Text = _cm.GetStringType();
            }
            catch (FormatException)
            {
                MessageBox.Show("Число не комплексное!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (DivideByZeroException)
            {
                MessageBox.Show("Попытка деления на ноль", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void btnCE_Click(object sender, EventArgs e)
        {
            _cm.Reset();
            txtCalculate.Text = _cm.strCalculate;
            txtHistory.Text = _cm.strHistory;
            lblType.Text = _cm.GetStringType();
        }
       
        private void btnSqr_Click(object sender, EventArgs e)
        {
            _cm.Compute(Func.Sqr);
            txtHistory.Text = _cm.strHistory;
            txtCalculate.Text = _cm.strCalculate;
        }

        private void Main_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.NumPad0 || e.KeyCode == Keys.D0)
                btnNumeric_Click(btn0, e);
            if (e.KeyCode == Keys.NumPad1 || e.KeyCode == Keys.D1)
                btnNumeric_Click(btn1, e);
            if (e.KeyCode == Keys.NumPad2 || e.KeyCode == Keys.D2)
                btnNumeric_Click(btn2, e);
            if (e.KeyCode == Keys.NumPad3 || e.KeyCode == Keys.D3)
                btnNumeric_Click(btn3, e);
            if (e.KeyCode == Keys.NumPad4 || e.KeyCode == Keys.D4)
                btnNumeric_Click(btn4, e);
            if (e.KeyCode == Keys.NumPad5 || e.KeyCode == Keys.D5)
                btnNumeric_Click(btn5, e);
            if (e.KeyCode == Keys.NumPad6 || e.KeyCode == Keys.D6)
                btnNumeric_Click(btn6, e);
            if (e.KeyCode == Keys.NumPad7 || e.KeyCode == Keys.D7)
                btnNumeric_Click(btn7, e);
            if (e.KeyCode == Keys.NumPad8 || e.KeyCode == Keys.D8)
                btnNumeric_Click(btn8, e);
            if (e.KeyCode == Keys.NumPad9 || e.KeyCode == Keys.D9)
                btnNumeric_Click(btn9, e);
            if (e.KeyCode == Keys.Back)
                btnBackSpace_Click(btnBackSpace, e);
            if (e.KeyCode == Keys.Multiply)
                btnMul_Click(btnMul, e);
            if (e.KeyCode == Keys.Divide)
                btnDivide_Click(btnDivide, e);
            if (e.KeyCode == Keys.Subtract)
                btnDeduct_Click(btnDeduct, e);
            if (e.KeyCode == Keys.Add)
                btnAdd_Click(btnAdd, e);
            if (e.KeyCode == Keys.Enter)
                btnCalculate_Click(btnCalculate, e);
            if (e.KeyValue == 190)
                btnSeparator_Click(btnSeparator, e);
            if (e.KeyValue == 187 && !e.Shift)
                btnCalculate_Click(btnCalculate, e);
            if (e.KeyValue == 187 && e.Shift)
                btnAdd_Click(btnAdd, e);
            if (e.KeyValue == 189 && !e.Shift)
                btnDeduct_Click(btnDeduct, e);
            if (e.KeyValue == 56 && e.Shift)
                btnMul_Click(btnMul, e);
            if (e.KeyValue == 220)
                btnDivide_Click(btnDivide, e);
        }

        private void btnRev_Click(object sender, EventArgs e)
        {
            try
            {
                _cm.Compute(Func.Revers);
                txtHistory.Text = _cm.strHistory;
                txtCalculate.Text = _cm.strCalculate;
            }
            catch (DivideByZeroException)
            {
                MessageBox.Show("Попытка деления на ноль", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnMC_Click(object sender, EventArgs e)
        {
            _cm.MC();
            checkBox1.Checked = false;
            btnMC.Enabled = btnMR.Enabled = btnMAdd.Enabled = btnMDeduct.Enabled = false;
            checkBox1.Text = "ВЫКЛ";
        }
        private void btnMR_Click(object sender, EventArgs e)
        {
            _cm.MR();
            txtCalculate.Text = _cm.strCalculate;
            txtHistory.Text = _cm.strHistory;
        }
        private void btnMS_Click(object sender, EventArgs e)
        {
            _cm.MS();
            checkBox1.Checked = true;
            checkBox1.Text = "ВКЛ";
            btnMC.Enabled = btnMR.Enabled = btnMAdd.Enabled = btnMDeduct.Enabled = true;
        }
        private void btnMAdd_Click(object sender, EventArgs e)
        {
            _cm.MAdd();
        }
        private void btnMDeduct_Click(object sender, EventArgs e)
        {
            _cm.MDeduct();
        }

        private void btnNegativ_Click(object sender, EventArgs e)
        {
            _cm.PlusMinus();
            txtCalculate.Text = _cm.strCalculate;
            txtHistory.Text = _cm.strHistory;
        }
    

        private void обАвтореToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Калькулятор комплексных чисел:\nАвтор: Хубашвили М.А.", "Об авторах", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }

        private void справкаToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Данный калькулятор производит операции только над комплексными числами.", "Справка", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void копироватьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(txtCalculate.Text);
            checkBox2.Checked = true;
            checkBox2.Text = "ВКЛ";
        }

        private void вставитьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                _cm.InsertBuffer(Clipboard.GetText());
                lblType.Text = _cm.GetStringType();
                txtCalculate.Text = _cm.strCalculate;
                txtHistory.Text = _cm.strHistory;
            }
            catch (Exception)
            {
            }
        }

        private void сбросБуфераToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Clipboard.SetText("0");
            checkBox2.Checked = false;
            checkBox2.Text = "ВЫКЛ";
        }

        private void выходToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        

        private void CorrectInput(int newBase)
        {
            btn2.Enabled = btn3.Enabled =
                btn4.Enabled = btn5.Enabled =
                btn6.Enabled = btn7.Enabled =
                btn8.Enabled = btn9.Enabled;
                

            if (newBase == 2) return;
            btn2.Enabled = true;
            if (newBase == 3) return;
            btn3.Enabled = true;
            if (newBase == 4) return;
            btn4.Enabled = true;
            if (newBase == 5) return;
            btn5.Enabled = true;
            if (newBase == 6) return;
            btn6.Enabled = true;
            if (newBase == 7) return;
            btn7.Enabled = true;
            if (newBase == 8) return;
            btn8.Enabled = true;
            if (newBase == 9) return;
            btn9.Enabled = true;
            if (newBase == 10) return;
            
        }

        private void btnCompMin_Click(object sender, EventArgs e)
        {
            //if (_cm.GetTypeCalc() != TypeCalc.Frac)
         
            _cm.SetTypeCalc(TypeCalc.Complex, "-");
            txtCalculate.Text = _cm.strCalculate;
            lblType.Text = _cm.GetStringType();
        }

        private void btnComplexPlus_Click(object sender, EventArgs e)
        {
            //if (_cm.GetTypeCalc() != TypeCalc.Frac)
                _cm.SetTypeCalc(TypeCalc.Complex, "+");
            txtCalculate.Text = _cm.strCalculate;
            lblType.Text = _cm.GetStringType();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void правкаToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void panel5_Paint(object sender, PaintEventArgs e)
        {

        }

        private void справкаToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void txtHistory_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtCalculate_TextChanged(object sender, EventArgs e)
        {

        }

        private void panel4_Paint(object sender, PaintEventArgs e)
        {

        }

        private void lblType_Click(object sender, EventArgs e)
        {

        }

        private void btnReset_Click(object sender, EventArgs e)
        {

        }

        private void Main_Load(object sender, EventArgs e)
        {

        }

        
    }
}
