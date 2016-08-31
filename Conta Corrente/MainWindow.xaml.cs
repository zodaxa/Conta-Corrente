using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.IO;
using System.Windows.Media.Animation;

namespace Conta_Corrente
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        //List<Image> gListImagem = new List<Image>();
        string gMenuAtivado = "";
        string gApresentacaoAtivado = "";

        public MainWindow()
        {
            InitializeComponent();

            CarregarImagens();

            //if (File.Exists(Directory.GetCurrentDirectory() + @"\ABERTURA.mxf"))
            //{
            //    meAbertura.Visibility = Visibility.Visible;
            //    meAbertura.Source = new Uri(Directory.GetCurrentDirectory() + @"\ABERTURA.mxf");
            //    meAbertura.Play();
            //}
            //else
            //{
            //    meAbertura.Visibility = Visibility.Hidden;
            //}

        }

        private void EsconderExibicao(string pExibirSomente)
        {
            try
            {
                meSelecionado01.Visibility = Visibility.Hidden;
                meSelecionado02.Visibility = Visibility.Hidden;
                meSelecionado03.Visibility = Visibility.Hidden;
                meSelecionado04.Visibility = Visibility.Hidden;
                meSelecionado05.Visibility = Visibility.Hidden;
                meSelecionado06.Visibility = Visibility.Hidden;

                meSelecionado01.Tag = "FALSE";
                meSelecionado02.Tag = "FALSE";
                meSelecionado03.Tag = "FALSE";
                meSelecionado04.Tag = "FALSE";
                meSelecionado05.Tag = "FALSE";
                meSelecionado06.Tag = "FALSE";

                try
                {
                    meSelecionado01.Stop();
                    meSelecionado02.Stop();
                    meSelecionado03.Stop();
                    meSelecionado04.Stop();
                    meSelecionado05.Stop();
                    meSelecionado06.Stop();
                }
                catch (Exception X)
                {

                    throw;
                }

                switch (pExibirSomente)
                {
                    case "1":
                        meSelecionado01.Visibility = Visibility.Visible;

                        try
                        {
                            meSelecionado01.Play();
                            meSelecionado01.Tag = "TRUE";
                        }
                        catch (Exception E1)
                        {

                            throw;
                        }

                        break;

                    case "2":
                        meSelecionado02.Visibility = Visibility.Visible;

                        try
                        {
                            meSelecionado02.Play();
                            meSelecionado02.Tag = "TRUE";
                        }
                        catch (Exception E2)
                        {

                            throw;
                        }

                        break;

                    case "3":
                        meSelecionado03.Visibility = Visibility.Visible;

                        try
                        {
                            meSelecionado03.Play();
                            meSelecionado03.Tag = "TRUE";
                        }
                        catch (Exception E3)
                        {

                            throw;
                        }

                        break;

                    case "4":
                        meSelecionado04.Visibility = Visibility.Visible;

                        try
                        {
                            meSelecionado04.Play();
                            meSelecionado04.Tag = "TRUE";
                        }
                        catch (Exception E4)
                        {

                            throw;
                        }

                        break;

                    case "5":
                        meSelecionado05.Visibility = Visibility.Visible;

                        try
                        {
                            meSelecionado05.Play();
                            meSelecionado05.Tag = "TRUE";
                        }
                        catch (Exception E5)
                        {

                            throw;
                        }

                        break;

                    case "6":
                        meSelecionado06.Visibility = Visibility.Visible;

                        try
                        {
                            meSelecionado06.Play();
                            meSelecionado06.Tag = "TRUE";
                        }
                        catch (Exception E6)
                        {
                            throw;
                        }

                        break;
                }
            }
            catch (Exception E)
            {
                throw;
            }
        }

        private void CarregarImagens(string pTipo = "")
        {
            try
            {
                ImageBrush tbrush01 = new ImageBrush();
                tbrush01.Stretch = Stretch.Fill;
                tbrush01.ImageSource = new BitmapImage(new Uri(Directory.GetCurrentDirectory() + @"\IMAGENS\LOGO.PNG"));
                grdPrincipal.Background = tbrush01;

                EsconderExibicao("");

                switch (pTipo)
                {
                    case "1":
                        CarregarImagensMenu01();
                        break;

                    case "2":
                        CarregarImagensMenu02();
                        break;

                    case "3":
                        CarregarImagensMenu03();
                        break;

                    case "4":
                        CarregarImagensMenu04();
                        break;

                    case "5":
                        CarregarImagensMenu05();
                        break;

                    case "6":
                        CarregarImagensMenu06();
                        break;

                    case "7":
                        CarregarImagensMenu07();
                        break;

                    case "8":
                        CarregarImagensMenu08();
                        break;
                }           
            }
            catch (Exception E)
            {
                throw;
            }
        }

        private void CarregarImagensMenu01()
        {
            try
            {
                int vCont = 0;
                foreach (string itm in Directory.GetFiles(Directory.GetCurrentDirectory() + @"\IMAGENS\CATEGORIA_1"))
                {
                    vCont = vCont + 1;

                    switch (vCont)
                    {
                        case 1:
                            meSelecionado01.Source = new Uri(itm);
                            break;

                        case 2:
                            meSelecionado02.Source = new Uri(itm);
                            break;

                        case 3:
                            meSelecionado03.Source = new Uri(itm);
                            break;

                        case 4:
                            meSelecionado04.Source = new Uri(itm);
                            break;

                        case 5:
                            meSelecionado05.Source = new Uri(itm);
                            break;

                        case 6:
                            meSelecionado06.Source = new Uri(itm);
                            break;
                    }
                }
            }
            catch (Exception E)
            {
                throw;
            }
        }

        private void CarregarImagensMenu02()
        {
            try
            {
                int vCont = 0;
                foreach (string itm in Directory.GetFiles(Directory.GetCurrentDirectory() + @"\IMAGENS\CATEGORIA_2"))
                {
                    vCont = vCont + 1;

                    switch (vCont)
                    {
                        case 1:
                            meSelecionado01.Source = new Uri(itm);
                            break;

                        case 2:
                            meSelecionado02.Source = new Uri(itm);
                            break;

                        case 3:
                            meSelecionado03.Source = new Uri(itm);
                            break;

                        case 4:
                            meSelecionado04.Source = new Uri(itm);
                            break;

                        case 5:
                            meSelecionado05.Source = new Uri(itm);
                            break;

                        case 6:
                            meSelecionado06.Source = new Uri(itm);
                            break;
                    }
                }
            }
            catch (Exception E)
            {
                throw;
            }
        }

        private void CarregarImagensMenu03()
        {
            try
            {
                int vCont = 0;
                foreach (string itm in Directory.GetFiles(Directory.GetCurrentDirectory() + @"\IMAGENS\CATEGORIA_3"))
                {
                    vCont = vCont + 1;

                    switch (vCont)
                    {
                        case 1:
                            meSelecionado01.Source = new Uri(itm);
                            break;

                        case 2:
                            meSelecionado02.Source = new Uri(itm);
                            break;

                        case 3:
                            meSelecionado03.Source = new Uri(itm);
                            break;

                        case 4:
                            meSelecionado04.Source = new Uri(itm);
                            break;

                        case 5:
                            meSelecionado05.Source = new Uri(itm);
                            break;

                        case 6:
                            meSelecionado06.Source = new Uri(itm);
                            break;
                    }
                }
            }
            catch (Exception E)
            {
                throw;
            }
        }

        private void CarregarImagensMenu04()
        {
            try
            {
                int vCont = 0;
                foreach (string itm in Directory.GetFiles(Directory.GetCurrentDirectory() + @"\IMAGENS\CATEGORIA_4"))
                {
                    vCont = vCont + 1;

                    switch (vCont)
                    {
                        case 1:
                            meSelecionado01.Source = new Uri(itm);
                            break;

                        case 2:
                            meSelecionado02.Source = new Uri(itm);
                            break;

                        case 3:
                            meSelecionado03.Source = new Uri(itm);
                            break;

                        case 4:
                            meSelecionado04.Source = new Uri(itm);
                            break;

                        case 5:
                            meSelecionado05.Source = new Uri(itm);
                            break;

                        case 6:
                            meSelecionado06.Source = new Uri(itm);
                            break;
                    }
                }
            }
            catch (Exception E)
            {
                throw;
            }
        }

        private void CarregarImagensMenu05()
        {
            try
            {
                int vCont = 0;
                foreach (string itm in Directory.GetFiles(Directory.GetCurrentDirectory() + @"\IMAGENS\CATEGORIA_5"))
                {
                    vCont = vCont + 1;

                    switch (vCont)
                    {
                        case 1:
                            meSelecionado01.Source = new Uri(itm);
                            break;

                        case 2:
                            meSelecionado02.Source = new Uri(itm);
                            break;

                        case 3:
                            meSelecionado03.Source = new Uri(itm);
                            break;

                        case 4:
                            meSelecionado04.Source = new Uri(itm);
                            break;

                        case 5:
                            meSelecionado05.Source = new Uri(itm);
                            break;

                        case 6:
                            meSelecionado06.Source = new Uri(itm);
                            break;
                    }
                }
            }
            catch (Exception E)
            {
                throw;
            }
        }

        private void CarregarImagensMenu06()
        {
            try
            {
                int vCont = 0;
                foreach (string itm in Directory.GetFiles(Directory.GetCurrentDirectory() + @"\IMAGENS\CATEGORIA_6"))
                {
                    vCont = vCont + 1;

                    switch (vCont)
                    {
                        case 1:
                            meSelecionado01.Source = new Uri(itm);
                            break;

                        case 2:
                            meSelecionado02.Source = new Uri(itm);
                            break;

                        case 3:
                            meSelecionado03.Source = new Uri(itm);
                            break;

                        case 4:
                            meSelecionado04.Source = new Uri(itm);
                            break;

                        case 5:
                            meSelecionado05.Source = new Uri(itm);
                            break;

                        case 6:
                            meSelecionado06.Source = new Uri(itm);
                            break;
                    }
                }
            }
            catch (Exception E)
            {
                throw;
            }
        }

        private void CarregarImagensMenu07()
        {
            try
            {
                int vCont = 0;
                foreach (string itm in Directory.GetFiles(Directory.GetCurrentDirectory() + @"\IMAGENS\CATEGORIA_7"))
                {
                    vCont = vCont + 1;

                    switch (vCont)
                    {
                        case 1:
                            meSelecionado01.Source = new Uri(itm);
                            break;

                        case 2:
                            meSelecionado02.Source = new Uri(itm);
                            break;

                        case 3:
                            meSelecionado03.Source = new Uri(itm);
                            break;

                        case 4:
                            meSelecionado04.Source = new Uri(itm);
                            break;

                        case 5:
                            meSelecionado05.Source = new Uri(itm);
                            break;

                        case 6:
                            meSelecionado06.Source = new Uri(itm);
                            break;
                    }
                }
            }
            catch (Exception E)
            {
                throw;
            }
        }

        private void CarregarImagensMenu08()
        {
            try
            {
                int vCont = 0;
                foreach (string itm in Directory.GetFiles(Directory.GetCurrentDirectory() + @"\IMAGENS\CATEGORIA_8"))
                {
                    vCont = vCont + 1;

                    switch (vCont)
                    {
                        case 1:
                            meSelecionado01.Source = new Uri(itm);
                            break;

                        case 2:
                            meSelecionado02.Source = new Uri(itm);
                            break;

                        case 3:
                            meSelecionado03.Source = new Uri(itm);
                            break;

                        case 4:
                            meSelecionado04.Source = new Uri(itm);
                            break;

                        case 5:
                            meSelecionado05.Source = new Uri(itm);
                            break;

                        case 6:
                            meSelecionado06.Source = new Uri(itm);
                            break;
                    }
                }
            }
            catch (Exception E)
            {
                throw;
            }
        }

        private void imgSelecionarMenu01_MouseLeftButtonUp(object sender, MouseButtonEventArgs e)
        {
            try
            {
                DesativarInk();

                Image vSender = (Image)sender;
                CarregarImagens(vSender.Tag.ToString());
                DesmarcarTodoMenuInferior(vSender.Name.ToString());

                AtivarAnimacaoInferior(vSender.Name.ToString());
            }
            catch (Exception E)
            {
                throw;
            }
        }

        private void AtivarAnimacaoInferior(string pNome)
        {
            try
            {
                if (pNome != gMenuAtivado)
                {

                    Storyboard sbCrescer1 = this.FindResource("crescendo_inferior_1") as Storyboard;
                    Storyboard sbCrescer2 = this.FindResource("crescendo_inferior_2") as Storyboard;
                    Storyboard sbCrescer3 = this.FindResource("crescendo_inferior_3") as Storyboard;
                    Storyboard sbCrescer4 = this.FindResource("crescendo_inferior_4") as Storyboard;
                    Storyboard sbCrescer5 = this.FindResource("crescendo_inferior_5") as Storyboard;
                    Storyboard sbCrescer6 = this.FindResource("crescendo_inferior_6") as Storyboard;
                    Storyboard sbCrescer7 = this.FindResource("crescendo_inferiro_7_BKP") as Storyboard;
                    Storyboard sbCrescer8 = this.FindResource("crescendo_inferior_8") as Storyboard;

                    Storyboard sbDiminuir1 = this.FindResource("diminuir_inferior_1") as Storyboard;
                    Storyboard sbDiminuir2 = this.FindResource("diminuir_inferior_2") as Storyboard;
                    Storyboard sbDiminuir3 = this.FindResource("diminuir_inferior_3") as Storyboard;
                    Storyboard sbDiminuir4 = this.FindResource("diminuir_inferior_4") as Storyboard;
                    Storyboard sbDiminuir5 = this.FindResource("diminuir_inferior_5") as Storyboard;
                    Storyboard sbDiminuir6 = this.FindResource("diminuir_inferior_6") as Storyboard;
                    Storyboard sbDiminuir7 = this.FindResource("diminuir_inferior_7_BKP") as Storyboard;
                    Storyboard sbDiminuir8 = this.FindResource("diminuir_inferior_8") as Storyboard;

                    switch (gMenuAtivado)
                    {
                        case "imgSelecionarMenu01":
                            sbDiminuir1.Begin();
                            break;

                        case "imgSelecionarMenu02":
                            sbDiminuir2.Begin();
                            break;

                        case "imgSelecionarMenu03":
                            sbDiminuir3.Begin();
                            break;

                        case "imgSelecionarMenu04":
                            sbDiminuir4.Begin();
                            break;

                        case "imgSelecionarMenu05":
                            sbDiminuir5.Begin();
                            break;

                        case "imgSelecionarMenu06":
                            sbDiminuir6.Begin();
                            break;

                        case "imgSelecionarMenu07":
                            sbDiminuir7.Begin();
                            break;

                        case "imgSelecionarMenu08":
                            sbDiminuir8.Begin();
                            break;

                        case "":

                            break;
                    }

                    switch (pNome)
                    {
                        case "imgSelecionarMenu01":
                            sbCrescer1.Begin();

                            gMenuAtivado = pNome;
                            break;

                        case "imgSelecionarMenu02":
                            sbCrescer2.Begin();

                            gMenuAtivado = pNome;
                            break;

                        case "imgSelecionarMenu03":
                            sbCrescer3.Begin();

                            gMenuAtivado = pNome;
                            break;

                        case "imgSelecionarMenu04":
                            sbCrescer4.Begin();

                            gMenuAtivado = pNome;
                            break;

                        case "imgSelecionarMenu05":
                            sbCrescer5.Begin();

                            gMenuAtivado = pNome;
                            break;

                        case "imgSelecionarMenu06":
                            sbCrescer6.Begin();

                            gMenuAtivado = pNome;
                            break;

                        case "imgSelecionarMenu07":
                            sbCrescer7.Begin();

                            gMenuAtivado = pNome;
                            break;

                        case "imgSelecionarMenu08":
                            sbCrescer8.Begin();

                            gMenuAtivado = pNome;
                            break;
                    }
                }
            }
            catch (Exception E)
            {
                throw;
            }
        }

        private void DesmarcarTodoMenuInferior(string pMenu)
        {
            try
            {
                BitmapImage vImagemDesativado01 = new BitmapImage(new Uri(Directory.GetCurrentDirectory() + @"\MENUS\MENU_1_DESATIVADO.PNG"));
                imgSelecionarMenu01.Source = vImagemDesativado01;

                BitmapImage vImagemDesativado02 = new BitmapImage(new Uri(Directory.GetCurrentDirectory() + @"\MENUS\MENU_2_DESATIVADO.PNG"));
                imgSelecionarMenu02.Source = vImagemDesativado02;

                BitmapImage vImagemDesativado03 = new BitmapImage(new Uri(Directory.GetCurrentDirectory() + @"\MENUS\MENU_3_DESATIVADO.PNG"));
                imgSelecionarMenu03.Source = vImagemDesativado03;

                BitmapImage vImagemDesativado04 = new BitmapImage(new Uri(Directory.GetCurrentDirectory() + @"\MENUS\MENU_4_DESATIVADO.PNG"));
                imgSelecionarMenu04.Source = vImagemDesativado04;

                BitmapImage vImagemDesativado05 = new BitmapImage(new Uri(Directory.GetCurrentDirectory() + @"\MENUS\MENU_5_DESATIVADO.PNG"));
                imgSelecionarMenu05.Source = vImagemDesativado05;

                BitmapImage vImagemDesativado06 = new BitmapImage(new Uri(Directory.GetCurrentDirectory() + @"\MENUS\MENU_6_DESATIVADO.PNG"));
                imgSelecionarMenu06.Source = vImagemDesativado06;

                BitmapImage vImagemDesativado07 = new BitmapImage(new Uri(Directory.GetCurrentDirectory() + @"\MENUS\MENU_7_DESATIVADO.PNG"));
                imgSelecionarMenu07.Source = vImagemDesativado07;

                BitmapImage vImagemDesativado08 = new BitmapImage(new Uri(Directory.GetCurrentDirectory() + @"\MENUS\MENU_8_DESATIVADO.PNG"));
                imgSelecionarMenu08.Source = vImagemDesativado08;

                switch (pMenu)
                {
                    case "imgSelecionarMenu01":
                        BitmapImage vImagemativado01 = new BitmapImage(new Uri(Directory.GetCurrentDirectory() + @"\MENUS\MENU_1_ATIVO.PNG"));
                        imgSelecionarMenu01.Source = vImagemativado01;
                        break;

                    case "imgSelecionarMenu02":
                        BitmapImage vImagemativado02 = new BitmapImage(new Uri(Directory.GetCurrentDirectory() + @"\MENUS\MENU_2_ATIVO.PNG"));
                        imgSelecionarMenu02.Source = vImagemativado02;
                        break;

                    case "imgSelecionarMenu03":
                        BitmapImage vImagemativado03 = new BitmapImage(new Uri(Directory.GetCurrentDirectory() + @"\MENUS\MENU_3_ATIVO.PNG"));
                        imgSelecionarMenu03.Source = vImagemativado03;
                        break;

                    case "imgSelecionarMenu04":
                        BitmapImage vImagemativado04 = new BitmapImage(new Uri(Directory.GetCurrentDirectory() + @"\MENUS\MENU_4_ATIVO.PNG"));
                        imgSelecionarMenu04.Source = vImagemativado04;
                        break;

                    case "imgSelecionarMenu05":
                        BitmapImage vImagemativado05 = new BitmapImage(new Uri(Directory.GetCurrentDirectory() + @"\MENUS\MENU_5_ATIVO.PNG"));
                        imgSelecionarMenu05.Source = vImagemativado05;
                        break;

                    case "imgSelecionarMenu06":
                        BitmapImage vImagemativado06 = new BitmapImage(new Uri(Directory.GetCurrentDirectory() + @"\MENUS\MENU_6_ATIVO.PNG"));
                        imgSelecionarMenu06.Source = vImagemativado06;
                        break;

                    case "imgSelecionarMenu07":
                        BitmapImage vImagemativado07 = new BitmapImage(new Uri(Directory.GetCurrentDirectory() + @"\MENUS\MENU_7_ATIVO.PNG"));
                        imgSelecionarMenu07.Source = vImagemativado07;
                        break;

                    case "imgSelecionarMenu08":
                        BitmapImage vImagemativado08 = new BitmapImage(new Uri(Directory.GetCurrentDirectory() + @"\MENUS\MENU_8_ATIVO.PNG"));
                        imgSelecionarMenu08.Source = vImagemativado08;
                        break;
                }
            }
            catch (Exception E)
            {

                throw;
            }
        }

        private void imgSelecionarApresentacao01_MouseLeftButtonUp(object sender, MouseButtonEventArgs e)
        {
            try
            {
                DesativarInk();              

                Image vSender = (Image)sender;
                EsconderExibicao(vSender.Tag.ToString());

                DesmarcarTodoMenuLateral(vSender.Name.ToString());

                AtivarAnimacaoLateral(vSender.Name.ToString());
            }
            catch (Exception E)
            {
                throw;
            }
        }

        private void AtivarAnimacaoLateral(string pNome)
        {
            try
            {
                if (gApresentacaoAtivado != pNome)
                {

                    Storyboard sbCrescer1 = this.FindResource("crescendo_lateral_1") as Storyboard;
                    Storyboard sbCrescer2 = this.FindResource("crescendo_lateral_2") as Storyboard;
                    Storyboard sbCrescer3 = this.FindResource("crescendo_lateral_3") as Storyboard;
                    Storyboard sbCrescer4 = this.FindResource("crescendo_lateral_4") as Storyboard;
                    Storyboard sbCrescer5 = this.FindResource("crescendo_lateral_5") as Storyboard;
                    Storyboard sbCrescer6 = this.FindResource("crescendo_lateral_6") as Storyboard;

                    Storyboard sbDiminuir1 = this.FindResource("diminuir_lateral_1") as Storyboard;
                    Storyboard sbDiminuir2 = this.FindResource("diminuir_lateral_2") as Storyboard;
                    Storyboard sbDiminuir3 = this.FindResource("diminuir_lateral_3") as Storyboard;
                    Storyboard sbDiminuir4 = this.FindResource("diminuir_lateral_4") as Storyboard;
                    Storyboard sbDiminuir5 = this.FindResource("diminuir_lateral_5") as Storyboard;
                    Storyboard sbDiminuir6 = this.FindResource("diminuir_lateral_6") as Storyboard;

                    Storyboard sbCrescerMidia1 = this.FindResource("principal_crescendo_1") as Storyboard;
                    Storyboard sbCrescerMidia2 = this.FindResource("principal_crescendo_2") as Storyboard;
                    Storyboard sbCrescerMidia3 = this.FindResource("principal_crescendo_3") as Storyboard;
                    Storyboard sbCrescerMidia4 = this.FindResource("principal_crescendo_4") as Storyboard;
                    Storyboard sbCrescerMidia5 = this.FindResource("principal_crescendo_5") as Storyboard;
                    Storyboard sbCrescerMidia6 = this.FindResource("principal_crescendo_6") as Storyboard;

                    Storyboard sbDiminuirMidia1 = this.FindResource("principal_diminuindo_1") as Storyboard;
                    Storyboard sbDiminuirMidia2 = this.FindResource("principal_diminuindo_2") as Storyboard;
                    Storyboard sbDiminuirMidia3 = this.FindResource("principal_diminuindo_3") as Storyboard;
                    Storyboard sbDiminuirMidia4 = this.FindResource("principal_diminuindo_4") as Storyboard;
                    Storyboard sbDiminuirMidia5 = this.FindResource("principal_diminuindo_5") as Storyboard;
                    Storyboard sbDiminuirMidia6 = this.FindResource("principal_diminuindo_6") as Storyboard;

                    switch (gApresentacaoAtivado)
                    {
                        case "imgSelecionarApresentacao01":
                            sbDiminuir1.Begin();
                            sbDiminuirMidia1.Begin();
                            break;

                        case "imgSelecionarApresentacao02":
                            sbDiminuir2.Begin();
                            sbDiminuirMidia2.Begin();
                            break;

                        case "imgSelecionarApresentacao03":
                            sbDiminuir3.Begin();
                            sbDiminuirMidia3.Begin();
                            break;

                        case "imgSelecionarApresentacao04":
                            sbDiminuir4.Begin();
                            sbDiminuirMidia4.Begin();
                            break;

                        case "imgSelecionarApresentacao05":
                            sbDiminuir5.Begin();
                            sbDiminuirMidia5.Begin();
                            break;

                        case "imgSelecionarApresentacao06":
                            sbDiminuir6.Begin();
                            sbDiminuirMidia6.Begin();
                            break;

                        case "":

                            break;
                    }

                    switch (pNome)
                    {
                        case "imgSelecionarApresentacao01":
                            sbCrescer1.Begin();
                            sbCrescerMidia1.Begin();

                            gApresentacaoAtivado = pNome;
                            break;

                        case "imgSelecionarApresentacao02":
                            sbCrescer2.Begin();
                            sbCrescerMidia2.Begin();

                            gApresentacaoAtivado = pNome;
                            break;

                        case "imgSelecionarApresentacao03":
                            sbCrescer3.Begin();
                            sbCrescerMidia3.Begin();

                            gApresentacaoAtivado = pNome;
                            break;

                        case "imgSelecionarApresentacao04":
                            sbCrescer4.Begin();
                            sbCrescerMidia4.Begin();

                            gApresentacaoAtivado = pNome;
                            break;

                        case "imgSelecionarApresentacao05":
                            sbCrescer5.Begin();
                            sbCrescerMidia5.Begin();

                            gApresentacaoAtivado = pNome;
                            break;

                        case "imgSelecionarApresentacao06":
                            sbCrescer6.Begin();
                            sbCrescerMidia6.Begin();

                            gApresentacaoAtivado = pNome;
                            break;
                    }
                }
            }
            catch (Exception E)
            {
                throw;
            }
        }

        private void DesmarcarTodoMenuLateral(string pMenu)
        {
            try
            {
                BitmapImage vImagemDesativado01 = new BitmapImage(new Uri(Directory.GetCurrentDirectory() + @"\MENUS\APRESENTACAO_1_DESATIVADO.PNG"));
                imgSelecionarApresentacao01.Source = vImagemDesativado01;

                BitmapImage vImagemDesativado02 = new BitmapImage(new Uri(Directory.GetCurrentDirectory() + @"\MENUS\APRESENTACAO_2_DESATIVADO.PNG"));
                imgSelecionarApresentacao02.Source = vImagemDesativado02;

                BitmapImage vImagemDesativado03 = new BitmapImage(new Uri(Directory.GetCurrentDirectory() + @"\MENUS\APRESENTACAO_3_DESATIVADO.PNG"));
                imgSelecionarApresentacao03.Source = vImagemDesativado03;

                BitmapImage vImagemDesativado04 = new BitmapImage(new Uri(Directory.GetCurrentDirectory() + @"\MENUS\APRESENTACAO_4_DESATIVADO.PNG"));
                imgSelecionarApresentacao04.Source = vImagemDesativado04;

                BitmapImage vImagemDesativado05 = new BitmapImage(new Uri(Directory.GetCurrentDirectory() + @"\MENUS\APRESENTACAO_5_DESATIVADO.PNG"));
                imgSelecionarApresentacao05.Source = vImagemDesativado05;

                BitmapImage vImagemDesativado06 = new BitmapImage(new Uri(Directory.GetCurrentDirectory() + @"\MENUS\APRESENTACAO_6_DESATIVADO.PNG"));
                imgSelecionarApresentacao06.Source = vImagemDesativado06;

                switch (pMenu)
                {
                    case "imgSelecionarApresentacao01":
                        BitmapImage vImagemativado01 = new BitmapImage(new Uri(Directory.GetCurrentDirectory() + @"\MENUS\APRESENTACAO_1_ATIVO.PNG"));
                        imgSelecionarApresentacao01.Source = vImagemativado01;
                        break;

                    case "imgSelecionarApresentacao02":
                        BitmapImage vImagemativado02 = new BitmapImage(new Uri(Directory.GetCurrentDirectory() + @"\MENUS\APRESENTACAO_2_ATIVO.PNG"));
                        imgSelecionarApresentacao02.Source = vImagemativado02;
                        break;

                    case "imgSelecionarApresentacao03":
                        BitmapImage vImagemativado03 = new BitmapImage(new Uri(Directory.GetCurrentDirectory() + @"\MENUS\APRESENTACAO_3_ATIVO.PNG"));
                        imgSelecionarApresentacao03.Source = vImagemativado03;
                        break;

                    case "imgSelecionarApresentacao04":
                        BitmapImage vImagemativado04 = new BitmapImage(new Uri(Directory.GetCurrentDirectory() + @"\MENUS\APRESENTACAO_4_ATIVO.PNG"));
                        imgSelecionarApresentacao04.Source = vImagemativado04;
                        break;

                    case "imgSelecionarApresentacao05":
                        BitmapImage vImagemativado05 = new BitmapImage(new Uri(Directory.GetCurrentDirectory() + @"\MENUS\APRESENTACAO_5_ATIVO.PNG"));
                        imgSelecionarApresentacao05.Source = vImagemativado05;
                        break;

                    case "imgSelecionarApresentacao06":
                        BitmapImage vImagemativado06 = new BitmapImage(new Uri(Directory.GetCurrentDirectory() + @"\MENUS\APRESENTACAO_6_ATIVO.PNG"));
                        imgSelecionarApresentacao06.Source = vImagemativado06;
                        break;                
                }
            }
            catch (Exception E)
            {

                throw;
            }
        }

        private void DesativarInk()
        {
            try
            {
                inkTrabalho.Strokes.Clear();
                inkTrabalho.IsEnabled = false;
            }
            catch (Exception E)
            {
                throw;
            }
        }

        private void AtivarInk()
        {
            try
            {
                if (inkTrabalho.IsEnabled == false)
                {
                    inkTrabalho.IsEnabled = true;
                    inkTrabalho.EditingMode = InkCanvasEditingMode.Ink;
                    inkTrabalho.DefaultDrawingAttributes.Color = Color.FromRgb(255, 0, 0);

                    inkTrabalho.Visibility = Visibility.Visible;
                }
                else if (inkTrabalho.IsEnabled == true)
                {
                    inkTrabalho.IsEnabled = false;

                    inkTrabalho.Visibility = Visibility.Hidden;
                }
            }
            catch (Exception E)
            {
                throw;
            }
        }

        private void imgSelecionarMenu09_MouseLeftButtonUp(object sender, MouseButtonEventArgs e)
        {
            try
            {
                AtivarInk();
            }
            catch (Exception E)
            {
                throw;
            }
        }

        private void imgSelecionarMenu10_MouseLeftButtonUp(object sender, MouseButtonEventArgs e)
        {
            try
            {
                DesativarInk();
            }
            catch (Exception E)
            {
                throw;
            }
        }

        private void meSelecionado01_MouseLeftButtonUp(object sender, MouseButtonEventArgs e)
        {
            try
            {
                MediaElement vSender = (MediaElement)sender;
                if (vSender.Tag.ToString() == "FALSE")
                {
                    vSender.Tag = "TRUE";
                    vSender.Play();
                }
                else if (vSender.Tag.ToString() == "TRUE")
                {
                    vSender.Tag = "FALSE";
                    vSender.Pause();
                }
            }
            catch (Exception E)
            {
                throw;
            }
        }

        private void inkTrabalho_MouseLeftButtonUp(object sender, MouseButtonEventArgs e)
        {
            try
            {

            }
            catch (Exception E)
            {
                throw;
            }
        }

        private void meAbertura_MediaEnded(object sender, RoutedEventArgs e)
        {
            try
            {
                meAbertura.Visibility = Visibility.Hidden;
            }
            catch (Exception E)
            {

                throw;
            }
        }
    }
}
