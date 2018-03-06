Public Class Form1

#Region "Variables"

    Dim intPic As Integer

    Dim blanc101 As Integer
    Dim blanc102 As Integer

    Dim blanc201 As Integer
    Dim blanc202 As Integer

    Dim cont103 As Integer
    Dim cont203 As Integer

    Dim randomizer As Boolean

    Dim numero As Integer
    Dim graella As Integer

    Dim rand As New Random

    Dim firstnumber101 As Integer
    Dim secondnumber101 As Integer
    Dim firstnumber102 As Integer
    Dim secondnumber102 As Integer
    Dim firstnumber103 As Integer
    Dim secondnumber103 As Integer
    Dim firstnumber104 As Integer
    Dim secondnumber104 As Integer
    Dim firstnumber105 As Integer
    Dim secondnumber105 As Integer
    Dim firstnumber106 As Integer
    Dim secondnumber106 As Integer
    Dim firstnumber107 As Integer
    Dim secondnumber107 As Integer
    Dim firstnumber108 As Integer
    Dim secondnumber108 As Integer
    Dim firstnumber109 As Integer
    Dim secondnumber109 As Integer

    Dim firstnumber201 As Integer
    Dim secondnumber201 As Integer
    Dim firstnumber202 As Integer
    Dim secondnumber202 As Integer
    Dim firstnumber203 As Integer
    Dim secondnumber203 As Integer
    Dim firstnumber204 As Integer
    Dim secondnumber204 As Integer
    Dim firstnumber205 As Integer
    Dim secondnumber205 As Integer
    Dim firstnumber206 As Integer
    Dim secondnumber206 As Integer
    Dim firstnumber207 As Integer
    Dim secondnumber207 As Integer
    Dim firstnumber208 As Integer
    Dim secondnumber208 As Integer
    Dim firstnumber209 As Integer
    Dim secondnumber209 As Integer

    Dim pass1_101 As Boolean
    Dim pass2_101 As Boolean
    Dim pass1_102 As Boolean
    Dim pass2_102 As Boolean
    Dim pass1_103 As Boolean
    Dim pass2_103 As Boolean
    Dim pass1_104 As Boolean
    Dim pass2_104 As Boolean
    Dim pass1_105 As Boolean
    Dim pass2_105 As Boolean
    Dim pass1_106 As Boolean
    Dim pass2_106 As Boolean
    Dim pass1_107 As Boolean
    Dim pass2_107 As Boolean
    Dim pass1_108 As Boolean
    Dim pass2_108 As Boolean
    Dim pass1_109 As Boolean
    Dim pass2_109 As Boolean

    Dim pass1_201 As Boolean
    Dim pass2_201 As Boolean
    Dim pass1_202 As Boolean
    Dim pass2_202 As Boolean
    Dim pass1_203 As Boolean
    Dim pass2_203 As Boolean
    Dim pass1_204 As Boolean
    Dim pass2_204 As Boolean
    Dim pass1_205 As Boolean
    Dim pass2_205 As Boolean
    Dim pass1_206 As Boolean
    Dim pass2_206 As Boolean
    Dim pass1_207 As Boolean
    Dim pass2_207 As Boolean
    Dim pass1_208 As Boolean
    Dim pass2_208 As Boolean
    Dim pass1_209 As Boolean
    Dim pass2_209 As Boolean

    Dim contador As Integer

    Dim contador_x_101 As Integer
    Dim contador_x_102 As Integer
    Dim contador_x_103 As Integer

    Dim contador_x_201 As Integer
    Dim contador_x_202 As Integer
    Dim contador_x_203 As Integer

    Dim cicle As Boolean

    Dim linia As Boolean
    Dim bingo As Boolean

    Dim contaclick1 As Integer
    Dim contaclick2 As Integer

    Dim click1 As Boolean
    Dim click2 As Boolean

    Dim linia101 As Integer
    Dim linia102 As Integer
    Dim linia103 As Integer

    Dim linia201 As Integer
    Dim linia202 As Integer
    Dim linia203 As Integer

    Dim int_ou As Integer



    Dim pickedImg As New List(Of Integer)
    Dim pickedNum As New List(Of Integer)
#End Region

#Region "Preparar el joc"

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles Me.Load

        'Assigna cada numero de la graella al que li pertoca i deixa els cartrons en blanc

        click1 = False
        click2 = False

        linia = False
        bingo = False

        int_ou = 0

        For Each ctlControl In Me.Controls.OfType(Of PictureBox)

            If ctlControl.Tag = "blanc" Then

                ctlControl.Image = ImageList1.Images.Item(0)

            End If

            If ctlControl.Location.Y < 400 Then

                numero = ctlControl.Tag

                ctlControl.Image = ImageList1.Images.Item(numero)

            End If

        Next

    End Sub

#End Region

#Region "Generar cartrons"

