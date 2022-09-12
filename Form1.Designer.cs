
namespace EnviodeCorreo
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textCorreo = new System.Windows.Forms.TextBox();
            this.textContrasenha = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textReceptor = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.textAsunto = new System.Windows.Forms.TextBox();
            this.memoMensaje = new DevExpress.XtraEditors.MemoEdit();
            this.label5 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.button3 = new System.Windows.Forms.Button();
            this.pictureImageQr = new System.Windows.Forms.PictureBox();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.txtOpenfile = new System.Windows.Forms.Button();
            this.btnLeerQr = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.bindingNavigator1 = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.txtvalorQr = new System.Windows.Forms.ComboBox();
            this.rbPng = new System.Windows.Forms.RadioButton();
            this.rbJpg = new System.Windows.Forms.RadioButton();
            this.rbPmp = new System.Windows.Forms.RadioButton();
            this.btnGenerate = new System.Windows.Forms.Button();
            this.txtTexto = new System.Windows.Forms.TextBox();
            this.rbGOptions = new System.Windows.Forms.RadioButton();
            ((System.ComponentModel.ISupportInitialize)(this.memoMensaje.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureImageQr)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingNavigator1)).BeginInit();
            this.bindingNavigator1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(85, 49);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Correo: ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(56, 76);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Contrasenha: ";
            // 
            // textCorreo
            // 
            this.textCorreo.Location = new System.Drawing.Point(135, 46);
            this.textCorreo.Name = "textCorreo";
            this.textCorreo.Size = new System.Drawing.Size(229, 20);
            this.textCorreo.TabIndex = 2;
            this.textCorreo.TextChanged += new System.EventHandler(this.textCorreo_TextChanged);
            // 
            // textContrasenha
            // 
            this.textContrasenha.Location = new System.Drawing.Point(135, 76);
            this.textContrasenha.Name = "textContrasenha";
            this.textContrasenha.Size = new System.Drawing.Size(229, 20);
            this.textContrasenha.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(97, 150);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(32, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Para:";
            // 
            // textReceptor
            // 
            this.textReceptor.Location = new System.Drawing.Point(135, 147);
            this.textReceptor.Name = "textReceptor";
            this.textReceptor.Size = new System.Drawing.Size(229, 20);
            this.textReceptor.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(85, 195);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(43, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Asunto:";
            // 
            // textAsunto
            // 
            this.textAsunto.Location = new System.Drawing.Point(134, 195);
            this.textAsunto.Name = "textAsunto";
            this.textAsunto.Size = new System.Drawing.Size(229, 20);
            this.textAsunto.TabIndex = 7;
            // 
            // memoMensaje
            // 
            this.memoMensaje.Location = new System.Drawing.Point(134, 248);
            this.memoMensaje.Name = "memoMensaje";
            this.memoMensaje.Size = new System.Drawing.Size(388, 65);
            this.memoMensaje.TabIndex = 8;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(78, 250);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(50, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "Mensaje:";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(134, 319);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 10;
            this.button1.Text = "Enviar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(230, 319);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(121, 23);
            this.button2.TabIndex = 11;
            this.button2.Text = "Adjuntar Archivo";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(627, 202);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(52, 13);
            this.label6.TabIndex = 13;
            this.label6.Text = "Url/Texto";
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(221, 416);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 14;
            this.button3.Text = "Generar QR";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // pictureImageQr
            // 
            this.pictureImageQr.Location = new System.Drawing.Point(630, 39);
            this.pictureImageQr.Name = "pictureImageQr";
            this.pictureImageQr.Size = new System.Drawing.Size(200, 200);
            this.pictureImageQr.TabIndex = 15;
            this.pictureImageQr.TabStop = false;
            this.pictureImageQr.Click += new System.EventHandler(this.pictureImageQr_Click);
            // 
            // btnGuardar
            // 
            this.btnGuardar.Enabled = false;
            this.btnGuardar.Location = new System.Drawing.Point(302, 416);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(75, 23);
            this.btnGuardar.TabIndex = 16;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.UseVisualStyleBackColor = true;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // txtOpenfile
            // 
            this.txtOpenfile.Location = new System.Drawing.Point(383, 416);
            this.txtOpenfile.Name = "txtOpenfile";
            this.txtOpenfile.Size = new System.Drawing.Size(75, 23);
            this.txtOpenfile.TabIndex = 17;
            this.txtOpenfile.Text = "OpenFile";
            this.txtOpenfile.UseVisualStyleBackColor = true;
            this.txtOpenfile.Click += new System.EventHandler(this.txtOpenfile_Click);
            // 
            // btnLeerQr
            // 
            this.btnLeerQr.Location = new System.Drawing.Point(224, 459);
            this.btnLeerQr.Name = "btnLeerQr";
            this.btnLeerQr.Size = new System.Drawing.Size(75, 23);
            this.btnLeerQr.TabIndex = 18;
            this.btnLeerQr.Text = "LeerCodigo";
            this.btnLeerQr.UseVisualStyleBackColor = true;
            this.btnLeerQr.Click += new System.EventHandler(this.btnLeerQr_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(100, 50);
            this.pictureBox1.TabIndex = 19;
            this.pictureBox1.TabStop = false;
            // 
            // bindingNavigator1
            // 
            this.bindingNavigator1.AddNewItem = this.bindingNavigatorAddNewItem;
            this.bindingNavigator1.CountItem = this.bindingNavigatorCountItem;
            this.bindingNavigator1.DeleteItem = this.bindingNavigatorDeleteItem;
            this.bindingNavigator1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.bindingNavigatorSeparator2,
            this.bindingNavigatorAddNewItem,
            this.bindingNavigatorDeleteItem});
            this.bindingNavigator1.Location = new System.Drawing.Point(0, 0);
            this.bindingNavigator1.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.bindingNavigator1.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.bindingNavigator1.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.bindingNavigator1.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.bindingNavigator1.Name = "bindingNavigator1";
            this.bindingNavigator1.PositionItem = this.bindingNavigatorPositionItem;
            this.bindingNavigator1.Size = new System.Drawing.Size(925, 25);
            this.bindingNavigator1.TabIndex = 22;
            this.bindingNavigator1.Text = "bindingNavigator1";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveFirstItem.Text = "Mover primero";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMovePreviousItem.Text = "Mover anterior";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "Posición";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 23);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Posición actual";
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(37, 22);
            this.bindingNavigatorCountItem.Text = "de {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Número total de elementos";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveNextItem.Text = "Mover siguiente";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveLastItem.Text = "Mover último";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorAddNewItem.Text = "Agregar nuevo";
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorDeleteItem.Text = "Eliminar";
            // 
            // txtvalorQr
            // 
            this.txtvalorQr.FormattingEnabled = true;
            this.txtvalorQr.Items.AddRange(new object[] {
            "Code128",
            "Datamatrix",
            "PDF417",
            "QR"});
            this.txtvalorQr.Location = new System.Drawing.Point(630, 265);
            this.txtvalorQr.Name = "txtvalorQr";
            this.txtvalorQr.Size = new System.Drawing.Size(243, 21);
            this.txtvalorQr.TabIndex = 23;
            this.txtvalorQr.SelectedIndexChanged += new System.EventHandler(this.txtvalorQr_SelectedIndexChanged);
            // 
            // rbPng
            // 
            this.rbPng.AutoSize = true;
            this.rbPng.Location = new System.Drawing.Point(631, 347);
            this.rbPng.Name = "rbPng";
            this.rbPng.Size = new System.Drawing.Size(53, 17);
            this.rbPng.TabIndex = 24;
            this.rbPng.TabStop = true;
            this.rbPng.Text = "rbPng";
            this.rbPng.UseVisualStyleBackColor = true;
            // 
            // rbJpg
            // 
            this.rbJpg.AutoSize = true;
            this.rbJpg.Location = new System.Drawing.Point(703, 347);
            this.rbJpg.Name = "rbJpg";
            this.rbJpg.Size = new System.Drawing.Size(51, 17);
            this.rbJpg.TabIndex = 25;
            this.rbJpg.TabStop = true;
            this.rbJpg.Text = "rbJpg";
            this.rbJpg.UseVisualStyleBackColor = true;
            // 
            // rbPmp
            // 
            this.rbPmp.AutoSize = true;
            this.rbPmp.Location = new System.Drawing.Point(760, 347);
            this.rbPmp.Name = "rbPmp";
            this.rbPmp.Size = new System.Drawing.Size(55, 17);
            this.rbPmp.TabIndex = 26;
            this.rbPmp.TabStop = true;
            this.rbPmp.Text = "rbPmp";
            this.rbPmp.UseVisualStyleBackColor = true;
            // 
            // btnGenerate
            // 
            this.btnGenerate.Location = new System.Drawing.Point(630, 407);
            this.btnGenerate.Name = "btnGenerate";
            this.btnGenerate.Size = new System.Drawing.Size(75, 23);
            this.btnGenerate.TabIndex = 27;
            this.btnGenerate.Text = "Generar";
            this.btnGenerate.UseVisualStyleBackColor = true;
            this.btnGenerate.Click += new System.EventHandler(this.btnGenerate_Click);
            // 
            // txtTexto
            // 
            this.txtTexto.Location = new System.Drawing.Point(630, 304);
            this.txtTexto.Name = "txtTexto";
            this.txtTexto.Size = new System.Drawing.Size(229, 20);
            this.txtTexto.TabIndex = 28;
            this.txtTexto.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // rbGOptions
            // 
            this.rbGOptions.AutoSize = true;
            this.rbGOptions.Location = new System.Drawing.Point(630, 370);
            this.rbGOptions.Name = "rbGOptions";
            this.rbGOptions.Size = new System.Drawing.Size(108, 17);
            this.rbGOptions.TabIndex = 29;
            this.rbGOptions.TabStop = true;
            this.rbGOptions.Text = "GenerarOpciones";
            this.rbGOptions.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(925, 560);
            this.Controls.Add(this.rbGOptions);
            this.Controls.Add(this.txtTexto);
            this.Controls.Add(this.btnGenerate);
            this.Controls.Add(this.rbPmp);
            this.Controls.Add(this.rbJpg);
            this.Controls.Add(this.rbPng);
            this.Controls.Add(this.txtvalorQr);
            this.Controls.Add(this.bindingNavigator1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnLeerQr);
            this.Controls.Add(this.txtOpenfile);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.pictureImageQr);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.memoMensaje);
            this.Controls.Add(this.textAsunto);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.textReceptor);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textContrasenha);
            this.Controls.Add(this.textCorreo);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Generar Opciones";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.memoMensaje.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureImageQr)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingNavigator1)).EndInit();
            this.bindingNavigator1.ResumeLayout(false);
            this.bindingNavigator1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textCorreo;
        private System.Windows.Forms.TextBox textContrasenha;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textReceptor;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textAsunto;
        private DevExpress.XtraEditors.MemoEdit memoMensaje;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.PictureBox pictureImageQr;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.Button txtOpenfile;
        private System.Windows.Forms.Button btnLeerQr;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.BindingNavigator bindingNavigator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorAddNewItem;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorDeleteItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.ComboBox txtvalorQr;
        private System.Windows.Forms.RadioButton rbPng;
        private System.Windows.Forms.RadioButton rbJpg;
        private System.Windows.Forms.RadioButton rbPmp;
        private System.Windows.Forms.Button btnGenerate;
        private System.Windows.Forms.TextBox txtTexto;
        private System.Windows.Forms.RadioButton rbGOptions;
    }
}

