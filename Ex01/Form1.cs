using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Security.Cryptography.X509Certificates;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;

namespace Ex01
{
    
    public partial class frmTresillo : Form
    {


        // espacio de declaracion de variables iniciales
        bool poniendoFichas = true;
        int contador = 18;  // Contador de cantidad total de fichas, debe de ser un número par
        int cuentaMovimientos = 0;  // lleva el conteo de los movimiento, luego de colocadas las fichas
        // Variables que indican si es verde = impar(1) / azul = par(2) / 0 = espacio vacío
        int vpb1A, vpb2A, vpb3A, vpb1B, vpb2B, vpb3B, vpb1C, vpb2C, vpb3C, vpb1D, vpb2D, vpb3D, vpb4D , vpb5D, vpb6D, vpb1E, vpb2E, vpb3E, vpb1F, vpb2F, vpb3F, vpb1G, vpb2G, vpb3G = 0;
        // Variables para indicar si están seleccionadas: = 1 / 0 = no seleccionada
        int vspb1A, vspb2A, vspb3A, vspb1B, vspb2B, vspb3B, vspb1C, vspb2C, vspb3C, vspb1D, vspb2D, vspb3D, vspb4D, vspb5D, vspb6D, vspb1E, vspb2E, vspb3E,vspb1F, vspb2F, vspb3F,vspb1G, vspb2G, vspb3G = 0;
        int fichasVerdes = 9;
        int fichasAzules = 9;

        int colorRobar = 0; // Selecciona el color que se debe robar
        // se guarda la informacion en caso de que haya 3 en línea en estas llaves:
        int llave01 = 1; int llave02 = 1; int llave03 = 1; int llave04 = 1; int llave05 = 1; int llave06 = 1; int llave07 = 1; int llave08 = 1; int llave09 = 1;
        int llave10 = 1; int llave11 = 1; int llave12 = 1; int llave13 = 1; int llave14 = 1; int llave15 = 1; int llave16 = 1; int llave17 = 1; int llave18 = 1; 
        int llave19 = 1; int llave20 = 1; int llave21 = 1; int llave22 = 1; int llave23 = 1; int llave24 = 1; int llave25 = 1; int llave26 = 1; int llave27 = 1; 
        int llave28 = 1; int llave29 = 1; int llave30 = 1; int llave31 = 1; int llave32 = 1;
        List<PictureBox> mPictureBoxesList = new List<PictureBox>(); // se crea una lista de PictureBox para poder buscarlas por su índice
        

        public frmTresillo()
        {
            InitializeComponent();
        }



        private void Form1_Load_1(object sender, EventArgs e)
        {
            btnRobar.Visible = false;
            lblTurno.BackColor = Color.Blue;
            lblMovimiento.Visible = false;
            lblCuentaMov.Visible = false;

            // lista con los picture box
            mPictureBoxesList.Add(pb1A); //0
            mPictureBoxesList.Add(pb2A); //1
            mPictureBoxesList.Add(pb3A); //2
            mPictureBoxesList.Add(pb1B); //3
            mPictureBoxesList.Add(pb2B); //4
            mPictureBoxesList.Add(pb3B); //5
            mPictureBoxesList.Add(pb1C); //6
            mPictureBoxesList.Add(pb2C); //7
            mPictureBoxesList.Add(pb3C); //8
            mPictureBoxesList.Add(pb1D); //9
            mPictureBoxesList.Add(pb2D); //10
            mPictureBoxesList.Add(pb3D); //11
            mPictureBoxesList.Add(pb4D); //12
            mPictureBoxesList.Add(pb5D); //13
            mPictureBoxesList.Add(pb6D); //14
            mPictureBoxesList.Add(pb1E); //15
            mPictureBoxesList.Add(pb2E); //16
            mPictureBoxesList.Add(pb3E); //17
            mPictureBoxesList.Add(pb1F); //18
            mPictureBoxesList.Add(pb2F); //19
            mPictureBoxesList.Add(pb3F); //20
            mPictureBoxesList.Add(pb1G); //21
            mPictureBoxesList.Add(pb2G); //22
            mPictureBoxesList.Add(pb3G); //23
            // lista con los picture box
        }

        private void btnInstrucciones_Click(object sender, EventArgs e)
        {
        frmInstrucciones Instruccuines = new frmInstrucciones();
            Instruccuines.Show();
        }

        public void btnReinicia_Click(object sender, EventArgs e) // botón para reiniciar el juego
        {

            contador = 18; // CANTIDAD DE FICHAS DE JUEGO
            cuentaMovimientos = 0;
            desseleccionaTodo();
            fichasVerdes = 9;
            fichasAzules = 9;
            pb1A.BackgroundImage = null;
            pb2A.BackgroundImage = null;
            pb3A.BackgroundImage = null;

            pb1B.BackgroundImage = null;
            pb2B.BackgroundImage = null;
            pb3B.BackgroundImage = null;

            pb1C.BackgroundImage = null;
            pb2C.BackgroundImage = null;
            pb3C.BackgroundImage = null;

            pb1D.BackgroundImage = null;
            pb2D.BackgroundImage = null;
            pb3D.BackgroundImage = null;
            pb4D.BackgroundImage = null;
            pb5D.BackgroundImage = null;
            pb6D.BackgroundImage = null;

            pb1E.BackgroundImage = null;
            pb2E.BackgroundImage = null;
            pb3E.BackgroundImage = null;

            pb1F.BackgroundImage = null;
            pb2F.BackgroundImage = null;
            pb3F.BackgroundImage = null;

            pb1G.BackgroundImage = null;
            pb2G.BackgroundImage = null;
            pb3G.BackgroundImage = null;


            vpb1A = vpb2A = vpb3A = vpb1B = vpb2B = vpb3B = vpb1C = vpb2C = vpb3C = vpb1D = vpb2D = vpb3D = vpb4D = vpb5D = vpb6D = vpb1E = vpb2E = vpb3E = vpb1F = vpb2F = vpb3F = vpb1G = vpb2G = vpb3G = 0;
            vspb1A = vspb2A = vspb3A = vspb1B = vspb2B = vspb3B = vspb1C = vspb2C = vspb3C = vspb1D = vspb2D = vspb3D = vspb4D = vspb5D = vspb6D = vspb1E = vspb2E = vspb3E = vspb1F = vspb2F = vspb3F = vspb1G = vspb2G = vspb3G = 0;
            llave01 = llave02 = llave03 = llave04 = llave05 =  1;


            colorRobar = 0;
            lblTurno.BackColor = Color.Blue;
            lblMovimiento.Visible = false;
            btnRobar.Visible = false;
            lblCuentaMov.Visible = false;
            poniendoFichas = true;


        }

        private void desseleccionaTodo()
        {
            pb1A.BackColor = Color.Transparent;
            pb2A.BackColor = Color.Transparent;
            pb3A.BackColor = Color.Transparent;

            pb1B.BackColor = Color.Transparent;
            pb2B.BackColor = Color.Transparent;
            pb3B.BackColor = Color.Transparent;

            pb1C.BackColor = Color.Transparent;
            pb2C.BackColor = Color.Transparent;
            pb3C.BackColor = Color.Transparent;

            pb1D.BackColor = Color.Transparent;
            pb2D.BackColor = Color.Transparent;
            pb3D.BackColor = Color.Transparent;
            pb4D.BackColor = Color.Transparent;
            pb5D.BackColor = Color.Transparent;
            pb6D.BackColor = Color.Transparent;
            
            pb1E.BackColor = Color.Transparent;
            pb2E.BackColor = Color.Transparent;
            pb3E.BackColor = Color.Transparent;

            pb1F.BackColor = Color.Transparent;
            pb2F.BackColor = Color.Transparent;
            pb3F.BackColor = Color.Transparent;

            pb1G.BackColor = Color.Transparent;
            pb2G.BackColor = Color.Transparent;
            pb3G.BackColor = Color.Transparent;



            vspb1A = vspb2A = vspb3A = vspb1B = vspb2B = vspb3B = vspb1C = vspb2C = vspb3C = vspb1D = vspb2D = vspb3D = vspb4D = vspb5D = vspb6D = vspb1E = vspb2E = vspb3E = vspb1F = vspb2F = vspb3F = vspb1G = vspb2G = vspb3G = 0;

        }



        public int EncontrarSeleccionada()  // fincion para encontrar la ficha seleccionada
        {
            int resultado = 0;   
                if (vspb1A == 1) { resultado = 0; }
                if (vspb2A == 1) { resultado = 1; }
                if (vspb3A == 1) { resultado = 2; }
                if (vspb1B == 1) { resultado = 3; }
                if (vspb2B == 1) { resultado = 4; }
                if (vspb3B == 1) { resultado = 5; }
                if (vspb1C == 1) { resultado = 6; }
                if (vspb2C == 1) { resultado = 7; }
                if (vspb3C == 1) { resultado = 8; }
                if (vspb1D == 1) { resultado = 9; }
                if (vspb2D == 1) { resultado = 10; }
                if (vspb3D == 1) { resultado = 11; }
                if (vspb4D == 1) { resultado = 12; }
                if (vspb5D == 1) { resultado = 13; }
                if (vspb6D == 1) { resultado = 14; }

                if (vspb1E == 1) { resultado = 15; }
                if (vspb2E == 1) { resultado = 16; }
                if (vspb3E == 1) { resultado = 17; }

                if (vspb1F == 1) { resultado = 18; }
                if (vspb2F == 1) { resultado = 19; }
                if (vspb3F == 1) { resultado = 20; }

                if (vspb1G == 1) { resultado = 21; }
                if (vspb2G == 1) { resultado = 22; }
                if (vspb3G == 1) { resultado = 23; }

            return resultado;
        }

        
        public PictureBox fnEncontrarPictureBox(int pb) // funcion para encontrar el Picturebox con su índice
        {
            PictureBox valor = mPictureBoxesList[pb];

          return valor;
        }



        public void fnPnerVariablePictureBxcero(int indice) // Para poner las variables en 0 cuando desaparece una ficha
        {
            if (indice == 0) { vpb1A = 0; }
            if (indice == 1) { vpb2A = 0; }
            if (indice == 2) { vpb3A = 0; }
            if (indice == 3) { vpb1B = 0; }
            if (indice == 4) { vpb2B = 0; }
            if (indice == 5) { vpb3B = 0; }
            if (indice == 6) { vpb1C = 0; }
            if (indice == 7) { vpb2C = 0; }
            if (indice == 8) { vpb3C = 0; }
            if (indice == 9) { vpb1D = 0; }
            if (indice == 10) { vpb2D = 0;}
            if (indice == 11) { vpb3D = 0;}
            if (indice == 12) { vpb4D = 0;}
            if (indice == 13) { vpb5D = 0;}
            if (indice == 14) { vpb6D = 0;}

            if (indice == 15) { vpb1E = 0; }
            if (indice == 16) { vpb2E = 0; }
            if (indice == 17) { vpb3E = 0; }

            if (indice == 18) { vpb1F = 0; }
            if (indice == 19) { vpb2F = 0; }
            if (indice == 20) { vpb3F = 0; }

            if (indice == 21) { vpb1G = 0; }
            if (indice == 22) { vpb2G = 0; }
            if (indice == 23) { vpb3G = 0; }
        }