#Region "Generar el cartró 1"

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        'Comencem per generar el primer cartró limitant el nombre de vegades que es pot fer el randomper a no saturar 
        'la memoria del programa

        contaclick1 += 1

        If contaclick1 = 1 Then

            Button1.Text = "Un altre?"

        ElseIf contaclick1 = 2 Then

            Button1.Text = "Últim intent!"

        Else

            Button1.Enabled = False
            Button1.Visible = False

            If contaclick2 = 3 Then

                Label1.Visible = False

            End If

        End If

        click1 = True

        cont103 = 0

        If click1 = True And click2 = True Then

            Button3.Visible = True

            Button3.Enabled = True

        End If

        pass1_101 = False
        pass2_101 = False
        pass1_102 = False
        pass2_102 = False
        pass1_103 = False
        pass2_103 = False
        pass1_104 = False
        pass2_104 = False
        pass1_105 = False
        pass2_105 = False
        pass1_106 = False
        pass2_106 = False
        pass1_107 = False
        pass2_107 = False
        pass1_108 = False
        pass2_108 = False
        pass1_109 = False
        pass2_109 = False

        pickedImg.Clear()

        'Aqui executem la funció pertinent per cada columna del cartró 1 que, juntament amb la que veurem a continuació,
        'assigna numeros a cada columna mai superior al numero que hi hagi damunt seu

        For Each ctlControl In Me.Controls.OfType(Of PictureBox)

            If ctlControl.Location.X = 40 And ctlControl.Location.Y > 460 Then

                chooseImg101()

                ctlControl.Image = ImageList1.Images.Item(intPic)

                ctlControl.Tag = intPic

            End If

            If ctlControl.Location.X = 82 And ctlControl.Location.Y > 460 Then

                chooseImg102()

                ctlControl.Image = ImageList1.Images.Item(intPic)

                ctlControl.Tag = intPic

            End If

            If ctlControl.Location.X = 124 And ctlControl.Location.Y > 460 Then

                chooseImg103()

                ctlControl.Image = ImageList1.Images.Item(intPic)

                ctlControl.Tag = intPic

            End If

            If ctlControl.Location.X = 166 And ctlControl.Location.Y > 460 Then

                chooseImg104()

                ctlControl.Image = ImageList1.Images.Item(intPic)

                ctlControl.Tag = intPic

            End If

            If ctlControl.Location.X = 208 And ctlControl.Location.Y > 460 Then

                chooseImg105()

                ctlControl.Image = ImageList1.Images.Item(intPic)

                ctlControl.Tag = intPic

            End If

            If ctlControl.Location.X = 250 And ctlControl.Location.Y > 460 Then

                chooseImg106()

                ctlControl.Image = ImageList1.Images.Item(intPic)

                ctlControl.Tag = intPic

            End If

            If ctlControl.Location.X = 292 And ctlControl.Location.Y > 460 Then

                chooseImg107()

                ctlControl.Image = ImageList1.Images.Item(intPic)

                ctlControl.Tag = intPic

            End If

            If ctlControl.Location.X = 334 And ctlControl.Location.Y > 460 Then

                chooseImg108()

                ctlControl.Image = ImageList1.Images.Item(intPic)

                ctlControl.Tag = intPic

            End If

            If ctlControl.Location.X = 376 And ctlControl.Location.Y > 460 Then

                chooseImg109()

                ctlControl.Image = ImageList1.Images.Item(intPic)

                ctlControl.Tag = intPic

            End If

        Next ctlControl

        make_blanc1()

    End Sub

    Sub chooseImg101()

        'Mirant com fer que els numeros no fossin superiors vaig veure que a la tercera fila els numeros per força havien
        'd'estar entre el X2 i el X9, incloent ambdos numeros, ja que per força han de tenir dos numeros per sota seu.
        'Seguint aquesta norma, els numeros de la segona fila han de ser entre el X1 i el resultat anterior -1.
        'Per acabar, els de la primera filera han de estar entre el X0 i el resultat anterior -1.

        'La primera columna i la ultima tenen les seves propies normes, ja que en la primera els numeros son entre 1 i 9, 
        'i la ultima entre 81 i 90.

        'Si seguim aquestes normes, aconseguirem tenir numeros de petit a gran no repetits de forma vertical a cada columna
        'del cartró.

        'El pass1 i pass2 per cada columna es per a confirmar que els numeros no es repeteixen i asegurar que estan ben col·locats

        If pass1_101 = False Then

            intPic = rand.Next(3, 10)

            pass1_101 = True

            pickedImg.Add(intPic)

            firstnumber101 = intPic

        Else

            If pass2_101 = False Then

                intPic = rand.Next(2, firstnumber101)

                pass2_101 = True

                pickedImg.Add(intPic)

                secondnumber101 = intPic

            Else

                intPic = rand.Next(1, secondnumber101)

                pickedImg.Add(intPic)

            End If

        End If

    End Sub

    Sub chooseImg102()

        'Mirar linia 332

        If pass1_102 = False Then

            intPic = rand.Next(12, 20)

            pass1_102 = True

            pickedImg.Add(intPic)

            firstnumber102 = intPic

        Else

            If pass2_102 = False Then

                intPic = rand.Next(11, firstnumber102)

                pass2_102 = True

                pickedImg.Add(intPic)

                secondnumber102 = intPic

            Else

                intPic = rand.Next(10, secondnumber102)

                pickedImg.Add(intPic)

            End If

        End If

    End Sub

    Sub chooseImg103()

        'Mirar linia 332

        If pass1_103 = False Then

            intPic = rand.Next(22, 30)

            pass1_103 = True

            pickedImg.Add(intPic)

            firstnumber103 = intPic

        Else

            If pass2_103 = False Then

                intPic = rand.Next(21, firstnumber103)

                pass2_103 = True

                pickedImg.Add(intPic)

                secondnumber103 = intPic

            Else

                intPic = rand.Next(20, secondnumber103)

                pickedImg.Add(intPic)

            End If

        End If

    End Sub

    Sub chooseImg104()

        'Mirar linia 332

        If pass1_104 = False Then

            intPic = rand.Next(32, 40)

            pass1_104 = True

            pickedImg.Add(intPic)

            firstnumber104 = intPic

        Else

            If pass2_104 = False Then

                intPic = rand.Next(31, firstnumber104)

                pass2_104 = True

                pickedImg.Add(intPic)

                secondnumber104 = intPic

            Else

                intPic = rand.Next(30, secondnumber104)

                pickedImg.Add(intPic)

            End If

        End If

    End Sub

    Sub chooseImg105()

        'Mirar linia 332

        If pass1_105 = False Then

            intPic = rand.Next(42, 50)

            pass1_105 = True

            pickedImg.Add(intPic)

            firstnumber105 = intPic

        Else

            If pass2_105 = False Then

                intPic = rand.Next(41, firstnumber105)

                pass2_105 = True

                pickedImg.Add(intPic)

                secondnumber105 = intPic

            Else

                intPic = rand.Next(40, secondnumber105)

                pickedImg.Add(intPic)

            End If

        End If

    End Sub

    Sub chooseImg106()

        'Mirar linia 332

        If pass1_106 = False Then

            intPic = rand.Next(52, 60)

            pass1_106 = True

            pickedImg.Add(intPic)

            firstnumber106 = intPic

        Else

            If pass2_106 = False Then

                intPic = rand.Next(51, firstnumber106)

                pass2_106 = True

                pickedImg.Add(intPic)

                secondnumber106 = intPic

            Else

                intPic = rand.Next(50, secondnumber106)

                pickedImg.Add(intPic)

            End If

        End If

    End Sub

    Sub chooseImg107()

        'Mirar linia 332

        If pass1_107 = False Then

            intPic = rand.Next(62, 70)

            pass1_107 = True

            pickedImg.Add(intPic)

            firstnumber107 = intPic

        Else

            If pass2_107 = False Then

                intPic = rand.Next(61, firstnumber107)

                pass2_107 = True

                pickedImg.Add(intPic)

                secondnumber107 = intPic

            Else

                intPic = rand.Next(60, secondnumber107)

                pickedImg.Add(intPic)

            End If

        End If

    End Sub

    Sub chooseImg108()

        'Mirar linia 332

        If pass1_108 = False Then

            intPic = rand.Next(72, 80)

            pass1_108 = True

            pickedImg.Add(intPic)

            firstnumber108 = intPic

        Else

            If pass2_108 = False Then

                intPic = rand.Next(71, firstnumber108)

                pass2_108 = True

                pickedImg.Add(intPic)

                secondnumber108 = intPic

            Else

                intPic = rand.Next(70, secondnumber108)

                pickedImg.Add(intPic)

            End If

        End If

    End Sub

    Sub chooseImg109()

        'Mirar linia 332

        If pass1_109 = False Then

            intPic = rand.Next(82, 91)

            pass1_109 = True

            pickedImg.Add(intPic)

            firstnumber109 = intPic

        Else

            If pass2_109 = False Then

                intPic = rand.Next(81, firstnumber109)

                pass2_109 = True

                pickedImg.Add(intPic)

                secondnumber109 = intPic

            Else

                intPic = rand.Next(80, secondnumber109)

                pickedImg.Add(intPic)

            End If

        End If

    End Sub

    Sub make_blanc1()

        'En aquesta funció remplaçarem els numeros que em ficat abans amb caselles en blanc.
        'Quan feia aquesta practica vaig agafar un paper i vaig crear totes les combinacions possibles respectant les normes
        'donades al document, i acaba resultant 21 combinacions diferent que s'apliquen a les dos primeres fileres.
        'Per mirar la tercera filera, anar a la linia 1272

        blanc101 = rand.Next(1, 22)
        blanc102 = rand.Next(1, 22)

        While blanc101 = blanc102

            blanc102 = rand.Next(1, 22)

        End While

        'Aquí fem la primera fila

        For Each ctlControl In Me.Controls.OfType(Of PictureBox)

            If ctlControl.Location.Y = 499 And ctlControl.Location.X < 380 Then

                If blanc101 = 1 Then

                    PictureBox101.Image = ImageList1.Images.Item(0)
                    PictureBox101.Tag = "blanc"
                    PictureBox107.Image = ImageList1.Images.Item(0)
                    PictureBox107.Tag = "blanc"
                    PictureBox113.Image = ImageList1.Images.Item(0)
                    PictureBox113.Tag = "blanc"
                    PictureBox119.Image = ImageList1.Images.Item(0)
                    PictureBox119.Tag = "blanc"

                End If

                If blanc101 = 2 Then

                    PictureBox101.Image = ImageList1.Images.Item(0)
                    PictureBox101.Tag = "blanc"
                    PictureBox107.Image = ImageList1.Images.Item(0)
                    PictureBox107.Tag = "blanc"
                    PictureBox113.Image = ImageList1.Images.Item(0)
                    PictureBox113.Tag = "blanc"
                    PictureBox122.Image = ImageList1.Images.Item(0)
                    PictureBox122.Tag = "blanc"

                End If

                If blanc101 = 2 Then

                    PictureBox101.Image = ImageList1.Images.Item(0)
                    PictureBox101.Tag = "blanc"
                    PictureBox107.Image = ImageList1.Images.Item(0)
                    PictureBox107.Tag = "blanc"
                    PictureBox113.Image = ImageList1.Images.Item(0)
                    PictureBox113.Tag = "blanc"
                    PictureBox122.Image = ImageList1.Images.Item(0)
                    PictureBox122.Tag = "blanc"

                End If

                If blanc101 = 3 Then

                    PictureBox101.Image = ImageList1.Images.Item(0)
                    PictureBox101.Tag = "blanc"
                    PictureBox107.Image = ImageList1.Images.Item(0)
                    PictureBox107.Tag = "blanc"
                    PictureBox116.Image = ImageList1.Images.Item(0)
                    PictureBox116.Tag = "blanc"
                    PictureBox122.Image = ImageList1.Images.Item(0)
                    PictureBox122.Tag = "blanc"

                End If

                If blanc101 = 4 Then

                    PictureBox101.Image = ImageList1.Images.Item(0)
                    PictureBox101.Tag = "blanc"
                    PictureBox110.Image = ImageList1.Images.Item(0)
                    PictureBox110.Tag = "blanc"
                    PictureBox116.Image = ImageList1.Images.Item(0)
                    PictureBox116.Tag = "blanc"
                    PictureBox122.Image = ImageList1.Images.Item(0)
                    PictureBox122.Tag = "blanc"

                End If

                If blanc101 = 5 Then

                    PictureBox107.Image = ImageList1.Images.Item(0)
                    PictureBox107.Tag = "blanc"
                    PictureBox113.Image = ImageList1.Images.Item(0)
                    PictureBox113.Tag = "blanc"
                    PictureBox119.Image = ImageList1.Images.Item(0)
                    PictureBox119.Tag = "blanc"
                    PictureBox125.Image = ImageList1.Images.Item(0)
                    PictureBox125.Tag = "blanc"

                End If

                If blanc101 = 6 Then

                    PictureBox104.Image = ImageList1.Images.Item(0)
                    PictureBox104.Tag = "blanc"
                    PictureBox113.Image = ImageList1.Images.Item(0)
                    PictureBox113.Tag = "blanc"
                    PictureBox119.Image = ImageList1.Images.Item(0)
                    PictureBox119.Tag = "blanc"
                    PictureBox125.Image = ImageList1.Images.Item(0)
                    PictureBox125.Tag = "blanc"

                End If

                If blanc101 = 7 Then

                    PictureBox104.Image = ImageList1.Images.Item(0)
                    PictureBox104.Tag = "blanc"
                    PictureBox110.Image = ImageList1.Images.Item(0)
                    PictureBox110.Tag = "blanc"
                    PictureBox119.Image = ImageList1.Images.Item(0)
                    PictureBox119.Tag = "blanc"
                    PictureBox125.Image = ImageList1.Images.Item(0)
                    PictureBox125.Tag = "blanc"

                End If

                If blanc101 = 8 Then

                    PictureBox104.Image = ImageList1.Images.Item(0)
                    PictureBox104.Tag = "blanc"
                    PictureBox110.Image = ImageList1.Images.Item(0)
                    PictureBox110.Tag = "blanc"
                    PictureBox116.Image = ImageList1.Images.Item(0)
                    PictureBox116.Tag = "blanc"
                    PictureBox125.Image = ImageList1.Images.Item(0)
                    PictureBox125.Tag = "blanc"

                End If

                If blanc101 = 9 Then

                    PictureBox101.Image = ImageList1.Images.Item(0)
                    PictureBox101.Tag = "blanc"
                    PictureBox107.Image = ImageList1.Images.Item(0)
                    PictureBox107.Tag = "blanc"
                    PictureBox116.Image = ImageList1.Images.Item(0)
                    PictureBox116.Tag = "blanc"
                    PictureBox125.Image = ImageList1.Images.Item(0)
                    PictureBox125.Tag = "blanc"

                End If

                If blanc101 = 10 Then

                    PictureBox101.Image = ImageList1.Images.Item(0)
                    PictureBox101.Tag = "blanc"
                    PictureBox110.Image = ImageList1.Images.Item(0)
                    PictureBox110.Tag = "blanc"
                    PictureBox116.Image = ImageList1.Images.Item(0)
                    PictureBox116.Tag = "blanc"
                    PictureBox125.Image = ImageList1.Images.Item(0)
                    PictureBox125.Tag = "blanc"

                End If

                If blanc101 = 11 Then

                    PictureBox101.Image = ImageList1.Images.Item(0)
                    PictureBox101.Tag = "blanc"
                    PictureBox110.Image = ImageList1.Images.Item(0)
                    PictureBox110.Tag = "blanc"
                    PictureBox119.Image = ImageList1.Images.Item(0)
                    PictureBox119.Tag = "blanc"
                    PictureBox125.Image = ImageList1.Images.Item(0)
                    PictureBox125.Tag = "blanc"

                End If

                If blanc101 = 12 Then

                    PictureBox104.Image = ImageList1.Images.Item(0)
                    PictureBox104.Tag = "blanc"
                    PictureBox107.Image = ImageList1.Images.Item(0)
                    PictureBox107.Tag = "blanc"
                    PictureBox113.Image = ImageList1.Images.Item(0)
                    PictureBox113.Tag = "blanc"
                    PictureBox119.Image = ImageList1.Images.Item(0)
                    PictureBox119.Tag = "blanc"

                End If

                If blanc101 = 13 Then

                    PictureBox104.Image = ImageList1.Images.Item(0)
                    PictureBox104.Tag = "blanc"
                    PictureBox110.Image = ImageList1.Images.Item(0)
                    PictureBox110.Tag = "blanc"
                    PictureBox113.Image = ImageList1.Images.Item(0)
                    PictureBox113.Tag = "blanc"
                    PictureBox119.Image = ImageList1.Images.Item(0)
                    PictureBox119.Tag = "blanc"

                End If

                If blanc101 = 14 Then

                    PictureBox104.Image = ImageList1.Images.Item(0)
                    PictureBox104.Tag = "blanc"
                    PictureBox110.Image = ImageList1.Images.Item(0)
                    PictureBox110.Tag = "blanc"
                    PictureBox116.Image = ImageList1.Images.Item(0)
                    PictureBox116.Tag = "blanc"
                    PictureBox119.Image = ImageList1.Images.Item(0)
                    PictureBox119.Tag = "blanc"

                End If

                If blanc101 = 15 Then

                    PictureBox107.Image = ImageList1.Images.Item(0)
                    PictureBox107.Tag = "blanc"
                    PictureBox110.Image = ImageList1.Images.Item(0)
                    PictureBox110.Tag = "blanc"
                    PictureBox116.Image = ImageList1.Images.Item(0)
                    PictureBox116.Tag = "blanc"
                    PictureBox122.Image = ImageList1.Images.Item(0)
                    PictureBox122.Tag = "blanc"

                End If

                If blanc101 = 16 Then

                    PictureBox107.Image = ImageList1.Images.Item(0)
                    PictureBox107.Tag = "blanc"
                    PictureBox113.Image = ImageList1.Images.Item(0)
                    PictureBox113.Tag = "blanc"
                    PictureBox116.Image = ImageList1.Images.Item(0)
                    PictureBox116.Tag = "blanc"
                    PictureBox122.Image = ImageList1.Images.Item(0)
                    PictureBox122.Tag = "blanc"

                End If

                If blanc101 = 17 Then

                    PictureBox107.Image = ImageList1.Images.Item(0)
                    PictureBox107.Tag = "blanc"
                    PictureBox113.Image = ImageList1.Images.Item(0)
                    PictureBox113.Tag = "blanc"
                    PictureBox119.Image = ImageList1.Images.Item(0)
                    PictureBox119.Tag = "blanc"
                    PictureBox122.Image = ImageList1.Images.Item(0)
                    PictureBox122.Tag = "blanc"

                End If

                If blanc101 = 18 Then

                    PictureBox104.Image = ImageList1.Images.Item(0)
                    PictureBox104.Tag = "blanc"
                    PictureBox113.Image = ImageList1.Images.Item(0)
                    PictureBox113.Tag = "blanc"
                    PictureBox116.Image = ImageList1.Images.Item(0)
                    PictureBox116.Tag = "blanc"
                    PictureBox122.Image = ImageList1.Images.Item(0)
                    PictureBox122.Tag = "blanc"

                End If

                If blanc101 = 19 Then

                    PictureBox104.Image = ImageList1.Images.Item(0)
                    PictureBox104.Tag = "blanc"
                    PictureBox110.Image = ImageList1.Images.Item(0)
                    PictureBox110.Tag = "blanc"
                    PictureBox113.Image = ImageList1.Images.Item(0)
                    PictureBox113.Tag = "blanc"
                    PictureBox122.Image = ImageList1.Images.Item(0)
                    PictureBox122.Tag = "blanc"

                End If

                If blanc101 = 20 Then

                    PictureBox107.Image = ImageList1.Images.Item(0)
                    PictureBox107.Tag = "blanc"
                    PictureBox110.Image = ImageList1.Images.Item(0)
                    PictureBox110.Tag = "blanc"
                    PictureBox116.Image = ImageList1.Images.Item(0)
                    PictureBox116.Tag = "blanc"
                    PictureBox119.Image = ImageList1.Images.Item(0)
                    PictureBox119.Tag = "blanc"

                End If

                If blanc101 = 21 Then

                    PictureBox104.Image = ImageList1.Images.Item(0)
                    PictureBox104.Tag = "blanc"
                    PictureBox110.Image = ImageList1.Images.Item(0)
                    PictureBox110.Tag = "blanc"
                    PictureBox116.Image = ImageList1.Images.Item(0)
                    PictureBox116.Tag = "blanc"
                    PictureBox122.Image = ImageList1.Images.Item(0)
                    PictureBox122.Tag = "blanc"

                End If

            End If

            'Aquí fem la segona fila

            If ctlControl.Location.Y = 541 And ctlControl.Location.X < 380 Then

                If blanc102 = 1 Then

                    PictureBox102.Image = ImageList1.Images.Item(0)
                    PictureBox102.Tag = "blanc"
                    PictureBox108.Image = ImageList1.Images.Item(0)
                    PictureBox108.Tag = "blanc"
                    PictureBox114.Image = ImageList1.Images.Item(0)
                    PictureBox114.Tag = "blanc"
                    PictureBox120.Image = ImageList1.Images.Item(0)
                    PictureBox120.Tag = "blanc"

                End If

                If blanc102 = 2 Then

                    PictureBox102.Image = ImageList1.Images.Item(0)
                    PictureBox102.Tag = "blanc"
                    PictureBox108.Image = ImageList1.Images.Item(0)
                    PictureBox108.Tag = "blanc"
                    PictureBox114.Image = ImageList1.Images.Item(0)
                    PictureBox114.Tag = "blanc"
                    PictureBox123.Image = ImageList1.Images.Item(0)
                    PictureBox123.Tag = "blanc"

                End If

                If blanc102 = 3 Then

                    PictureBox102.Image = ImageList1.Images.Item(0)
                    PictureBox102.Tag = "blanc"
                    PictureBox108.Image = ImageList1.Images.Item(0)
                    PictureBox108.Tag = "blanc"
                    PictureBox117.Image = ImageList1.Images.Item(0)
                    PictureBox117.Tag = "blanc"
                    PictureBox123.Image = ImageList1.Images.Item(0)
                    PictureBox123.Tag = "blanc"

                End If

                If blanc102 = 4 Then

                    PictureBox102.Image = ImageList1.Images.Item(0)
                    PictureBox102.Tag = "blanc"
                    PictureBox111.Image = ImageList1.Images.Item(0)
                    PictureBox111.Tag = "blanc"
                    PictureBox117.Image = ImageList1.Images.Item(0)
                    PictureBox117.Tag = "blanc"
                    PictureBox123.Image = ImageList1.Images.Item(0)
                    PictureBox123.Tag = "blanc"

                End If

                If blanc102 = 5 Then

                    PictureBox108.Image = ImageList1.Images.Item(0)
                    PictureBox108.Tag = "blanc"
                    PictureBox114.Image = ImageList1.Images.Item(0)
                    PictureBox114.Tag = "blanc"
                    PictureBox120.Image = ImageList1.Images.Item(0)
                    PictureBox120.Tag = "blanc"
                    PictureBox126.Image = ImageList1.Images.Item(0)
                    PictureBox126.Tag = "blanc"

                End If

                If blanc102 = 6 Then

                    PictureBox105.Image = ImageList1.Images.Item(0)
                    PictureBox105.Tag = "blanc"
                    PictureBox114.Image = ImageList1.Images.Item(0)
                    PictureBox114.Tag = "blanc"
                    PictureBox120.Image = ImageList1.Images.Item(0)
                    PictureBox120.Tag = "blanc"
                    PictureBox126.Image = ImageList1.Images.Item(0)
                    PictureBox126.Tag = "blanc"

                End If

                If blanc102 = 7 Then

                    PictureBox105.Image = ImageList1.Images.Item(0)
                    PictureBox105.Tag = "blanc"
                    PictureBox111.Image = ImageList1.Images.Item(0)
                    PictureBox111.Tag = "blanc"
                    PictureBox120.Image = ImageList1.Images.Item(0)
                    PictureBox120.Tag = "blanc"
                    PictureBox126.Image = ImageList1.Images.Item(0)
                    PictureBox126.Tag = "blanc"

                End If

                If blanc102 = 8 Then

                    PictureBox105.Image = ImageList1.Images.Item(0)
                    PictureBox105.Tag = "blanc"
                    PictureBox111.Image = ImageList1.Images.Item(0)
                    PictureBox111.Tag = "blanc"
                    PictureBox117.Image = ImageList1.Images.Item(0)
                    PictureBox117.Tag = "blanc"
                    PictureBox126.Image = ImageList1.Images.Item(0)
                    PictureBox126.Tag = "blanc"

                End If

                If blanc102 = 9 Then

                    PictureBox102.Image = ImageList1.Images.Item(0)
                    PictureBox102.Tag = "blanc"
                    PictureBox108.Image = ImageList1.Images.Item(0)
                    PictureBox108.Tag = "blanc"
                    PictureBox117.Image = ImageList1.Images.Item(0)
                    PictureBox117.Tag = "blanc"
                    PictureBox126.Image = ImageList1.Images.Item(0)
                    PictureBox126.Tag = "blanc"

                End If

                If blanc102 = 10 Then

                    PictureBox102.Image = ImageList1.Images.Item(0)
                    PictureBox102.Tag = "blanc"
                    PictureBox111.Image = ImageList1.Images.Item(0)
                    PictureBox111.Tag = "blanc"
                    PictureBox117.Image = ImageList1.Images.Item(0)
                    PictureBox117.Tag = "blanc"
                    PictureBox126.Image = ImageList1.Images.Item(0)
                    PictureBox126.Tag = "blanc"

                End If

                If blanc102 = 11 Then

                    PictureBox102.Image = ImageList1.Images.Item(0)
                    PictureBox102.Tag = "blanc"
                    PictureBox111.Image = ImageList1.Images.Item(0)
                    PictureBox111.Tag = "blanc"
                    PictureBox120.Image = ImageList1.Images.Item(0)
                    PictureBox120.Tag = "blanc"
                    PictureBox126.Image = ImageList1.Images.Item(0)
                    PictureBox126.Tag = "blanc"

                End If

                If blanc102 = 12 Then

                    PictureBox105.Image = ImageList1.Images.Item(0)
                    PictureBox105.Tag = "blanc"
                    PictureBox108.Image = ImageList1.Images.Item(0)
                    PictureBox108.Tag = "blanc"
                    PictureBox114.Image = ImageList1.Images.Item(0)
                    PictureBox114.Tag = "blanc"
                    PictureBox120.Image = ImageList1.Images.Item(0)
                    PictureBox120.Tag = "blanc"

                End If

                If blanc102 = 13 Then

                    PictureBox105.Image = ImageList1.Images.Item(0)
                    PictureBox105.Tag = "blanc"
                    PictureBox111.Image = ImageList1.Images.Item(0)
                    PictureBox111.Tag = "blanc"
                    PictureBox114.Image = ImageList1.Images.Item(0)
                    PictureBox114.Tag = "blanc"
                    PictureBox120.Image = ImageList1.Images.Item(0)
                    PictureBox120.Tag = "blanc"

                End If

                If blanc102 = 14 Then

                    PictureBox105.Image = ImageList1.Images.Item(0)
                    PictureBox105.Tag = "blanc"
                    PictureBox111.Image = ImageList1.Images.Item(0)
                    PictureBox111.Tag = "blanc"
                    PictureBox117.Image = ImageList1.Images.Item(0)
                    PictureBox117.Tag = "blanc"
                    PictureBox120.Image = ImageList1.Images.Item(0)
                    PictureBox120.Tag = "blanc"

                End If

                If blanc102 = 15 Then

                    PictureBox108.Image = ImageList1.Images.Item(0)
                    PictureBox108.Tag = "blanc"
                    PictureBox111.Image = ImageList1.Images.Item(0)
                    PictureBox111.Tag = "blanc"
                    PictureBox117.Image = ImageList1.Images.Item(0)
                    PictureBox117.Tag = "blanc"
                    PictureBox123.Image = ImageList1.Images.Item(0)
                    PictureBox123.Tag = "blanc"

                End If

                If blanc102 = 16 Then

                    PictureBox108.Image = ImageList1.Images.Item(0)
                    PictureBox108.Tag = "blanc"
                    PictureBox114.Image = ImageList1.Images.Item(0)
                    PictureBox114.Tag = "blanc"
                    PictureBox117.Image = ImageList1.Images.Item(0)
                    PictureBox117.Tag = "blanc"
                    PictureBox123.Image = ImageList1.Images.Item(0)
                    PictureBox123.Tag = "blanc"

                End If

                If blanc102 = 17 Then

                    PictureBox108.Image = ImageList1.Images.Item(0)
                    PictureBox108.Tag = "blanc"
                    PictureBox114.Image = ImageList1.Images.Item(0)
                    PictureBox114.Tag = "blanc"
                    PictureBox120.Image = ImageList1.Images.Item(0)
                    PictureBox120.Tag = "blanc"
                    PictureBox123.Image = ImageList1.Images.Item(0)
                    PictureBox123.Tag = "blanc"

                End If

                If blanc102 = 18 Then

                    PictureBox105.Image = ImageList1.Images.Item(0)
                    PictureBox105.Tag = "blanc"
                    PictureBox114.Image = ImageList1.Images.Item(0)
                    PictureBox114.Tag = "blanc"
                    PictureBox117.Image = ImageList1.Images.Item(0)
                    PictureBox117.Tag = "blanc"
                    PictureBox123.Image = ImageList1.Images.Item(0)
                    PictureBox123.Tag = "blanc"

                End If

                If blanc102 = 19 Then

                    PictureBox105.Image = ImageList1.Images.Item(0)
                    PictureBox105.Tag = "blanc"
                    PictureBox111.Image = ImageList1.Images.Item(0)
                    PictureBox111.Tag = "blanc"
                    PictureBox114.Image = ImageList1.Images.Item(0)
                    PictureBox114.Tag = "blanc"
                    PictureBox123.Image = ImageList1.Images.Item(0)
                    PictureBox123.Tag = "blanc"

                End If

                If blanc102 = 20 Then

                    PictureBox108.Image = ImageList1.Images.Item(0)
                    PictureBox108.Tag = "blanc"
                    PictureBox111.Image = ImageList1.Images.Item(0)
                    PictureBox111.Tag = "blanc"
                    PictureBox117.Image = ImageList1.Images.Item(0)
                    PictureBox117.Tag = "blanc"
                    PictureBox120.Image = ImageList1.Images.Item(0)
                    PictureBox120.Tag = "blanc"

                End If

                If blanc102 = 21 Then

                    PictureBox105.Image = ImageList1.Images.Item(0)
                    PictureBox105.Tag = "blanc"
                    PictureBox111.Image = ImageList1.Images.Item(0)
                    PictureBox111.Tag = "blanc"
                    PictureBox117.Image = ImageList1.Images.Item(0)
                    PictureBox117.Tag = "blanc"
                    PictureBox123.Image = ImageList1.Images.Item(0)
                    PictureBox123.Tag = "blanc"

                End If

            End If

            'Aquí mirem els tags de les dos caselles de les linies primera i segona per a, si es compleixen unes condicions
            'determinades, deixa el numero en blanc o no

            'El integer cont103 compta les caselles en blanc de la tercera filera

            'Si les dos tenen numero, la tercera es deixa en blanc

        Next ctlControl

        If PictureBox101.Tag IsNot "blanc" AndAlso PictureBox102.Tag IsNot "blanc" Then

            PictureBox103.Image = ImageList1.Images.Item(0)
            PictureBox103.Tag = "blanc"
            cont103 += 1

        End If

        If PictureBox104.Tag IsNot "blanc" AndAlso PictureBox105.Tag IsNot "blanc" Then

            PictureBox106.Image = ImageList1.Images.Item(0)
            PictureBox106.Tag = "blanc"
            cont103 += 1

        End If

        If PictureBox107.Tag IsNot "blanc" AndAlso PictureBox108.Tag IsNot "blanc" Then

            PictureBox109.Image = ImageList1.Images.Item(0)
            PictureBox109.Tag = "blanc"
            cont103 += 1

        End If

        If PictureBox110.Tag IsNot "blanc" AndAlso PictureBox111.Tag IsNot "blanc" Then

            PictureBox112.Image = ImageList1.Images.Item(0)
            PictureBox112.Tag = "blanc"
            cont103 += 1

        End If

        If PictureBox113.Tag IsNot "blanc" AndAlso PictureBox114.Tag IsNot "blanc" Then

            PictureBox115.Image = ImageList1.Images.Item(0)
            PictureBox115.Tag = "blanc"
            cont103 += 1

        End If

        If PictureBox116.Tag IsNot "blanc" AndAlso PictureBox117.Tag IsNot "blanc" Then

            PictureBox118.Image = ImageList1.Images.Item(0)
            PictureBox118.Tag = "blanc"
            cont103 += 1

        End If

        If PictureBox119.Tag IsNot "blanc" AndAlso PictureBox120.Tag IsNot "blanc" Then

            PictureBox121.Image = ImageList1.Images.Item(0)
            PictureBox121.Tag = "blanc"
            cont103 += 1

        End If

        If PictureBox122.Tag IsNot "blanc" AndAlso PictureBox123.Tag IsNot "blanc" Then

            PictureBox124.Image = ImageList1.Images.Item(0)
            PictureBox124.Tag = "blanc"
            cont103 += 1

        End If

        If PictureBox125.Tag IsNot "blanc" AndAlso PictureBox126.Tag IsNot "blanc" Then

            PictureBox127.Image = ImageList1.Images.Item(0)
            PictureBox127.Tag = "blanc"
            cont103 += 1

        End If

        'Si les dos estan en blanc, es deixa el numero

        If PictureBox101.Tag Is "blanc" AndAlso PictureBox102.Tag Is "blanc" Then

            PictureBox103.Enabled = False

        End If

        If PictureBox104.Tag Is "blanc" AndAlso PictureBox105.Tag Is "blanc" Then

            PictureBox106.Enabled = False

        End If

        If PictureBox107.Tag Is "blanc" AndAlso PictureBox108.Tag Is "blanc" Then

            PictureBox109.Enabled = False

        End If

        If PictureBox110.Tag Is "blanc" AndAlso PictureBox111.Tag Is "blanc" Then

            PictureBox112.Enabled = False

        End If

        If PictureBox113.Tag Is "blanc" AndAlso PictureBox114.Tag Is "blanc" Then

            PictureBox115.Enabled = False

        End If

        If PictureBox116.Tag Is "blanc" AndAlso PictureBox117.Tag Is "blanc" Then

            PictureBox118.Enabled = False

        End If

        If PictureBox119.Tag Is "blanc" AndAlso PictureBox120.Tag Is "blanc" Then

            PictureBox121.Enabled = False

        End If

        If PictureBox122.Tag Is "blanc" AndAlso PictureBox123.Tag Is "blanc" Then

            PictureBox124.Enabled = False

        End If

        If PictureBox125.Tag Is "blanc" AndAlso PictureBox126.Tag Is "blanc" Then

            PictureBox127.Enabled = False

        End If

        'Si arribats a aquest pas els espais en blanc a la tercera filera encara no han arribat a quatre, agafa qualsevol casella
        'i la transforma en blanca. SEMPRE es compleix les condicions i el fa un cartró valid.

        While cont103 < 4

            For Each ctlControl In Me.Controls.OfType(Of PictureBox)

                If ctlControl.Location.Y = 583 And ctlControl.Location.X < 380 And ctlControl.Tag IsNot "blanc" And ctlControl.Enabled = True Then

                    randomizer = rand.Next(0, 2) > 0

                    If randomizer = True And cont103 < 4 Then

                        ctlControl.Image = ImageList1.Images.Item(0)
                        ctlControl.Tag = "blanc"

                        cont103 += 1

                    End If

                End If

            Next ctlControl

        End While

    End Sub

