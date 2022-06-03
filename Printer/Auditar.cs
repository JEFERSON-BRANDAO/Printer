using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Classes;
using System.Media;
using System.Data.OleDb;
using System.Collections;
//using System.Data.OracleClient.OracleType;
using System.Data.OracleClient;

// ===============================
// AUTHOR       : JEFFERSON BRANDÃO DA COSTA - ANALISTA/PROGRAMADOR
// CREATE DATE  : 03/04/2018  dd/mm/yyyy
// DESCRIPTION  : registrar seriais na estação PRINTER
// SPECIAL NOTES: 
// ===============================
// Change History: version 1.0.0 
// Date: 
//==================================

namespace Printer
{
    public partial class Auditar : Form
    {
        Conexao stringConexao_ = new Conexao();
        string connectionString_ = string.Empty;
        private IList _parametros = new ArrayList();
        //
        public Auditar()
        {
            InitializeComponent();
            connectionString_ = stringConexao_.Caminho();//string de conexão
            //
            #region RODAPÉ

            int anoCriacao = 2018;
            int anoAtual = DateTime.Now.Year;
            string texto = anoCriacao == anoAtual ? " Foxconn CNSBG All Rights Reserved." : "-" + anoAtual + " Foxconn CNSBG All Rights Reserved.";
            //
            lbRodape.Text = "Copyright © " + anoCriacao + texto;

            #endregion
            //
            lbAviso.Visible = false;

            string nomeLinha = Linha();
            //BOT
            rdbBOTa.Text = "PRINTB-" + nomeLinha + "A";//LADO A
            rdbBOTb.Text = "PRINTB-" + nomeLinha + "B";//LADO B
            //TOP
            rdbTOPa.Text = "PRINTT-" + nomeLinha + "A";//LADO A
            rdbTOPb.Text = "PRINTT-" + nomeLinha + "B";//LADO B
            //
            Text = "Printer V1.0.1      [LINHA: " + Linha() + "]";

        }

        public bool ExisteRota()
        {
            string status = string.Empty;
            //
            try
            {
                string caminho = AppDomain.CurrentDomain.BaseDirectory + @"\CONFIG\STATION_NO.txt";
                string linha;
                int row = 0;
                //
                if (System.IO.File.Exists(caminho))
                {
                    System.IO.StreamReader arqTXT = new System.IO.StreamReader(caminho);
                    //
                    while ((linha = arqTXT.ReadLine()) != null)
                    {
                        #region ROTA

                        if (row == 2)//3ra linha do arquivo STATION_NO.txt
                        {
                            for (int indice = 0; indice < linha.Length; indice++)
                            {
                                if (indice > 4)
                                {
                                    status += linha[indice];
                                }
                            }
                        }
                        #endregion
                        //                      
                        row++;
                    }
                    //
                    arqTXT.Close();
                }
            }
            catch (Exception erro)
            {
                lbAviso.ForeColor = System.Drawing.Color.Red;
                lbAviso.Text = erro.Message;
                lbAviso.Visible = true;
            }

            return status.Trim() == "1" ? true : false;

        }

        public string Estacao(string lado)
        {
            string nome_estacao = string.Empty;
            string PRINTB_STATION = string.Empty;
            string PRINTT_STATION = string.Empty;
            //
            try
            {
                string caminho = AppDomain.CurrentDomain.BaseDirectory + @"\CONFIG\STATION_NO.txt";
                string linha;
                int row = 0;
                //
                if (System.IO.File.Exists(caminho))
                {
                    System.IO.StreamReader arqTXT = new System.IO.StreamReader(caminho);
                    //
                    while ((linha = arqTXT.ReadLine()) != null)
                    {
                        //STATION_NO IN C_GW28_CONFIG
                        if (lado.Contains("PRINTB"))
                        {
                            #region ESTAÇÃO PRINTB

                            if (row == 0)//1ra linha do .txt
                            {
                                for (int indice = 0; indice < linha.Length; indice++)
                                {
                                    if (indice > 3)
                                    {
                                        PRINTB_STATION += linha[indice];
                                    }
                                }
                                //
                                nome_estacao = PRINTB_STATION;
                            }

                            #endregion
                        }
                        else
                        {
                            #region ESTAÇÃO PRINTT

                            if (row == 1)//2da linha do .txt
                            {
                                for (int indice = 0; indice < linha.Length; indice++)
                                {
                                    if (indice > 3)
                                    {
                                        PRINTT_STATION += linha[indice];
                                    }
                                }
                                //
                                nome_estacao = PRINTT_STATION;
                            }

                            #endregion
                        }
                        //                      
                        row++;
                    }
                    //
                    arqTXT.Close();
                }
            }
            catch (Exception erro)
            {
                lbAviso.ForeColor = System.Drawing.Color.Red;
                lbAviso.Text = erro.Message;
                lbAviso.Visible = true;
            }
            //
            return nome_estacao.Trim().ToUpper();
        }


