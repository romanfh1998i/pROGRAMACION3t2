using System.Security.Cryptography.X509Certificates;
using static System.Net.Mime.MediaTypeNames;

namespace Tarea2
{
    public partial class Form1 : Form
    {
        ClassNomina nomina=new ClassNomina();
        public Form1()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {


        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            int total, Sueldo_Neto;
            nomina.sueldo = Convert.ToInt32(txtSueldo.Text);
            nomina.AFP=(int)(Convert.ToInt32(txtSueldo.Text) * 0.0291);
            nomina.ASR=(int)(Convert.ToInt32(txtSueldo.Text) * 0.0304);
            if (nomina.sueldo > 33384)
            {
               
                nomina.IRS = (int)((nomina.sueldo-33384)*0.15);
                

            }
            else
            {
                nomina.IRS = 0;

            }
            ClassCalculo Total = new ClassCalculo();
            total = Total.TotalSalario(nomina.AFP, nomina.ASR, nomina.IRS);


            Sueldo_Neto = Total.SueldoNeto(total, nomina.sueldo);
            {
                int fila = dataGridView1.Rows.Add();
                dataGridView1.Rows[fila].Cells["ASR"].Value = nomina.ASR;
                dataGridView1.Rows[fila].Cells["ISR"].Value = nomina.IRS;
                dataGridView1.Rows[fila].Cells["AFP"].Value = nomina.AFP;
                dataGridView1.Rows[fila].Cells["Total_Descuento"].Value = total;
                dataGridView1.Rows[fila].Cells["Sueldo_Neto"].Value = Sueldo_Neto;
            }

        }

        private void txtSueldo_TextChanged(object sender, EventArgs e)
        {

        }
    }
}