        public int ColorSeleccionado() // Para encontrar el color de la ficha que se selecciona
        {
            int resultado = 0;
            if (EncontrarSeleccionada() == 0 && vpb1A == 1) { resultado = 1; }
            if (EncontrarSeleccionada() == 0 && vpb1A == 2) { resultado = 2; }
            if (EncontrarSeleccionada() == 1 && vpb2A == 1) { resultado = 1; }
            if (EncontrarSeleccionada() == 1 && vpb2A == 2) { resultado = 2; }
            if (EncontrarSeleccionada() == 2 && vpb3A == 1) { resultado = 1; }
            if (EncontrarSeleccionada() == 2 && vpb3A == 2) { resultado = 2; }

            if (EncontrarSeleccionada() == 3 && vpb1B == 1) { resultado = 1; }
            if (EncontrarSeleccionada() == 3 && vpb1B == 2) { resultado = 2; }
            if (EncontrarSeleccionada() == 4 && vpb2B == 1) { resultado = 1; }
            if (EncontrarSeleccionada() == 4 && vpb2B == 2) { resultado = 2; }
            if (EncontrarSeleccionada() == 5 && vpb3B == 1) { resultado = 1; }
            if (EncontrarSeleccionada() == 5 && vpb3B == 2) { resultado = 2; }

            if (EncontrarSeleccionada() == 6 && vpb1C == 1) { resultado = 1; }
            if (EncontrarSeleccionada() == 6 && vpb1C == 2) { resultado = 2; }
            if (EncontrarSeleccionada() == 7 && vpb2C == 1) { resultado = 1; }
            if (EncontrarSeleccionada() == 7 && vpb2C == 2) { resultado = 2; }
            if (EncontrarSeleccionada() == 8 && vpb3C == 1) { resultado = 1; }
            if (EncontrarSeleccionada() == 8 && vpb3C == 2) { resultado = 2; }

            if (EncontrarSeleccionada() == 9  && vpb1D == 1) { resultado = 1; }
            if (EncontrarSeleccionada() == 9  && vpb1D == 2) { resultado = 2; }
            if (EncontrarSeleccionada() == 10 && vpb2D == 1) { resultado = 1; }
            if (EncontrarSeleccionada() == 10 && vpb2D == 2) { resultado = 2; }
            if (EncontrarSeleccionada() == 11 && vpb3D == 1) { resultado = 1; }
            if (EncontrarSeleccionada() == 11 && vpb3D == 2) { resultado = 2; }
            if (EncontrarSeleccionada() == 12 && vpb4D == 1) { resultado = 1; }
            if (EncontrarSeleccionada() == 12 && vpb4D == 2) { resultado = 2; }
            if (EncontrarSeleccionada() == 13 && vpb5D == 1) { resultado = 1; }
            if (EncontrarSeleccionada() == 13 && vpb5D == 2) { resultado = 2; }
            if (EncontrarSeleccionada() == 14 && vpb6D == 1) { resultado = 1; }
            if (EncontrarSeleccionada() == 14 && vpb6D == 2) { resultado = 2; }
            
            if (EncontrarSeleccionada() == 15 && vpb1E == 1) { resultado = 1; }
            if (EncontrarSeleccionada() == 15 && vpb1E == 2) { resultado = 2; }
            if (EncontrarSeleccionada() == 16 && vpb2E == 1) { resultado = 1; }
            if (EncontrarSeleccionada() == 16 && vpb2E == 2) { resultado = 2; }
            if (EncontrarSeleccionada() == 17 && vpb3E == 1) { resultado = 1; }
            if (EncontrarSeleccionada() == 17 && vpb3E == 2) { resultado = 2; }

            if (EncontrarSeleccionada() == 18 && vpb1F == 1) { resultado = 1; }
            if (EncontrarSeleccionada() == 18 && vpb1F == 2) { resultado = 2; }
            if (EncontrarSeleccionada() == 19 && vpb2F == 1) { resultado = 1; }
            if (EncontrarSeleccionada() == 19 && vpb2F == 2) { resultado = 2; }
            if (EncontrarSeleccionada() == 20 && vpb3F == 1) { resultado = 1; }
            if (EncontrarSeleccionada() == 20 && vpb3F == 2) { resultado = 2; }

            if (EncontrarSeleccionada() == 21 && vpb1G == 1) { resultado = 1; }
            if (EncontrarSeleccionada() == 21 && vpb1G == 2) { resultado = 2; }
            if (EncontrarSeleccionada() == 22 && vpb2G == 1) { resultado = 1; }
            if (EncontrarSeleccionada() == 22 && vpb2G == 2) { resultado = 2; }
            if (EncontrarSeleccionada() == 23 && vpb3G == 1) { resultado = 1; }
            if (EncontrarSeleccionada() == 23 && vpb3G == 2) { resultado = 2; }

            return resultado;
        }


        public void mostrarTurno() // Funcion para indicar el color que juega
        {
            if (contador % 2 == 0 && cuentaMovimientos % 2 == 0)
            {
                lblTurno.BackColor = Color.Blue;
            }
            else if (contador % 2 == 1 || cuentaMovimientos % 2 == 1)
            {
                lblTurno.BackColor = Color.Green;
            }

            if (contador == 0)
            {
                lblMovimiento.Visible = true;
                poniendoFichas = false;
                lblCuentaMov.Visible = true;
                lblCuentaMov.Text = "Mov: "+cuentaMovimientos.ToString();

                if (fichasVerdes == 2) { MessageBox.Show("El jugador AZUL HA GANADO", "Logro AZUL", MessageBoxButtons.OK, MessageBoxIcon.Information); }
                if (fichasAzules == 2) { MessageBox.Show("El jugador VERDE HA GANADO", "Logro VERDE", MessageBoxButtons.OK, MessageBoxIcon.Information);}

            }

        }


        public int fnVerificarLineaVerde(int pos01, int pos02, int pos03, int llave)  // fincion verificar si hay linea de 3 Verde
        {
            if (pos01 * pos02 * pos03 * llave == 1) // cuando 3 verdes en  linea
            {
               // MessageBox.Show("El jugador VERDE ha hecho 3 en línea, Seleccione la ficha AZUL a robar!", "Logro verde", MessageBoxButtons.OK, MessageBoxIcon.Information);
                btnRobar.Visible = true;
                contador++;
                poniendoFichas = false;
                colorRobar = 2; // azul
                llave = 2;
            }
            else if (pos01 * pos02 * pos03 * llave != 2) { llave = 1; }
            return llave;
       }

        //   ----------     -----------  //

        public int fnVerificarLineaAzul(int pos01, int pos02, int pos03, int llave) // fincion verificar si hay linea de 3 Azul
        {
            if (pos01 * pos02 * pos03 * llave == 8) // cuando 3 verdes en  linea
            {
               // MessageBox.Show("El jugador AZUL ha hecho 3 en línea, Seleccione la ficha VERDE a robar!", "Logro azul", MessageBoxButtons.OK, MessageBoxIcon.Information);
                btnRobar.Visible = true;
                contador++;
                poniendoFichas = false;
                colorRobar = 1; // azul
                llave = 2;
            }
            else if (pos01 * pos02 * pos03 * llave != 16) { llave = 1; }
            return llave;
        }


        //   ----------     -----------  //




        public void Verificar_Ganador()            // Para encontrar cuando alguien hace 3 en linea  ..
        {
                          // ----- horizontales ------- //
            llave01 = fnVerificarLineaVerde(vpb1A, vpb2A, vpb3A, llave01);// Primera línea horizontal Verde
            llave02 = fnVerificarLineaAzul (vpb1A, vpb2A, vpb3A, llave02);// Primera línea horizontal Azul

            llave03 = fnVerificarLineaVerde(vpb1B, vpb2B, vpb3B, llave03);// Segunda línea horizontal Verde
            llave04 = fnVerificarLineaAzul (vpb1B, vpb2B, vpb3B, llave04);// Segunda línea horizontal Azul

            llave05 = fnVerificarLineaVerde(vpb1C, vpb2C, vpb3C, llave05); 
            llave06 = fnVerificarLineaAzul (vpb1C, vpb2C, vpb3C, llave06);

            llave07 = fnVerificarLineaVerde(vpb1D, vpb2D, vpb3D, llave07);
            llave08 = fnVerificarLineaAzul (vpb1D, vpb2D, vpb3D, llave08);

            llave09 = fnVerificarLineaVerde(vpb4D, vpb5D, vpb6D, llave09);
            llave10 = fnVerificarLineaAzul (vpb4D, vpb5D, vpb6D, llave10);

            llave11 = fnVerificarLineaVerde(vpb1E, vpb2E, vpb3E, llave11);
            llave12 = fnVerificarLineaAzul (vpb1E, vpb2E, vpb3E, llave12);

            llave13 = fnVerificarLineaVerde(vpb1F, vpb2F, vpb3F, llave13);
            llave14 = fnVerificarLineaAzul (vpb1F, vpb2F, vpb3F, llave14);

            llave15 = fnVerificarLineaVerde(vpb1G, vpb2G, vpb3G, llave15);
            llave16 = fnVerificarLineaAzul (vpb1G, vpb2G, vpb3G, llave16);
                            // ----- verticales ------- //
            llave17 = fnVerificarLineaVerde(vpb1A, vpb1D, vpb1G, llave17);
            llave18 = fnVerificarLineaAzul (vpb1A, vpb1D, vpb1G, llave18);

            llave19 = fnVerificarLineaVerde(vpb1B, vpb2D, vpb1F, llave19);
            llave20 = fnVerificarLineaAzul (vpb1B, vpb2D, vpb1F, llave20);

            llave21 = fnVerificarLineaVerde(vpb1C, vpb3D, vpb1E, llave21);
            llave22 = fnVerificarLineaAzul (vpb1C, vpb3D, vpb1E, llave22);

            llave23 = fnVerificarLineaVerde(vpb2A, vpb2B, vpb2C, llave23);
            llave24 = fnVerificarLineaAzul (vpb2A, vpb2B, vpb2C, llave24);

            llave25 = fnVerificarLineaVerde(vpb2E, vpb2F, vpb2G, llave25);
            llave26 = fnVerificarLineaAzul (vpb2E, vpb2F, vpb2G, llave26);

            llave27 = fnVerificarLineaVerde(vpb3C, vpb4D, vpb3E, llave27);
            llave28 = fnVerificarLineaAzul (vpb3C, vpb4D, vpb3E, llave28);

            llave29 = fnVerificarLineaVerde(vpb3B, vpb5D, vpb3F, llave29);
            llave30 = fnVerificarLineaAzul (vpb3B, vpb5D, vpb3F, llave30);

            llave31 = fnVerificarLineaVerde(vpb3A, vpb6D, vpb3G, llave31);
            llave32 = fnVerificarLineaAzul (vpb3A, vpb6D, vpb3G, llave32);



        }





        public PictureBox fnBorrarFichaContraria(int selecci, int index, PictureBox pb,int varpb, int varspv)
        {
            if (selecci == index)
            {
                pb.BackgroundImage = null;
                pb.BackColor = Color.Transparent;
                varpb = 0;
                varspv = 0;
                contador--;
                btnRobar.Visible = false;
                poniendoFichas = true;
            }
            return null;
        }


