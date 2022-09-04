using System.Diagnostics;
namespace SQLconn

{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

      Class_con obnew =new  Class_con();
        private void button1_Click(object sender, EventArgs e)
        {
            obnew.conectar();
        }

        Class_con objcon= new Class_con();
        private void button2_Click(object sender, EventArgs e)
        {

            objcon.p_nombre = txtname.Text;
            objcon.p_apellido = txtlast.Text;
            objcon.p_edad = int.Parse(txtEdad.Text);
            objcon.p_direccion = txtdireccion.Text;
            objcon.p_deparmento = txtDepartamento.Text;
            objcon.insertar();
            Hide();





        }

        private void button7_Click(object sender, EventArgs e)
        {
            objcon.p_codigo = int.Parse(textBox8.Text);
            objcon.buscar(dataGridView1);

        }

        private void button4_Click(object sender, EventArgs e)
        {
          // objcon.p_codigo = int.Parse(textBox8.Text);
            objcon.view(dataGridView1);



        }

        private void worrdToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Process.Start("word");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            objcon.p_codigo = int.Parse(txtcodigo.Text);
            objcon.p_nombre = txtname.Text;
            objcon.p_apellido = txtlast.Text;
            objcon.p_edad = int.Parse(txtEdad.Text);
            objcon.p_direccion = txtdireccion.Text;
            objcon.p_deparmento = txtDepartamento.Text;
            objcon.actualizar();
            Hide();





        }

        private void button6_Click(object sender, EventArgs e)
        {
            objcon.p_codigo = int.Parse(txtcodigo.Text);
            objcon.eliminar(dataGridView1);


        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {


         
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }
    }
}