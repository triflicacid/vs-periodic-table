Imports System.Net
Imports System.Text
Imports System.IO
Imports Newtonsoft.Json.Linq

Public Class Form1
    '' Element button clicks
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles H.Click
        Call lookupElement(1, sender)
    End Sub
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles He.Click
        Call lookupElement(2, sender)
    End Sub
    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Li.Click
        Call lookupElement(3, sender)
    End Sub
    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Be.Click
        Call lookupElement(4, sender)
    End Sub
    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles B.Click
        Call lookupElement(5, sender)
    End Sub
    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles C.Click
        Call lookupElement(6, sender)
    End Sub
    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles N.Click
        Call lookupElement(7, sender)
    End Sub
    Private Sub Button8_Click(sender As Object, e As EventArgs) Handles O.Click
        Call lookupElement(8, sender)
    End Sub
    Private Sub Button9_Click(sender As Object, e As EventArgs) Handles F.Click
        Call lookupElement(9, sender)
    End Sub
    Private Sub Button10_Click(sender As Object, e As EventArgs) Handles Ne.Click
        Call lookupElement(10, sender)
    End Sub
    Private Sub Button11_Click(sender As Object, e As EventArgs) Handles Na.Click
        Call lookupElement(11, sender)
    End Sub
    Private Sub Button12_Click(sender As Object, e As EventArgs) Handles Mg.Click
        Call lookupElement(12, sender)
    End Sub
    Private Sub Button13_Click(sender As Object, e As EventArgs) Handles Al.Click
        Call lookupElement(13, sender)
    End Sub
    Private Sub Button14_Click(sender As Object, e As EventArgs) Handles Si.Click
        Call lookupElement(14, sender)
    End Sub
    Private Sub Button15_Click(sender As Object, e As EventArgs) Handles P.Click
        Call lookupElement(15, sender)
    End Sub
    Private Sub Button16_Click(sender As Object, e As EventArgs) Handles S.Click
        Call lookupElement(16, sender)
    End Sub
    Private Sub Button17_Click(sender As Object, e As EventArgs) Handles Cl.Click
        Call lookupElement(17, sender)
    End Sub
    Private Sub Button18_Click(sender As Object, e As EventArgs) Handles Ar.Click
        Call lookupElement(18, sender)
    End Sub
    Private Sub Button19_Click(sender As Object, e As EventArgs) Handles K.Click
        Call lookupElement(19, sender)
    End Sub
    Private Sub Button20_Click(sender As Object, e As EventArgs) Handles Ca.Click
        Call lookupElement(20, sender)
    End Sub
    Private Sub Button21_Click(sender As Object, e As EventArgs) Handles Sc.Click
        Call lookupElement(21, sender)
    End Sub
    Private Sub Button22_Click(sender As Object, e As EventArgs) Handles Ti.Click
        Call lookupElement(22, sender)
    End Sub
    Private Sub Button23_Click(sender As Object, e As EventArgs) Handles V.Click
        Call lookupElement(23, sender)
    End Sub
    Private Sub Button24_Click(sender As Object, e As EventArgs) Handles Cr.Click
        Call lookupElement(24, sender)
    End Sub
    Private Sub Button25_Click(sender As Object, e As EventArgs) Handles Mn.Click
        Call lookupElement(25, sender)
    End Sub
    Private Sub Button26_Click(sender As Object, e As EventArgs) Handles Fe.Click
        Call lookupElement(26, sender)
    End Sub
    Private Sub Button27_Click(sender As Object, e As EventArgs) Handles Co.Click
        Call lookupElement(27, sender)
    End Sub
    Private Sub Button28_Click(sender As Object, e As EventArgs) Handles Ni.Click
        Call lookupElement(28, sender)
    End Sub
    Private Sub Button29_Click(sender As Object, e As EventArgs) Handles Cu.Click
        Call lookupElement(29, sender)
    End Sub
    Private Sub Button30_Click(sender As Object, e As EventArgs) Handles Zn.Click
        Call lookupElement(30, sender)
    End Sub
    Private Sub Button31_Click(sender As Object, e As EventArgs) Handles Ga.Click
        Call lookupElement(31, sender)
    End Sub
    Private Sub Button32_Click(sender As Object, e As EventArgs) Handles Ge.Click
        Call lookupElement(32, sender)
    End Sub
    Private Sub Button33_Click(sender As Object, e As EventArgs) Handles Arsenic.Click
        Call lookupElement(33, sender)
    End Sub
    Private Sub Button34_Click(sender As Object, e As EventArgs) Handles Se.Click
        Call lookupElement(34, sender)
    End Sub
    Private Sub Button35_Click(sender As Object, e As EventArgs) Handles Br.Click
        Call lookupElement(35, sender)
    End Sub
    Private Sub Button36_Click(sender As Object, e As EventArgs) Handles Kr.Click
        Call lookupElement(36, sender)
    End Sub
    Private Sub Button37_Click(sender As Object, e As EventArgs) Handles Rb.Click
        Call lookupElement(37, sender)
    End Sub
    Private Sub Button38_Click(sender As Object, e As EventArgs) Handles Sr.Click
        Call lookupElement(38, sender)
    End Sub
    Private Sub Button39_Click(sender As Object, e As EventArgs) Handles Y.Click
        Call lookupElement(39, sender)
    End Sub
    Private Sub Button40_Click(sender As Object, e As EventArgs) Handles Zr.Click
        Call lookupElement(40, sender)
    End Sub
    Private Sub Button41_Click(sender As Object, e As EventArgs) Handles Nb.Click
        Call lookupElement(41, sender)
    End Sub
    Private Sub Button42_Click(sender As Object, e As EventArgs) Handles Mo.Click
        Call lookupElement(42, sender)
    End Sub
    Private Sub Button43_Click(sender As Object, e As EventArgs) Handles Tc.Click
        Call lookupElement(43, sender)
    End Sub
    Private Sub Button44_Click(sender As Object, e As EventArgs) Handles Ru.Click
        Call lookupElement(44, sender)
    End Sub
    Private Sub Button45_Click(sender As Object, e As EventArgs) Handles Rh.Click
        Call lookupElement(45, sender)
    End Sub
    Private Sub Button46_Click(sender As Object, e As EventArgs) Handles Pd.Click
        Call lookupElement(46, sender)
    End Sub
    Private Sub Button47_Click(sender As Object, e As EventArgs) Handles Ag.Click
        Call lookupElement(47, sender)
    End Sub
    Private Sub Button48_Click(sender As Object, e As EventArgs) Handles Cd.Click
        Call lookupElement(48, sender)
    End Sub
    Private Sub Button49_Click(sender As Object, e As EventArgs) Handles Indium.Click
        Call lookupElement(49, sender)
    End Sub
    Private Sub Button50_Click(sender As Object, e As EventArgs) Handles Sn.Click
        Call lookupElement(50, sender)
    End Sub
    Private Sub Button51_Click(sender As Object, e As EventArgs) Handles Sb.Click
        Call lookupElement(51, sender)
    End Sub
    Private Sub Button52_Click(sender As Object, e As EventArgs) Handles Te.Click
        Call lookupElement(52, sender)
    End Sub
    Private Sub Button53_Click(sender As Object, e As EventArgs) Handles I.Click
        Call lookupElement(53, sender)
    End Sub
    Private Sub Button54_Click(sender As Object, e As EventArgs) Handles Xe.Click
        Call lookupElement(54, sender)
    End Sub
    Private Sub Button55_Click(sender As Object, e As EventArgs) Handles Cs.Click
        Call lookupElement(55, sender)
    End Sub
    Private Sub Button56_Click(sender As Object, e As EventArgs) Handles Ba.Click
        Call lookupElement(56, sender)
    End Sub
    Private Sub Button57_Click(sender As Object, e As EventArgs) Handles La.Click
        Call lookupElement(57, sender)
    End Sub
    Private Sub Button58_Click(sender As Object, e As EventArgs) Handles Ce.Click
        Call lookupElement(58, sender)
    End Sub
    Private Sub Button59_Click(sender As Object, e As EventArgs) Handles Pr.Click
        Call lookupElement(59, sender)
    End Sub
    Private Sub Button60_Click(sender As Object, e As EventArgs) Handles Nd.Click
        Call lookupElement(60, sender)
    End Sub
    Private Sub Button61_Click(sender As Object, e As EventArgs) Handles Pm.Click
        Call lookupElement(61, sender)
    End Sub
    Private Sub Button62_Click(sender As Object, e As EventArgs) Handles Sm.Click
        Call lookupElement(62, sender)
    End Sub
    Private Sub Button63_Click(sender As Object, e As EventArgs) Handles Eu.Click
        Call lookupElement(63, sender)
    End Sub
    Private Sub Button64_Click(sender As Object, e As EventArgs) Handles Gd.Click
        Call lookupElement(64, sender)
    End Sub
    Private Sub Button65_Click(sender As Object, e As EventArgs) Handles Tb.Click
        Call lookupElement(65, sender)
    End Sub
    Private Sub Button66_Click(sender As Object, e As EventArgs) Handles Dy.Click
        Call lookupElement(66, sender)
    End Sub
    Private Sub Button67_Click(sender As Object, e As EventArgs) Handles Ho.Click
        Call lookupElement(67, sender)
    End Sub
    Private Sub Button68_Click(sender As Object, e As EventArgs) Handles Er.Click
        Call lookupElement(68, sender)
    End Sub
    Private Sub Button69_Click(sender As Object, e As EventArgs) Handles Tm.Click
        Call lookupElement(69, sender)
    End Sub
    Private Sub Button70_Click(sender As Object, e As EventArgs) Handles Yb.Click
        Call lookupElement(70, sender)
    End Sub
    Private Sub Button71_Click(sender As Object, e As EventArgs) Handles Lu.Click
        Call lookupElement(71, sender)
    End Sub
    Private Sub Button72_Click(sender As Object, e As EventArgs) Handles Hf.Click
        Call lookupElement(72, sender)
    End Sub
    Private Sub Button73_Click(sender As Object, e As EventArgs) Handles Ta.Click
        Call lookupElement(73, sender)
    End Sub
    Private Sub Button74_Click(sender As Object, e As EventArgs) Handles W.Click
        Call lookupElement(74, sender)
    End Sub
    Private Sub Button75_Click(sender As Object, e As EventArgs) Handles Re.Click
        Call lookupElement(75, sender)
    End Sub
    Private Sub Button76_Click(sender As Object, e As EventArgs) Handles Os.Click
        Call lookupElement(76, sender)
    End Sub
    Private Sub Button77_Click(sender As Object, e As EventArgs) Handles Ir.Click
        Call lookupElement(77, sender)
    End Sub
    Private Sub Button78_Click(sender As Object, e As EventArgs) Handles Pt.Click
        Call lookupElement(78, sender)
    End Sub
    Private Sub Button79_Click(sender As Object, e As EventArgs) Handles Au.Click
        Call lookupElement(79, sender)
    End Sub
    Private Sub Button80_Click(sender As Object, e As EventArgs) Handles Hg.Click
        Call lookupElement(80, sender)
    End Sub
    Private Sub Button81_Click(sender As Object, e As EventArgs) Handles Tl.Click
        Call lookupElement(81, sender)
    End Sub
    Private Sub Button82_Click(sender As Object, e As EventArgs) Handles Pb.Click
        Call lookupElement(82, sender)
    End Sub
    Private Sub Button83_Click(sender As Object, e As EventArgs) Handles Bi.Click
        Call lookupElement(83, sender)
    End Sub
    Private Sub Button84_Click(sender As Object, e As EventArgs) Handles Po.Click
        Call lookupElement(84, sender)
    End Sub
    Private Sub Button85_Click(sender As Object, e As EventArgs) Handles At.Click
        Call lookupElement(85, sender)
    End Sub
    Private Sub Button86_Click(sender As Object, e As EventArgs) Handles Rn.Click
        Call lookupElement(86, sender)
    End Sub
    Private Sub Button87_Click(sender As Object, e As EventArgs) Handles Fr.Click
        Call lookupElement(87, sender)
    End Sub
    Private Sub Button88_Click(sender As Object, e As EventArgs) Handles Ra.Click
        Call lookupElement(88, sender)
    End Sub
    Private Sub Button89_Click(sender As Object, e As EventArgs) Handles Ac.Click
        Call lookupElement(89, sender)
    End Sub
    Private Sub Button90_Click(sender As Object, e As EventArgs) Handles Th.Click
        Call lookupElement(90, sender)
    End Sub
    Private Sub Button91_Click(sender As Object, e As EventArgs) Handles Pa.Click
        Call lookupElement(91, sender)
    End Sub
    Private Sub Button92_Click(sender As Object, e As EventArgs) Handles U.Click
        Call lookupElement(92, sender)
    End Sub
    Private Sub Button93_Click(sender As Object, e As EventArgs) Handles Np.Click
        Call lookupElement(93, sender)
    End Sub
    Private Sub Button94_Click(sender As Object, e As EventArgs) Handles Pu.Click
        Call lookupElement(94, sender)
    End Sub
    Private Sub Button95_Click(sender As Object, e As EventArgs) Handles Am.Click
        Call lookupElement(95, sender)
    End Sub
    Private Sub Button96_Click(sender As Object, e As EventArgs) Handles Cm.Click
        Call lookupElement(96, sender)
    End Sub
    Private Sub Button97_Click(sender As Object, e As EventArgs) Handles Bk.Click
        Call lookupElement(97, sender)
    End Sub
    Private Sub Button98_Click(sender As Object, e As EventArgs) Handles Cf.Click
        Call lookupElement(98, sender)
    End Sub
    Private Sub Button99_Click(sender As Object, e As EventArgs) Handles Es.Click
        Call lookupElement(99, sender)
    End Sub
    Private Sub Button100_Click(sender As Object, e As EventArgs) Handles Fm.Click
        Call lookupElement(100, sender)
    End Sub
    Private Sub Button101_Click(sender As Object, e As EventArgs) Handles Md.Click
        Call lookupElement(101, sender)
    End Sub
    Private Sub Button102_Click(sender As Object, e As EventArgs) Handles No.Click
        Call lookupElement(102, sender)
    End Sub
    Private Sub Button103_Click(sender As Object, e As EventArgs) Handles Lr.Click
        Call lookupElement(103, sender)
    End Sub
    Private Sub Button104_Click(sender As Object, e As EventArgs) Handles Rf.Click
        Call lookupElement(104, sender)
    End Sub
    Private Sub Button105_Click(sender As Object, e As EventArgs) Handles Db.Click
        Call lookupElement(105, sender)
    End Sub
    Private Sub Button106_Click(sender As Object, e As EventArgs) Handles Sg.Click
        Call lookupElement(106, sender)
    End Sub
    Private Sub Button107_Click(sender As Object, e As EventArgs) Handles Bh.Click
        Call lookupElement(107, sender)
    End Sub
    Private Sub Button108_Click(sender As Object, e As EventArgs) Handles Hs.Click
        Call lookupElement(108, sender)
    End Sub
    Private Sub Button109_Click(sender As Object, e As EventArgs) Handles Mt.Click
        Call lookupElement(109, sender)
    End Sub
    Private Sub Button110_Click(sender As Object, e As EventArgs) Handles Ds.Click
        Call lookupElement(110, sender)
    End Sub
    Private Sub Button111_Click(sender As Object, e As EventArgs) Handles Rg.Click
        Call lookupElement(111, sender)
    End Sub
    Private Sub Button112_Click(sender As Object, e As EventArgs) Handles Cn.Click
        Call lookupElement(112, sender)
    End Sub
    Private Sub Button113_Click(sender As Object, e As EventArgs) Handles Nh.Click
        Call lookupElement(113, sender)
    End Sub
    Private Sub Button114_Click(sender As Object, e As EventArgs) Handles Fl.Click
        Call lookupElement(114, sender)
    End Sub
    Private Sub Button115_Click(sender As Object, e As EventArgs) Handles Mc.Click
        Call lookupElement(115, sender)
    End Sub
    Private Sub Button116_Click(sender As Object, e As EventArgs) Handles Lv.Click
        Call lookupElement(116, sender)
    End Sub
    Private Sub Button117_Click(sender As Object, e As EventArgs) Handles Ts.Click
        Call lookupElement(117, sender)
    End Sub
    Private Sub Button118_Click(sender As Object, e As EventArgs) Handles Og.Click
        Call lookupElement(118, sender)
    End Sub

    '' Element info lookup
    Sub lookupElement(atomicNumber As Integer, sender As Object)
        Dim json = getElementJSON(atomicNumber)
        If json("error") = "True" Then
            Exit Sub
        End If
        FormInfo.Show()
        FormInfo.eTitle.Text = "Information - " & json("data")("name").ToString()
        FormInfo.Text = "Information - " & json("data")("name").ToString()
        FormInfo.tmpElName.Text = json("data")("name").ToString()

        For Each item As JProperty In json.Item("data")
            If item.Name.ToString() = "isotopes" Then
                For Each obj As JArray In item
                    For Each isotope In obj
                        FormIsotopes.isotopeTable.Rows.Add(isotope("isotope"), isotope("protons"), isotope("neutrons"), isotope("mass"), isotope("halflife"), isotope("decay"), isotope("daughters"), isotope("nuclear_spin"))
                    Next
                Next
            End If
        Next

        '' Fill in info
        FormInfo.eOverview.Text = "The element " & json("data")("name").ToString() & " has the symbol " & json("data")("symbol").ToString() & " and is a " & json("data")("category").ToString()
        FormInfo.eAtomicStructure1.Text = "It has an atomic weight of " & json("data")("atomic_mass").ToString() & ", and an atomic number of " & json("data")("atomic_number").ToString()
        FormInfo.eAtomicStructure2.Text = json("data")("name").ToString() & " has " & json("data")("protons").ToString() & " protons, " & json("data")("electrons").ToString() & " electrons, and " & json("data")("neutrons").ToString() & " neutrons"
        FormInfo.eAtomicStructure3.Text = json("data")("name").ToString() & " is in the " & json("data")("block").ToString() & "-block and has electron configuration of " & json("data")("electron_configuration").ToString()
        FormInfo.ePhysicalProperties1.Text = json("data")("name").ToString() & " is a " & json("data")("colour").ToString() & " " & json("data")("state").ToString() & " at room temperature"
        FormInfo.ePhysicalProperties2.Text = "It has a melting point of " & json("data")("melting_point").ToString() & "⁰C, and a boiling point of " & json("data")("boiling_point").ToString() & "⁰C"
        FormInfo.ePhysicalProperties3.Text = "It has a density of " & json("data")("density").ToString() & "g/cm³"
        FormInfo.ePhysicalProperties4.Text = json("data")("name").ToString() & " has a " & json("data")("crystal").ToString() & " crystaline structure"
        FormInfo.eOxidationStates1.Text = json("data")("name").ToString() & " can form the following oxidation states:"
        FormInfo.eOxidationStates2.Text = json("data")("oxidation_states")
        FormInfo.eIsotopes.Text = json("data")("name").ToString() & " has " & json("data")("num_isotopes").ToString() & " isotopes"

        If json("data")("radioactive").ToString() = "1" Then
            FormInfo.eIsRadioactive.Visible = True
        End If

        FormInfo.TopMost = True
    End Sub

    Function getElementJSON(atomicNumber As Integer)
        Try
            Dim url As String = "http://192.168.0.129/account/edu/sci/periodic-table/json.php?q=" & atomicNumber

            '' Set up client connection
            Dim client As New System.Net.WebClient

            '' Get web page result from URL
            Dim result As String = client.DownloadString(url)
            Dim json As JObject = JObject.Parse(result)
            Return json
        Catch ex As Exception
            MsgBox("Cannot retrieve data for Atomic Number " & atomicNumber & ":" & vbCrLf & ex.Message, vbCritical)
            Dim json As JObject = New JObject()
            json("error") = "True"
            Return json
        End Try
    End Function
End Class
