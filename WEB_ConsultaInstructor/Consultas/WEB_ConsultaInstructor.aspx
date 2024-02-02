<%@ Page Title="" Language="C#" MasterPageFile="~/DemoMaster.master" AutoEventWireup="true" CodeBehind="WEB_ConsultaInstructor.aspx.cs" Inherits="WEB_ConsultaInstructor.Consultas.WEB_ConsultaInstructor" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <style type="text/css">
        .auto-style1 {
            width: 80%;
        }
        .auto-style3 {
            width: 187px;
        }
        .auto-style4 {
            font-family: Verdana;
            font-size: 10pt;
            color: #993366;
            height: 24px;
        }
        .auto-style5 {
            width: 187px;
            height: 24px;
        }
        .auto-style6 {
            height: 24px;        
        }
    </style>
</asp:Content>    
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="containers">
         <div class="col-md-7 col-lg-8 padding-top"; >
            <h4 class="mb-3">Clases Programadas del Instructor</h4>
         </div>
        <div class="row g-3" Width="300px">
            <div class="col-4 col-sm-3">
                <p class="labelContenido">Ingrese código instructor:</p>                
            </div>
            <div class="col-4 col-sm-2">
                <asp:TextBox ID="txtCod" runat="server" Width="85px" class="form-control"></asp:TextBox>
            </div>
            <div class="col-4 col-sm-2">
                <asp:ImageButton ID="btnBuscar" runat="server" ImageUrl="~/Images/lupa.png" Width="18px" Height="18" OnClick="btnBuscar_Click" />
            </div>
            <div class="row g-3">
                <div col="col-12">
                    <label class="form-label">Nombre del instructor</label>
                    <asp:TextBox ID="txtNombre" runat="server" class="form-control" ReadOnly="True"></asp:TextBox>
                </div>
                <div class="col-12">
                    <label class="form-label">Correo</label>
                    <div class="group-text">
                         <span class="input-group-text">@</span>
                         <asp:TextBox ID="txtCorreo" runat="server" ReadOnly="True" class="form-control"></asp:TextBox>
                    </div>                    
                </div>
                <div class="col-sm-6">
                    <label class="form-label">Dirección</label>
                    <asp:TextBox ID="txtDireccion" runat="server" class="form-control" ReadOnly="True"></asp:TextBox>
                </div>                
                <div class="col-sm-6">
                    <label class="form-label">DNI</label>
                    <asp:TextBox ID="txtDNI" runat="server" class="form-control" ReadOnly="True"></asp:TextBox>
                </div>
                <div class="col-sm-6">
                    <label class="form-label">Teléfono</label>
                    <asp:TextBox ID="txtTelef" runat="server" class="form-control" ReadOnly="True"></asp:TextBox>
                </div>  
                <div class="col-sm-6">
                    <label class="form-label">Departamento_Provincia_Distrito</label>
                    <asp:TextBox ID="txtUbigeo" runat="server" class="form-control" ReadOnly="True"></asp:TextBox>
                </div> 
                <div class="col-sm-6">                     
                    <label class="form-label">Fecha</label>
                    <asp:TextBox ID="txtFI" runat="server" class="form-control"></asp:TextBox>
                </div>
                <div>
                     <asp:Label ID="lblMensaje" runat="server" CssClass="labelErrores" Width="300px"></asp:Label>
                </div>
                <div>
                       <asp:HyperLink ID="HyperLink1" runat="server" NavigateUrl="~/Consultas.aspx">retornar</asp:HyperLink>
                </div>
                <div>
                     <asp:Button ID="btnConsultar" runat="server" CssClass="btn btn-success btn-lg" OnClick="btnConsultar_Click" Text="Consultar" />
                </div>
                <div Height="40px">
                    <br />       
                </div>
            </div>
        </div>
    </div>   
    <div class="container" >
           <div class="row">
               <asp:GridView ID="grvClasesProgramadas" runat="server" AutoGenerateColumns="False" class="table table-success table-striped table-bordered" BorderColor="#999999" BorderStyle="Solid" BorderWidth="3px" CellPadding="4" ForeColor="Black" ShowHeaderWhenEmpty="True" Width="1278px" HorizontalAlign="Left" OnSelectedIndexChanged="grvClasesProgramadas_SelectedIndexChanged" BackColor="#CCCCCC" CellSpacing="2">
           <Columns>
               <asp:BoundField DataField="NombreSalon" HeaderText="Clase" />
               <asp:BoundField DataField="Fec_Clase" DataFormatString="{0:d}" HeaderText="Fec. Clase">
                   <ItemStyle HorizontalAlign="Right" />
               </asp:BoundField>
               <asp:BoundField DataField="Hora_Emp" DataFormatString="{0:t}" HeaderText="Hora Empieza">
                   <ItemStyle HorizontalAlign="Right" />
               </asp:BoundField>
               <asp:BoundField DataField="Hora_Term" DataFormatString="{0:t}" HeaderText="Hora Termina">
                   <ItemStyle HorizontalAlign="Right" />
               </asp:BoundField>
               <asp:BoundField DataField="EstadoClase" HeaderText="Estado" />
               </Columns>
           <FooterStyle BackColor="#CCCCCC" />
           <HeaderStyle BackColor="Black" Font-Bold="True" ForeColor="White" />
           <PagerStyle BackColor="#CCCCCC" ForeColor="Black" HorizontalAlign="Left" />
           <RowStyle BackColor="White" />
           <SelectedRowStyle BackColor="#000099" Font-Bold="True" ForeColor="White" />
           <SortedAscendingCellStyle BackColor="#F1F1F1" />
           <SortedAscendingHeaderStyle BackColor="#808080" />
           <SortedDescendingCellStyle BackColor="#CAC9C9" />
           <SortedDescendingHeaderStyle BackColor="#383838" />
       </asp:GridView>
               <br />
            
   </div>
    </div>
 
   
   
   


</asp:Content>
