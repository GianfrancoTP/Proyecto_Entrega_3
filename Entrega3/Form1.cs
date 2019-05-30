﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Linq;

namespace Entrega3
{
    public partial class Form1 : Form
    {
        int alto = 10;
        int ancho = 10;
        int cantidad_mese = 20;
        int mes = 0;
        public Mapa mapa1 = new Mapa();
        Terreno[,] opcion1 = new Terreno[10, 10];
        Label[,] labels;
        public Form1()
        {
            InitializeComponent();

            labels = new Label[alto, ancho];
            List<Bitmon> bitmons1 = new List<Bitmon>();
            LabelMes.Text = "Mes: " + Convert.ToString(mes);
            Terreno Vegetación = new Terreno("Vegetacn");
            Terreno Acuático = new Terreno("Acuatico");
            Terreno Desierto = new Terreno("Desierto");
            Terreno Nieve = new Terreno("NieveIce");
            Terreno Volcán = new Terreno("Volcanic");
            // Creamos la matriz de terrenos predefinida
            opcion1[0, 0] = Desierto;
            opcion1[1, 0] = Desierto;
            opcion1[1, 1] = Desierto;
            opcion1[1, 2] = Desierto;
            opcion1[1, 3] = Desierto;
            opcion1[1, 4] = Desierto;
            opcion1[1, 5] = Desierto;
            opcion1[1, 6] = Desierto;
            opcion1[2, 3] = Desierto;
            opcion1[2, 4] = Desierto;
            opcion1[2, 5] = Desierto;
            opcion1[2, 6] = Desierto;
            opcion1[2, 7] = Desierto;
            opcion1[3, 6] = Desierto;
            opcion1[3, 7] = Desierto;
            opcion1[3, 8] = Desierto;
            opcion1[3, 9] = Desierto;
            opcion1[4, 5] = Desierto;
            opcion1[4, 6] = Desierto;
            opcion1[4, 7] = Desierto;
            opcion1[4, 8] = Desierto;
            opcion1[4, 9] = Desierto;
            opcion1[5, 6] = Desierto;
            opcion1[5, 8] = Desierto;
            opcion1[0, 1] = Acuático;
            opcion1[0, 1] = Acuático;
            opcion1[0, 2] = Acuático;
            opcion1[0, 3] = Acuático;
            opcion1[0, 4] = Acuático;
            opcion1[0, 5] = Acuático;
            opcion1[5, 7] = Acuático;
            opcion1[5, 9] = Acuático;
            opcion1[6, 5] = Acuático;
            opcion1[6, 6] = Acuático;
            opcion1[6, 7] = Acuático;
            opcion1[6, 8] = Acuático;
            opcion1[6, 9] = Acuático;
            opcion1[7, 1] = Acuático;
            opcion1[7, 4] = Acuático;
            opcion1[7, 5] = Acuático;
            opcion1[7, 9] = Acuático;
            opcion1[8, 0] = Acuático;
            opcion1[8, 1] = Acuático;
            opcion1[8, 2] = Acuático;
            opcion1[8, 3] = Acuático;
            opcion1[8, 4] = Acuático;
            opcion1[9, 0] = Acuático;
            opcion1[9, 1] = Acuático;
            opcion1[9, 2] = Acuático;
            opcion1[9, 3] = Acuático;
            opcion1[0, 6] = Nieve;
            opcion1[0, 7] = Nieve;
            opcion1[0, 8] = Nieve;
            opcion1[0, 9] = Nieve;
            opcion1[1, 7] = Nieve;
            opcion1[1, 8] = Nieve;
            opcion1[1, 9] = Nieve;
            opcion1[2, 8] = Nieve;
            opcion1[2, 9] = Nieve;
            opcion1[2, 0] = Vegetación;
            opcion1[2, 1] = Vegetación;
            opcion1[2, 2] = Vegetación;
            opcion1[3, 0] = Vegetación;
            opcion1[3, 1] = Vegetación;
            opcion1[3, 2] = Vegetación;
            opcion1[3, 3] = Vegetación;
            opcion1[3, 4] = Vegetación;
            opcion1[3, 5] = Vegetación;
            opcion1[4, 0] = Vegetación;
            opcion1[4, 1] = Vegetación;
            opcion1[4, 2] = Vegetación;
            opcion1[4, 3] = Vegetación;
            opcion1[4, 4] = Vegetación;
            opcion1[5, 0] = Vegetación;
            opcion1[5, 1] = Vegetación;
            opcion1[5, 2] = Vegetación;
            opcion1[5, 3] = Vegetación;
            opcion1[5, 4] = Vegetación;
            opcion1[5, 5] = Vegetación;
            opcion1[6, 0] = Vegetación;
            opcion1[6, 1] = Vegetación;
            opcion1[6, 2] = Vegetación;
            opcion1[6, 3] = Vegetación;
            opcion1[6, 4] = Vegetación;
            opcion1[7, 0] = Vegetación;
            opcion1[7, 2] = Vegetación;
            opcion1[7, 3] = Vegetación;
            opcion1[7, 6] = Volcán;
            opcion1[7, 7] = Volcán;
            opcion1[7, 8] = Volcán;
            opcion1[8, 5] = Volcán;
            opcion1[8, 6] = Volcán;
            opcion1[8, 7] = Volcán;
            opcion1[8, 8] = Volcán;
            opcion1[8, 9] = Volcán;
            opcion1[9, 4] = Volcán;
            opcion1[9, 5] = Volcán;
            opcion1[9, 6] = Volcán;
            opcion1[9, 7] = Volcán;
            opcion1[9, 8] = Volcán;
            opcion1[9, 9] = Volcán;

            //Creamos la poblacion inicial de Bitmon

            //Poblacion inicial de Taplan
            int[] pos1 = { 2, 2 };
            Taplan taplan1 = new Taplan(pos1);
            int[] pos2 = { 4, 1 };
            Taplan taplan2 = new Taplan(pos2);
            int[] pos3 = { 4, 2 };
            Taplan taplan3 = new Taplan(pos3);
            int[] pos4 = { 5, 3 };
            Taplan taplan4 = new Taplan(pos4);
            int[] pos5 = { 6, 0 };
            Taplan taplan5 = new Taplan(pos5);

            //Poblacion inicial de Ents
            int[] pos6 = { 2, 4 };
            Ent Ent1 = new Ent(pos6);
            int[] pos7 = { 0, 9 };
            Ent Ent2 = new Ent(pos7);
            int[] pos8 = { 3, 9 };
            Ent Ent3 = new Ent(pos8);
            int[] pos9 = { 4, 4 };
            Ent Ent4 = new Ent(pos9);

            //Poblacion inicial de Wetar
            int[] pos10 = { 0, 5 };
            Wetar Wetar1 = new Wetar(pos10);
            int[] pos11 = { 0, 1 };
            Wetar Wetar2 = new Wetar(pos11);
            int[] pos12 = { 9, 0 };
            Wetar Wetar3 = new Wetar(pos12);

            //Poblacion inicial de Gofue
            int[] pos13 = { 1, 7 };
            Gofue Gofue1 = new Gofue(pos13);
            int[] pos14 = { 7, 7 };
            Gofue Gofue2 = new Gofue(pos14);
            int[] pos15 = { 9, 5 };
            Gofue Gofue3 = new Gofue(pos15);

            //Poblacion inicial Dorvalo
            int[] pos16 = { 1, 7 };
            Dorvalo Dorvalo1 = new Dorvalo(pos16);
            int[] pos17 = { 3, 7 };
            Dorvalo Dorvalo2 = new Dorvalo(pos17);
            int[] pos18 = { 2, 7 };
            Dorvalo Dorvalo3 = new Dorvalo(pos18);

            //Poblacion inicial Doti
            int[] pos19 = { 1, 5 };
            Doti Doti1 = new Doti(pos19);
            int[] pos20 = { 9, 7 };
            Doti Doti2 = new Doti(pos20);
            int[] pos21 = { 0, 0 };
            Doti Doti3 = new Doti(pos21);
            int[] pos22 = { 5, 7 };
            Doti Doti4 = new Doti(pos22);

            bitmons1.Add(taplan1);
            bitmons1.Add(taplan2);
            bitmons1.Add(taplan3);
            bitmons1.Add(taplan4);
            bitmons1.Add(taplan5);
            bitmons1.Add(Ent1);
            bitmons1.Add(Ent2);
            bitmons1.Add(Ent3);
            bitmons1.Add(Ent4);
            bitmons1.Add(Wetar1);
            bitmons1.Add(Wetar2);
            bitmons1.Add(Wetar3);
            bitmons1.Add(Gofue1);
            bitmons1.Add(Gofue2);
            bitmons1.Add(Gofue3);
            bitmons1.Add(Dorvalo1);
            bitmons1.Add(Dorvalo2);
            bitmons1.Add(Dorvalo3);
            bitmons1.Add(Doti1);
            bitmons1.Add(Doti2);
            bitmons1.Add(Doti3);
            bitmons1.Add(Doti4);

            mapa1.Alto = alto;
            mapa1.Ancho = ancho;
            mapa1.Terrenos = opcion1;
            mapa1.Bitmons = bitmons1;

            labelInfoMes.Text = "";

            for (int i = 0; i < alto; i++)
            {
                for (int j = 0; j < ancho; j++)
                {
                    Label label = new Label();
                    label.AutoSize = true;
                    label.Dock = DockStyle.Fill;
                    label.Location = new Point(3, 0);
                    label.Name = "label";
                    label.Size = new Size(51, 32);
                    label.TabIndex = 0;
                    label.Font = new Font("Trebuchet MS", 16F, FontStyle.Regular, GraphicsUnit.Point, ((byte)(0)));
                    string str = "";
                    var bitmons = mapa1.Bitmons.Where(x => (x.Posicion[0] == i) && (x.Posicion[1] == j)).ToList();
                    foreach (var bitmon in bitmons)
                    {
                        if (bitmon.Tipo == "Dorvalo")
                        {
                            str += "🦅";
                        }
                        else if (bitmon.Tipo == "Doti")
                        {
                            str += "🐇";
                        }
                        else if (bitmon.Tipo == "Ent")
                        {
                            str += "🐢";
                        }
                        else if (bitmon.Tipo == "Gofue")
                        {
                            str += "🐉";
                        }
                        else if (bitmon.Tipo == "Taplan")
                        {
                            str += "🦎";
                        }
                        else if (bitmon.Tipo == "Wetar")
                        {
                            str += "🐟";
                        }
                    }
                    label.Text = str;
                    if (opcion1[i,j].tipo == "Vegetacn")
                    {
                        label.BackColor = Color.Green;
                    }
                    else if (opcion1[i, j].tipo == "Acuatico")
                    {
                        label.BackColor = Color.Blue;
                    }
                    else if (opcion1[i, j].tipo == "Desierto")
                    {
                        label.BackColor = Color.SandyBrown;
                    }
                    else if (opcion1[i, j].tipo == "NieveIce")
                    {
                        label.BackColor = Color.Snow;
                    }
                    else
                    {
                        label.BackColor = Color.DarkRed;
                    }
                    tableLayoutPanel1.Controls.Add(label, j, i);
                    labels[i, j] = label;
                }
            }

            string info = "    Bitmons en el mapa:\n";
            for (int k = 0; k < mapa1.Bitmons.Count; k++)
            {
                info += $"{mapa1.Bitmons[k].Tipo}, [{mapa1.Bitmons[k].Posicion[0]},{mapa1.Bitmons[k].Posicion[1]}], puntos de Vida: {mapa1.Bitmons[k].PuntosdeVida}\n";
            }
            labelinfo.Text = info;

        }
        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }
        private void label1_Click(object sender, EventArgs e)
        {

        }
        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void Meses_Click(object sender, EventArgs e)
        {
            if (BotonMeses.Text == "Empezar simulacion")
            {
                try
                {
                    cantidad_mese = Convert.ToInt32(MesesBox.Text);
                    BotonMeses.Text = "Siguiente mes";
                    MesesBox.Enabled = false;
                    MesesBox.Visible = false;
                    CantidadMeses.Visible = false;
                }
                catch (Exception)
                {
                    MessageBox.Show("Este numero no es valido", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else if (mes < cantidad_mese)
            {
                string infoMes = "";
                string info = "    Bitmons en el mapa:\n";
                int[] posENT = { 0, 0 };
                Ent papa = new Ent(posENT);
                Ent mama = new Ent(posENT);

                if (mes % 3 == 0)
                {
                    mapa1.CrearBitmon(papa, mama);
                }
                foreach (var bitmon in mapa1.Bitmons)
                {
                    bitmon.Mover(mapa1);
                }
                mapa1.Relaciones();
                for (int i = 0; i < mapa1.Bitmons.Count; i++)
                {
                    mapa1.Bitmons[i].Envejecer();
                    if (!mapa1.Bitmons[i].vivo)
                    {
                        mapa1.Bitmons.Remove(mapa1.Bitmons[i]);
                        mapa1.Bitmons_muertos.Add(mapa1.Bitmons[i]);
                        mapa1.bitmons_muertos_mes.Add(mapa1.Bitmons[i]);
                    }
                }
                for (int i = 0; i < alto; i++)
                {
                    for (int j = 0; j < ancho; j++)
                    {
                        string str = "";
                        var bitmons = mapa1.Bitmons.Where(x => (x.Posicion[0] == i) && (x.Posicion[1] == j)).ToList();
                        foreach (var bitmon in bitmons)
                        {
                            if (bitmon.Tipo == "Dorvalo")
                            {
                                str += "🦅";
                            }
                            else if (bitmon.Tipo == "Doti")
                            {
                                str += "🐇";
                            }
                            else if (bitmon.Tipo == "Ent")
                            {
                                str += "🐢";
                            }
                            else if (bitmon.Tipo == "Gofue")
                            {
                                str += "🐉";
                            }
                            else if (bitmon.Tipo == "Taplan")
                            {
                                str += "🦎";
                            }
                            else if (bitmon.Tipo == "Wetar")
                            {
                                str += "🐟";
                            }
                        }
                        labels[i,j].Text = str;
                        if (opcion1[i, j].tipo == "Vegetacn")
                        {
                            labels[i, j].BackColor = Color.Green;
                        }
                        else if (opcion1[i, j].tipo == "Acuatico")
                        {
                            labels[i, j].BackColor = Color.Blue;
                        }
                        else if (opcion1[i, j].tipo == "Desierto")
                        {
                            labels[i, j].BackColor = Color.SandyBrown;
                        }
                        else if (opcion1[i, j].tipo == "NieveIce")
                        {
                            labels[i, j].BackColor = Color.Snow;
                        }
                        else
                        {
                            labels[i, j].BackColor = Color.DarkRed;
                        }
                        tableLayoutPanel1.Controls.Add(labels[i, j], j, i);
                        
                    }
                }
                for (int k = 0; k < mapa1.Bitmons.Count; k++)
                {
                    info += $"\n{mapa1.Bitmons[k].Tipo}, [{mapa1.Bitmons[k].Posicion[0]},{mapa1.Bitmons[k].Posicion[1]}], puntos de Vida: {mapa1.Bitmons[k].PuntosdeVida}";
                }

                Console.WriteLine("");
                foreach (var bitmon in mapa1.bitmons_creado_mes)
                {
                    infoMes += $"\nse creo un {bitmon.Tipo} en la posicion [{bitmon.Posicion[0]},{bitmon.Posicion[1]}]";
                }
                Console.WriteLine("");
                foreach (var bitmon in mapa1.bitmons_muertos_mes)
                {
                    infoMes += $"\nse murio un {bitmon.Tipo} en la posicion [{bitmon.Posicion[0]},{bitmon.Posicion[1]}]";
                }
                if (mapa1.sobrepoblacion)
                {
                    infoMes += $"\nsobrepoblacion en el mes {mes}, se detuvo las simulacion";
                    BotonMeses.Enabled = false;
                }
                labelinfo.Text = info;
                labelInfoMes.Text = infoMes;
                mes++;
                LabelMes.Text = "Mes: " + Convert.ToString(mes);
                if (mes == cantidad_mese)
                {
                    /*
                    MesesBox.Enabled = true;
                    MesesBox.Visible = true;
                    CantidadMeses.Visible = true;
                    */
                    string info_end = "";

                    BotonMeses.Text = "Empezar simulacion";
                    labelInfoMes.Text = "";
                }
            }
        }
    }
}