#End Region

#Region "Generar el cartró 2"

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click

        'Comencem per generar el primer cartró limitant el nombre de vegades que es pot fer el random per a no saturar 
        'la memoria del programa

        contaclick2 += 1

        If contaclick2 = 1 Then

            Button2.Text = "Un altre?"

        ElseIf contaclick2 = 2 Then

            Button2.Text = "Últim intent!"

        Else

            Button2.Enabled = False
            Button2.Visible = False

            If contaclick1 = 3 Then

                Label1.Visible = False

            End If

        End If

        click2 = True

        cont203 = 0

        If click1 = True And click2 = True Then

            Button3.Visible = True

            Button3.Enabled = True

        End If

        pass1_201 = False
        pass2_201 = False
        pass1_202 = False
        pass2_202 = False
        pass1_203 = False
        pass2_203 = False
        pass1_204 = False
        pass2_204 = False
        pass1_205 = False
        pass2_205 = False
        pass1_206 = False
        pass2_206 = False
        pass1_207 = False
        pass2_207 = False
        pass1_208 = False
        pass2_208 = False
        pass1_209 = False
        pass2_209 = False

        pickedImg.Clear()

        'Aqui executem la funció pertinent per cada columna del cartró 2 que, juntament amb la que veurem a continuació,
        'assigna numeros a cada columna mai superior al numero que hi hagi damunt seu

        For Each ctlControl In Me.Controls.OfType(Of PictureBox)

            If ctlControl.Location.X = 521 And ctlControl.Location.Y > 300 Then

                chooseImg201()

                ctlControl.Image = ImageList1.Images.Item(intPic)

                ctlControl.Tag = intPic

            End If

            If ctlControl.Location.X = 563 And ctlControl.Location.Y > 300 Then

                chooseImg202()

                ctlControl.Image = ImageList1.Images.Item(intPic)

                ctlControl.Tag = intPic

            End If

            If ctlControl.Location.X = 605 And ctlControl.Location.Y > 300 Then

                chooseImg203()

                ctlControl.Image = ImageList1.Images.Item(intPic)

                ctlControl.Tag = intPic

            End If

            If ctlControl.Location.X = 647 And ctlControl.Location.Y > 300 Then

                chooseImg204()

                ctlControl.Image = ImageList1.Images.Item(intPic)

                ctlControl.Tag = intPic

            End If

            If ctlControl.Location.X = 689 And ctlControl.Location.Y > 300 Then

                chooseImg205()

                ctlControl.Image = ImageList1.Images.Item(intPic)

                ctlControl.Tag = intPic

            End If

            If ctlControl.Location.X = 731 And ctlControl.Location.Y > 300 Then

                chooseImg206()

                ctlControl.Image = ImageList1.Images.Item(intPic)

                ctlControl.Tag = intPic

            End If

            If ctlControl.Location.X = 773 And ctlControl.Location.Y > 300 Then

                chooseImg207()

                ctlControl.Image = ImageList1.Images.Item(intPic)

                ctlControl.Tag = intPic

            End If

            If ctlControl.Location.X = 815 And ctlControl.Location.Y > 300 Then

                chooseImg208()

                ctlControl.Image = ImageList1.Images.Item(intPic)

                ctlControl.Tag = intPic

            End If

            If ctlControl.Location.X = 857 And ctlControl.Location.Y > 300 Then

                chooseImg209()

                ctlControl.Image = ImageList1.Images.Item(intPic)

                ctlControl.Tag = intPic

            End If

        Next ctlControl

        make_blanc2()

    End Sub

    Sub chooseImg201()

        'Mirar linia 332

        If pass1_201 = False Then

            intPic = rand.Next(3, 10)

            pass1_201 = True

            pickedImg.Add(intPic)

            firstnumber201 = intPic

        Else

            If pass2_201 = False Then

                intPic = rand.Next(2, firstnumber201)

                pass2_201 = True

                pickedImg.Add(intPic)

                secondnumber201 = intPic

            Else

                intPic = rand.Next(1, secondnumber201)

                pickedImg.Add(intPic)

            End If

        End If

    End Sub

    Sub chooseImg202()

        'Mirar linia 332

        If pass1_202 = False Then

            intPic = rand.Next(12, 20)

            pass1_202 = True

            pickedImg.Add(intPic)

            firstnumber202 = intPic

        Else

            If pass2_202 = False Then

                intPic = rand.Next(11, firstnumber202)

                pass2_202 = True

                pickedImg.Add(intPic)

                secondnumber202 = intPic

            Else

                intPic = rand.Next(10, secondnumber202)

                pickedImg.Add(intPic)

            End If

        End If

    End Sub

    Sub chooseImg203()

        'Mirar linia 332

        If pass1_203 = False Then

            intPic = rand.Next(22, 30)

            pass1_203 = True

            pickedImg.Add(intPic)

            firstnumber203 = intPic

        Else

            If pass2_203 = False Then

                intPic = rand.Next(21, firstnumber203)

                pass2_203 = True

                pickedImg.Add(intPic)

                secondnumber203 = intPic

            Else

                intPic = rand.Next(20, secondnumber203)

                pickedImg.Add(intPic)

            End If

        End If

    End Sub

    Sub chooseImg204()

        'Mirar linia 332

        If pass1_204 = False Then

            intPic = rand.Next(32, 40)

            pass1_204 = True

            pickedImg.Add(intPic)

            firstnumber204 = intPic

        Else

            If pass2_204 = False Then

                intPic = rand.Next(31, firstnumber204)

                pass2_204 = True

                pickedImg.Add(intPic)

                secondnumber204 = intPic

            Else

                intPic = rand.Next(30, secondnumber204)

                pickedImg.Add(intPic)

            End If

        End If

    End Sub

    Sub chooseImg205()

        'Mirar linia 332

        If pass1_205 = False Then

            intPic = rand.Next(42, 50)

            pass1_205 = True

            pickedImg.Add(intPic)

            firstnumber205 = intPic

        Else

            If pass2_205 = False Then

                intPic = rand.Next(41, firstnumber205)

                pass2_205 = True

                pickedImg.Add(intPic)

                secondnumber205 = intPic

            Else

                intPic = rand.Next(40, secondnumber205)

                pickedImg.Add(intPic)

            End If

        End If

    End Sub

    Sub chooseImg206()

        'Mirar linia 332

        If pass1_206 = False Then

            intPic = rand.Next(52, 60)

            pass1_206 = True

            pickedImg.Add(intPic)

            firstnumber206 = intPic

        Else

            If pass2_206 = False Then

                intPic = rand.Next(51, firstnumber206)

                pass2_206 = True

                pickedImg.Add(intPic)

                secondnumber206 = intPic

            Else

                intPic = rand.Next(50, secondnumber206)

                pickedImg.Add(intPic)

            End If

        End If

    End Sub

    Sub chooseImg207()

        'Mirar linia 332

        If pass1_207 = False Then

            intPic = rand.Next(62, 70)

            pass1_207 = True

            pickedImg.Add(intPic)

            firstnumber207 = intPic

        Else

            If pass2_207 = False Then

                intPic = rand.Next(61, firstnumber207)

                pass2_207 = True

                pickedImg.Add(intPic)

                secondnumber207 = intPic

            Else

                intPic = rand.Next(60, secondnumber207)

                pickedImg.Add(intPic)

            End If

        End If

    End Sub

    Sub chooseImg208()

        'Mirar linia 332

        If pass1_208 = False Then

            intPic = rand.Next(72, 80)

            pass1_208 = True

            pickedImg.Add(intPic)

            firstnumber208 = intPic

        Else

            If pass2_208 = False Then

                intPic = rand.Next(71, firstnumber208)

                pass2_208 = True

                pickedImg.Add(intPic)

                secondnumber208 = intPic

            Else

                intPic = rand.Next(70, secondnumber208)

                pickedImg.Add(intPic)

            End If

        End If

    End Sub

    Sub chooseImg209()

        'Mirar linia 332

        If pass1_209 = False Then

            intPic = rand.Next(82, 91)

            pass1_209 = True

            pickedImg.Add(intPic)

            firstnumber209 = intPic

        Else

            If pass2_209 = False Then

                intPic = rand.Next(81, firstnumber209)

                pass2_209 = True

                pickedImg.Add(intPic)

                secondnumber209 = intPic

            Else

                intPic = rand.Next(80, secondnumber209)

                pickedImg.Add(intPic)

            End If

        End If

    End Sub

    Sub make_blanc2()

        'Mirar linia 685

        blanc201 = rand.Next(1, 22)
        blanc202 = rand.Next(1, 22)

        While blanc201 = blanc202

            blanc202 = rand.Next(1, 22)

        End While

        For Each ctlControl In Me.Controls.OfType(Of PictureBox)

            If ctlControl.Location.Y = 499 And ctlControl.Location.X > 400 Then

                If blanc201 = 1 Then

                    PictureBox201.Image = ImageList1.Images.Item(0)
                    PictureBox201.Tag = "blanc"
                    PictureBox207.Image = ImageList1.Images.Item(0)
                    PictureBox207.Tag = "blanc"
                    PictureBox213.Image = ImageList1.Images.Item(0)
                    PictureBox213.Tag = "blanc"
                    PictureBox219.Image = ImageList1.Images.Item(0)
                    PictureBox219.Tag = "blanc"

                End If

                If blanc201 = 2 Then

                    PictureBox201.Image = ImageList1.Images.Item(0)
                    PictureBox201.Tag = "blanc"
                    PictureBox207.Image = ImageList1.Images.Item(0)
                    PictureBox207.Tag = "blanc"
                    PictureBox213.Image = ImageList1.Images.Item(0)
                    PictureBox213.Tag = "blanc"
                    PictureBox222.Image = ImageList1.Images.Item(0)
                    PictureBox222.Tag = "blanc"

                End If

                If blanc201 = 2 Then

                    PictureBox201.Image = ImageList1.Images.Item(0)
                    PictureBox201.Tag = "blanc"
                    PictureBox207.Image = ImageList1.Images.Item(0)
                    PictureBox207.Tag = "blanc"
                    PictureBox213.Image = ImageList1.Images.Item(0)
                    PictureBox213.Tag = "blanc"
                    PictureBox222.Image = ImageList1.Images.Item(0)
                    PictureBox222.Tag = "blanc"

                End If

                If blanc201 = 3 Then

                    PictureBox201.Image = ImageList1.Images.Item(0)
                    PictureBox201.Tag = "blanc"
                    PictureBox207.Image = ImageList1.Images.Item(0)
                    PictureBox207.Tag = "blanc"
                    PictureBox216.Image = ImageList1.Images.Item(0)
                    PictureBox216.Tag = "blanc"
                    PictureBox222.Image = ImageList1.Images.Item(0)
                    PictureBox222.Tag = "blanc"

                End If

                If blanc201 = 4 Then

                    PictureBox201.Image = ImageList1.Images.Item(0)
                    PictureBox201.Tag = "blanc"
                    PictureBox210.Image = ImageList1.Images.Item(0)
                    PictureBox210.Tag = "blanc"
                    PictureBox216.Image = ImageList1.Images.Item(0)
                    PictureBox216.Tag = "blanc"
                    PictureBox222.Image = ImageList1.Images.Item(0)
                    PictureBox222.Tag = "blanc"

                End If

                If blanc201 = 5 Then

                    PictureBox207.Image = ImageList1.Images.Item(0)
                    PictureBox207.Tag = "blanc"
                    PictureBox213.Image = ImageList1.Images.Item(0)
                    PictureBox213.Tag = "blanc"
                    PictureBox219.Image = ImageList1.Images.Item(0)
                    PictureBox219.Tag = "blanc"
                    PictureBox225.Image = ImageList1.Images.Item(0)
                    PictureBox225.Tag = "blanc"

                End If

                If blanc201 = 6 Then

                    PictureBox204.Image = ImageList1.Images.Item(0)
                    PictureBox204.Tag = "blanc"
                    PictureBox213.Image = ImageList1.Images.Item(0)
                    PictureBox213.Tag = "blanc"
                    PictureBox219.Image = ImageList1.Images.Item(0)
                    PictureBox219.Tag = "blanc"
                    PictureBox225.Image = ImageList1.Images.Item(0)
                    PictureBox225.Tag = "blanc"

                End If

                If blanc201 = 7 Then

                    PictureBox204.Image = ImageList1.Images.Item(0)
                    PictureBox204.Tag = "blanc"
                    PictureBox210.Image = ImageList1.Images.Item(0)
                    PictureBox210.Tag = "blanc"
                    PictureBox219.Image = ImageList1.Images.Item(0)
                    PictureBox219.Tag = "blanc"
                    PictureBox225.Image = ImageList1.Images.Item(0)
                    PictureBox225.Tag = "blanc"

                End If

                If blanc201 = 8 Then

                    PictureBox204.Image = ImageList1.Images.Item(0)
                    PictureBox204.Tag = "blanc"
                    PictureBox210.Image = ImageList1.Images.Item(0)
                    PictureBox210.Tag = "blanc"
                    PictureBox216.Image = ImageList1.Images.Item(0)
                    PictureBox216.Tag = "blanc"
                    PictureBox225.Image = ImageList1.Images.Item(0)
                    PictureBox225.Tag = "blanc"

                End If

                If blanc201 = 9 Then

                    PictureBox201.Image = ImageList1.Images.Item(0)
                    PictureBox201.Tag = "blanc"
                    PictureBox207.Image = ImageList1.Images.Item(0)
                    PictureBox207.Tag = "blanc"
                    PictureBox216.Image = ImageList1.Images.Item(0)
                    PictureBox216.Tag = "blanc"
                    PictureBox225.Image = ImageList1.Images.Item(0)
                    PictureBox225.Tag = "blanc"

                End If

                If blanc201 = 10 Then

                    PictureBox201.Image = ImageList1.Images.Item(0)
                    PictureBox201.Tag = "blanc"
                    PictureBox210.Image = ImageList1.Images.Item(0)
                    PictureBox210.Tag = "blanc"
                    PictureBox216.Image = ImageList1.Images.Item(0)
                    PictureBox216.Tag = "blanc"
                    PictureBox225.Image = ImageList1.Images.Item(0)
                    PictureBox225.Tag = "blanc"

                End If

                If blanc201 = 11 Then

                    PictureBox201.Image = ImageList1.Images.Item(0)
                    PictureBox201.Tag = "blanc"
                    PictureBox210.Image = ImageList1.Images.Item(0)
                    PictureBox210.Tag = "blanc"
                    PictureBox219.Image = ImageList1.Images.Item(0)
                    PictureBox219.Tag = "blanc"
                    PictureBox225.Image = ImageList1.Images.Item(0)
                    PictureBox225.Tag = "blanc"

                End If

                If blanc201 = 12 Then

                    PictureBox204.Image = ImageList1.Images.Item(0)
                    PictureBox204.Tag = "blanc"
                    PictureBox207.Image = ImageList1.Images.Item(0)
                    PictureBox207.Tag = "blanc"
                    PictureBox213.Image = ImageList1.Images.Item(0)
                    PictureBox213.Tag = "blanc"
                    PictureBox219.Image = ImageList1.Images.Item(0)
                    PictureBox219.Tag = "blanc"

                End If

                If blanc201 = 13 Then

                    PictureBox204.Image = ImageList1.Images.Item(0)
                    PictureBox204.Tag = "blanc"
                    PictureBox210.Image = ImageList1.Images.Item(0)
                    PictureBox210.Tag = "blanc"
                    PictureBox213.Image = ImageList1.Images.Item(0)
                    PictureBox213.Tag = "blanc"
                    PictureBox219.Image = ImageList1.Images.Item(0)
                    PictureBox219.Tag = "blanc"

                End If

                If blanc201 = 14 Then

                    PictureBox204.Image = ImageList1.Images.Item(0)
                    PictureBox204.Tag = "blanc"
                    PictureBox210.Image = ImageList1.Images.Item(0)
                    PictureBox210.Tag = "blanc"
                    PictureBox216.Image = ImageList1.Images.Item(0)
                    PictureBox216.Tag = "blanc"
                    PictureBox219.Image = ImageList1.Images.Item(0)
                    PictureBox219.Tag = "blanc"

                End If

                If blanc201 = 15 Then

                    PictureBox207.Image = ImageList1.Images.Item(0)
                    PictureBox207.Tag = "blanc"
                    PictureBox210.Image = ImageList1.Images.Item(0)
                    PictureBox210.Tag = "blanc"
                    PictureBox216.Image = ImageList1.Images.Item(0)
                    PictureBox216.Tag = "blanc"
                    PictureBox222.Image = ImageList1.Images.Item(0)
                    PictureBox222.Tag = "blanc"

                End If

                If blanc201 = 16 Then

                    PictureBox207.Image = ImageList1.Images.Item(0)
                    PictureBox207.Tag = "blanc"
                    PictureBox213.Image = ImageList1.Images.Item(0)
                    PictureBox213.Tag = "blanc"
                    PictureBox216.Image = ImageList1.Images.Item(0)
                    PictureBox216.Tag = "blanc"
                    PictureBox222.Image = ImageList1.Images.Item(0)
                    PictureBox222.Tag = "blanc"

                End If

                If blanc201 = 17 Then

                    PictureBox207.Image = ImageList1.Images.Item(0)
                    PictureBox207.Tag = "blanc"
                    PictureBox213.Image = ImageList1.Images.Item(0)
                    PictureBox213.Tag = "blanc"
                    PictureBox219.Image = ImageList1.Images.Item(0)
                    PictureBox219.Tag = "blanc"
                    PictureBox222.Image = ImageList1.Images.Item(0)
                    PictureBox222.Tag = "blanc"

                End If

                If blanc201 = 18 Then

                    PictureBox204.Image = ImageList1.Images.Item(0)
                    PictureBox204.Tag = "blanc"
                    PictureBox213.Image = ImageList1.Images.Item(0)
                    PictureBox213.Tag = "blanc"
                    PictureBox216.Image = ImageList1.Images.Item(0)
                    PictureBox216.Tag = "blanc"
                    PictureBox222.Image = ImageList1.Images.Item(0)
                    PictureBox222.Tag = "blanc"

                End If

                If blanc201 = 19 Then

                    PictureBox204.Image = ImageList1.Images.Item(0)
                    PictureBox204.Tag = "blanc"
                    PictureBox210.Image = ImageList1.Images.Item(0)
                    PictureBox210.Tag = "blanc"
                    PictureBox213.Image = ImageList1.Images.Item(0)
                    PictureBox213.Tag = "blanc"
                    PictureBox222.Image = ImageList1.Images.Item(0)
                    PictureBox222.Tag = "blanc"

                End If

                If blanc201 = 20 Then

                    PictureBox207.Image = ImageList1.Images.Item(0)
                    PictureBox207.Tag = "blanc"
                    PictureBox210.Image = ImageList1.Images.Item(0)
                    PictureBox210.Tag = "blanc"
                    PictureBox216.Image = ImageList1.Images.Item(0)
                    PictureBox216.Tag = "blanc"
                    PictureBox219.Image = ImageList1.Images.Item(0)
                    PictureBox219.Tag = "blanc"

                End If

                If blanc201 = 21 Then

                    PictureBox204.Image = ImageList1.Images.Item(0)
                    PictureBox204.Tag = "blanc"
                    PictureBox210.Image = ImageList1.Images.Item(0)
                    PictureBox210.Tag = "blanc"
                    PictureBox216.Image = ImageList1.Images.Item(0)
                    PictureBox216.Tag = "blanc"
                    PictureBox222.Image = ImageList1.Images.Item(0)
                    PictureBox222.Tag = "blanc"

                End If

            End If

            If ctlControl.Location.Y = 541 And ctlControl.Location.X > 400 Then

                If blanc202 = 1 Then

                    PictureBox202.Image = ImageList1.Images.Item(0)
                    PictureBox202.Tag = "blanc"
                    PictureBox208.Image = ImageList1.Images.Item(0)
                    PictureBox208.Tag = "blanc"
                    PictureBox214.Image = ImageList1.Images.Item(0)
                    PictureBox214.Tag = "blanc"
                    PictureBox220.Image = ImageList1.Images.Item(0)
                    PictureBox220.Tag = "blanc"

                End If

                If blanc202 = 2 Then

                    PictureBox202.Image = ImageList1.Images.Item(0)
                    PictureBox202.Tag = "blanc"
                    PictureBox208.Image = ImageList1.Images.Item(0)
                    PictureBox208.Tag = "blanc"
                    PictureBox214.Image = ImageList1.Images.Item(0)
                    PictureBox214.Tag = "blanc"
                    PictureBox223.Image = ImageList1.Images.Item(0)
                    PictureBox223.Tag = "blanc"

                End If

                If blanc202 = 3 Then

                    PictureBox202.Image = ImageList1.Images.Item(0)
                    PictureBox202.Tag = "blanc"
                    PictureBox208.Image = ImageList1.Images.Item(0)
                    PictureBox208.Tag = "blanc"
                    PictureBox217.Image = ImageList1.Images.Item(0)
                    PictureBox217.Tag = "blanc"
                    PictureBox223.Image = ImageList1.Images.Item(0)
                    PictureBox223.Tag = "blanc"

                End If

                If blanc202 = 4 Then

                    PictureBox202.Image = ImageList1.Images.Item(0)
                    PictureBox202.Tag = "blanc"
                    PictureBox211.Image = ImageList1.Images.Item(0)
                    PictureBox211.Tag = "blanc"
                    PictureBox217.Image = ImageList1.Images.Item(0)
                    PictureBox217.Tag = "blanc"
                    PictureBox223.Image = ImageList1.Images.Item(0)
                    PictureBox223.Tag = "blanc"

                End If

                If blanc202 = 5 Then

                    PictureBox208.Image = ImageList1.Images.Item(0)
                    PictureBox208.Tag = "blanc"
                    PictureBox214.Image = ImageList1.Images.Item(0)
                    PictureBox214.Tag = "blanc"
                    PictureBox220.Image = ImageList1.Images.Item(0)
                    PictureBox220.Tag = "blanc"
                    PictureBox226.Image = ImageList1.Images.Item(0)
                    PictureBox226.Tag = "blanc"

                End If

                If blanc202 = 6 Then

                    PictureBox205.Image = ImageList1.Images.Item(0)
                    PictureBox205.Tag = "blanc"
                    PictureBox214.Image = ImageList1.Images.Item(0)
                    PictureBox214.Tag = "blanc"
                    PictureBox220.Image = ImageList1.Images.Item(0)
                    PictureBox220.Tag = "blanc"
                    PictureBox226.Image = ImageList1.Images.Item(0)
                    PictureBox226.Tag = "blanc"

                End If

                If blanc202 = 7 Then

                    PictureBox205.Image = ImageList1.Images.Item(0)
                    PictureBox205.Tag = "blanc"
                    PictureBox211.Image = ImageList1.Images.Item(0)
                    PictureBox211.Tag = "blanc"
                    PictureBox220.Image = ImageList1.Images.Item(0)
                    PictureBox220.Tag = "blanc"
                    PictureBox226.Image = ImageList1.Images.Item(0)
                    PictureBox226.Tag = "blanc"

                End If

                If blanc202 = 8 Then

                    PictureBox205.Image = ImageList1.Images.Item(0)
                    PictureBox205.Tag = "blanc"
                    PictureBox211.Image = ImageList1.Images.Item(0)
                    PictureBox211.Tag = "blanc"
                    PictureBox217.Image = ImageList1.Images.Item(0)
                    PictureBox217.Tag = "blanc"
                    PictureBox226.Image = ImageList1.Images.Item(0)
                    PictureBox226.Tag = "blanc"

                End If

                If blanc202 = 9 Then

                    PictureBox202.Image = ImageList1.Images.Item(0)
                    PictureBox202.Tag = "blanc"
                    PictureBox208.Image = ImageList1.Images.Item(0)
                    PictureBox208.Tag = "blanc"
                    PictureBox217.Image = ImageList1.Images.Item(0)
                    PictureBox217.Tag = "blanc"
                    PictureBox226.Image = ImageList1.Images.Item(0)
                    PictureBox226.Tag = "blanc"

                End If

                If blanc202 = 10 Then

                    PictureBox202.Image = ImageList1.Images.Item(0)
                    PictureBox202.Tag = "blanc"
                    PictureBox211.Image = ImageList1.Images.Item(0)
                    PictureBox211.Tag = "blanc"
                    PictureBox217.Image = ImageList1.Images.Item(0)
                    PictureBox217.Tag = "blanc"
                    PictureBox226.Image = ImageList1.Images.Item(0)
                    PictureBox226.Tag = "blanc"

                End If

                If blanc202 = 11 Then

                    PictureBox202.Image = ImageList1.Images.Item(0)
                    PictureBox202.Tag = "blanc"
                    PictureBox211.Image = ImageList1.Images.Item(0)
                    PictureBox211.Tag = "blanc"
                    PictureBox220.Image = ImageList1.Images.Item(0)
                    PictureBox220.Tag = "blanc"
                    PictureBox226.Image = ImageList1.Images.Item(0)
                    PictureBox226.Tag = "blanc"

                End If

                If blanc202 = 12 Then

                    PictureBox205.Image = ImageList1.Images.Item(0)
                    PictureBox205.Tag = "blanc"
                    PictureBox208.Image = ImageList1.Images.Item(0)
                    PictureBox208.Tag = "blanc"
                    PictureBox214.Image = ImageList1.Images.Item(0)
                    PictureBox214.Tag = "blanc"
                    PictureBox220.Image = ImageList1.Images.Item(0)
                    PictureBox220.Tag = "blanc"

                End If

                If blanc202 = 13 Then

                    PictureBox205.Image = ImageList1.Images.Item(0)
                    PictureBox205.Tag = "blanc"
                    PictureBox211.Image = ImageList1.Images.Item(0)
                    PictureBox211.Tag = "blanc"
                    PictureBox214.Image = ImageList1.Images.Item(0)
                    PictureBox214.Tag = "blanc"
                    PictureBox220.Image = ImageList1.Images.Item(0)
                    PictureBox220.Tag = "blanc"

                End If

                If blanc202 = 14 Then

                    PictureBox205.Image = ImageList1.Images.Item(0)
                    PictureBox205.Tag = "blanc"
                    PictureBox211.Image = ImageList1.Images.Item(0)
                    PictureBox211.Tag = "blanc"
                    PictureBox217.Image = ImageList1.Images.Item(0)
                    PictureBox217.Tag = "blanc"
                    PictureBox220.Image = ImageList1.Images.Item(0)
                    PictureBox220.Tag = "blanc"

                End If

                If blanc202 = 15 Then

                    PictureBox208.Image = ImageList1.Images.Item(0)
                    PictureBox208.Tag = "blanc"
                    PictureBox211.Image = ImageList1.Images.Item(0)
                    PictureBox211.Tag = "blanc"
                    PictureBox217.Image = ImageList1.Images.Item(0)
                    PictureBox217.Tag = "blanc"
                    PictureBox223.Image = ImageList1.Images.Item(0)
                    PictureBox223.Tag = "blanc"

                End If

                If blanc202 = 16 Then

                    PictureBox208.Image = ImageList1.Images.Item(0)
                    PictureBox208.Tag = "blanc"
                    PictureBox214.Image = ImageList1.Images.Item(0)
                    PictureBox214.Tag = "blanc"
                    PictureBox217.Image = ImageList1.Images.Item(0)
                    PictureBox217.Tag = "blanc"
                    PictureBox223.Image = ImageList1.Images.Item(0)
                    PictureBox223.Tag = "blanc"

                End If

                If blanc202 = 17 Then

                    PictureBox208.Image = ImageList1.Images.Item(0)
                    PictureBox208.Tag = "blanc"
                    PictureBox214.Image = ImageList1.Images.Item(0)
                    PictureBox214.Tag = "blanc"
                    PictureBox220.Image = ImageList1.Images.Item(0)
                    PictureBox220.Tag = "blanc"
                    PictureBox223.Image = ImageList1.Images.Item(0)
                    PictureBox223.Tag = "blanc"

                End If

                If blanc202 = 18 Then

                    PictureBox205.Image = ImageList1.Images.Item(0)
                    PictureBox205.Tag = "blanc"
                    PictureBox214.Image = ImageList1.Images.Item(0)
                    PictureBox214.Tag = "blanc"
                    PictureBox217.Image = ImageList1.Images.Item(0)
                    PictureBox217.Tag = "blanc"
                    PictureBox223.Image = ImageList1.Images.Item(0)
                    PictureBox223.Tag = "blanc"

                End If

                If blanc202 = 19 Then

                    PictureBox205.Image = ImageList1.Images.Item(0)
                    PictureBox205.Tag = "blanc"
                    PictureBox211.Image = ImageList1.Images.Item(0)
                    PictureBox211.Tag = "blanc"
                    PictureBox214.Image = ImageList1.Images.Item(0)
                    PictureBox214.Tag = "blanc"
                    PictureBox223.Image = ImageList1.Images.Item(0)
                    PictureBox223.Tag = "blanc"

                End If

                If blanc202 = 20 Then

                    PictureBox208.Image = ImageList1.Images.Item(0)
                    PictureBox208.Tag = "blanc"
                    PictureBox211.Image = ImageList1.Images.Item(0)
                    PictureBox211.Tag = "blanc"
                    PictureBox217.Image = ImageList1.Images.Item(0)
                    PictureBox217.Tag = "blanc"
                    PictureBox220.Image = ImageList1.Images.Item(0)
                    PictureBox220.Tag = "blanc"

                End If

                If blanc202 = 21 Then

                    PictureBox205.Image = ImageList1.Images.Item(0)
                    PictureBox205.Tag = "blanc"
                    PictureBox211.Image = ImageList1.Images.Item(0)
                    PictureBox211.Tag = "blanc"
                    PictureBox217.Image = ImageList1.Images.Item(0)
                    PictureBox217.Tag = "blanc"
                    PictureBox223.Image = ImageList1.Images.Item(0)
                    PictureBox223.Tag = "blanc"

                End If

            End If

        Next ctlControl

        If PictureBox201.Tag IsNot "blanc" AndAlso PictureBox202.Tag IsNot "blanc" Then

            PictureBox203.Image = ImageList1.Images.Item(0)
            PictureBox203.Tag = "blanc"
            cont203 += 1

        End If

        If PictureBox204.Tag IsNot "blanc" AndAlso PictureBox205.Tag IsNot "blanc" Then

            PictureBox206.Image = ImageList1.Images.Item(0)
            PictureBox206.Tag = "blanc"
            cont203 += 1

        End If

        If PictureBox207.Tag IsNot "blanc" AndAlso PictureBox208.Tag IsNot "blanc" Then

            PictureBox209.Image = ImageList1.Images.Item(0)
            PictureBox209.Tag = "blanc"
            cont203 += 1

        End If

        If PictureBox210.Tag IsNot "blanc" AndAlso PictureBox211.Tag IsNot "blanc" Then

            PictureBox212.Image = ImageList1.Images.Item(0)
            PictureBox212.Tag = "blanc"
            cont203 += 1

        End If

        If PictureBox213.Tag IsNot "blanc" AndAlso PictureBox214.Tag IsNot "blanc" Then

            PictureBox215.Image = ImageList1.Images.Item(0)
            PictureBox215.Tag = "blanc"
            cont203 += 1

        End If

        If PictureBox216.Tag IsNot "blanc" AndAlso PictureBox217.Tag IsNot "blanc" Then

            PictureBox218.Image = ImageList1.Images.Item(0)
            PictureBox218.Tag = "blanc"
            cont203 += 1

        End If

        If PictureBox219.Tag IsNot "blanc" AndAlso PictureBox220.Tag IsNot "blanc" Then

            PictureBox221.Image = ImageList1.Images.Item(0)
            PictureBox221.Tag = "blanc"
            cont203 += 1

        End If

        If PictureBox222.Tag IsNot "blanc" AndAlso PictureBox223.Tag IsNot "blanc" Then

            PictureBox224.Image = ImageList1.Images.Item(0)
            PictureBox224.Tag = "blanc"
            cont203 += 1

        End If

        If PictureBox225.Tag IsNot "blanc" AndAlso PictureBox226.Tag IsNot "blanc" Then

            PictureBox227.Image = ImageList1.Images.Item(0)
            PictureBox227.Tag = "blanc"
            cont203 += 1

        End If

        If PictureBox201.Tag Is "blanc" AndAlso PictureBox202.Tag Is "blanc" Then

            PictureBox203.Enabled = False

        End If

        If PictureBox204.Tag Is "blanc" AndAlso PictureBox205.Tag Is "blanc" Then

            PictureBox206.Enabled = False

        End If

        If PictureBox207.Tag Is "blanc" AndAlso PictureBox208.Tag Is "blanc" Then

            PictureBox209.Enabled = False

        End If

        If PictureBox210.Tag Is "blanc" AndAlso PictureBox211.Tag Is "blanc" Then

            PictureBox212.Enabled = False

        End If

        If PictureBox213.Tag Is "blanc" AndAlso PictureBox214.Tag Is "blanc" Then

            PictureBox215.Enabled = False

        End If

        If PictureBox216.Tag Is "blanc" AndAlso PictureBox217.Tag Is "blanc" Then

            PictureBox218.Enabled = False

        End If

        If PictureBox219.Tag Is "blanc" AndAlso PictureBox220.Tag Is "blanc" Then

            PictureBox221.Enabled = False

        End If

        If PictureBox222.Tag Is "blanc" AndAlso PictureBox223.Tag Is "blanc" Then

            PictureBox224.Enabled = False

        End If

        If PictureBox225.Tag Is "blanc" AndAlso PictureBox226.Tag Is "blanc" Then

            PictureBox227.Enabled = False

        End If

        While cont203 < 4

            For Each ctlControl In Me.Controls.OfType(Of PictureBox)

                If ctlControl.Location.Y = 583 And ctlControl.Location.X > 400 And ctlControl.Tag IsNot "blanc" And ctlControl.Enabled = True Then

                    randomizer = rand.Next(0, 2) > 0

                    If randomizer = True And cont203 < 4 Then

                        ctlControl.Image = ImageList1.Images.Item(0)
                        ctlControl.Tag = "blanc"

                        cont203 += 1

                    End If

                End If

            Next ctlControl

        End While

    End Sub

