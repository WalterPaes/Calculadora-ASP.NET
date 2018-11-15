<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="Calculadora.Calculadora" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title>Calculadora</title>
    
    <!-- Materialize CSS -->
    <link rel="stylesheet" href="https://cdnjs.cloudflare.com/ajax/libs/materialize/1.0.0/css/materialize.min.css"/>


    <style>
        .card div {
            margin-top: -5px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div class="row">
            <div class="card blue-grey lighten-5 col s12 offset-s1 m12 offset-m1 l4 offset-l4">
                <div class="card-content black-text">
                    <span class="card-title">Calculadora .NET</span>
                    
                    <div class="row">
                        <div class="input-field col s12">
                            <asp:TextBox runat="server" ID="txtDisplay" Text="" ReadOnly="true"/>
                        </div>
                    </div>

                    <div class="row">
                        <div class="input-field col s3">
                            <asp:Button Text="CE" runat="server" ID="btnCe" class="btn waves-effect waves-light btn-large" OnClick="btnCe_Click"/>    
                        </div>

                        <div class="input-field col s3">
                            <asp:Button Text="C" runat="server" ID="btnC" class="btn waves-effect waves-light btn-large" OnClick="btnC_Click"/>
                        </div>

                        <div class="input-field col s3">
                            <asp:Button Text="<" runat="server" ID="btnApagar" class="btn waves-effect waves-light btn-large" OnClick="btnApagar_Click"/>    
                        </div>

                        <div class="input-field col s3">
                            <asp:Button Text="/" runat="server" ID="btnDividir" class="btn waves-effect waves-light btn-large blue" OnClick="btnDividir_Click"/>
                        </div>
                    </div>

                    <div class="row">
                        <div class="input-field col s3">
                            <asp:Button Text="7" runat="server" ID="btnSeven" class="btn-floating btn-large waves-effect waves-light black" OnClick="btnSeven_Click"/>
                        </div>

                        <div class="input-field col s3">
                            <asp:Button Text="8" runat="server" ID="btnEight" class="btn-floating btn-large waves-effect waves-light black" OnClick="btnEight_Click"/>
                        </div>

                        <div class="input-field col s3">
                            <asp:Button Text="9" runat="server" ID="btnNine" class="btn-floating btn-large waves-effect waves-light black" OnClick="btnNine_Click"/>
                        </div>

                        <div class="input-field col s3">
                            <asp:Button Text="x" runat="server" ID="btnMultiplicar" class="btn waves-effect waves-light btn-large blue" OnClick="btnMultiplicar_Click"/>    
                        </div>
                    </div>

                    <div class="row">
                        <div class="input-field col s3">
                            <asp:Button Text="4" runat="server" ID="btnFour" class="btn-floating btn-large waves-effect waves-light black" OnClick="btnFour_Click"/>
                        </div>

                        <div class="input-field col s3">
                            <asp:Button Text="5" runat="server" ID="btnFive" class="btn-floating btn-large waves-effect waves-light black" OnClick="btnFive_Click"/>
                        </div>

                        <div class="input-field col s3">
                            <asp:Button Text="6" runat="server" ID="btnSix" class="btn-floating btn-large waves-effect waves-light black" OnClick="btnSix_Click"/>
                        </div>

                        <div class="input-field col s3">
                            <asp:Button Text="-" runat="server" ID="btnSubtracao" class="btn waves-effect waves-light btn-large blue" OnClick="btnSubtracao_Click"/>    
                        </div>
                    </div>

                    <div class="row">
                        <div class="input-field col s3">
                            <asp:Button Text="1" runat="server" ID="btnOne" class="btn-floating btn-large waves-effect waves-light black" OnClick="btnOne_Click"/>
                        </div>

                        <div class="input-field col s3">
                            <asp:Button Text="2" runat="server" ID="btnTwo" class="btn-floating btn-large waves-effect waves-light black" OnClick="btnTwo_Click"/>
                        </div>

                        <div class="input-field col s3">
                            <asp:Button Text="3" runat="server" ID="btnThree" class="btn-floating btn-large waves-effect waves-light black" OnClick="btnThree_Click"/>
                        </div>

                        <div class="input-field col s3">
                            <asp:Button Text="+" runat="server" ID="btnSoma" class="btn waves-effect waves-light btn-large blue" OnClick="btnSoma_Click"/>    
                        </div>
                    </div>

                    <div class="row">
                        <div class="input-field col s3">
                            <asp:Button Text="," runat="server" ID="btnDot" class="btn-floating btn-large waves-effect waves-light black" OnClick="btnDot_Click"/>
                        </div>

                        <div class="input-field col s3">
                            <asp:Button Text="0" runat="server" ID="btnZero" class="btn-floating btn-large waves-effect waves-light black" OnClick="btnZero_Click"/>
                        </div>
                        
                        <div class="input-field col s3 offset-s3">
                            <asp:Button Text="=" ID="BtnCalcular" runat="server" class="btn waves-effect waves-light btn-large red" OnClick="BtnCalcular_Click"/>
                        </div>
                    </div>
                </div>
            </div>
        </div>
    </form>
</body>
</html>