        public void btnRobar_Click(object sender, EventArgs e) // Botón para -- ROBAR -- ficha contraria
        {



            int colorx = ColorSeleccionado();
            int selec = EncontrarSeleccionada();
          if (selec != 0  && ColorSeleccionado() == colorRobar)
            {



                if (selec == 0)
                {
                    pb1A.BackgroundImage = null;
                    pb1A.BackColor = Color.Transparent;
                    vpb1A = 0;
                    vspb1A = 0;
                    contador--;
                    btnRobar.Visible = false;
                    poniendoFichas = true;
                    if (colorx == 1) { fichasVerdes--; }
                    if (colorx == 2) { fichasAzules--; }
                }

                if (selec == 1)
                {
                    pb2A.BackgroundImage = null;
                    pb2A.BackColor = Color.Transparent;
                    vpb2A = 0;
                    vspb2A = 0;
                    contador--;
                    btnRobar.Visible = false;
                    poniendoFichas = true;
                    if (colorx == 1) { fichasVerdes--; }
                    if (colorx == 2) { fichasAzules--; }
                }

                if (selec == 2)
                {
                    pb3A.BackgroundImage = null;
                    pb3A.BackColor = Color.Transparent;
                    vpb3A = 0;
                    vspb3A = 0;
                    contador--;
                    btnRobar.Visible = false;
                    poniendoFichas = true;
                    if (colorx == 1) { fichasVerdes--; }
                    if (colorx == 2) { fichasAzules--; }
                }


                if (selec == 3)
                    {
                        pb1B.BackgroundImage = null;
                        pb1B.BackColor = Color.Transparent;
                        vpb1B = 0;
                        vspb1B = 0;
                        contador--;
                        btnRobar.Visible = false;
                        poniendoFichas = true;
                    if (colorx == 1) { fichasVerdes--; }
                    if (colorx == 2) { fichasAzules--; }
                }

                     if (selec == 4)
                    {
                    pb2B.BackgroundImage = null;
                    pb2B.BackColor = Color.Transparent;
                    vpb2B = 0;
                    vspb2B = 0;
                    contador--;
                    btnRobar.Visible = false;
                    poniendoFichas = true;
                    if (colorx == 1) { fichasVerdes--; }
                    if (colorx == 2) { fichasAzules--; }
                }

                    if (selec == 5)
                    {
                    pb3B.BackgroundImage = null;
                    pb3B.BackColor = Color.Transparent;
                    vpb3B = 0;
                    vspb3B = 0;
                    contador--;
                    btnRobar.Visible = false;
                    poniendoFichas = true;
                    if (colorx == 1) { fichasVerdes--; }
                    if (colorx == 2) { fichasAzules--; }
                }


                if (selec == 6)
                {
                    pb1C.BackgroundImage = null;
                    pb1C.BackColor = Color.Transparent;
                    vpb1C = 0;
                    vspb1C = 0;
                    contador--;
                    btnRobar.Visible = false;
                    poniendoFichas = true;
                    if (colorx == 1) { fichasVerdes--; }
                    if (colorx == 2) { fichasAzules--; }
                }

                if (selec == 7)
                {
                    pb2C.BackgroundImage = null;
                    pb2C.BackColor = Color.Transparent;
                    vpb2C = 0;
                    vspb2C = 0;
                    contador--;
                    btnRobar.Visible = false;
                    poniendoFichas = true;
                    if (colorx == 1) { fichasVerdes--; }
                    if (colorx == 2) { fichasAzules--; }
                }

                if (selec == 8)
                {
                    pb3C.BackgroundImage = null;
                    pb3C.BackColor = Color.Transparent;
                    vpb3C = 0;
                    vspb3C = 0;
                    contador--;
                    btnRobar.Visible = false;
                    poniendoFichas = true;
                    if (colorx == 1) { fichasVerdes--; }
                    if (colorx == 2) { fichasAzules--; }
                }

                if (selec == 9)
                {
                    pb1D.BackgroundImage = null;
                    pb1D.BackColor = Color.Transparent;
                    vpb1D = 0;
                    vspb1D = 0;
                    contador--;
                    btnRobar.Visible = false;
                    poniendoFichas = true;
                    if (colorx == 1) { fichasVerdes--; }
                    if (colorx == 2) { fichasAzules--; }
                }

                if (selec == 10)
                {
                    pb2D.BackgroundImage = null;
                    pb2D.BackColor = Color.Transparent;
                    vpb2D = 0;
                    vspb2D = 0;
                    contador--;
                    btnRobar.Visible = false;
                    poniendoFichas = true;
                    if (colorx == 1) { fichasVerdes--; }
                    if (colorx == 2) { fichasAzules--; }
                }

                if (selec == 11)
                {
                    pb3D.BackgroundImage = null;
                    pb3D.BackColor = Color.Transparent;
                    vpb3D = 0;
                    vspb3D = 0;
                    contador--;
                    btnRobar.Visible = false;
                    poniendoFichas = true;
                    if (colorx == 1) { fichasVerdes--; }
                    if (colorx == 2) { fichasAzules--; }
                }

                if (selec == 12) 
                {
                    pb4D.BackgroundImage = null;
                    pb4D.BackColor = Color.Transparent;
                    vpb4D = 0;
                    vspb4D = 0;
                    contador--;
                    btnRobar.Visible = false;
                    poniendoFichas = true;
                    if (colorx == 1) { fichasVerdes--; }
                    if (colorx == 2) { fichasAzules--; }
                }

                if (selec == 13)
                {
                    pb5D.BackgroundImage = null;
                    pb5D.BackColor = Color.Transparent;
                    vpb5D = 0;
                    vspb5D = 0;
                    contador--;
                    btnRobar.Visible = false;
                    poniendoFichas = true;
                    if (colorx == 1) { fichasVerdes--; }
                    if (colorx == 2) { fichasAzules--; }
                }

                if (selec == 14)
                {
                    pb6D.BackgroundImage = null;
                    pb6D.BackColor = Color.Transparent;
                    vpb6D = 0;
                    vspb6D = 0;
                    contador--;
                    btnRobar.Visible = false;
                    poniendoFichas = true;
                    if (colorx == 1) { fichasVerdes--; }
                    if (colorx == 2) { fichasAzules--; }
                }
                if (selec == 15)
                {
                    pb1E.BackgroundImage = null;
                    pb1E.BackColor = Color.Transparent;
                    vpb1E = 0;
                    vspb1E = 0;
                    contador--;
                    btnRobar.Visible = false;
                    poniendoFichas = true;
                    if (colorx == 1) { fichasVerdes--; }
                    if (colorx == 2) { fichasAzules--; }
                }
                //
                if (selec == 16)
                {
                    pb2E.BackgroundImage = null;
                    pb2E.BackColor = Color.Transparent;
                    vpb2E = 0;
                    vspb2E = 0;
                    contador--;
                    btnRobar.Visible = false;
                    poniendoFichas = true;
                    if (colorx == 1) { fichasVerdes--; }
                    if (colorx == 2) { fichasAzules--; }
                }

                if (selec == 17)
                {
                    pb3E.BackgroundImage = null;
                    pb3E.BackColor = Color.Transparent;
                    vpb3E = 0;
                    vspb3E = 0;
                    contador--;
                    btnRobar.Visible = false;
                    poniendoFichas = true;
                    if (colorx == 1) { fichasVerdes--; }
                    if (colorx == 2) { fichasAzules--; }
                }
                if (selec == 18)
                {
                    pb1F.BackgroundImage = null;
                    pb1F.BackColor = Color.Transparent;
                    vpb1F = 0;
                    vspb1F = 0;
                    contador--;
                    btnRobar.Visible = false;
                    poniendoFichas = true;
                    if (colorx == 1) { fichasVerdes--; }
                    if (colorx == 2) { fichasAzules--; }
                }

                if (selec == 19)
                {
                    pb2F.BackgroundImage = null;
                    pb2F.BackColor = Color.Transparent;
                    vpb2F = 0;
                    vspb2F = 0;
                    contador--;
                    btnRobar.Visible = false;
                    poniendoFichas = true;
                    if (colorx == 1) { fichasVerdes--; }
                    if (colorx == 2) { fichasAzules--; }
                }

                if (selec == 20)
                {
                    pb3F.BackgroundImage = null;
                    pb3F.BackColor = Color.Transparent;
                    vpb3F = 0;
                    vspb3F = 0;
                    contador--;
                    btnRobar.Visible = false;
                    poniendoFichas = true;
                    if (colorx == 1) { fichasVerdes--; }
                    if (colorx == 2) { fichasAzules--; }
                }
                if (selec == 21)
                {
                    pb1G.BackgroundImage = null;
                    pb1G.BackColor = Color.Transparent;
                    vpb1G = 0;
                    vspb1G = 0;
                    contador--;
                    btnRobar.Visible = false;
                    poniendoFichas = true;
                    if (colorx == 1) { fichasVerdes--; }
                    if (colorx == 2) { fichasAzules--; }
                }

                if (selec == 22)
                {
                    pb2G.BackgroundImage = null;
                    pb2G.BackColor = Color.Transparent;
                    vpb2G = 0;
                    vspb2G = 0;
                    contador--;
                    btnRobar.Visible = false;
                    poniendoFichas = true;
                    if (colorx == 1) { fichasVerdes--; }
                    if (colorx == 2) { fichasAzules--; }
                }

                if (selec == 23)
                {
                    pb3G.BackgroundImage = null;
                    pb3G.BackColor = Color.Transparent;
                    vpb3G = 0;
                    vspb3G = 0;
                    contador--;
                    btnRobar.Visible = false;
                    poniendoFichas = true;
                    if (colorx == 1) { fichasVerdes--; }
                    if (colorx == 2) { fichasAzules--; }
                }
                mostrarTurno();
                Verificar_Ganador();
            }
                else { MessageBox.Show("Debe de seleccionar la víctima del color CONTRARIO"); }

          

        }

       




        // -----   SECION PARA LA COLOCACION DE LAS 18 FICHAS ALTERNADAMENTE //-----
        private void pb1A_Click(object sender, EventArgs e)   // Al hacer click                        ////-----  1 -----//////
        {
            
            if (contador > 0 && contador % 2 == 0 && vpb1A == 0 && poniendoFichas == true)
            {
                pb1A.BackgroundImage = Properties.Resources.azulmini;
                pb1A.BackgroundImageLayout = ImageLayout.Center;
                vpb1A = 2;
                contador--;
            }
             if (contador > 0 && contador % 2 == 1 && vpb1A == 0 && poniendoFichas == true)
            {
                pb1A.BackgroundImage = Properties.Resources.verdemini;
                pb1A.BackgroundImageLayout = ImageLayout.Center;
                vpb1A = 1;
                contador--;
            }
            
            if (poniendoFichas == false && vpb1A != 0)  // condicion de selecion de ficha // si ya no hay fichas  
            {
                desseleccionaTodo();
                pb1A.BackColor = Color.DarkGray;
                vspb1A = 1;
            }
            

    // para realizar Movimiento  
            if (vspb1A == 0 && contador == 0 && vpb1A == 0 )  // Para realizar movimiento:
            {
                                               
                if (EncontrarSeleccionada() == 1 || EncontrarSeleccionada() == 9) // condiciones de movimiento
                {
                    int seleccion = EncontrarSeleccionada(); //  se almacena el dato de la ficha anteriormente seleccionada
                   
                    if (ColorSeleccionado() == 1 && cuentaMovimientos % 2 == 1)  // Condición del turno y del color
                    {
                        pb1A.BackgroundImage = Properties.Resources.verdemini; // se crea la ficha el el lugar indicado
                        pb1A.BackgroundImageLayout = ImageLayout.Center;
                        vpb1A = 1;
                        cuentaMovimientos++;
                        // para eliminar el anterior 
                        PictureBox pbSeleccon = fnEncontrarPictureBox(seleccion); //  se busca cual fué el picture box seleccionado previamente
                        pbSeleccon.BackgroundImage = null; // se procede a borrar la imagen
                        fnPnerVariablePictureBxcero(seleccion); // se reinicia a 0 la variable del picture box
                    }
                    
                    else if (ColorSeleccionado() == 2 && cuentaMovimientos % 2 == 0)
                    {
                        pb1A.BackgroundImage = Properties.Resources.azulmini;
                        pb1A.BackgroundImageLayout = ImageLayout.Center;
                        vpb1A = 2;
                        cuentaMovimientos++;
                        // para eliminar  
                        PictureBox pbSeleccon = fnEncontrarPictureBox(EncontrarSeleccionada());
                        pbSeleccon.BackgroundImage = null;
                        fnPnerVariablePictureBxcero(seleccion);
                    }

                    desseleccionaTodo();
                    
                }
            }

            //  Finaliza codigo para movimiento
            Verificar_Ganador();
            mostrarTurno();
        }

