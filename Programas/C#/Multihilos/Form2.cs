using System;
using System.Drawing;
using System.Diagnostics;
using System.Data;
using Microsoft.VisualBasic;
using System.Collections;
using System.Windows.Forms;
using Multihilos;

namespace Multihilos
{
    public class Form2 : System.Windows.Forms.Form
    {
        #region Default Instance

        private static Form2 defaultInstance;
        /// <summary>
        /// Added by the VB.Net to C# Converter to support default instance behavour in C#
        /// </summary>
        public static Form2 Default
        {
            get
            {
                if (defaultInstance == null)
                {
                    defaultInstance = new Form2();
                    defaultInstance.FormClosed += new
                    System.Windows.Forms.FormClosedEventHandler(defaultInstance_FormClosed);

                }
                return defaultInstance;
            }
            set
            {
                defaultInstance = value;
            }
        }
        static void defaultInstance_FormClosed(object sender,

        System.Windows.Forms.FormClosedEventArgs e)

        {
            defaultInstance = null;
        }
        #endregion
        #region Código generado por el Diseñador de Windows Forms

        public Form2()
        {
            //El Diseñador de Windows Forms requiere esta llamada.
            InitializeComponent();
            //Added to support default instance behavour in C#
            if (defaultInstance == null)
                defaultInstance = this;
            //Agregar cualquier inicialización después de la llamada a InitializeComponent()
        
}
        //Form reemplaza a Dispose para limpiar la lista de componentes.
    

    protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                if (!(ReferenceEquals(components, null)))
                {
                    components.Dispose();
                }
            }
            base.Dispose(disposing);
        }
        internal Button BotonCerrar1;
        internal ToolTip ToolTip1;
        internal Label LabelInfo1;
        internal Label LabelInfo2;
        internal Button BotonCerrar2;

        private System.ComponentModel.IContainer components;
        //NOTA: el Diseñador de Windows Forms requiere el siguiente procedimiento
        //Puede modificarse utilizando el Diseñador de Windows Forms.
        //No lo modifique con el editor de código.
        [System.Diagnostics.DebuggerStepThrough()] private void
        InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2));
            this.BotonCerrar1 = new System.Windows.Forms.Button();
            this.ToolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.LabelInfo1 = new System.Windows.Forms.Label();
            this.LabelInfo2 = new System.Windows.Forms.Label();
            this.BotonCerrar2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // BotonCerrar1
            // 
            this.BotonCerrar1.AutoSize = true;
            this.BotonCerrar1.BackColor = System.Drawing.Color.Plum;
            this.BotonCerrar1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BotonCerrar1.Font = new System.Drawing.Font("Verdana", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BotonCerrar1.Location = new System.Drawing.Point(127, 98);
            this.BotonCerrar1.Name = "BotonCerrar1";
            this.BotonCerrar1.Size = new System.Drawing.Size(96, 37);
            this.BotonCerrar1.TabIndex = 1;
            this.BotonCerrar1.Text = "Cerrar";
            this.ToolTip1.SetToolTip(this.BotonCerrar1, "Cerrar los 2 formularios y salir de la aplicación");
            this.BotonCerrar1.UseVisualStyleBackColor = false;
            this.BotonCerrar1.Click += new System.EventHandler(this.BotonCerrar_Click);
            // 
            // LabelInfo1
            // 
            this.LabelInfo1.AutoSize = true;
            this.LabelInfo1.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelInfo1.Location = new System.Drawing.Point(89, 52);
            this.LabelInfo1.Name = "LabelInfo1";
            this.LabelInfo1.Size = new System.Drawing.Size(193, 38);
            this.LabelInfo1.TabIndex = 0;
            this.LabelInfo1.Text = "Cerrar los 2 formularios\ny salir de la aplicación.";
            this.LabelInfo1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // LabelInfo2
            // 
            this.LabelInfo2.AutoSize = true;
            this.LabelInfo2.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelInfo2.Location = new System.Drawing.Point(110, 186);
            this.LabelInfo2.Name = "LabelInfo2";
            this.LabelInfo2.Size = new System.Drawing.Size(140, 38);
            this.LabelInfo2.TabIndex = 2;
            this.LabelInfo2.Text = "Cerrar solamente\r\neste formulario.";
            this.LabelInfo2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // BotonCerrar2
            // 
            this.BotonCerrar2.AutoSize = true;
            this.BotonCerrar2.BackColor = System.Drawing.Color.Plum;
            this.BotonCerrar2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BotonCerrar2.Font = new System.Drawing.Font("Verdana", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BotonCerrar2.Location = new System.Drawing.Point(127, 234);
            this.BotonCerrar2.Name = "BotonCerrar2";
            this.BotonCerrar2.Size = new System.Drawing.Size(96, 37);
            this.BotonCerrar2.TabIndex = 3;
            this.BotonCerrar2.Text = "Cerrar";
            this.BotonCerrar2.UseVisualStyleBackColor = false;
            this.BotonCerrar2.Click += new System.EventHandler(this.BotonCerrar2_Click);
            // 
            // Form2
            // 
            this.AutoScaleBaseSize = new System.Drawing.Size(6, 15);
            this.BackColor = System.Drawing.Color.Thistle;
            this.BackgroundImage = global::Multihilos.Properties.Resources.montanas_con_ciudad_y_planeta_de_fondo_5120x2880_xtrafondos_com;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(352, 349);
            this.ControlBox = false;
            this.Controls.Add(this.BotonCerrar2);
            this.Controls.Add(this.LabelInfo2);
            this.Controls.Add(this.LabelInfo1);
            this.Controls.Add(this.BotonCerrar1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form2";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "Form2 - Hilo 2 C#";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }
        #endregion

        private void Form2_Load(System.Object sender, System.EventArgs e)

        {
            //posición del formulario
            this.Top = 220;
            this.Left = 220 + Form1.Default.Width;
        }
        //Cerrar los 2 formularios y salir de la aplicación
        private void BotonCerrar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        //Cerrar este formulario sin salir de la aplicación.
        private void BotonCerrar2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}