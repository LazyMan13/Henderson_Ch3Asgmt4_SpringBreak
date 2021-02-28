<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmSpringBreak
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmSpringBreak))
        Me.btnMyrtleBeach = New System.Windows.Forms.Button()
        Me.btnKeyWest = New System.Windows.Forms.Button()
        Me.btnVeniceBeach = New System.Windows.Forms.Button()
        Me.picMyrtle = New System.Windows.Forms.PictureBox()
        Me.picKeyWest = New System.Windows.Forms.PictureBox()
        Me.picVenice = New System.Windows.Forms.PictureBox()
        Me.lblEnjoy = New System.Windows.Forms.Label()
        Me.btnPurchase = New System.Windows.Forms.Button()
        CType(Me.picMyrtle, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picKeyWest, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picVenice, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnMyrtleBeach
        '
        Me.btnMyrtleBeach.Location = New System.Drawing.Point(19, 24)
        Me.btnMyrtleBeach.Name = "btnMyrtleBeach"
        Me.btnMyrtleBeach.Size = New System.Drawing.Size(75, 23)
        Me.btnMyrtleBeach.TabIndex = 0
        Me.btnMyrtleBeach.Text = "Myrtle Beach"
        Me.btnMyrtleBeach.UseVisualStyleBackColor = True
        '
        'btnKeyWest
        '
        Me.btnKeyWest.Location = New System.Drawing.Point(184, 24)
        Me.btnKeyWest.Name = "btnKeyWest"
        Me.btnKeyWest.Size = New System.Drawing.Size(75, 23)
        Me.btnKeyWest.TabIndex = 1
        Me.btnKeyWest.Text = "Key West"
        Me.btnKeyWest.UseVisualStyleBackColor = True
        '
        'btnVeniceBeach
        '
        Me.btnVeniceBeach.Location = New System.Drawing.Point(359, 24)
        Me.btnVeniceBeach.Name = "btnVeniceBeach"
        Me.btnVeniceBeach.Size = New System.Drawing.Size(75, 23)
        Me.btnVeniceBeach.TabIndex = 2
        Me.btnVeniceBeach.Text = "Venice Beach"
        Me.btnVeniceBeach.UseVisualStyleBackColor = True
        '
        'picMyrtle
        '
        Me.picMyrtle.Image = CType(resources.GetObject("picMyrtle.Image"), System.Drawing.Image)
        Me.picMyrtle.Location = New System.Drawing.Point(49, 64)
        Me.picMyrtle.Name = "picMyrtle"
        Me.picMyrtle.Size = New System.Drawing.Size(360, 282)
        Me.picMyrtle.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picMyrtle.TabIndex = 3
        Me.picMyrtle.TabStop = False
        '
        'picKeyWest
        '
        Me.picKeyWest.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.picKeyWest.Image = CType(resources.GetObject("picKeyWest.Image"), System.Drawing.Image)
        Me.picKeyWest.Location = New System.Drawing.Point(49, 64)
        Me.picKeyWest.Name = "picKeyWest"
        Me.picKeyWest.Size = New System.Drawing.Size(360, 282)
        Me.picKeyWest.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picKeyWest.TabIndex = 4
        Me.picKeyWest.TabStop = False
        Me.picKeyWest.Visible = False
        '
        'picVenice
        '
        Me.picVenice.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.picVenice.Image = CType(resources.GetObject("picVenice.Image"), System.Drawing.Image)
        Me.picVenice.Location = New System.Drawing.Point(49, 64)
        Me.picVenice.Name = "picVenice"
        Me.picVenice.Size = New System.Drawing.Size(360, 282)
        Me.picVenice.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picVenice.TabIndex = 5
        Me.picVenice.TabStop = False
        Me.picVenice.Visible = False
        '
        'lblEnjoy
        '
        Me.lblEnjoy.AutoSize = True
        Me.lblEnjoy.Font = New System.Drawing.Font("Engravers MT", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.lblEnjoy.Location = New System.Drawing.Point(79, 365)
        Me.lblEnjoy.Name = "lblEnjoy"
        Me.lblEnjoy.Size = New System.Drawing.Size(296, 25)
        Me.lblEnjoy.TabIndex = 6
        Me.lblEnjoy.Text = "Enjoy your trip!"
        Me.lblEnjoy.Visible = False
        '
        'btnPurchase
        '
        Me.btnPurchase.Location = New System.Drawing.Point(184, 365)
        Me.btnPurchase.Name = "btnPurchase"
        Me.btnPurchase.Size = New System.Drawing.Size(75, 23)
        Me.btnPurchase.TabIndex = 7
        Me.btnPurchase.Text = "Purchase"
        Me.btnPurchase.UseVisualStyleBackColor = True
        '
        'frmSpringBreak
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(460, 412)
        Me.Controls.Add(Me.btnPurchase)
        Me.Controls.Add(Me.lblEnjoy)
        Me.Controls.Add(Me.picVenice)
        Me.Controls.Add(Me.picKeyWest)
        Me.Controls.Add(Me.picMyrtle)
        Me.Controls.Add(Me.btnVeniceBeach)
        Me.Controls.Add(Me.btnKeyWest)
        Me.Controls.Add(Me.btnMyrtleBeach)
        Me.Name = "frmSpringBreak"
        Me.Text = "Henderson Ch3Asgmt4 Spring Break Travel Specials"
        CType(Me.picMyrtle, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picKeyWest, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picVenice, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnMyrtleBeach As Button
    Friend WithEvents btnKeyWest As Button
    Friend WithEvents btnVeniceBeach As Button
    Friend WithEvents picMyrtle As PictureBox
    Friend WithEvents picKeyWest As PictureBox
    Friend WithEvents picVenice As PictureBox
    Friend WithEvents lblEnjoy As Label
    Friend WithEvents btnPurchase As Button
End Class
