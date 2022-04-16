using PaintDotNet.Effects;
using System;
using System.Diagnostics;
using System.Windows.Forms;

namespace VancouverSkyline
{
    public class EffectPluginConfigDialog : EffectConfigDialog
    {
        private Button? ButtonOK;
        private Button? button1;
        private LinkLabel? linkLabel1;
        private Button? ButtonCancel;

        public EffectPluginConfigDialog()
        {
            InitializeComponent();
        }

        protected override void InitialInitToken()
        {
            theEffectToken = new EffectPluginConfigToken();
        }

        protected override void InitTokenFromDialog()
        {
            // ((EffectPluginConfigToken)EffectToken).variable = dialogVariable;
        }

        protected override void InitDialogFromToken(EffectConfigToken effectToken)
        {
            // EffectPluginConfigToken token = (EffectPluginConfigToken)effectToken;
            // dialogVariable = token.variable;
        }

        private void InitializeComponent()
        {
            ButtonCancel = new System.Windows.Forms.Button();
            ButtonOK = new System.Windows.Forms.Button();
            button1 = new System.Windows.Forms.Button();
            linkLabel1 = new System.Windows.Forms.LinkLabel();
            SuspendLayout();
            // 
            // ButtonCancel
            // 
            ButtonCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            ButtonCancel.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            ButtonCancel.Location = new System.Drawing.Point(195, 218);
            ButtonCancel.Name = "ButtonCancel";
            ButtonCancel.Size = new System.Drawing.Size(75, 23);
            ButtonCancel.TabIndex = 1;
            ButtonCancel.Text = "Cancel";
            ButtonCancel.UseVisualStyleBackColor = true;
#pragma warning disable CS8622 // Nullability of reference types in type of parameter doesn't match the target delegate (possibly because of nullability attributes).
            ButtonCancel.Click += new System.EventHandler(ButtonCancel_Click);
#pragma warning restore CS8622 // Nullability of reference types in type of parameter doesn't match the target delegate (possibly because of nullability attributes).
            // 
            // ButtonOK
            // 
            ButtonOK.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            ButtonOK.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            ButtonOK.Location = new System.Drawing.Point(114, 218);
            ButtonOK.Name = "ButtonOK";
            ButtonOK.Size = new System.Drawing.Size(75, 23);
            ButtonOK.TabIndex = 2;
            ButtonOK.Text = "OK";
            ButtonOK.UseVisualStyleBackColor = true;
#pragma warning disable CS8622 // Nullability of reference types in type of parameter doesn't match the target delegate (possibly because of nullability attributes).
            ButtonOK.Click += new System.EventHandler(ButtonOK_Click);
#pragma warning restore CS8622 // Nullability of reference types in type of parameter doesn't match the target delegate (possibly because of nullability attributes).
            // 
            // button1
            // 
            button1.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            button1.Location = new System.Drawing.Point(195, 12);
            button1.Name = "button1";
            button1.Size = new System.Drawing.Size(75, 23);
            button1.TabIndex = 3;
            button1.Text = "Help";
            button1.UseVisualStyleBackColor = true;
            // 
            // linkLabel1
            // 
            linkLabel1.AutoSize = true;
            linkLabel1.Location = new System.Drawing.Point(12, 218);
            linkLabel1.Name = "linkLabel1";
            linkLabel1.Size = new System.Drawing.Size(86, 15);
            linkLabel1.TabIndex = 4;
            linkLabel1.TabStop = true;
            linkLabel1.Text = "More Plugins...";
            linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(LinkLabel1_LinkClicked);
            // 
            // EffectPluginConfigDialog
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            ClientSize = new System.Drawing.Size(282, 253);
            Controls.Add(linkLabel1);
            Controls.Add(button1);
            Controls.Add(ButtonOK);
            Controls.Add(ButtonCancel);
            Location = new System.Drawing.Point(0, 0);
            Name = "EffectPluginConfigDialog";
            Text = "VancouverSunset - by Andrew David";
            ResumeLayout(false);
            PerformLayout();

        }

        private void ButtonOK_Click(object sender, EventArgs e)
        {
            FinishTokenUpdate();
            DialogResult = DialogResult.OK;
            Close();
        }

        private void ButtonCancel_Click(object sender, EventArgs e)
        {
            Close();
        }


        private void Button1_Click(object sender, EventArgs e)
        {
            string Message =
    "This message will show up when\n" +
    "the user clicks the HELP button.\n\n" +
    "           - Andrew David 2021";

            string Title = "About the VancouverSunset Plugin";
            _ = MessageBox.Show(Message, Title);
        }

        private void LinkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            try
            {
                VisitLink();
            }
            catch (Exception ex)
            {
                _ = (int)MessageBox.Show("Unable to open 'Plugins' page on the Paint.NET forum." + ex.Message);
            }
        }

        private void VisitLink()
        {
            throw new NotImplementedException();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            // Send the URL to the operating system.
#pragma warning disable CS8604 // Possible null reference argument.
            _ = Process.Start(e.Link.LinkData as string);
#pragma warning restore CS8604 // Possible null reference argument.
        }
    }
}