        public string Linha()
        {
            string nome_linha = string.Empty;
            //
            try
            {
                string caminho = AppDomain.CurrentDomain.BaseDirectory + @"\CONFIG\LINHA.txt";
                string linha;
                //
                if (System.IO.File.Exists(caminho))
                {
                    System.IO.StreamReader arqTXT = new System.IO.StreamReader(caminho);
                    //
                    while ((linha = arqTXT.ReadLine()) != null)
                    {
                        for (int indice = 0; indice < linha.Length; indice++)
                        {

                            nome_linha += linha[indice];
                        }

                    }
                    //
                    arqTXT.Close();
                }
            }
            catch (Exception erro)
            {
                lbAviso.ForeColor = System.Drawing.Color.Red;
                lbAviso.Text = erro.Message;
                lbAviso.Visible = true;
            }
            //
            return nome_linha.Trim().ToUpper();
        }


        protected override void OnShown(EventArgs e)
        {
            txtSerial.Focus();
            // base.OnShown(e);
        }
        //
        #region SOM AVISO

        private void SomErro()
        {
            try
            {
                string caminho = AppDomain.CurrentDomain.BaseDirectory;
                SoundPlayer som = new SoundPlayer(caminho + "/sound/fail.wav");
                som.Play();
            }
            catch (Exception ex)
            {
                string erro = ex.Message;

            }
        }
        //
        private void SomOk()
        {
            try
            {
                string caminho = AppDomain.CurrentDomain.BaseDirectory;
                SoundPlayer som = new SoundPlayer(caminho + "/sound/pass.wav");
                som.Play();
            }
            catch (Exception ex)
            {
                string erro = ex.Message;
            }
        }

        #endregion
        //
        private void txtSerial_KeyUp(object sender, KeyEventArgs e)
        {
            string mensagem_ = string.Empty;
            //
            if (e.KeyCode == Keys.Enter)
            {
                //Do something
                e.Handled = true;
                //
                string serial = txtSerial.Text.Trim().ToUpper();
                if (!string.IsNullOrEmpty(serial))
                {
                    try
                    {
                        mensagem_ = ExecutarProcedure(serial.Trim().ToUpper());
                        //
                        if (mensagem_.Remove(2) == "OK")
                        {
                            lbAviso.ForeColor = System.Drawing.Color.Green;
                            lbAviso.Visible = true;
                            lbAviso.Text = mensagem_;
                            //
                            SomOk();
                        }
                        else
                        {
                            lbAviso.ForeColor = System.Drawing.Color.Red;
                            lbAviso.Visible = true;
                            lbAviso.Text = mensagem_;
                            //
                            SomErro();
                        }
                    }
                    catch (Exception erro)
                    {
                        lbAviso.ForeColor = System.Drawing.Color.Red;
                        lbAviso.Visible = true;
                        lbAviso.Text = mensagem_ + " - " + erro;
                        //
                        SomErro();
                    }
                }
                //
                txtSerial.SelectAll();//deixa selecionado valor
            }
        }

        public string ExecutarProcedure(string sn)
        {
            OracleConnection conexao = new OracleConnection(connectionString_);
            //
            string retorno = string.Empty;
            string lado = string.Empty;
            string nomeProcedure = string.Empty;

            //BOT
            if (rdbBOTa.Checked)
            {
                lado = rdbBOTa.Text;//LINHA + LADO A
            }
            else if (rdbBOTb.Checked)
            {
                lado = rdbBOTb.Text;//LINHA + LADO B
            }
            //TOP
            else if (rdbTOPa.Checked)
            {
                lado = rdbTOPa.Text;//LINHA + LADO A
            }
            else if (rdbTOPb.Checked)
            {
                lado = rdbTOPb.Text;//LINHA + LADO B
            }

            //
            if (ExisteRota())
            {
                nomeProcedure = "CMC_PRINTER_TEST_CENTER";
            }
            else
            {
                nomeProcedure = "CMC_PRINTER_SEM_ROTA";
            }

            //
            string nome_estacao = Estacao(lado);
            //
            try
            {
                #region PROCEDURE

                OracleCommand cmd = new OracleCommand();
                cmd.Connection = conexao;//Conexao_ORA("banco", "usuario", "senha");
                conexao.Open();
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = nomeProcedure;
                //
                cmd.Parameters.Clear();
                cmd.Parameters.Add("VAR_MYDATA", OracleType.VarChar).Value = sn;//serial SN               
                cmd.Parameters.Add("VAR_STATIONNO", OracleType.VarChar).Value = nome_estacao;
                cmd.Parameters.Add("VAR_SIDE", OracleType.VarChar).Value = lado;//ladoA/ladoB; 
                cmd.Parameters.Add("VAR_RES", OracleType.VarChar, 50).Direction = ParameterDirection.Output;
                //
                cmd.ExecuteReader();
                retorno = cmd.Parameters["VAR_RES"].Value.ToString();

                #endregion

            }
            catch (Exception ex)
            {
                retorno = ex.Message;
            }
            finally
            {
                conexao.Close();
            }
            //
            return retorno;
        }


    }
}
