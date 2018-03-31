using Serializable.Controller;
using Serializable.Model;
using System;
using System.Collections.Generic;
using System.Net;
using System.Windows.Forms;

namespace Serializable
{
    public partial class Principal : Form
    {

        private EquipoController Equipos = new EquipoController();

        public Principal()
        {
            InitializeComponent();
        }

        private void Principal_Load(object sender, System.EventArgs e)
        {
            tboxNombre.Focus();
            Listar(Equipos.Equipos);
        }

        private void Listar(List<Equipo> Lista)
        {
            TableEquipos.Rows.Clear();
            for(int i = 0; i < Lista.Count; i++)
            {
                TableEquipos.Rows.Add(new string[] {i+"", Lista[i].Nombre, Lista[i].Estadio ,
                    Lista[i].uEscudo.ToString(), Lista[i].uEstadio.ToString()});
            }
        }

        private void btnAdd_Click(object sender, System.EventArgs e)
        {
            if (ValEquipo())
            {
                Equipos.Create(new Equipo(tboxNombre.Text.ToUpper(), tboxEstadio.Text.ToUpper(), 
                    new Uri(tboxuEstadio.Text), new Uri(tboxuEscudo.Text)));
                Vista();
                MessageBox.Show("Se ha registrado satisfactoriamente", "Registrado", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                Listar(Equipos.Equipos);
            }
        }

        private void ControlBtn(bool Cond)
        {
            btnAdd.Enabled = Cond;
            btnMod.Enabled = !Cond;
            btnElim.Enabled = !Cond;
        }

        private void Vista()
        {
            tboxEstadio.Text = null;
            tboxFind.Text = null;
            tboxuEstadio.Text = null;
            tboxNombre.Text = null;
            tboxuEscudo.Text = null;
        }

        private bool ValEquipo()
        {
            try
            {
                if(string.IsNullOrEmpty(tboxEstadio.Text) || string.IsNullOrEmpty(tboxNombre.Text) ||
                    string.IsNullOrEmpty(tboxuEscudo.Text) || string.IsNullOrEmpty(tboxuEstadio.Text))
                {
                    MessageBox.Show("Debe ingresar todos los campos solicitados", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }else if (!ValUrl(tboxuEscudo.Text) || !ValUrl(tboxuEstadio.Text))
                {
                    MessageBox.Show("Debe ingresar urls validas de imagen", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }
                else
                {
                    return true;
                }
            }
            catch (Exception)
            {
                return false;
            }
        }
        private bool ValUrl(string url)
        {
            HttpWebRequest wreq;
            HttpWebResponse wresp;
            wresp = null;
            try
            {
                wreq = (HttpWebRequest)HttpWebRequest.Create(url);
                wreq.AllowWriteStreamBuffering = true;
                wresp = (HttpWebResponse)wreq.GetResponse();
                if (wresp.GetResponseStream() != null)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            catch
            {
                return false;
            }
            finally
            {
                if (wresp != null)
                    wresp.Close();
            }
        }
    }
}