#End Region

#End Region

#Region "Funcionament del Bingo"

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click

        'Amaga els botons ( si no ho estaven ja) i posa els valors que conta els valors per fer linia a 0

        Button1.Visible = False
        Button1.Enabled = False

        Button2.Visible = False
        Button2.Enabled = False

        Button3.Visible = False
        Button3.Enabled = False

        Label1.Visible = False
        Label1.Enabled = False

        linia101 = 0
        linia102 = 0
        linia103 = 0

        linia201 = 0
        linia202 = 0
        linia203 = 0

        Timer1.Enabled = True

    End Sub

    Private Sub Timer1_Tick(ByVal Sender As Object, ByVal e As EventArgs) Handles Timer1.Tick

        'Un cop arribat aquí ja tenim els dos cartrons generats i el joc començat. Aquesta funció correra segons la velocitat
        'que tinguem assignada al groupbox.
        'Quan el timer comença, tria un numero random entre el 1 i el 90 (mai repetit) al qual anomenarem "graella"

        cicle = False

        While cicle = False

            graella = rand.Next(1, 91)

            If pickedNum.Contains(graella) Then

                While (pickedNum.Contains(graella))

                    graella = rand.Next(1, 91)

                End While

                pickedNum.Add(graella)

            Else

                pickedNum.Add(graella)

            End If

            'Ara repasa totes les linies dels cartrons per a trobar tags amb el mateix valor. Quan en troba un, 
            'el canvia per la imatge amb una creu i canvia el seu valor a 100, per a que no es pugui triar una altra vegada.

            'Per exemple, aquí repasarem la primera linia del primer cartró

            For Each ctlControl In Me.Controls.OfType(Of PictureBox)

                If ctlControl.Location.Y = 499 And ctlControl.Location.X < 500 Then

                    If ctlControl.Tag IsNot "blanc" Then

                        If ctlControl.Tag = graella Then

                            ctlControl.Image = ImageList3.Images.Item(graella)

                            'Aquest contador que hi ha a continuació guarda la de vegades que un numero ha estat marcat en una
                            'linia

                            contador_x_101 += 1

                            marcar_numero()

                            'Cada vegada que marquem un numero repasem totes les linies de l'altre cartró per asegurar-nos de que
                            'allí no hi hagi el mateix numero. En cas de que hi sigui, el marca.

                            repasar_cartro2_fila1()
                            repasar_cartro2_fila2()
                            repasar_cartro2_fila3()

                            'Si en una linia hi han 5 numeros que han estat marcats, atura el timer, i en un integer, emmagatzema
                            'que una linia esta completa. Tot seguit, executa la funció per a comprovar si l'altre jugador 
                            'també n'ha fet o no (funció linia_show())

                            If contador_x_101 = 5 And linia = False Then

                                linia101 = 1

                            End If

                            linia_show()

                            Exit For

                        End If

                        marcar_numero()

                    End If

                End If

                If ctlControl.Location.Y = 541 And ctlControl.Location.X < 500 Then

                    If ctlControl.Tag IsNot "blanc" Then

                        If ctlControl.Tag = graella Then

                            ctlControl.Image = ImageList3.Images.Item(graella)

                            contador_x_102 += 1

                            marcar_numero()

                            repasar_cartro2_fila1()
                            repasar_cartro2_fila2()
                            repasar_cartro2_fila3()

                            If contador_x_102 = 5 And linia = False Then

                                linia102 = 1

                            End If

                            linia_show()

                            Exit For

                        End If

                    End If

                End If

                If ctlControl.Location.Y = 583 And ctlControl.Location.X < 500 Then

                    If ctlControl.Tag IsNot "blanc" Then

                        If ctlControl.Tag = graella Then

                            ctlControl.Image = ImageList3.Images.Item(graella)

                            contador_x_103 += 1

                            marcar_numero()

                            repasar_cartro2_fila1()
                            repasar_cartro2_fila2()
                            repasar_cartro2_fila3()

                            If contador_x_103 = 5 And linia = False Then

                                linia103 = 1

                            End If

                            linia_show()

                            Exit For

                        End If

                    End If

                End If

                'Aquí comença amb el segon cartró

                If ctlControl.Location.Y = 499 And ctlControl.Location.X > 500 Then

                    If ctlControl.Tag IsNot "blanc" Then

                        If ctlControl.Tag = graella Then

                            ctlControl.Image = ImageList3.Images.Item(graella)

                            contador_x_201 += 1

                            marcar_numero()

                            repasar_cartro1_fila1()
                            repasar_cartro1_fila2()
                            repasar_cartro1_fila3()

                            If contador_x_201 = 5 And linia = False Then

                                linia201 = 1

                            End If

                            linia_show()

                            Exit For

                        End If

                    End If

                End If

                If ctlControl.Location.Y = 541 And ctlControl.Location.X > 500 Then

                    If ctlControl.Tag IsNot "blanc" Then

                        If ctlControl.Tag = graella Then

                            ctlControl.Image = ImageList3.Images.Item(graella)

                            contador_x_202 += 1

                            marcar_numero()

                            repasar_cartro1_fila1()
                            repasar_cartro1_fila2()
                            repasar_cartro1_fila3()

                            If contador_x_202 = 5 And linia = False Then

                                linia202 = 1

                            End If

                            linia_show()

                            Exit For

                        End If

                    End If

                End If

                If ctlControl.Location.Y = 583 And ctlControl.Location.X > 500 Then

                    If ctlControl.Tag IsNot "blanc" Then

                        If ctlControl.Tag = graella Then

                            ctlControl.Image = ImageList3.Images.Item(graella)

                            contador_x_203 += 1

                            marcar_numero()

                            repasar_cartro1_fila1()
                            repasar_cartro1_fila2()
                            repasar_cartro1_fila3()

                            If contador_x_203 = 5 And linia = False Then

                                linia203 = 1

                            End If

                            linia_show()

                            Exit For

                        End If

                    End If

                End If

            Next ctlControl

            'Si algun dels jugadors te tot el cartró ple de creus (15 numeros), aquesta part de la funció tria qui
            'crida bingo, encara que sempre pot ser que siguin els dos a la vegada

            If (contador_x_101 + contador_x_102 + contador_x_103) = 15 Then

                If (contador_x_201 + contador_x_202 + contador_x_203) = 15 Then

                    Timer1.Stop()

                    MessageBox.Show("Els dos jugadors han fet bingo!!" & vbNewLine & vbNewLine & "FI DE LA PARTIDA")

                Else

                    Timer1.Stop()

                    MessageBox.Show("El jugador 1 ha fet bingo!" & vbNewLine & vbNewLine & "FI DE LA PARTIDA")

                End If

                End

            End If

            If (contador_x_201 + contador_x_202 + contador_x_203) = 15 Then

                Timer1.Stop()

                MessageBox.Show("El jugador 2 ha fet bingo!" & vbNewLine & vbNewLine & "FI DE LA PARTIDA")

                End

            End If

        End While

    End Sub

    Sub marcar_numero()

        'Aquesta funció s'encarrega de marcar els numeros de la graella i que el timer pugui sortir del cicle per passar al
        'següent numero

        For Each ctlControl In Me.Controls.OfType(Of PictureBox)

            If ctlControl.Location.Y < 370 Then

                If ctlControl.Tag = graella Then

                    ctlControl.Image = ImageList2.Images.Item(graella)

                    contador += 1

                    cicle = True

                End If

            End If

        Next ctlControl

    End Sub

    Sub linia_show()

        'Si algun dels jugadors te una linia plena de creus (5 creus en linia) i ningun altre jugador ha marcat linia abans, 
        'aquesta funció tria qui crida linia, encara que sempre pot ser que siguin els dos a la vegada

        If linia = False Then

            If (linia101 + linia102 + linia103) > 0 Then

                If (linia201 + linia202 + linia203) > 0 Then

                    Timer1.Stop()

                    MessageBox.Show("Els dos jugadors han fet línia!")

                    Timer1.Start()

                    linia = True

                Else

                    Timer1.Stop()

                    MessageBox.Show("El jugador 1 ha fet línia!")

                    Timer1.Start()

                    linia = True

                End If

            End If

            If (linia201 + linia202 + linia203) > 0 Then

                If (linia101 + linia102 + linia103) > 0 Then

                    Timer1.Stop()

                    MessageBox.Show("Els dos jugadors han fet línia!")

                    Timer1.Start()

                    linia = True

                Else

                    Timer1.Stop()

                    MessageBox.Show("El jugador 2 ha fet línia!")

                    Timer1.Start()

                    linia = True

                End If

            End If

        End If

    End Sub

