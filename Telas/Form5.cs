using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Telas {
    public partial class Form5 : Form {
        public Form5() {
            InitializeComponent();
            customizeDesign();
        }
        private void customizeDesign() {
            panelCadServico.Visible = false;
            panelCadCategoria.Visible = false;


        }
        private void hideSubMenu() {
            if (panelCadServico.Visible == true) {
                panelCadServico.Visible = false;
            }
            if (panelCadCategoria.Visible == true) {
                panelCadCategoria.Visible = false;
            }
        }
        private void showSubMenu(Panel subMenu) {
            if (subMenu.Visible == false) {
                hideSubMenu();
                subMenu.Visible = true;
            }
            else {
                subMenu.Visible = false;
            }

        }

        private void button4_Click(object sender, EventArgs e) {
            this.Close();
        }

        private void btnCadServico_Click(object sender, EventArgs e) {
            showSubMenu(panelCadServico);
        }

        private void btnCadCategoria_Click(object sender, EventArgs e) {
            showSubMenu(panelCadCategoria);
        }
    }
}