        private void pb2A_Click(object sender, EventArgs e)   // Al hacer click  ------------                  ////-----  2 -----//////
        {
            if (contador > 0 && contador % 2 == 0 && vpb2A == 0 && poniendoFichas == true)
            {
                pb2A.BackgroundImage = Properties.Resources.azulmini;
                pb2A.BackgroundImageLayout = ImageLayout.Center;
                vpb2A = 2;
                contador--;
            }
            else if (contador > 0 && contador % 2 == 1 && vpb2A == 0 && poniendoFichas == true)
            {
                pb2A.BackgroundImage = Properties.Resources.verdemini;
                pb2A.BackgroundImageLayout = ImageLayout.Center;
                vpb2A = 1;
                contador--;
            }
            
            if (poniendoFichas == false && vpb2A != 0)  // condicion de selecion de ficha
            {
                desseleccionaTodo();
                pb2A.BackColor = Color.Gray;
                vspb2A = 1;
            }
            // para realizar Movimiento  
            if (vspb2A == 0 && contador == 0 && vpb2A == 0)  // Para realizar movimiento:
            {

                if (EncontrarSeleccionada() == 0 || EncontrarSeleccionada() == 2 || EncontrarSeleccionada() == 4) // condiciones de movimiento
                {
                    int seleccion = EncontrarSeleccionada(); //  se almacena el dato de la ficha anteriormente seleccionada

                    if (ColorSeleccionado() == 1 && cuentaMovimientos % 2 == 1)  // Condición del turno y del color
                    {
                        pb2A.BackgroundImage = Properties.Resources.verdemini; // se crea la ficha el el lugar indicado
                        pb2A.BackgroundImageLayout = ImageLayout.Center;
                        vpb2A = 1;
                        cuentaMovimientos++;
                        // para eliminar el anterior 
                        PictureBox pbSeleccon = fnEncontrarPictureBox(seleccion); //  se busca cual fué el picture box seleccionado previamente
                        pbSeleccon.BackgroundImage = null; // se procede a borrar la imagen
                        fnPnerVariablePictureBxcero(seleccion); // se reinicia a 0 la variable del picture box
                    }

                    else if (ColorSeleccionado() == 2 && cuentaMovimientos % 2 == 0)
                    {
                        pb2A.BackgroundImage = Properties.Resources.azulmini;
                        pb2A.BackgroundImageLayout = ImageLayout.Center;
                        vpb2A = 2;
                        cuentaMovimientos++;
                        // para eliminar  
                        PictureBox pbSeleccon = fnEncontrarPictureBox(EncontrarSeleccionada());
                        pbSeleccon.BackgroundImage = null;
                        fnPnerVariablePictureBxcero(seleccion);
                    }

                    desseleccionaTodo();

                }
            }

            //  Finaliza codigo para movimiento

            Verificar_Ganador();
            mostrarTurno();
        }

        private void pb3A_Click(object sender, EventArgs e)                                              ////-----  3 -----//////
        {
            if (contador > 0 && contador % 2 == 0 && vpb3A == 0 && poniendoFichas == true)
            {
                pb3A.BackgroundImage = Properties.Resources.azulmini;
                pb3A.BackgroundImageLayout = ImageLayout.Center;
                vpb3A = 2;
                contador--;
            }
            else if (contador > 0 && contador % 2 == 1 && vpb3A == 0 && poniendoFichas == true)
            {
                pb3A.BackgroundImage = Properties.Resources.verdemini;
                pb3A.BackgroundImageLayout = ImageLayout.Center;
                vpb3A = 1;
                contador--;
            }
            if (poniendoFichas == false && vpb3A != 0)  // condicion de selecion de ficha
            {
                desseleccionaTodo();
                pb3A.BackColor = Color.Gray;
                vspb3A = 1;
            }

            // para realizar Movimiento  
            if (vspb3A == 0 && contador == 0 && vpb3A == 0)  // Para realizar movimiento:
            {

                if (EncontrarSeleccionada() == 1 || EncontrarSeleccionada() == 14) // condiciones de movimiento
                {
                    int seleccion = EncontrarSeleccionada(); //  se almacena el dato de la ficha anteriormente seleccionada

                    if (ColorSeleccionado() == 1 && cuentaMovimientos % 2 == 1)  // Condición del turno y del color
                    {
                        pb3A.BackgroundImage = Properties.Resources.verdemini; // se crea la ficha el el lugar indicado
                        pb3A.BackgroundImageLayout = ImageLayout.Center;
                        vpb3A = 1;
                        cuentaMovimientos++;
                        // para eliminar el anterior 
                        PictureBox pbSeleccon = fnEncontrarPictureBox(seleccion); //  se busca cual fué el picture box seleccionado previamente
                        pbSeleccon.BackgroundImage = null; // se procede a borrar la imagen
                        fnPnerVariablePictureBxcero(seleccion); // se reinicia a 0 la variable del picture box
                    }

                    else if (ColorSeleccionado() == 2 && cuentaMovimientos % 2 == 0)
                    {
                        pb3A.BackgroundImage = Properties.Resources.azulmini;
                        pb3A.BackgroundImageLayout = ImageLayout.Center;
                        vpb3A = 2;
                        cuentaMovimientos++;
                        // para eliminar  
                        PictureBox pbSeleccon = fnEncontrarPictureBox(EncontrarSeleccionada());
                        pbSeleccon.BackgroundImage = null;
                        fnPnerVariablePictureBxcero(seleccion);
                    }

                    desseleccionaTodo();


                }
            }

            //  Finaliza codigo para movimiento            

            Verificar_Ganador();
            mostrarTurno();
        }

        private void pb1B_Click(object sender, EventArgs e)                                       ////// -----    4 ----  ////////
        {
            if (contador > 0 && contador % 2 == 0 && vpb1B == 0 && poniendoFichas == true)
            {
                pb1B.BackgroundImage = Properties.Resources.azulmini;
                pb1B.BackgroundImageLayout = ImageLayout.Center;
                vpb1B = 2;
                contador--;
            }
            else if (contador > 0 && contador % 2 == 1 && vpb1B == 0 && poniendoFichas == true)
            {
                pb1B.BackgroundImage = Properties.Resources.verdemini;
                pb1B.BackgroundImageLayout = ImageLayout.Center;
                vpb1B = 1;
                contador--;
            }
            if (poniendoFichas == false && vpb1B != 0)  // condicion de selecion de ficha
            {
                desseleccionaTodo();
                pb1B.BackColor = Color.Gray;
                vspb1B = 1;
            }


            // para realizar Movimiento  
            if (vspb1B == 0 && contador == 0 && vpb1B == 0)  // Para realizar movimiento:
            {

                if (EncontrarSeleccionada() == 4 || EncontrarSeleccionada() == 10) // condiciones de movimiento
                {
                    int seleccion = EncontrarSeleccionada(); //  se almacena el dato de la ficha anteriormente seleccionada

                    if (ColorSeleccionado() == 1 && cuentaMovimientos % 2 == 1)  // Condición del turno y del color
                    {
                        pb1B.BackgroundImage = Properties.Resources.verdemini; // se crea la ficha el el lugar indicado
                        pb1B.BackgroundImageLayout = ImageLayout.Center;
                        vpb1B = 1;
                        cuentaMovimientos++;
                        // para eliminar el anterior 
                        PictureBox pbSeleccon = fnEncontrarPictureBox(seleccion); //  se busca cual fué el picture box seleccionado previamente
                        pbSeleccon.BackgroundImage = null; // se procede a borrar la imagen
                        fnPnerVariablePictureBxcero(seleccion); // se reinicia a 0 la variable del picture box
                    }

                    else if (ColorSeleccionado() == 2 && cuentaMovimientos % 2 == 0)
                    {
                        pb1B.BackgroundImage = Properties.Resources.azulmini;
                        pb1B.BackgroundImageLayout = ImageLayout.Center;
                        vpb1B = 2;
                        cuentaMovimientos++;
                        // para eliminar  
                        PictureBox pbSeleccon = fnEncontrarPictureBox(EncontrarSeleccionada());
                        pbSeleccon.BackgroundImage = null;
                        fnPnerVariablePictureBxcero(seleccion);
                    }

                    desseleccionaTodo();


                }
            }

            //  Finaliza codigo para movimiento            

            Verificar_Ganador();
            mostrarTurno();
        }

        private void pb2B_Click(object sender, EventArgs e)                                       ////-----  5 -----//////
        {
            if (contador > 0 && contador % 2 == 0 && vpb2B == 0 && poniendoFichas == true)
            {
                pb2B.BackgroundImage = Properties.Resources.azulmini;
                pb2B.BackgroundImageLayout = ImageLayout.Center;
                vpb2B = 2;
                contador--;
            }
            else if (contador > 0 && contador % 2 == 1 && vpb2B == 0 && poniendoFichas == true)
            {
                pb2B.BackgroundImage = Properties.Resources.verdemini;
                pb2B.BackgroundImageLayout = ImageLayout.Center;
                vpb2B = 1;
                contador--;
            }
            if (poniendoFichas == false && vpb2B != 0)  // condicion de selecion de ficha
            {
                desseleccionaTodo();
                pb2B.BackColor = Color.Gray;
                vspb2B = 1;
            }

            // para realizar Movimiento  
            if (vspb2B == 0 && contador == 0 && vpb2B == 0)  // Para realizar movimiento:
            {

                if (EncontrarSeleccionada() == 1 || EncontrarSeleccionada() == 3 || EncontrarSeleccionada() == 5 || EncontrarSeleccionada() == 7) // condiciones de movimiento
                {
                    int seleccion = EncontrarSeleccionada(); //  se almacena el dato de la ficha anteriormente seleccionada

                    if (ColorSeleccionado() == 1 && cuentaMovimientos % 2 == 1)  // Condición del turno y del color
                    {
                        pb2B.BackgroundImage = Properties.Resources.verdemini; // se crea la ficha el el lugar indicado
                        pb2B.BackgroundImageLayout = ImageLayout.Center;
                        vpb2B = 1;
                        cuentaMovimientos++;
                        // para eliminar el anterior 
                        PictureBox pbSeleccon = fnEncontrarPictureBox(seleccion); //  se busca cual fué el picture box seleccionado previamente
                        pbSeleccon.BackgroundImage = null; // se procede a borrar la imagen
                        fnPnerVariablePictureBxcero(seleccion); // se reinicia a 0 la variable del picture box
                    }

                    else if (ColorSeleccionado() == 2 && cuentaMovimientos % 2 == 0)
                    {
                        pb2B.BackgroundImage = Properties.Resources.azulmini;
                        pb2B.BackgroundImageLayout = ImageLayout.Center;
                        vpb2B = 2;
                        cuentaMovimientos++;
                        // para eliminar  
                        PictureBox pbSeleccon = fnEncontrarPictureBox(EncontrarSeleccionada());
                        pbSeleccon.BackgroundImage = null;
                        fnPnerVariablePictureBxcero(seleccion);
                    }

                    desseleccionaTodo();


                }
            }

            //  Finaliza codigo para movimiento            

            Verificar_Ganador();
            mostrarTurno();
        }

        private void pb3B_Click(object sender, EventArgs e)                                        ////-----  6 -----//////
        {
            if (contador > 0 && contador % 2 == 0 && vpb3B == 0 && poniendoFichas == true)
            {
                pb3B.BackgroundImage = Properties.Resources.azulmini;
                pb3B.BackgroundImageLayout = ImageLayout.Center;
                vpb3B = 2;
                contador--;
            }
            else if (contador > 0 && contador % 2 == 1 && vpb3B == 0 && poniendoFichas == true)
            {
                pb3B.BackgroundImage = Properties.Resources.verdemini;
                pb3B.BackgroundImageLayout = ImageLayout.Center;
                vpb3B = 1;
                contador--;
            }
            if (poniendoFichas == false && vpb3B != 0)  // condicion de selecion de ficha
            {
                desseleccionaTodo();
                pb3B.BackColor = Color.Gray;
                vspb3B = 1; 
            }

            // para realizar Movimiento  
            if (vspb3B == 0 && contador == 0 && vpb3B == 0)  // Para realizar movimiento:
            {

                if (EncontrarSeleccionada() == 4 || EncontrarSeleccionada() == 13) // condiciones de movimiento
                {
                    int seleccion = EncontrarSeleccionada(); //  se almacena el dato de la ficha anteriormente seleccionada

                    if (ColorSeleccionado() == 1 && cuentaMovimientos % 2 == 1)  // Condición del turno y del color
                    {
                        pb3B.BackgroundImage = Properties.Resources.verdemini; // se crea la ficha el el lugar indicado
                        pb3B.BackgroundImageLayout = ImageLayout.Center;
                        vpb3B = 1;
                        cuentaMovimientos++;
                        // para eliminar el anterior 
                        PictureBox pbSeleccon = fnEncontrarPictureBox(seleccion); //  se busca cual fué el picture box seleccionado previamente
                        pbSeleccon.BackgroundImage = null; // se procede a borrar la imagen
                        fnPnerVariablePictureBxcero(seleccion); // se reinicia a 0 la variable del picture box
                    }

                    else if (ColorSeleccionado() == 2 && cuentaMovimientos % 2 == 0)
                    {
                        pb3B.BackgroundImage = Properties.Resources.azulmini;
                        pb3B.BackgroundImageLayout = ImageLayout.Center;
                        vpb3B = 2;
                        cuentaMovimientos++;
                        // para eliminar  
                        PictureBox pbSeleccon = fnEncontrarPictureBox(EncontrarSeleccionada());
                        pbSeleccon.BackgroundImage = null;
                        fnPnerVariablePictureBxcero(seleccion);
                    }

                    desseleccionaTodo();


                }
            }

            //  Finaliza codigo para movimiento            

            Verificar_Ganador();
            mostrarTurno();
        }