#Region "Funcions de repasar files"

    Sub repasar_cartro1_fila1()

        'Aquesta funció i les 5 següents repasen que, quan ha sortit un numero i s'hagi marcat en un cartró, revisen el cartró
        'contrari i miren aveure si hi ha el numero, per a marcar-lo allí també.

        For Each ctlControl In Me.Controls.OfType(Of PictureBox)

            If ctlControl.Location.Y = 499 And ctlControl.Location.X < 500 Then

                If ctlControl.Tag IsNot "blanc" Then

                    If ctlControl.Tag = graella Then

                        ctlControl.Image = ImageList3.Images.Item(graella)

                        contador_x_101 += 1

                        ctlControl.Tag = "blanc"

                        If contador_x_101 = 5 And linia = False Then

                            linia101 = 1

                        End If

                        Exit For

                    End If

                End If

            End If

        Next ctlControl

    End Sub

    Sub repasar_cartro1_fila2()

        'Mirar linia 3016

        For Each ctlControl In Me.Controls.OfType(Of PictureBox)

            If ctlControl.Location.Y = 541 And ctlControl.Location.X < 500 Then

                If ctlControl.Tag IsNot "blanc" Then

                    If ctlControl.Tag = graella Then

                        ctlControl.Image = ImageList3.Images.Item(graella)

                        contador_x_102 += 1

                        ctlControl.Tag = "blanc"

                        If contador_x_102 = 5 And linia = False Then

                            linia102 = 1

                        End If

                        Exit For

                    End If

                End If

            End If

        Next ctlControl

    End Sub

    Sub repasar_cartro1_fila3()

        'Mirar linia 3016

        For Each ctlControl In Me.Controls.OfType(Of PictureBox)

            If ctlControl.Location.Y = 583 And ctlControl.Location.X < 500 Then

                If ctlControl.Tag IsNot "blanc" Then

                    If ctlControl.Tag = graella Then

                        ctlControl.Image = ImageList3.Images.Item(graella)

                        contador_x_103 += 1

                        ctlControl.Tag = "blanc"

                        If contador_x_103 = 5 And linia = False Then

                            linia103 = 1

                        End If

                        Exit For

                    End If

                End If

            End If

        Next ctlControl

    End Sub

    Sub repasar_cartro2_fila1()

        'Mirar linia 3016

        For Each ctlControl In Me.Controls.OfType(Of PictureBox)

            If ctlControl.Location.Y = 499 And ctlControl.Location.X > 500 Then

                If ctlControl.Tag IsNot "blanc" Then

                    If ctlControl.Tag = graella Then

                        ctlControl.Image = ImageList3.Images.Item(graella)

                        contador_x_201 += 1

                        ctlControl.Tag = "blanc"

                        If contador_x_201 = 5 And linia = False Then

                            linia201 = 1

                        End If

                        Exit For

                    End If

                End If

            End If

        Next ctlControl

    End Sub

    Sub repasar_cartro2_fila2()

        'Mirar linia 3016

        For Each ctlControl In Me.Controls.OfType(Of PictureBox)

            If ctlControl.Location.Y = 541 And ctlControl.Location.X > 500 Then

                If ctlControl.Tag IsNot "blanc" Then

                    If ctlControl.Tag = graella Then

                        ctlControl.Image = ImageList3.Images.Item(graella)

                        contador_x_202 += 1

                        ctlControl.Tag = "blanc"

                        If contador_x_202 = 5 And linia = False Then

                            linia202 = 1

                        End If

                        Exit For

                    End If

                End If

            End If

        Next ctlControl

    End Sub

    Sub repasar_cartro2_fila3()

        'Mirar linia 3016

        For Each ctlControl In Me.Controls.OfType(Of PictureBox)

            If ctlControl.Location.Y = 583 And ctlControl.Location.X > 500 Then

                If ctlControl.Tag IsNot "blanc" Then

                    If ctlControl.Tag = graella Then

                        ctlControl.Image = ImageList3.Images.Item(graella)

                        contador_x_203 += 1

                        ctlControl.Tag = "blanc"

                        If contador_x_203 = 5 And linia = False Then

                            linia203 = 1

                        End If

                        Exit For

                    End If

                End If

            End If

        Next ctlControl

    End Sub

#End Region

#Region "Velocitats"

    Private Sub RadioButton1_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton1.CheckedChanged

        'Velocitat estandar (1 numero cada segons)

        Timer1.Interval = 1000

    End Sub

    Private Sub RadioButton2_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton2.CheckedChanged

        'Canvia la velocitat per a que faci 2 numeros per segon

        Timer1.Interval = 500

    End Sub

    Private Sub RadioButton3_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton3.CheckedChanged

        'Canvia la velocitat per a que faci 20 numeros per segon

        Timer1.Interval = 50

    End Sub

#End Region

#End Region

#Region "Ester Egg"

    Private Sub PictureBox42_Click(sender As Object, e As EventArgs) Handles PictureBox42.Click

        'Easter Egg

        int_ou += 1

        If int_ou = 2 Then

            If Timer1.Enabled = False Then

                Form2.Show()

            End If

        End If

    End Sub

#End Region

End Class