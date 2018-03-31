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
        private object IndexTable;

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
                btnCancel.PerformClick();
                MessageBox.Show("Se ha registrado satisfactoriamente", "Registrado", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
            IndexTable = null;
            pbEstadio.ImageLocation = null;
            pbEscudo.ImageLocation = null;
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

        private void TableEquipos_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            ControlBtn(false);
            IndexTable = TableEquipos.CurrentRow.Cells[0].Value;
            tboxNombre.Text = TableEquipos.CurrentRow.Cells[1].Value.ToString();
            tboxEstadio.Text = TableEquipos.CurrentRow.Cells[2].Value.ToString();
            tboxuEscudo.Text = TableEquipos.CurrentRow.Cells[3].Value.ToString();
            tboxuEstadio.Text = TableEquipos.CurrentRow.Cells[4].Value.ToString();
            pbEscudo.ImageLocation = TableEquipos.CurrentRow.Cells[3].Value.ToString();
            pbEstadio.ImageLocation = TableEquipos.CurrentRow.Cells[4].Value.ToString();
        }

        private void btnElim_Click(object sender, EventArgs e)
        {
            try
            {
                if(Confirm("¿Seguro que desea eliminar este item?"))
                {
                    Equipos.Delete(Int16.Parse(IndexTable.ToString()));
                    btnCancel.PerformClick();
                    MessageBox.Show("Se ha eliminado satisfactoriamente", "Eliminado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Ha ocurrido un error vuelva a intentar", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private bool Confirm(string Mensaje)
        {
             if(MessageBox.Show(Mensaje, "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
             {
                return true;
             }
            return false;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Vista();
            ControlBtn(true);
            Listar(Equipos.Equipos);
            tboxNombre.Focus();
        }

        private void btnMod_Click(object sender, EventArgs e)
        {
            try
            {
                if (ValEquipo())
                {
                    if (Confirm("¿Seguro que desea modificar este item?"))
                    {
                        Equipos.Update(Int16.Parse(IndexTable.ToString()), new Equipo(tboxNombre.Text.ToUpper(), tboxEstadio.Text.ToUpper(),
                                                        new Uri(tboxuEstadio.Text), new Uri(tboxuEscudo.Text)));
                        btnCancel.PerformClick();
                        MessageBox.Show("Se ha modificado satisfactoriamente", "modificado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Ha ocurrido un error vuelva a intentar", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