        private void pb1C_Click(object sender, EventArgs e)                            ////-----  7 -----//////
        {
            if (contador > 0 && contador % 2 == 0 && vpb1C == 0 && poniendoFichas == true)
            {
                pb1C.BackgroundImage = Properties.Resources.azulmini;
                pb1C.BackgroundImageLayout = ImageLayout.Center;
                vpb1C = 2;
                contador--;
            }
            else if (contador > 0 && contador % 2 == 1 && vpb1C == 0 && poniendoFichas == true)
            {
                pb1C.BackgroundImage = Properties.Resources.verdemini;
                pb1C.BackgroundImageLayout = ImageLayout.Center;
                vpb1C = 1;
                contador--;
            }
            if (poniendoFichas == false && vpb1C != 0)  // condicion de selecion de ficha
            {
                desseleccionaTodo();
                pb1C.BackColor = Color.Gray;
                vspb1C = 1;
            }

            // para realizar Movimiento  
            if (vspb1C == 0 && contador == 0 && vpb1C == 0)  // Para realizar movimiento:
            {

                if (EncontrarSeleccionada() == 11 || EncontrarSeleccionada() == 7) // condiciones de movimiento
                {
                    int seleccion = EncontrarSeleccionada(); //  se almacena el dato de la ficha anteriormente seleccionada

                    if (ColorSeleccionado() == 1 && cuentaMovimientos % 2 == 1)  // Condición del turno y del color
                    {
                        pb1C.BackgroundImage = Properties.Resources.verdemini; // se crea la ficha el el lugar indicado
                        pb1C.BackgroundImageLayout = ImageLayout.Center;
                        vpb1C = 1;
                        cuentaMovimientos++;
                        // para eliminar el anterior 
                        PictureBox pbSeleccon = fnEncontrarPictureBox(seleccion); //  se busca cual fué el picture box seleccionado previamente
                        pbSeleccon.BackgroundImage = null; // se procede a borrar la imagen
                        fnPnerVariablePictureBxcero(seleccion); // se reinicia a 0 la variable del picture box
                    }

                    else if (ColorSeleccionado() == 2 && cuentaMovimientos % 2 == 0)
                    {
                        pb1C.BackgroundImage = Properties.Resources.azulmini;
                        pb1C.BackgroundImageLayout = ImageLayout.Center;
                        vpb1C = 2;
                        cuentaMovimientos++;
                        // para eliminar  
                        PictureBox pbSeleccon = fnEncontrarPictureBox(EncontrarSeleccionada());
                        pbSeleccon.BackgroundImage = null;
                        fnPnerVariablePictureBxcero(seleccion);
                    }

                    desseleccionaTodo();


                }
            }

            //  Finaliza codigo para movimiento            

            Verificar_Ganador();
            mostrarTurno();
        }

        private void pb2C_Click(object sender, EventArgs e)                            ////-----  8 -----//////
        {
            if (contador > 0 && contador % 2 == 0 && vpb2C == 0 && poniendoFichas == true)
            {
                pb2C.BackgroundImage = Properties.Resources.azulmini;
                pb2C.BackgroundImageLayout = ImageLayout.Center;
                vpb2C = 2;
                contador--;
            }
            else if (contador > 0 && contador % 2 == 1 && vpb2C == 0 && poniendoFichas == true)
            {
                pb2C.BackgroundImage = Properties.Resources.verdemini;
                pb2C.BackgroundImageLayout = ImageLayout.Center;
                vpb2C = 1;
                contador--;
            }
            if (poniendoFichas == false && vpb2C != 0)  // condicion de selecion de ficha
            {
                desseleccionaTodo();
                pb2C.BackColor = Color.Gray;
                vspb2C = 1;
            }

            // para realizar Movimiento  
            if (vspb2C == 0 && contador == 0 && vpb2C == 0)  // Para realizar movimiento:
            {

                if (EncontrarSeleccionada() == 6 || EncontrarSeleccionada() == 8 || EncontrarSeleccionada() == 4) // condiciones de movimiento
                {
                    int seleccion = EncontrarSeleccionada(); //  se almacena el dato de la ficha anteriormente seleccionada

                    if (ColorSeleccionado() == 1 && cuentaMovimientos % 2 == 1)  // Condición del turno y del color
                    {
                        pb2C.BackgroundImage = Properties.Resources.verdemini; // se crea la ficha el el lugar indicado
                        pb2C.BackgroundImageLayout = ImageLayout.Center;
                        vpb2C = 1;
                        cuentaMovimientos++;
                        // para eliminar el anterior 
                        PictureBox pbSeleccon = fnEncontrarPictureBox(seleccion); //  se busca cual fué el picture box seleccionado previamente
                        pbSeleccon.BackgroundImage = null; // se procede a borrar la imagen
                        fnPnerVariablePictureBxcero(seleccion); // se reinicia a 0 la variable del picture box
                    }

                    else if (ColorSeleccionado() == 2 && cuentaMovimientos % 2 == 0)
                    {
                        pb2C.BackgroundImage = Properties.Resources.azulmini;
                        pb2C.BackgroundImageLayout = ImageLayout.Center;
                        vpb2C = 2;
                        cuentaMovimientos++;
                        // para eliminar  
                        PictureBox pbSeleccon = fnEncontrarPictureBox(EncontrarSeleccionada());
                        pbSeleccon.BackgroundImage = null;
                        fnPnerVariablePictureBxcero(seleccion);
                    }

                    desseleccionaTodo();


                }
            }

            //  Finaliza codigo para movimiento            

            Verificar_Ganador();
            mostrarTurno();
        }

        private void pb3C_Click(object sender, EventArgs e)                                         ////-----  9 -----//////
        {
            if (contador > 0 && contador % 2 == 0 && vpb3C == 0 && poniendoFichas == true)
            {
                pb3C.BackgroundImage = Properties.Resources.azulmini;
                pb3C.BackgroundImageLayout = ImageLayout.Center;
                vpb3C = 2;
                contador--;
            }
            else if (contador > 0 && contador % 2 == 1 && vpb3C == 0 && poniendoFichas == true)
            {
                pb3C.BackgroundImage = Properties.Resources.verdemini;
                pb3C.BackgroundImageLayout = ImageLayout.Center;
                vpb3C = 1;
                contador--;
            }
            if (poniendoFichas == false && vpb3C != 0)  // condicion de selecion de ficha
            {
                desseleccionaTodo();
                pb3C.BackColor = Color.Gray;
                vspb3C = 1;
            }

            // para realizar Movimiento  
            if (vspb3C == 0 && contador == 0 && vpb3C == 0)  // Para realizar movimiento:
            {

                if (EncontrarSeleccionada() == 7 || EncontrarSeleccionada() == 12) // condiciones de movimiento
                {
                    int seleccion = EncontrarSeleccionada(); //  se almacena el dato de la ficha anteriormente seleccionada

                    if (ColorSeleccionado() == 1 && cuentaMovimientos % 2 == 1)  // Condición del turno y del color
                    {
                        pb3C.BackgroundImage = Properties.Resources.verdemini; // se crea la ficha el el lugar indicado
                        pb3C.BackgroundImageLayout = ImageLayout.Center;
                        vpb3C = 1;
                        cuentaMovimientos++;
                        // para eliminar el anterior 
                        PictureBox pbSeleccon = fnEncontrarPictureBox(seleccion); //  se busca cual fué el picture box seleccionado previamente
                        pbSeleccon.BackgroundImage = null; // se procede a borrar la imagen
                        fnPnerVariablePictureBxcero(seleccion); // se reinicia a 0 la variable del picture box
                    }

                    else if (ColorSeleccionado() == 2 && cuentaMovimientos % 2 == 0)
                    {
                        pb3C.BackgroundImage = Properties.Resources.azulmini;
                        pb3C.BackgroundImageLayout = ImageLayout.Center;
                        vpb3C = 2;
                        cuentaMovimientos++;
                        // para eliminar  
                        PictureBox pbSeleccon = fnEncontrarPictureBox(EncontrarSeleccionada());
                        pbSeleccon.BackgroundImage = null;
                        fnPnerVariablePictureBxcero(seleccion);
                    }

                    desseleccionaTodo();


                }
            }

            //  Finaliza codigo para movimiento            

            Verificar_Ganador();
            mostrarTurno();
        }


        private void pb1D_Click(object sender, EventArgs e)                                    ////-----  10 -----//////
        {
            if (contador > 0 && contador % 2 == 0 && vpb1D == 0 && poniendoFichas == true)
            {
                pb1D.BackgroundImage = Properties.Resources.azulmini;
                pb1D.BackgroundImageLayout = ImageLayout.Center;
                vpb1D = 2;
                contador--;
            }
            else if (contador > 0 && contador % 2 == 1 && vpb1D == 0 && poniendoFichas == true)
            {
                pb1D.BackgroundImage = Properties.Resources.verdemini;
                pb1D.BackgroundImageLayout = ImageLayout.Center;
                vpb1D = 1;
                contador--;
            }
            if (poniendoFichas == false && vpb1D != 0) // condicion de selecion de ficha
            {
                desseleccionaTodo();
                pb1D.BackColor = Color.Gray;
                vspb1D = 1;
            }

            // para realizar Movimiento  
            if (vspb1D == 0 && contador == 0 && vpb1D == 0)  // Para realizar movimiento:
            {
                int seleccion = EncontrarSeleccionada(); //  se almacena el dato de la ficha anteriormente seleccionada
                if (seleccion == 0 || seleccion == 10 || seleccion == 21) // condiciones de movimiento
                {


                    if (ColorSeleccionado() == 1 && cuentaMovimientos % 2 == 1)  // Condición del turno y del color
                    {
                        pb1D.BackgroundImage = Properties.Resources.verdemini; // se crea la ficha el el lugar indicado
                        pb1D.BackgroundImageLayout = ImageLayout.Center;
                        vpb1D = 1;
                        cuentaMovimientos++;
                        // para eliminar el anterior 
                        PictureBox pbSeleccon = fnEncontrarPictureBox(seleccion); //  se busca cual fué el picture box seleccionado previamente
                        pbSeleccon.BackgroundImage = null; // se procede a borrar la imagen
                        fnPnerVariablePictureBxcero(seleccion); // se reinicia a 0 la variable del picture box
                    }

                    else if (ColorSeleccionado() == 2 && cuentaMovimientos % 2 == 0)
                    {
                        pb1D.BackgroundImage = Properties.Resources.azulmini;
                        pb1D.BackgroundImageLayout = ImageLayout.Center;
                        vpb1D = 2;
                        cuentaMovimientos++;
                        // para eliminar  
                        PictureBox pbSeleccon = fnEncontrarPictureBox(seleccion);
                        pbSeleccon.BackgroundImage = null;
                        fnPnerVariablePictureBxcero(seleccion);
                    }

                    desseleccionaTodo();


                }
            }

            //  Finaliza codigo para movimiento            

            Verificar_Ganador();
            mostrarTurno();

        }



