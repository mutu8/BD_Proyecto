
namespace CapaPresentacion
{
    partial class frmListado
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmListado));
            this.dgvCliente = new System.Windows.Forms.DataGridView();
            this.btnListar = new System.Windows.Forms.Button();
            this.dgvOrigen = new System.Windows.Forms.DataGridView();
            this.dgvDestino = new System.Windows.Forms.DataGridView();
            this.dgvItinerario = new System.Windows.Forms.DataGridView();
            this.dgvEmpresa = new System.Windows.Forms.DataGridView();
            this.dgvPasaje = new System.Windows.Forms.DataGridView();
            this.dgvViaje = new System.Windows.Forms.DataGridView();
            this.Clientes = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCliente)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvOrigen)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDestino)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvItinerario)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEmpresa)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPasaje)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvViaje)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvCliente
            // 
            this.dgvCliente.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            resources.ApplyResources(this.dgvCliente, "dgvCliente");
            this.dgvCliente.Name = "dgvCliente";
            // 
            // btnListar
            // 
            resources.ApplyResources(this.btnListar, "btnListar");
            this.btnListar.Name = "btnListar";
            this.btnListar.UseVisualStyleBackColor = true;
            this.btnListar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // dgvOrigen
            // 
            this.dgvOrigen.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            resources.ApplyResources(this.dgvOrigen, "dgvOrigen");
            this.dgvOrigen.Name = "dgvOrigen";
            // 
            // dgvDestino
            // 
            this.dgvDestino.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            resources.ApplyResources(this.dgvDestino, "dgvDestino");
            this.dgvDestino.Name = "dgvDestino";
            // 
            // dgvItinerario
            // 
            this.dgvItinerario.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            resources.ApplyResources(this.dgvItinerario, "dgvItinerario");
            this.dgvItinerario.Name = "dgvItinerario";
            // 
            // dgvEmpresa
            // 
            this.dgvEmpresa.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            resources.ApplyResources(this.dgvEmpresa, "dgvEmpresa");
            this.dgvEmpresa.Name = "dgvEmpresa";
            // 
            // dgvPasaje
            // 
            this.dgvPasaje.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            resources.ApplyResources(this.dgvPasaje, "dgvPasaje");
            this.dgvPasaje.Name = "dgvPasaje";
            // 
            // dgvViaje
            // 
            this.dgvViaje.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            resources.ApplyResources(this.dgvViaje, "dgvViaje");
            this.dgvViaje.Name = "dgvViaje";
            // 
            // Clientes
            // 
            resources.ApplyResources(this.Clientes, "Clientes");
            this.Clientes.Name = "Clientes";
            // 
            // label1
            // 
            resources.ApplyResources(this.label1, "label1");
            this.label1.Name = "label1";
            // 
            // label2
            // 
            resources.ApplyResources(this.label2, "label2");
            this.label2.Name = "label2";
            // 
            // label3
            // 
            resources.ApplyResources(this.label3, "label3");
            this.label3.Name = "label3";
            // 
            // label4
            // 
            resources.ApplyResources(this.label4, "label4");
            this.label4.Name = "label4";
            // 
            // label5
            // 
            resources.ApplyResources(this.label5, "label5");
            this.label5.Name = "label5";
            // 
            // frmListado
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Clientes);
            this.Controls.Add(this.dgvViaje);
            this.Controls.Add(this.dgvPasaje);
            this.Controls.Add(this.dgvEmpresa);
            this.Controls.Add(this.dgvItinerario);
            this.Controls.Add(this.dgvDestino);
            this.Controls.Add(this.dgvOrigen);
            this.Controls.Add(this.btnListar);
            this.Controls.Add(this.dgvCliente);
            this.MaximizeBox = false;
            this.Name = "frmListado";
            ((System.ComponentModel.ISupportInitialize)(this.dgvCliente)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvOrigen)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDestino)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvItinerario)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEmpresa)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPasaje)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvViaje)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvCliente;
        private System.Windows.Forms.Button btnListar;
        private System.Windows.Forms.DataGridView dgvOrigen;
        private System.Windows.Forms.DataGridView dgvDestino;
        private System.Windows.Forms.DataGridView dgvItinerario;
        private System.Windows.Forms.DataGridView dgvEmpresa;
        private System.Windows.Forms.DataGridView dgvPasaje;
        private System.Windows.Forms.DataGridView dgvViaje;
        private System.Windows.Forms.Label Clientes;
        private System.Windows.Forms.Label label1;
        protected internal System.Windows.Forms.Label label2;
        protected internal System.Windows.Forms.Label label3;
        protected internal System.Windows.Forms.Label label4;
        protected internal System.Windows.Forms.Label label5;
    }
}

