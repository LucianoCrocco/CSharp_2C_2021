using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Entidades;

namespace Crocco.LucianoAgustin._2C
{
    public partial class FrmPrincipal : Form
    {
        private EjercitoImperial ejercitoImperial;
        public FrmPrincipal()
        {
            InitializeComponent();
            ejercitoImperial = new EjercitoImperial(20);
            ejercitoImperial += (new TrooperAsalto(Blaster.EC17));
            Refrescar();
        }

        private void Refrescar()
        {
            lstEjercito.Items.Clear();
            foreach(Trooper trooper in ejercitoImperial.Troopers)
            {
                lstEjercito.Items.Add(trooper.InfoTrooper());
            }
        }

        #region Agregar Trooper

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            Trooper trooper;
            if (cmbTipo.SelectedItem is not null && cmbArmamento.SelectedItem is not null)
            {
                if (chkEsClon.Checked)
                {
                    switch (cmbTipo.SelectedItem.ToString())
                    {
                        case "Arena":
                            switch (cmbArmamento.SelectedItem.ToString())
                            {
                                case "E11":
                                    trooper = new TrooperArena(Blaster.E11);
                                    trooper.EsClon = true;
                                    ejercitoImperial += trooper;
                                    break;
                                case "EC17":
                                    trooper = new TrooperArena(Blaster.EC17);
                                    trooper.EsClon = true;
                                    ejercitoImperial += trooper;
                                    break;
                                case "DLT19":
                                    trooper = new TrooperArena(Blaster.DLT19);
                                    trooper.EsClon = true;
                                    ejercitoImperial += trooper;
                                    break;
                            }
                            break;
                        case "Asalto":
                            switch (cmbArmamento.SelectedItem.ToString())
                            {
                                case "E11":
                                    trooper = new TrooperAsalto(Blaster.E11);
                                    ejercitoImperial += trooper;
                                    break;
                                case "EC17":
                                    trooper = new TrooperAsalto(Blaster.EC17);
                                    ejercitoImperial += trooper;
                                    break;
                                case "DLT19":
                                    trooper = new TrooperAsalto(Blaster.DLT19);
                                    ejercitoImperial += trooper;
                                    break;
                            }
                            break;
                        case "Explorador":
                            trooper = new TrooperExplorador("Moto");
                            trooper.EsClon = true;
                            ejercitoImperial += trooper;
                            break;
                    }
                } else
                {
                    switch (cmbTipo.SelectedItem.ToString())
                    {
                        case "Arena":
                            switch (cmbArmamento.SelectedItem.ToString()){
                                case "E11":
                                    trooper = new TrooperArena(Blaster.E11);
                                    ejercitoImperial += trooper;
                                    break;
                                case "EC17":
                                    trooper = new TrooperArena(Blaster.EC17);
                                    ejercitoImperial += trooper;
                                    break;
                                case "DLT19":
                                    trooper = new TrooperArena(Blaster.DLT19);
                                    ejercitoImperial += trooper;
                                    break;
                            }
                            break;
                        case "Asalto":
                            switch (cmbArmamento.SelectedItem.ToString())
                            {
                                case "E11":
                                    trooper = new TrooperAsalto(Blaster.E11);
                                    trooper.EsClon = false;
                                    ejercitoImperial += trooper;
                                    break;
                                case "EC17":
                                    trooper = new TrooperAsalto(Blaster.EC17);
                                    trooper.EsClon = false;
                                    ejercitoImperial += trooper;
                                    break;
                                case "DLT19":
                                    trooper = new TrooperAsalto(Blaster.DLT19);
                                    trooper.EsClon = false;
                                    ejercitoImperial += trooper;
                                    break;
                            }
                            break;
                        case "Explorador":
                            trooper = new TrooperExplorador("Moto");
                            ejercitoImperial += trooper;
                            break;
                    }
                }
            }
            Refrescar();
        }
        #endregion

        #region Quitar Trooper
        private void btnQuitar_Click(object sender, EventArgs e)
        {
            Trooper trooper;
            if (chkEsClon.Checked)
            {
                switch (cmbTipo.SelectedItem.ToString())
                {
                    case "Arena":
                        switch (cmbArmamento.SelectedItem.ToString())
                        {
                            case "E11":
                                trooper = new TrooperArena(Blaster.E11);
                                ejercitoImperial -= trooper;
                                break;
                            case "EC17":
                                trooper = new TrooperArena(Blaster.EC17);
                                ejercitoImperial -= trooper;
                                break;
                            case "DLT19":
                                trooper = new TrooperArena(Blaster.DLT19);
                                ejercitoImperial -= trooper;
                                break;
                        }
                        break;
                    case "Asalto":
                        switch (cmbArmamento.SelectedItem.ToString())
                        {
                            case "E11":
                                trooper = new TrooperAsalto(Blaster.E11);
                                ejercitoImperial -= trooper;
                                break;
                            case "EC17":
                                trooper = new TrooperAsalto(Blaster.EC17);
                                ejercitoImperial -= trooper;
                                break;
                            case "DLT19":
                                trooper = new TrooperAsalto(Blaster.DLT19);
                                ejercitoImperial -= trooper;
                                break;
                        }
                        break;
                    case "Explorador":
                        trooper = new TrooperExplorador("Moto");
                        ejercitoImperial -= trooper;
                        break;
                }
            }
            else
            {
                switch (cmbTipo.SelectedItem.ToString())
                {
                    case "Arena":
                        switch (cmbArmamento.SelectedItem.ToString())
                        {
                            case "E11":
                                trooper = new TrooperArena(Blaster.E11);
                                ejercitoImperial -= trooper;
                                break;
                            case "EC17":
                                trooper = new TrooperArena(Blaster.EC17);
                                ejercitoImperial -= trooper;
                                break;
                            case "DLT19":
                                trooper = new TrooperArena(Blaster.DLT19);
                                ejercitoImperial -= trooper;
                                break;
                        }
                        break;
                    case "Asalto":
                        switch (cmbArmamento.SelectedItem.ToString())
                        {
                            case "E11":
                                trooper = new TrooperAsalto(Blaster.E11);
                                ejercitoImperial -= trooper;
                                break;
                            case "EC17":
                                trooper = new TrooperAsalto(Blaster.EC17);
                                ejercitoImperial -= trooper;
                                break;
                            case "DLT19":
                                trooper = new TrooperAsalto(Blaster.DLT19);
                                ejercitoImperial -= trooper;
                                break;
                        }
                        break;
                    case "Explorador":
                        trooper = new TrooperExplorador("Moto");
                        ejercitoImperial -= trooper;
                        break;
                }
            }
            Refrescar();
        }

        #endregion
    }
}