        private void pb2D_Click(object sender, EventArgs e)                                       ////-----  11 -----//////
        {
            if (contador > 0 && contador % 2 == 0 && vpb2D == 0 && poniendoFichas == true)
            {
                pb2D.BackgroundImage = Properties.Resources.azulmini;
                pb2D.BackgroundImageLayout = ImageLayout.Center;
                vpb2D = 2;
                contador--;
            }
            else if (contador > 0 && contador % 2 == 1 && vpb2D == 0 && poniendoFichas == true)
            {
                pb2D.BackgroundImage = Properties.Resources.verdemini;
                pb2D.BackgroundImageLayout = ImageLayout.Center;
                vpb2D = 1;
                contador--;
            }
            if (poniendoFichas == false && vpb2D != 0) // condicion de selecion de ficha
            {
                desseleccionaTodo();
                pb2D.BackColor = Color.Gray;
                vspb2D = 1;
            }

            // para realizar Movimiento  
            if (vspb2D == 0 && contador == 0 && vpb2D == 0)  // Para realizar movimiento:
            {

                if (EncontrarSeleccionada() == 3 || EncontrarSeleccionada() == 9 || EncontrarSeleccionada() == 18 || EncontrarSeleccionada() == 11) // condiciones de movimiento
                {
                    int seleccion = EncontrarSeleccionada(); //  se almacena el dato de la ficha anteriormente seleccionada

                    if (ColorSeleccionado() == 1 && cuentaMovimientos % 2 == 1)  // Condición del turno y del color
                    {
                        pb2D.BackgroundImage = Properties.Resources.verdemini; // se crea la ficha el el lugar indicado
                        pb2D.BackgroundImageLayout = ImageLayout.Center;
                        vpb2D = 1;
                        cuentaMovimientos++;
                        // para eliminar el anterior 
                        PictureBox pbSeleccon = fnEncontrarPictureBox(seleccion); //  se busca cual fué el picture box seleccionado previamente
                        pbSeleccon.BackgroundImage = null; // se procede a borrar la imagen
                        fnPnerVariablePictureBxcero(seleccion); // se reinicia a 0 la variable del picture box
                    }

                    else if (ColorSeleccionado() == 2 && cuentaMovimientos % 2 == 0)
                    {
                        pb2D.BackgroundImage = Properties.Resources.azulmini;
                        pb2D.BackgroundImageLayout = ImageLayout.Center;
                        vpb2D = 2;
                        cuentaMovimientos++;
                        // para eliminar  
                        PictureBox pbSeleccon = fnEncontrarPictureBox(EncontrarSeleccionada());
                        pbSeleccon.BackgroundImage = null;
                        fnPnerVariablePictureBxcero(seleccion);
                    }

                    desseleccionaTodo();


                }
            }

            //  Finaliza codigo para movimiento            

            Verificar_Ganador();
            mostrarTurno();
        }

        private void pb3D_Click(object sender, EventArgs e)                                       ////-----  12 -----//////
        {
            if (contador > 0 && contador % 2 == 0 && vpb3D == 0 && poniendoFichas == true)
            {
                pb3D.BackgroundImage = Properties.Resources.azulmini;
                pb3D.BackgroundImageLayout = ImageLayout.Center;
                vpb3D = 2;
                contador--;
            }
            else if (contador > 0 && contador % 2 == 1 && vpb3D == 0 && poniendoFichas == true)
            {
                pb3D.BackgroundImage = Properties.Resources.verdemini;
                pb3D.BackgroundImageLayout = ImageLayout.Center;
                vpb3D = 1;
                contador--;
            }
            if (poniendoFichas == false && vpb3D != 0) // condicion de selecion de ficha
            {
                desseleccionaTodo();
                pb3D.BackColor = Color.Gray;
                vspb3D = 1;
            }

            // para realizar Movimiento  
            if (vspb3D == 0 && contador == 0 && vpb3D == 0)  // Para realizar movimiento:
            {
                 int seleccion = EncontrarSeleccionada(); //  se almacena el dato de la ficha anteriormente seleccionada
                if (seleccion == 10 || seleccion == 6 || seleccion == 15) // condiciones de movimiento
                {


                    if (ColorSeleccionado() == 1 && cuentaMovimientos % 2 == 1)  // Condición del turno y del color
                    {
                        pb3D.BackgroundImage = Properties.Resources.verdemini; // se crea la ficha el el lugar indicado
                        pb3D.BackgroundImageLayout = ImageLayout.Center;
                        vpb3D = 1;
                        cuentaMovimientos++;
                        // para eliminar el anterior 
                        PictureBox pbSeleccon = fnEncontrarPictureBox(seleccion); //  se busca cual fué el picture box seleccionado previamente
                        pbSeleccon.BackgroundImage = null; // se procede a borrar la imagen
                        fnPnerVariablePictureBxcero(seleccion); // se reinicia a 0 la variable del picture box
                    }

                    else if (ColorSeleccionado() == 2 && cuentaMovimientos % 2 == 0)
                    {
                        pb3D.BackgroundImage = Properties.Resources.azulmini;
                        pb3D.BackgroundImageLayout = ImageLayout.Center;
                        vpb3D = 2;
                        cuentaMovimientos++;
                        // para eliminar  
                        PictureBox pbSeleccon = fnEncontrarPictureBox(seleccion);
                        pbSeleccon.BackgroundImage = null;
                        fnPnerVariablePictureBxcero(seleccion);
                    }

                    desseleccionaTodo();


                }
            }

            //  Finaliza codigo para movimiento            

            Verificar_Ganador();
            mostrarTurno();
        }

        private void pb4D_Click(object sender, EventArgs e)
        {
            if (contador > 0 && contador % 2 == 0 && vpb4D == 0 && poniendoFichas == true)
            {
                pb4D.BackgroundImage = Properties.Resources.azulmini;
                pb4D.BackgroundImageLayout = ImageLayout.Center;
                vpb4D = 2;
                contador--;
            }
            else if (contador > 0 && contador % 2 == 1 && vpb4D == 0 && poniendoFichas == true)
            {
                pb4D.BackgroundImage = Properties.Resources.verdemini;
                pb4D.BackgroundImageLayout = ImageLayout.Center;
                vpb4D = 1;
                contador--;
            }
            if (poniendoFichas == false && vpb4D != 0) // condicion de selecion de ficha
            {
                desseleccionaTodo();
                pb4D.BackColor = Color.Gray;
                vspb4D = 1;
            }

            // para realizar Movimiento  
            if (vspb4D == 0 && contador == 0 && vpb4D == 0)  // Para realizar movimiento:
            {
                int seleccion = EncontrarSeleccionada(); //  se almacena el dato de la ficha anteriormente seleccionada
                if (seleccion == 8 || seleccion == 13 || seleccion == 17) // condiciones de movimiento
                {


                    if (ColorSeleccionado() == 1 && cuentaMovimientos % 2 == 1)  // Condición del turno y del color
                    {
                        pb4D.BackgroundImage = Properties.Resources.verdemini; // se crea la ficha el el lugar indicado
                        pb4D.BackgroundImageLayout = ImageLayout.Center;
                        vpb4D = 1;
                        cuentaMovimientos++;
                        // para eliminar el anterior 
                        PictureBox pbSeleccon = fnEncontrarPictureBox(seleccion); //  se busca cual fué el picture box seleccionado previamente
                        pbSeleccon.BackgroundImage = null; // se procede a borrar la imagen
                        fnPnerVariablePictureBxcero(seleccion); // se reinicia a 0 la variable del picture box
                    }

                    else if (ColorSeleccionado() == 2 && cuentaMovimientos % 2 == 0)
                    {
                        pb4D.BackgroundImage = Properties.Resources.azulmini;
                        pb4D.BackgroundImageLayout = ImageLayout.Center;
                        vpb4D = 2;
                        cuentaMovimientos++;
                        // para eliminar  
                        PictureBox pbSeleccon = fnEncontrarPictureBox(seleccion);
                        pbSeleccon.BackgroundImage = null;
                        fnPnerVariablePictureBxcero(seleccion);
                    }

                    desseleccionaTodo();


                }
            }

            //  Finaliza codigo para movimiento            

            Verificar_Ganador();
            mostrarTurno();
        }

        private void pb5D_Click(object sender, EventArgs e)
        {
            if (contador > 0 && contador % 2 == 0 && vpb5D == 0 && poniendoFichas == true)
            {
                pb5D.BackgroundImage = Properties.Resources.azulmini;
                pb5D.BackgroundImageLayout = ImageLayout.Center;
                vpb5D = 2;
                contador--;
            }
            else if (contador > 0 && contador % 2 == 1 && vpb5D == 0 && poniendoFichas == true)
            {
                pb5D.BackgroundImage = Properties.Resources.verdemini;
                pb5D.BackgroundImageLayout = ImageLayout.Center;
                vpb5D = 1;
                contador--;
            }
            if (poniendoFichas == false && vpb5D != 0) // condicion de selecion de ficha
            {
                desseleccionaTodo();
                pb5D.BackColor = Color.Gray;
                vspb5D = 1;
            }

            // para realizar Movimiento  
            if (vspb5D == 0 && contador == 0 && vpb5D == 0)  // Para realizar movimiento:
            {
                int seleccion = EncontrarSeleccionada(); //  se almacena el dato de la ficha anteriormente seleccionada
                if (seleccion == 12 || seleccion == 5 || seleccion == 20 || seleccion == 14) // condiciones de movimiento
                {


                    if (ColorSeleccionado() == 1 && cuentaMovimientos % 2 == 1)  // Condición del turno y del color
                    {
                        pb5D.BackgroundImage = Properties.Resources.verdemini; // se crea la ficha el el lugar indicado
                        pb5D.BackgroundImageLayout = ImageLayout.Center;
                        vpb5D = 1;
                        cuentaMovimientos++;
                        // para eliminar el anterior 
                        PictureBox pbSeleccon = fnEncontrarPictureBox(seleccion); //  se busca cual fué el picture box seleccionado previamente
                        pbSeleccon.BackgroundImage = null; // se procede a borrar la imagen
                        fnPnerVariablePictureBxcero(seleccion); // se reinicia a 0 la variable del picture box
                    }

                    else if (ColorSeleccionado() == 2 && cuentaMovimientos % 2 == 0)
                    {
                        pb5D.BackgroundImage = Properties.Resources.azulmini;
                        pb5D.BackgroundImageLayout = ImageLayout.Center;
                        vpb5D = 2;
                        cuentaMovimientos++;
                        // para eliminar  
                        PictureBox pbSeleccon = fnEncontrarPictureBox(seleccion);
                        pbSeleccon.BackgroundImage = null;
                        fnPnerVariablePictureBxcero(seleccion);
                    }

                    desseleccionaTodo();


                }
            }

            //  Finaliza codigo para movimiento            

            Verificar_Ganador();
            mostrarTurno();
        }

        private void pb6D_Click(object sender, EventArgs e)
        {
            if (contador > 0 && contador % 2 == 0 && vpb6D == 0 && poniendoFichas == true)
            {
                pb6D.BackgroundImage = Properties.Resources.azulmini;
                pb6D.BackgroundImageLayout = ImageLayout.Center;
                vpb6D = 2;
                contador--;
            }
            else if (contador > 0 && contador % 2 == 1 && vpb6D == 0 && poniendoFichas == true)
            {
                pb6D.BackgroundImage = Properties.Resources.verdemini;
                pb6D.BackgroundImageLayout = ImageLayout.Center;
                vpb6D = 1;
                contador--;
            }
            if (poniendoFichas == false && vpb6D != 0) // condicion de selecion de ficha
            {
                desseleccionaTodo();
                pb6D.BackColor = Color.Gray;
                vspb6D = 1;
            }

            // para realizar Movimiento  
            if (vspb6D == 0 && contador == 0 && vpb6D == 0)  // Para realizar movimiento:
            {
                int seleccion = EncontrarSeleccionada(); //  se almacena el dato de la ficha anteriormente seleccionada
                if (seleccion == 13 || seleccion == 2 || seleccion == 23) // condiciones de movimiento
                {


                    if (ColorSeleccionado() == 1 && cuentaMovimientos % 2 == 1)  // Condición del turno y del color
                    {
                        pb6D.BackgroundImage = Properties.Resources.verdemini; // se crea la ficha el el lugar indicado
                        pb6D.BackgroundImageLayout = ImageLayout.Center;
                        vpb6D = 1;
                        cuentaMovimientos++;
                        // para eliminar el anterior 
                        PictureBox pbSeleccon = fnEncontrarPictureBox(seleccion); //  se busca cual fué el picture box seleccionado previamente
                        pbSeleccon.BackgroundImage = null; // se procede a borrar la imagen
                        fnPnerVariablePictureBxcero(seleccion); // se reinicia a 0 la variable del picture box
                    }

                    else if (ColorSeleccionado() == 2 && cuentaMovimientos % 2 == 0)
                    {
                        pb6D.BackgroundImage = Properties.Resources.azulmini;
                        pb6D.BackgroundImageLayout = ImageLayout.Center;
                        vpb6D = 2;
                        cuentaMovimientos++;
                        // para eliminar  
                        PictureBox pbSeleccon = fnEncontrarPictureBox(seleccion);
                        pbSeleccon.BackgroundImage = null;
                        fnPnerVariablePictureBxcero(seleccion);
                    }

                    desseleccionaTodo();


                }
            }

            //  Finaliza codigo para movimiento            

            Verificar_Ganador();
            mostrarTurno();
        }

        private void pb1E_Click(object sender, EventArgs e)
        {
            if (contador > 0 && contador % 2 == 0 && vpb1E == 0 && poniendoFichas == true)
            {
                pb1E.BackgroundImage = Properties.Resources.azulmini;
                pb1E.BackgroundImageLayout = ImageLayout.Center;
                vpb1E = 2;
                contador--;
            }
            else if (contador > 0 && contador % 2 == 1 && vpb1E == 0 && poniendoFichas == true)
            {
                pb1E.BackgroundImage = Properties.Resources.verdemini;
                pb1E.BackgroundImageLayout = ImageLayout.Center;
                vpb1E = 1;
                contador--;
            }
            if (poniendoFichas == false && vpb1E != 0) // condicion de selecion de ficha
            {
                desseleccionaTodo();
                pb1E.BackColor = Color.Gray;
                vspb1E = 1;
            }

            // para realizar Movimiento  
            if (vspb1E == 0 && contador == 0 && vpb1E == 0)  // Para realizar movimiento:
            {
                int seleccion = EncontrarSeleccionada(); //  se almacena el dato de la ficha anteriormente seleccionada
                if (seleccion == 11 || seleccion == 16) // condiciones de movimiento
                {


                    if (ColorSeleccionado() == 1 && cuentaMovimientos % 2 == 1)  // Condición del turno y del color
                    {
                        pb1E.BackgroundImage = Properties.Resources.verdemini; // se crea la ficha el el lugar indicado
                        pb1E.BackgroundImageLayout = ImageLayout.Center;
                        vpb1E = 1;
                        cuentaMovimientos++;
                        // para eliminar el anterior 
                        PictureBox pbSeleccon = fnEncontrarPictureBox(seleccion); //  se busca cual fué el picture box seleccionado previamente
                        pbSeleccon.BackgroundImage = null; // se procede a borrar la imagen
                        fnPnerVariablePictureBxcero(seleccion); // se reinicia a 0 la variable del picture box
                    }

                    else if (ColorSeleccionado() == 2 && cuentaMovimientos % 2 == 0)
                    {
                        pb1E.BackgroundImage = Properties.Resources.azulmini;
                        pb1E.BackgroundImageLayout = ImageLayout.Center;
                        vpb1E = 2;
                        cuentaMovimientos++;
                        // para eliminar  
                        PictureBox pbSeleccon = fnEncontrarPictureBox(seleccion);
                        pbSeleccon.BackgroundImage = null;
                        fnPnerVariablePictureBxcero(seleccion);
                    }

                    desseleccionaTodo();


                }
            }

            //  Finaliza codigo para movimiento            

            Verificar_Ganador();
            mostrarTurno();
        }

        private void pb2E_Click(object sender, EventArgs e)
        {
            if (contador > 0 && contador % 2 == 0 && vpb2E == 0 && poniendoFichas == true)
            {
                pb2E.BackgroundImage = Properties.Resources.azulmini;
                pb2E.BackgroundImageLayout = ImageLayout.Center;
                vpb2E = 2;
                contador--;
            }
            else if (contador > 0 && contador % 2 == 1 && vpb2E == 0 && poniendoFichas == true)
            {
                pb2E.BackgroundImage = Properties.Resources.verdemini;
                pb2E.BackgroundImageLayout = ImageLayout.Center;
                vpb2E = 1;
                contador--;
            }
            if (poniendoFichas == false && vpb2E != 0) // condicion de selecion de ficha
            {
                desseleccionaTodo();
                pb2E.BackColor = Color.Gray;
                vspb2E = 1;
            }

            // para realizar Movimiento  
            if (vspb2E == 0 && contador == 0 && vpb2E == 0)  // Para realizar movimiento:
            {
                int seleccion = EncontrarSeleccionada(); //  se almacena el dato de la ficha anteriormente seleccionada
                if (seleccion == 15 || seleccion == 17 || seleccion == 19) // condiciones de movimiento
                {


                    if (ColorSeleccionado() == 1 && cuentaMovimientos % 2 == 1)  // Condición del turno y del color
                    {
                        pb2E.BackgroundImage = Properties.Resources.verdemini; // se crea la ficha el el lugar indicado
                        pb2E.BackgroundImageLayout = ImageLayout.Center;
                        vpb2E = 1;
                        cuentaMovimientos++;
                        // para eliminar el anterior 
                        PictureBox pbSeleccon = fnEncontrarPictureBox(seleccion); //  se busca cual fué el picture box seleccionado previamente
                        pbSeleccon.BackgroundImage = null; // se procede a borrar la imagen
                        fnPnerVariablePictureBxcero(seleccion); // se reinicia a 0 la variable del picture box
                    }

                    else if (ColorSeleccionado() == 2 && cuentaMovimientos % 2 == 0)
                    {
                        pb2E.BackgroundImage = Properties.Resources.azulmini;
                        pb2E.BackgroundImageLayout = ImageLayout.Center;
                        vpb2E = 2;
                        cuentaMovimientos++;
                        // para eliminar  
                        PictureBox pbSeleccon = fnEncontrarPictureBox(seleccion);
                        pbSeleccon.BackgroundImage = null;
                        fnPnerVariablePictureBxcero(seleccion);
                    }

                    desseleccionaTodo();


                }
            }

            //  Finaliza codigo para movimiento            

            Verificar_Ganador();
            mostrarTurno();
        }

        private void pb3E_Click(object sender, EventArgs e)
        {
            if (contador > 0 && contador % 2 == 0 && vpb3E == 0 && poniendoFichas == true)
            {
                pb3E.BackgroundImage = Properties.Resources.azulmini;
                pb3E.BackgroundImageLayout = ImageLayout.Center;
                vpb3E = 2;
                contador--;
            }
            else if (contador > 0 && contador % 2 == 1 && vpb3E == 0 && poniendoFichas == true)
            {
                pb3E.BackgroundImage = Properties.Resources.verdemini;
                pb3E.BackgroundImageLayout = ImageLayout.Center;
                vpb3E = 1;
                contador--;
            }
            if (poniendoFichas == false && vpb3E != 0) // condicion de selecion de ficha
            {
                desseleccionaTodo();
                pb3E.BackColor = Color.Gray;
                vspb3E = 1;
            }

            // para realizar Movimiento  
            if (vspb3E == 0 && contador == 0 && vpb3E == 0)  // Para realizar movimiento:
            {
                int seleccion = EncontrarSeleccionada(); //  se almacena el dato de la ficha anteriormente seleccionada
                if (seleccion == 16 || seleccion == 12) // condiciones de movimiento
                {


                    if (ColorSeleccionado() == 1 && cuentaMovimientos % 2 == 1)  // Condición del turno y del color
                    {
                        pb3E.BackgroundImage = Properties.Resources.verdemini; // se crea la ficha el el lugar indicado
                        pb3E.BackgroundImageLayout = ImageLayout.Center;
                        vpb3E = 1;
                        cuentaMovimientos++;
                        // para eliminar el anterior 
                        PictureBox pbSeleccon = fnEncontrarPictureBox(seleccion); //  se busca cual fué el picture box seleccionado previamente
                        pbSeleccon.BackgroundImage = null; // se procede a borrar la imagen
                        fnPnerVariablePictureBxcero(seleccion); // se reinicia a 0 la variable del picture box
                    }

                    else if (ColorSeleccionado() == 2 && cuentaMovimientos % 2 == 0)
                    {
                        pb3E.BackgroundImage = Properties.Resources.azulmini;
                        pb3E.BackgroundImageLayout = ImageLayout.Center;
                        vpb3E = 2;
                        cuentaMovimientos++;
                        // para eliminar  
                        PictureBox pbSeleccon = fnEncontrarPictureBox(seleccion);
                        pbSeleccon.BackgroundImage = null;
                        fnPnerVariablePictureBxcero(seleccion);
                    }

                    desseleccionaTodo();


                }
            }

            //  Finaliza codigo para movimiento            

            Verificar_Ganador();
            mostrarTurno();
        }
                                                                                            ///  POR AQUI VOOOOOOOOOY
        private void pb1F_Click(object sender, EventArgs e)
        {
            if (contador > 0 && contador % 2 == 0 && vpb1F == 0 && poniendoFichas == true)
            {
                pb1F.BackgroundImage = Properties.Resources.azulmini;
                pb1F.BackgroundImageLayout = ImageLayout.Center;
                vpb1F = 2;
                contador--;
            }
            else if (contador > 0 && contador % 2 == 1 && vpb1F == 0 && poniendoFichas == true)
            {
                pb1F.BackgroundImage = Properties.Resources.verdemini;
                pb1F.BackgroundImageLayout = ImageLayout.Center;
                vpb1F = 1;
                contador--;
            }
            if (poniendoFichas == false && vpb1F != 0) // condicion de selecion de ficha
            {
                desseleccionaTodo();
                pb1F.BackColor = Color.Gray;
                vspb1F = 1;
            }

            // para realizar Movimiento  
            if (vspb1F == 0 && contador == 0 && vpb1F == 0)  // Para realizar movimiento:
            {
                int seleccion = EncontrarSeleccionada(); //  se almacena el dato de la ficha anteriormente seleccionada
                if (seleccion == 10 || seleccion == 19) // condiciones de movimiento
                {


                    if (ColorSeleccionado() == 1 && cuentaMovimientos % 2 == 1)  // Condición del turno y del color
                    {
                        pb1F.BackgroundImage = Properties.Resources.verdemini; // se crea la ficha el el lugar indicado
                        pb1F.BackgroundImageLayout = ImageLayout.Center;
                        vpb1F = 1;
                        cuentaMovimientos++;
                        // para eliminar el anterior 
                        PictureBox pbSeleccon = fnEncontrarPictureBox(seleccion); //  se busca cual fué el picture box seleccionado previamente
                        pbSeleccon.BackgroundImage = null; // se procede a borrar la imagen
                        fnPnerVariablePictureBxcero(seleccion); // se reinicia a 0 la variable del picture box
                    }

                    else if (ColorSeleccionado() == 2 && cuentaMovimientos % 2 == 0)
                    {
                        pb1F.BackgroundImage = Properties.Resources.azulmini;
                        pb1F.BackgroundImageLayout = ImageLayout.Center;
                        vpb1F = 2;
                        cuentaMovimientos++;
                        // para eliminar  
                        PictureBox pbSeleccon = fnEncontrarPictureBox(seleccion);
                        pbSeleccon.BackgroundImage = null;
                        fnPnerVariablePictureBxcero(seleccion);
                    }

                    desseleccionaTodo();


                }
            }

            //  Finaliza codigo para movimiento            

            Verificar_Ganador();
            mostrarTurno();

        }

        private void pb2F_Click(object sender, EventArgs e)
        {
            if (contador > 0 && contador % 2 == 0 && vpb2F == 0 && poniendoFichas == true)
            {
                pb2F.BackgroundImage = Properties.Resources.azulmini;
                pb2F.BackgroundImageLayout = ImageLayout.Center;
                vpb2F = 2;
                contador--;
            }
            else if (contador > 0 && contador % 2 == 1 && vpb2F == 0 && poniendoFichas == true)
            {
                pb2F.BackgroundImage = Properties.Resources.verdemini;
                pb2F.BackgroundImageLayout = ImageLayout.Center;
                vpb2F = 1;
                contador--;
            }
            if (poniendoFichas == false && vpb2F != 0) // condicion de selecion de ficha
            {
                desseleccionaTodo();
                pb2F.BackColor = Color.Gray;
                vspb2F = 1;
            }

            // para realizar Movimiento  
            if (vspb2F == 0 && contador == 0 && vpb2F == 0)  // Para realizar movimiento:
            {
                int seleccion = EncontrarSeleccionada(); //  se almacena el dato de la ficha anteriormente seleccionada
                if (seleccion == 18 || seleccion == 16 || seleccion == 22 || seleccion == 20) // condiciones de movimiento
                {


                    if (ColorSeleccionado() == 1 && cuentaMovimientos % 2 == 1)  // Condición del turno y del color
                    {
                        pb2F.BackgroundImage = Properties.Resources.verdemini; // se crea la ficha el el lugar indicado
                        pb2F.BackgroundImageLayout = ImageLayout.Center;
                        vpb2F = 1;
                        cuentaMovimientos++;
                        // para eliminar el anterior 
                        PictureBox pbSeleccon = fnEncontrarPictureBox(seleccion); //  se busca cual fué el picture box seleccionado previamente
                        pbSeleccon.BackgroundImage = null; // se procede a borrar la imagen
                        fnPnerVariablePictureBxcero(seleccion); // se reinicia a 0 la variable del picture box
                    }

                    else if (ColorSeleccionado() == 2 && cuentaMovimientos % 2 == 0)
                    {
                        pb2F.BackgroundImage = Properties.Resources.azulmini;
                        pb2F.BackgroundImageLayout = ImageLayout.Center;
                        vpb2F = 2;
                        cuentaMovimientos++;
                        // para eliminar  
                        PictureBox pbSeleccon = fnEncontrarPictureBox(seleccion);
                        pbSeleccon.BackgroundImage = null;
                        fnPnerVariablePictureBxcero(seleccion);
                    }

                    desseleccionaTodo();


                }
            }

            //  Finaliza codigo para movimiento            

            Verificar_Ganador();
            mostrarTurno();
        }

        private void pb3F_Click(object sender, EventArgs e)
        {
            if (contador > 0 && contador % 2 == 0 && vpb3F == 0 && poniendoFichas == true)
            {
                pb3F.BackgroundImage = Properties.Resources.azulmini;
                pb3F.BackgroundImageLayout = ImageLayout.Center;
                vpb3F = 2;
                contador--;
            }
            else if (contador > 0 && contador % 2 == 1 && vpb3F == 0 && poniendoFichas == true)
            {
                pb3F.BackgroundImage = Properties.Resources.verdemini;
                pb3F.BackgroundImageLayout = ImageLayout.Center;
                vpb3F = 1;
                contador--;
            }
            if (poniendoFichas == false && vpb3F != 0) // condicion de selecion de ficha
            {
                desseleccionaTodo();
                pb3F.BackColor = Color.Gray;
                vspb3F = 1;
            }

            // para realizar Movimiento  
            if (vspb3F == 0 && contador == 0 && vpb3F == 0)  // Para realizar movimiento:
            {
                int seleccion = EncontrarSeleccionada(); //  se almacena el dato de la ficha anteriormente seleccionada
                if (seleccion == 19 || seleccion == 13 ) // condiciones de movimiento
                {


                    if (ColorSeleccionado() == 1 && cuentaMovimientos % 2 == 1)  // Condición del turno y del color
                    {
                        pb3F.BackgroundImage = Properties.Resources.verdemini; // se crea la ficha el el lugar indicado
                        pb3F.BackgroundImageLayout = ImageLayout.Center;
                        vpb3F = 1;
                        cuentaMovimientos++;
                        // para eliminar el anterior 
                        PictureBox pbSeleccon = fnEncontrarPictureBox(seleccion); //  se busca cual fué el picture box seleccionado previamente
                        pbSeleccon.BackgroundImage = null; // se procede a borrar la imagen
                        fnPnerVariablePictureBxcero(seleccion); // se reinicia a 0 la variable del picture box
                    }

                    else if (ColorSeleccionado() == 2 && cuentaMovimientos % 2 == 0)
                    {
                        pb3F.BackgroundImage = Properties.Resources.azulmini;
                        pb3F.BackgroundImageLayout = ImageLayout.Center;
                        vpb3F = 2;
                        cuentaMovimientos++;
                        // para eliminar  
                        PictureBox pbSeleccon = fnEncontrarPictureBox(seleccion);
                        pbSeleccon.BackgroundImage = null;
                        fnPnerVariablePictureBxcero(seleccion);
                    }

                    desseleccionaTodo();


                }
            }

            //  Finaliza codigo para movimiento            

            Verificar_Ganador();
            mostrarTurno();
        }

        private void pb1G_Click(object sender, EventArgs e)
        {
            if (contador > 0 && contador % 2 == 0 && vpb1G == 0 && poniendoFichas == true)
            {
                pb1G.BackgroundImage = Properties.Resources.azulmini;
                pb1G.BackgroundImageLayout = ImageLayout.Center;
                vpb1G = 2;
                contador--;
            }
            else if (contador > 0 && contador % 2 == 1 && vpb1G == 0 && poniendoFichas == true)
            {
                pb1G.BackgroundImage = Properties.Resources.verdemini;
                pb1G.BackgroundImageLayout = ImageLayout.Center;
                vpb1G = 1;
                contador--;
            }
            if (poniendoFichas == false && vpb1G != 0) // condicion de selecion de ficha
            {
                desseleccionaTodo();
                pb1G.BackColor = Color.Gray;
                vspb1G = 1;
            }

            // para realizar Movimiento  
            if (vspb1G == 0 && contador == 0 && vpb1G == 0)  // Para realizar movimiento:
            {
                int seleccion = EncontrarSeleccionada(); //  se almacena el dato de la ficha anteriormente seleccionada
                if (seleccion == 9 || seleccion == 22) // condiciones de movimiento
                {


                    if (ColorSeleccionado() == 1 && cuentaMovimientos % 2 == 1)  // Condición del turno y del color
                    {
                        pb1G.BackgroundImage = Properties.Resources.verdemini; // se crea la ficha el el lugar indicado
                        pb1G.BackgroundImageLayout = ImageLayout.Center;
                        vpb1G = 1;
                        cuentaMovimientos++;
                        // para eliminar el anterior 
                        PictureBox pbSeleccon = fnEncontrarPictureBox(seleccion); //  se busca cual fué el picture box seleccionado previamente
                        pbSeleccon.BackgroundImage = null; // se procede a borrar la imagen
                        fnPnerVariablePictureBxcero(seleccion); // se reinicia a 0 la variable del picture box
                    }

                    else if (ColorSeleccionado() == 2 && cuentaMovimientos % 2 == 0)
                    {
                        pb1G.BackgroundImage = Properties.Resources.azulmini;
                        pb1G.BackgroundImageLayout = ImageLayout.Center;
                        vpb1G = 2;
                        cuentaMovimientos++;
                        // para eliminar  
                        PictureBox pbSeleccon = fnEncontrarPictureBox(seleccion);
                        pbSeleccon.BackgroundImage = null;
                        fnPnerVariablePictureBxcero(seleccion);
                    }

                    desseleccionaTodo();


                }
            }

            //  Finaliza codigo para movimiento            

            Verificar_Ganador();
            mostrarTurno();
        }

        private void pb2G_Click(object sender, EventArgs e)
        {
            if (contador > 0 && contador % 2 == 0 && vpb2G == 0 && poniendoFichas == true)
            {
                pb2G.BackgroundImage = Properties.Resources.azulmini;
                pb2G.BackgroundImageLayout = ImageLayout.Center;
                vpb2G = 2;
                contador--;
            }
            else if (contador > 0 && contador % 2 == 1 && vpb2G == 0 && poniendoFichas == true)
            {
                pb2G.BackgroundImage = Properties.Resources.verdemini;
                pb2G.BackgroundImageLayout = ImageLayout.Center;
                vpb2G = 1;
                contador--;
            }
            if (poniendoFichas == false && vpb2G != 0) // condicion de selecion de ficha
            {
                desseleccionaTodo();
                pb2G.BackColor = Color.Gray;
                vspb2G = 1;
            }

            // para realizar Movimiento  
            if (vspb2G == 0 && contador == 0 && vpb2G == 0)  // Para realizar movimiento:
            {
                int seleccion = EncontrarSeleccionada(); //  se almacena el dato de la ficha anteriormente seleccionada
                if (seleccion == 21 || seleccion == 19 || seleccion == 23) // condiciones de movimiento
                {


                    if (ColorSeleccionado() == 1 && cuentaMovimientos % 2 == 1)  // Condición del turno y del color
                    {
                        pb2G.BackgroundImage = Properties.Resources.verdemini; // se crea la ficha el el lugar indicado
                        pb2G.BackgroundImageLayout = ImageLayout.Center;
                        vpb2G = 1;
                        cuentaMovimientos++;
                        // para eliminar el anterior 
                        PictureBox pbSeleccon = fnEncontrarPictureBox(seleccion); //  se busca cual fué el picture box seleccionado previamente
                        pbSeleccon.BackgroundImage = null; // se procede a borrar la imagen
                        fnPnerVariablePictureBxcero(seleccion); // se reinicia a 0 la variable del picture box
                    }

                    else if (ColorSeleccionado() == 2 && cuentaMovimientos % 2 == 0)
                    {
                        pb2G.BackgroundImage = Properties.Resources.azulmini;
                        pb2G.BackgroundImageLayout = ImageLayout.Center;
                        vpb2G = 2;
                        cuentaMovimientos++;
                        // para eliminar  
                        PictureBox pbSeleccon = fnEncontrarPictureBox(seleccion);
                        pbSeleccon.BackgroundImage = null;
                        fnPnerVariablePictureBxcero(seleccion);
                    }

                    desseleccionaTodo();


                }
            }

            //  Finaliza codigo para movimiento            

            Verificar_Ganador();
            mostrarTurno();
        }

        private void pb3G_Click(object sender, EventArgs e)
        {
            if (contador > 0 && contador % 2 == 0 && vpb3G == 0 && poniendoFichas == true)
            {
                pb3G.BackgroundImage = Properties.Resources.azulmini;
                pb3G.BackgroundImageLayout = ImageLayout.Center;
                vpb3G = 2;
                contador--;
            }
            else if (contador > 0 && contador % 2 == 1 && vpb3G == 0 && poniendoFichas == true)
            {
                pb3G.BackgroundImage = Properties.Resources.verdemini;
                pb3G.BackgroundImageLayout = ImageLayout.Center;
                vpb3G = 1;
                contador--;
            }
            if (poniendoFichas == false && vpb3G != 0) // condicion de selecion de ficha
            {
                desseleccionaTodo();
                pb3G.BackColor = Color.Gray;
                vspb3G = 1;
            }

            // para realizar Movimiento  
            if (vspb3G == 0 && contador == 0 && vpb3G == 0)  // Para realizar movimiento:
            {
                int seleccion = EncontrarSeleccionada(); //  se almacena el dato de la ficha anteriormente seleccionada
                if (seleccion == 22 || seleccion == 14) // condiciones de movimiento
                {


                    if (ColorSeleccionado() == 1 && cuentaMovimientos % 2 == 1)  // Condición del turno y del color
                    {
                        pb3G.BackgroundImage = Properties.Resources.verdemini; // se crea la ficha el el lugar indicado
                        pb3G.BackgroundImageLayout = ImageLayout.Center;
                        vpb3G = 1;
                        cuentaMovimientos++;
                        // para eliminar el anterior 
                        PictureBox pbSeleccon = fnEncontrarPictureBox(seleccion); //  se busca cual fué el picture box seleccionado previamente
                        pbSeleccon.BackgroundImage = null; // se procede a borrar la imagen
                        fnPnerVariablePictureBxcero(seleccion); // se reinicia a 0 la variable del picture box
                    }

                    else if (ColorSeleccionado() == 2 && cuentaMovimientos % 2 == 0)
                    {
                        pb3G.BackgroundImage = Properties.Resources.azulmini;
                        pb3G.BackgroundImageLayout = ImageLayout.Center;
                        vpb3G = 2;
                        cuentaMovimientos++;
                        // para eliminar  
                        PictureBox pbSeleccon = fnEncontrarPictureBox(seleccion);
                        pbSeleccon.BackgroundImage = null;
                        fnPnerVariablePictureBxcero(seleccion);
                    }

                    desseleccionaTodo();


                }
            }

            //  Finaliza codigo para movimiento            

            Verificar_Ganador();
            mostrarTurno();
        }










    }
}


